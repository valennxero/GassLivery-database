using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_lib
{
    public class RatingTenant
    {
        public static void RateTenant(User pUser, Tenant pTenant, int pNilai)
        {
            string perintah = "insert into ratingTenant (konsumenId, tenantId, nilai)" +
                $" values ({pUser.Id}, {pTenant.Id}, {pNilai});";
            Koneksi.JalankanQuery(perintah);
        }

        public static void UpdateTotalRatingTenan(Tenant pTenant)
        {
            string perintah = "update tenant t" +
                " set t.rating = (select avg(r.nilai)" +
                " from ratingTenant r where r.tenantId = t.idTenant)WHERE t.idTenant =" + pTenant.Id;
            Koneksi.JalankanQuery(perintah);
        }
    }
}

-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: gasslivery
-- ------------------------------------------------------
-- Server version	5.5.5-10.4.32-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `admin`
--

DROP TABLE IF EXISTS `admin`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `admin` (
  `id` int(11) NOT NULL,
  `username` varchar(45) DEFAULT NULL,
  `password` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `username_UNIQUE` (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `admin`
--

LOCK TABLES `admin` WRITE;
/*!40000 ALTER TABLE `admin` DISABLE KEYS */;
INSERT INTO `admin` VALUES (1,'admin','123');
/*!40000 ALTER TABLE `admin` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cancelorder`
--

DROP TABLE IF EXISTS `cancelorder`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cancelorder` (
  `konsumenId` int(11) NOT NULL,
  `orderRideId` int(11) NOT NULL,
  `Alasan` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`konsumenId`,`orderRideId`),
  KEY `fk_Konsumen_has_OrderRide_OrderRide2_idx` (`orderRideId`),
  KEY `fk_Konsumen_has_OrderRide_Konsumen2_idx` (`konsumenId`),
  CONSTRAINT `fk_Konsumen_has_OrderRide_Konsumen2` FOREIGN KEY (`konsumenId`) REFERENCES `konsumen` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Konsumen_has_OrderRide_OrderRide2` FOREIGN KEY (`orderRideId`) REFERENCES `orderride` (`idOrderRide`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cancelorder`
--

LOCK TABLES `cancelorder` WRITE;
/*!40000 ALTER TABLE `cancelorder` DISABLE KEYS */;
INSERT INTO `cancelorder` VALUES (1,55,'Pengemudi Terlalu Lama'),(1,62,'Berubah Pikiran'),(1,63,'Mau Mengubah Tujuan'),(1,64,'Driver ketiduran'),(1,73,'Pengemudi Terlalu Lama'),(1,81,'Pengemudi Galak'),(2,57,'Mau Mengubah Tujuan'),(2,58,'Mau Mengubah Tujuan'),(2,59,'Pengemudi Galak'),(2,60,'Mau Mengubah Tujuan'),(2,61,'Mau Mengubah Tujuan');
/*!40000 ALTER TABLE `cancelorder` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `driver`
--

DROP TABLE IF EXISTS `driver`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `driver` (
  `idDriver` int(11) NOT NULL AUTO_INCREMENT,
  `nama` varchar(45) DEFAULT NULL,
  `gender` enum('Male','Female') DEFAULT NULL,
  `ratingTotal` double DEFAULT NULL,
  `motorId` int(11) NOT NULL,
  `statusAktif` tinyint(4) DEFAULT NULL,
  `totalPendapatan` int(11) DEFAULT NULL,
  `username` varchar(45) DEFAULT NULL,
  `password` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idDriver`),
  UNIQUE KEY `username_UNIQUE` (`username`),
  KEY `fk_Driver_Motor_idx` (`motorId`),
  CONSTRAINT `fk_Driver_Motor` FOREIGN KEY (`motorId`) REFERENCES `motor` (`idMotor`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `driver`
--

LOCK TABLES `driver` WRITE;
/*!40000 ALTER TABLE `driver` DISABLE KEYS */;
INSERT INTO `driver` VALUES (1,'supri','Male',4.5,1,1,5600,'supri','123'),(2,'melati','Female',4.333333333,2,1,17560,'melati','321'),(3,'mita','Female',4.421052631,3,1,1314550,'mita','123');
/*!40000 ALTER TABLE `driver` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `gass-mon`
--

DROP TABLE IF EXISTS `gass-mon`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `gass-mon` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `saldo` int(11) DEFAULT NULL,
  `poin` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gass-mon`
--

LOCK TABLES `gass-mon` WRITE;
/*!40000 ALTER TABLE `gass-mon` DISABLE KEYS */;
INSERT INTO `gass-mon` VALUES (1,98774710,2730),(2,0,0),(11,0,0),(12,0,0),(13,0,0),(14,0,0),(15,0,0),(16,0,0),(17,0,0),(18,0,0),(19,0,0),(20,0,0),(21,0,0),(22,0,0),(23,0,0),(24,0,0),(25,0,0),(26,0,0),(27,0,0),(28,0,0),(29,0,0);
/*!40000 ALTER TABLE `gass-mon` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `jarak`
--

DROP TABLE IF EXISTS `jarak`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `jarak` (
  `idJarak` int(11) NOT NULL,
  `jarakKm` double DEFAULT NULL,
  `lokasiIdLokasiAwal` int(11) NOT NULL,
  `lokasiIdLokasiAkhir` int(11) NOT NULL,
  PRIMARY KEY (`idJarak`),
  KEY `fk_Jarak_Lokasi3_idx` (`lokasiIdLokasiAwal`),
  KEY `fk_Jarak_Lokasi4_idx` (`lokasiIdLokasiAkhir`),
  CONSTRAINT `fk_Jarak_Lokasi3` FOREIGN KEY (`lokasiIdLokasiAwal`) REFERENCES `lokasi` (`idLokasi`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Jarak_Lokasi4` FOREIGN KEY (`lokasiIdLokasiAkhir`) REFERENCES `lokasi` (`idLokasi`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `jarak`
--

LOCK TABLES `jarak` WRITE;
/*!40000 ALTER TABLE `jarak` DISABLE KEYS */;
INSERT INTO `jarak` VALUES (1,5,1,2),(2,4,2,1);
/*!40000 ALTER TABLE `jarak` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `konsumen`
--

DROP TABLE IF EXISTS `konsumen`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `konsumen` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `gender` enum('Male','Female') DEFAULT NULL,
  `nomorHP` int(11) DEFAULT NULL,
  `nama` varchar(45) DEFAULT NULL,
  `username` varchar(45) DEFAULT NULL,
  `password` varchar(45) DEFAULT NULL,
  `idGassmon` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `username_UNIQUE` (`username`),
  KEY `fk_Konsumen_Gass-Mon1_idx` (`idGassmon`),
  CONSTRAINT `fk_Konsumen_Gass-Mon1` FOREIGN KEY (`idGassmon`) REFERENCES `gass-mon` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `konsumen`
--

LOCK TABLES `konsumen` WRITE;
/*!40000 ALTER TABLE `konsumen` DISABLE KEYS */;
INSERT INTO `konsumen` VALUES (1,'Female',812,'Sinta','sinta','123',1),(2,'Male',1233,'Anto','anto','111',2),(14,'Female',NULL,'val','val','321',11),(15,'Female',1290,'siti','siti','321',12),(17,'Male',9333,'udin','udin','123',14),(18,'Male',789,'sumanto','sumanto','123',15),(19,'Male',234,'deni','deni','123',16),(20,'Male',NULL,'jev','all','222',18),(22,'Male',NULL,'jev','brave','222',21),(24,'Male',NULL,'jev','lor','222',22),(25,'Male',NULL,'jev','dino','222',25),(26,'Male',987,'rizal','rizal','123',26),(27,'Male',98,'vidi','vidi','123',27),(28,'Male',123456,'matthew','matthew','123',28);
/*!40000 ALTER TABLE `konsumen` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lokasi`
--

DROP TABLE IF EXISTS `lokasi`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `lokasi` (
  `idLokasi` int(11) NOT NULL,
  `nama` varchar(45) DEFAULT NULL,
  `longtitude` double DEFAULT NULL,
  `latitude` double DEFAULT NULL,
  PRIMARY KEY (`idLokasi`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lokasi`
--

LOCK TABLES `lokasi` WRITE;
/*!40000 ALTER TABLE `lokasi` DISABLE KEYS */;
INSERT INTO `lokasi` VALUES (1,'Ubaya',2,2),(2,'Kebun Sawit',3,1);
/*!40000 ALTER TABLE `lokasi` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `menu`
--

DROP TABLE IF EXISTS `menu`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `menu` (
  `idMenu` int(11) NOT NULL AUTO_INCREMENT,
  `statusHalal` tinyint(4) DEFAULT NULL,
  `jenis` varchar(45) DEFAULT NULL,
  `hargaJual` int(11) DEFAULT NULL,
  `tenantId` int(11) NOT NULL,
  `nama` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idMenu`),
  KEY `fk_Menu_Tenant1_idx` (`tenantId`),
  CONSTRAINT `fk_Menu_Tenant1` FOREIGN KEY (`tenantId`) REFERENCES `tenant` (`idTenant`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `menu`
--

LOCK TABLES `menu` WRITE;
/*!40000 ALTER TABLE `menu` DISABLE KEYS */;
INSERT INTO `menu` VALUES (1,1,'makanan',10000,1,'ayam geprek'),(2,0,'makanan',15000,1,'babi goreng'),(3,1,'minuman',8000,2,'es krim'),(4,1,'makanan',12000,2,'batagor');
/*!40000 ALTER TABLE `menu` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `motor`
--

DROP TABLE IF EXISTS `motor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `motor` (
  `idMotor` int(11) NOT NULL,
  `nama` varchar(45) DEFAULT NULL,
  `usia` double DEFAULT NULL,
  `adminId` int(11) DEFAULT NULL,
  `platNomor` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idMotor`),
  KEY `fk_Motor_Admin1_idx` (`adminId`),
  CONSTRAINT `fk_Motor_Admin1` FOREIGN KEY (`adminId`) REFERENCES `admin` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `motor`
--

LOCK TABLES `motor` WRITE;
/*!40000 ALTER TABLE `motor` DISABLE KEYS */;
INSERT INTO `motor` VALUES (1,'honda',6,NULL,'L 223 XY'),(2,'beat',2,NULL,'L5656 AB'),(3,'supra',1,NULL,'W 638 CC');
/*!40000 ALTER TABLE `motor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `notafooddetail`
--

DROP TABLE IF EXISTS `notafooddetail`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `notafooddetail` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `harga` int(11) DEFAULT NULL,
  `jumlah` int(11) DEFAULT NULL,
  `orderFoodId` int(11) NOT NULL,
  `menuId` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_NotaGassDetail_OrderFood1_idx` (`orderFoodId`),
  KEY `fk_NotaFoodDetail_Menu1_idx` (`menuId`),
  CONSTRAINT `fk_NotaFoodDetail_Menu1` FOREIGN KEY (`menuId`) REFERENCES `menu` (`idMenu`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_NotaGassDetail_OrderFood1` FOREIGN KEY (`orderFoodId`) REFERENCES `orderfood` (`idOrderFood`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `notafooddetail`
--

LOCK TABLES `notafooddetail` WRITE;
/*!40000 ALTER TABLE `notafooddetail` DISABLE KEYS */;
INSERT INTO `notafooddetail` VALUES (1,10000,1,5,1),(2,10000,3,9,1),(3,15000,2,9,2),(4,10000,1,10,1),(5,15000,1,10,2),(6,10000,1,11,1),(7,15000,1,11,2),(8,10000,1,12,1),(9,15000,2,12,2),(10,10000,2,13,1),(11,10000,1,14,1),(12,15000,2,14,2),(13,10000,1,15,1),(14,15000,5,15,2),(15,10000,2,16,1),(16,15000,2,16,2),(17,10000,1,17,1),(18,15000,1,17,2),(19,15000,2,18,2),(20,10000,1,18,1),(21,10000,1,19,1),(22,15000,3,20,2),(23,10000,1,21,1),(24,15000,3,21,2),(25,12000,1,22,4),(26,8000,2,22,3),(27,10000,3,23,1),(28,15000,1,23,2);
/*!40000 ALTER TABLE `notafooddetail` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orderfood`
--

DROP TABLE IF EXISTS `orderfood`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `orderfood` (
  `idOrderFood` int(11) NOT NULL AUTO_INCREMENT,
  `tanggalOrder` datetime DEFAULT NULL,
  `ongkir` int(11) DEFAULT NULL,
  `tips` double DEFAULT NULL,
  `driverId` int(11) NOT NULL,
  `konsumenId` int(11) NOT NULL,
  `waktuId` int(11) NOT NULL,
  `jarakId` int(11) NOT NULL,
  `adminId` int(11) DEFAULT NULL,
  `statusSelesai` tinyint(1) DEFAULT NULL,
  `totalBiaya` int(11) DEFAULT NULL,
  `tenantId` int(11) NOT NULL,
  PRIMARY KEY (`idOrderFood`),
  KEY `fk_OrderFood_Driver1_idx` (`driverId`),
  KEY `fk_OrderFood_Konsumen1_idx` (`konsumenId`),
  KEY `fk_OrderFood_Waktu1_idx` (`waktuId`),
  KEY `fk_OrderFood_Jarak1_idx` (`jarakId`),
  KEY `fk_OrderFood_Admin1_idx` (`adminId`),
  KEY `fk_OrderFood_Tenant1_idx` (`tenantId`),
  CONSTRAINT `fk_OrderFood_Admin1` FOREIGN KEY (`adminId`) REFERENCES `admin` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_OrderFood_Driver1` FOREIGN KEY (`driverId`) REFERENCES `driver` (`idDriver`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_OrderFood_Jarak1` FOREIGN KEY (`jarakId`) REFERENCES `jarak` (`idJarak`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_OrderFood_Konsumen1` FOREIGN KEY (`konsumenId`) REFERENCES `konsumen` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_OrderFood_Tenant1` FOREIGN KEY (`tenantId`) REFERENCES `tenant` (`idTenant`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_OrderFood_Waktu1` FOREIGN KEY (`waktuId`) REFERENCES `waktu` (`idWaktu`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orderfood`
--

LOCK TABLES `orderfood` WRITE;
/*!40000 ALTER TABLE `orderfood` DISABLE KEYS */;
INSERT INTO `orderfood` VALUES (3,'2026-01-16 00:36:58',3000,600,3,1,6,2,NULL,0,38000,1),(4,'2026-01-16 14:37:28',3000,600,2,1,8,2,NULL,0,38000,1),(5,'2026-01-16 15:10:54',3000,600,2,1,8,2,NULL,0,13000,1),(6,'2026-01-16 16:19:36',3000,600,3,1,8,2,NULL,1,3000,1),(7,'2026-01-16 16:21:36',3000,600,3,1,8,2,NULL,0,3000,1),(8,'2026-01-16 16:21:38',3000,600,1,1,8,2,NULL,0,3000,1),(9,'2026-01-16 16:21:51',3000,600,3,1,8,2,NULL,1,63000,1),(10,'2026-01-16 16:25:04',3000,600,3,1,8,2,NULL,1,28000,1),(11,'2026-01-16 16:36:45',3000,600,2,1,8,2,NULL,1,28000,1),(12,'2026-01-16 16:41:38',3000,600,1,1,8,2,NULL,1,43000,1),(13,'2026-01-16 17:44:15',7500,1500,3,1,9,1,NULL,1,27500,1),(14,'2026-01-16 17:52:38',7500,1500,3,1,9,1,NULL,1,47500,1),(15,'2026-01-16 21:25:52',3750,750,3,1,10,1,NULL,1,88750,1),(16,'2026-01-16 21:29:03',3750,750,3,1,10,1,NULL,1,53750,1),(17,'2026-01-16 21:38:02',3750,750,3,1,10,1,NULL,1,28750,1),(18,'2026-01-16 21:39:37',3750,750,3,1,10,1,NULL,1,43750,1),(19,'2026-01-16 23:34:11',3750,750,3,1,10,1,NULL,1,13750,1),(20,'2026-01-17 17:52:42',7500,1500,2,1,9,1,NULL,1,52500,1),(21,'2026-01-19 08:21:42',3750,750,3,1,6,1,NULL,1,58750,1),(22,'2026-01-19 09:03:50',3750,750,3,1,6,1,NULL,1,31750,2),(23,'2026-01-21 10:05:10',3750,750,2,1,6,1,NULL,1,48750,1);
/*!40000 ALTER TABLE `orderfood` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ordergasssend`
--

DROP TABLE IF EXISTS `ordergasssend`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ordergasssend` (
  `idOrderGassSend` int(11) NOT NULL AUTO_INCREMENT,
  `tanggalOrder` datetime DEFAULT NULL,
  `Konsumen_id` int(11) NOT NULL,
  `Jarak_idJarak` int(11) NOT NULL,
  `Waktu_idWaktu` int(11) NOT NULL,
  `Driver_idDriver` int(11) NOT NULL,
  `BeratBarang` int(11) DEFAULT NULL,
  `tip` int(11) DEFAULT NULL,
  `status` tinyint(4) DEFAULT NULL,
  `totalHarga` int(11) DEFAULT NULL,
  PRIMARY KEY (`idOrderGassSend`),
  KEY `fk_OrderGassSend_Konsumen1_idx` (`Konsumen_id`),
  KEY `fk_OrderGassSend_Jarak1_idx` (`Jarak_idJarak`),
  KEY `fk_OrderGassSend_Waktu1_idx` (`Waktu_idWaktu`),
  KEY `fk_OrderGassSend_Driver1_idx` (`Driver_idDriver`),
  CONSTRAINT `fk_OrderGassSend_Driver1` FOREIGN KEY (`Driver_idDriver`) REFERENCES `driver` (`idDriver`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_OrderGassSend_Jarak1` FOREIGN KEY (`Jarak_idJarak`) REFERENCES `jarak` (`idJarak`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_OrderGassSend_Konsumen1` FOREIGN KEY (`Konsumen_id`) REFERENCES `konsumen` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_OrderGassSend_Waktu1` FOREIGN KEY (`Waktu_idWaktu`) REFERENCES `waktu` (`idWaktu`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ordergasssend`
--

LOCK TABLES `ordergasssend` WRITE;
/*!40000 ALTER TABLE `ordergasssend` DISABLE KEYS */;
INSERT INTO `ordergasssend` VALUES (1,'2026-01-21 09:57:17',1,1,4,1,10,3000,0,10000),(2,'2026-01-21 09:59:57',1,1,4,1,20,5000,1,25000),(3,'2026-01-21 10:25:01',1,1,4,2,10,3000,1,15000);
/*!40000 ALTER TABLE `ordergasssend` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orderride`
--

DROP TABLE IF EXISTS `orderride`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `orderride` (
  `idOrderRide` int(11) NOT NULL AUTO_INCREMENT,
  `tips` double NOT NULL,
  `tanggalOrder` datetime DEFAULT NULL,
  `konsumenId` int(11) NOT NULL,
  `driverId` int(11) NOT NULL,
  `waktuId` int(11) NOT NULL,
  `jarakId` int(11) NOT NULL,
  `adminId` int(11) DEFAULT NULL,
  `reqWanita` tinyint(1) DEFAULT NULL,
  `reqMotorBaru` tinyint(1) DEFAULT NULL,
  `postOrder` datetime DEFAULT NULL,
  `statusSelesai` tinyint(1) DEFAULT NULL,
  `totalTransaksi` int(11) DEFAULT NULL,
  PRIMARY KEY (`idOrderRide`),
  KEY `fk_OrderRide_Konsumen1_idx` (`konsumenId`),
  KEY `fk_OrderRide_Driver1_idx` (`driverId`),
  KEY `fk_OrderRide_Waktu1_idx` (`waktuId`),
  KEY `fk_OrderRide_Jarak1_idx` (`jarakId`),
  KEY `fk_OrderRide_Admin1_idx` (`adminId`),
  CONSTRAINT `fk_OrderRide_Admin1` FOREIGN KEY (`adminId`) REFERENCES `admin` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_OrderRide_Driver1` FOREIGN KEY (`driverId`) REFERENCES `driver` (`idDriver`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_OrderRide_Jarak1` FOREIGN KEY (`jarakId`) REFERENCES `jarak` (`idJarak`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_OrderRide_Konsumen1` FOREIGN KEY (`konsumenId`) REFERENCES `konsumen` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_OrderRide_Waktu1` FOREIGN KEY (`waktuId`) REFERENCES `waktu` (`idWaktu`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=88 DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orderride`
--

LOCK TABLES `orderride` WRITE;
/*!40000 ALTER TABLE `orderride` DISABLE KEYS */;
INSERT INTO `orderride` VALUES (6,20,'2026-01-09 22:59:05',1,1,1,1,NULL,1,1,'2026-01-10 14:35:00',1,10),(9,1000,'2026-01-09 23:25:17',1,3,2,1,NULL,0,0,'2026-01-10 00:00:00',0,5000),(10,1000,'2026-01-10 00:03:37',1,3,3,1,NULL,0,0,'2026-01-10 00:00:00',0,5000),(11,2300,'2026-01-10 00:11:36',1,2,3,1,NULL,1,1,'2026-01-10 00:00:00',0,11500),(12,1000,'2026-01-10 00:11:58',1,3,3,1,NULL,0,0,'2026-01-10 00:00:00',0,5000),(13,1300,'2026-01-10 00:12:19',1,2,3,1,NULL,1,0,'2026-01-10 00:00:00',0,6500),(14,20,'2026-01-10 16:27:57',1,1,1,1,NULL,1,1,'2026-01-10 14:35:00',1,10),(15,3300,'2026-01-10 16:42:55',1,2,2,1,NULL,1,1,'2026-01-10 00:00:00',0,16500),(16,3300,'2026-01-10 16:43:58',1,3,4,1,NULL,1,1,'2026-01-10 00:00:00',0,16500),(17,2000,'2026-01-10 16:44:54',1,1,4,1,NULL,0,0,'2026-01-10 00:00:00',0,10000),(18,2000,'2026-01-10 16:46:23',1,3,2,1,NULL,0,0,'2026-01-10 00:00:00',0,10000),(19,3300,'2026-01-10 16:48:46',1,2,2,1,NULL,1,1,'2026-01-10 00:00:00',0,16500),(20,2000,'2026-01-10 17:00:32',1,1,2,1,NULL,0,0,'2026-01-10 00:00:00',0,10000),(21,2000,'2026-01-10 17:12:59',1,3,2,1,NULL,0,0,'2026-01-10 00:00:00',0,10000),(22,2000,'2026-01-10 17:16:50',1,1,2,1,NULL,0,0,'2026-01-10 17:16:50',0,10000),(23,2000,'2026-01-10 17:21:34',1,3,5,1,NULL,0,0,'2026-01-10 20:38:24',0,10000),(24,2000,'2026-01-10 17:25:15',1,1,4,1,NULL,0,0,'2026-01-09 10:38:24',0,10000),(25,2000,'2026-01-10 17:30:32',1,1,4,1,NULL,0,0,'2026-01-10 10:38:00',0,10000),(26,2000,'2026-01-10 17:32:17',1,3,4,1,NULL,0,0,'2026-01-11 10:38:00',0,10000),(27,2000,'2026-01-10 17:32:49',1,1,2,1,NULL,0,0,'2026-01-10 17:32:49',0,10000),(28,2000,'2026-01-10 17:38:23',1,3,2,1,NULL,0,0,'2026-11-09 17:38:24',0,10000),(29,2000,'2026-01-10 17:38:40',1,2,2,1,NULL,0,0,'2026-11-09 17:38:24',0,10000),(30,2000,'2026-01-10 17:38:51',1,1,2,1,NULL,0,0,'2026-11-09 16:38:24',0,10000),(31,2000,'2026-01-10 17:39:14',1,2,2,1,NULL,0,0,'2026-01-10 17:39:14',0,10000),(32,2000,'2026-01-10 17:39:27',1,2,4,1,NULL,0,0,'2026-01-11 13:38:24',0,10000),(33,2000,'2026-01-10 17:41:05',1,1,2,1,NULL,0,0,'2026-01-11 17:20:00',0,10000),(34,2000,'2026-01-10 17:41:15',1,3,2,1,NULL,0,0,'2026-01-11 17:50:00',0,10000),(35,2000,'2026-01-10 17:41:31',1,3,5,1,NULL,0,0,'2026-01-11 18:50:00',0,10000),(36,2000,'2026-01-10 17:41:42',1,1,4,1,NULL,0,0,'2026-01-11 13:50:00',0,10000),(37,2000,'2026-01-10 17:42:10',1,2,5,1,NULL,0,0,'2026-01-11 19:50:00',0,10000),(38,2000,'2026-01-10 17:43:02',1,2,2,1,NULL,0,0,'2026-01-10 17:59:00',0,10000),(39,2000,'2026-01-10 17:43:16',1,3,2,1,NULL,0,0,'2026-01-10 17:30:00',0,10000),(40,2000,'2026-01-10 17:43:28',1,1,4,1,NULL,0,0,'2026-01-10 11:30:00',0,10000),(41,2000,'2026-01-10 17:44:00',1,3,4,1,NULL,0,0,'2026-01-10 15:59:00',0,10000),(42,2000,'2026-01-10 17:44:13',1,3,5,1,NULL,0,0,'2026-01-10 22:59:00',0,10000),(43,2000,'2026-01-10 17:46:38',1,3,2,1,NULL,0,0,'2026-01-11 16:46:27',0,10000),(44,2000,'2026-01-10 17:46:55',1,2,5,1,NULL,0,0,'2026-01-10 20:46:27',1,10000),(45,1000,'2026-01-10 18:01:47',1,2,5,1,NULL,0,0,'2026-01-10 18:01:47',1,5000),(46,2000,'2026-01-10 18:13:13',1,1,5,1,NULL,0,1,'2026-01-11 18:13:13',0,10000),(47,1000,'2026-01-10 18:15:05',1,2,5,1,NULL,0,0,'2026-01-11 18:15:05',0,5000),(48,1000,'2026-01-10 18:26:20',1,2,5,1,NULL,0,0,'2026-01-10 18:26:20',0,5000),(49,1000,'2026-01-10 18:26:27',1,1,5,1,NULL,0,0,'2026-01-10 18:26:27',0,5000),(50,1000,'2026-01-10 18:26:43',1,3,5,1,NULL,0,0,'2026-01-10 18:26:43',0,5000),(51,1000,'2026-01-10 18:26:48',1,3,5,1,NULL,0,0,'2026-01-10 18:26:48',0,5000),(52,1000,'2026-01-10 18:38:49',1,1,4,1,NULL,0,0,'2026-01-11 11:38:35',0,5000),(53,2000,'2026-01-10 18:42:34',1,3,5,1,NULL,0,1,'2026-01-11 18:42:34',0,10000),(54,2000,'2026-01-10 18:42:57',1,3,5,1,NULL,0,1,'2026-01-10 18:42:57',0,10000),(55,2000,'2026-01-10 18:46:49',1,3,5,1,NULL,0,1,'2026-01-11 18:46:49',0,10000),(56,1800,'2026-01-10 22:00:32',2,3,5,2,NULL,0,1,'2026-01-11 22:00:32',1,9000),(57,1800,'2026-01-10 22:01:53',2,3,5,2,NULL,0,1,'2026-01-10 22:01:53',0,9000),(58,1800,'2026-01-10 22:05:10',2,3,5,2,NULL,0,1,'2026-01-10 22:05:10',0,9000),(59,1000,'2026-01-10 22:07:31',2,3,5,1,NULL,0,0,'2026-01-10 22:07:31',0,5000),(60,1000,'2026-01-10 22:10:21',2,3,5,1,NULL,0,0,'2026-01-11 22:10:21',0,5000),(61,1000,'2026-01-10 22:11:30',2,3,5,1,NULL,0,0,'2026-01-10 22:11:30',0,5000),(62,1000,'2026-01-10 22:14:03',1,3,5,1,NULL,0,0,'2026-01-10 22:14:03',0,5000),(63,1000,'2026-01-10 22:14:55',1,3,5,1,NULL,0,0,'2026-01-10 22:14:55',0,5000),(64,1000,'2026-01-10 22:17:36',1,3,5,1,NULL,0,0,'2026-01-10 22:17:36',0,5000),(65,1300,'2026-01-10 23:15:34',1,2,5,1,NULL,1,0,'2026-01-11 23:15:34',1,6500),(66,1100,'2026-01-10 23:18:06',1,2,5,2,NULL,1,0,'2026-01-10 23:18:06',1,5500),(67,1100,'2026-01-10 23:20:03',1,2,5,2,NULL,1,0,'2026-01-10 23:20:03',1,5500),(68,2300,'2026-01-10 23:23:15',1,3,5,1,NULL,1,1,'2026-01-10 23:23:15',1,11500),(69,1000,'2026-01-10 23:25:23',1,2,5,1,NULL,0,0,'2026-01-10 23:25:23',1,5000),(70,2300,'2026-01-12 09:53:26',1,3,4,1,NULL,1,1,'2026-01-13 08:53:10',1,11500),(71,1300,'2026-01-12 19:14:56',1,2,5,1,NULL,1,0,'2026-01-12 19:14:56',1,6500),(72,1100,'2026-01-13 08:45:01',1,3,4,2,NULL,1,0,'2026-01-14 08:45:01',1,5500),(73,2000,'2026-01-13 08:56:03',1,3,4,1,NULL,0,1,'2026-01-14 08:56:03',0,10000),(74,2000,'2026-01-13 08:56:18',1,3,4,1,NULL,0,1,'2026-01-13 08:56:18',1,10000),(75,2300,'2026-01-13 09:02:22',1,3,4,1,NULL,1,1,'2026-01-14 09:02:22',1,11500),(76,2300,'2026-01-13 15:56:41',1,3,4,1,NULL,1,1,'2026-01-14 15:56:41',1,11500),(77,1300,'2026-01-14 22:01:42',1,3,5,1,NULL,1,0,'2026-01-15 22:01:42',1,6500),(78,2300,'2026-01-14 22:43:21',1,3,5,1,NULL,1,1,'2026-01-15 22:43:21',1,11500),(79,2300,'2026-01-14 22:45:23',1,3,5,1,NULL,1,1,'2026-01-15 22:45:23',1,11500),(80,2100,'2026-01-15 12:43:29',1,3,4,2,NULL,1,1,'2026-01-16 12:43:29',1,10500),(81,800,'2026-01-15 12:57:46',1,3,4,2,NULL,0,0,'2026-01-16 12:57:46',0,4000),(82,2000,'2026-01-15 12:58:34',1,3,4,1,NULL,0,1,'2026-01-15 12:58:34',1,10000),(83,1300,'2026-01-16 14:50:45',1,2,4,1,NULL,1,0,'2026-01-17 14:50:45',1,6500),(84,2100,'2026-01-16 15:47:34',1,3,4,2,NULL,1,1,'2026-01-16 15:47:34',1,10500),(85,2300,'2026-01-16 23:33:36',1,2,1,1,NULL,1,0,'2026-01-17 07:33:03',1,11500),(86,2300,'2026-01-17 17:51:49',1,2,2,1,NULL,1,0,'2026-01-18 17:51:49',1,11500),(87,2300,'2026-01-17 22:22:32',1,3,5,1,NULL,1,1,'2026-01-17 22:22:32',1,11500);
/*!40000 ALTER TABLE `orderride` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `penarikandana`
--

DROP TABLE IF EXISTS `penarikandana`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `penarikandana` (
  `idPenarikanDana` int(11) NOT NULL AUTO_INCREMENT,
  `nominal` int(11) DEFAULT NULL,
  `tanggal` datetime DEFAULT NULL,
  `driverId` int(11) NOT NULL,
  PRIMARY KEY (`idPenarikanDana`),
  KEY `fk_PenarikanDana_Driver1_idx` (`driverId`),
  CONSTRAINT `fk_PenarikanDana_Driver1` FOREIGN KEY (`driverId`) REFERENCES `driver` (`idDriver`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `penarikandana`
--

LOCK TABLES `penarikandana` WRITE;
/*!40000 ALTER TABLE `penarikandana` DISABLE KEYS */;
INSERT INTO `penarikandana` VALUES (1,10000,'2026-01-16 23:12:16',3),(2,10000,'2026-01-16 23:12:20',3),(3,10000,'2026-01-16 23:12:31',2);
/*!40000 ALTER TABLE `penarikandana` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rating`
--

DROP TABLE IF EXISTS `rating`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `rating` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `konsumenId` int(11) NOT NULL,
  `driverId` int(11) NOT NULL,
  `nilai` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`,`konsumenId`,`driverId`),
  KEY `fk_Konsumen_has_Driver_Driver1_idx` (`driverId`),
  KEY `fk_Konsumen_has_Driver_Konsumen1_idx` (`konsumenId`),
  CONSTRAINT `fk_Konsumen_has_Driver_Driver1` FOREIGN KEY (`driverId`) REFERENCES `driver` (`idDriver`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Konsumen_has_Driver_Konsumen1` FOREIGN KEY (`konsumenId`) REFERENCES `konsumen` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rating`
--

LOCK TABLES `rating` WRITE;
/*!40000 ALTER TABLE `rating` DISABLE KEYS */;
INSERT INTO `rating` VALUES (1,1,1,5),(2,1,1,4),(3,1,2,1),(4,1,2,2),(5,1,2,5),(6,1,3,3),(7,1,2,5),(8,1,3,4),(9,1,2,5),(10,1,3,3),(11,1,3,5),(12,1,3,5),(13,1,3,5),(14,1,3,4),(15,1,3,5),(16,1,3,4),(17,1,2,4),(18,1,3,5),(19,1,3,5),(20,1,2,5),(21,1,1,5),(22,1,3,4),(23,1,3,5),(24,1,3,5),(25,1,3,2),(26,1,3,5),(27,1,2,5),(28,1,3,5),(29,1,2,5),(30,1,2,5),(31,1,3,5),(32,1,3,5),(33,1,1,4),(34,1,2,5),(35,1,2,5);
/*!40000 ALTER TABLE `rating` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ratingtenant`
--

DROP TABLE IF EXISTS `ratingtenant`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ratingtenant` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `konsumenId` int(11) NOT NULL,
  `tenantId` int(11) NOT NULL,
  `nilai` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`,`konsumenId`,`tenantId`),
  KEY `fk_Konsumen_has_Tenant_Tenant1_idx` (`tenantId`),
  KEY `fk_Konsumen_has_Tenant_Konsumen1_idx` (`konsumenId`),
  CONSTRAINT `fk_Konsumen_has_Tenant_Konsumen1` FOREIGN KEY (`konsumenId`) REFERENCES `konsumen` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Konsumen_has_Tenant_Tenant1` FOREIGN KEY (`tenantId`) REFERENCES `tenant` (`idTenant`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ratingtenant`
--

LOCK TABLES `ratingtenant` WRITE;
/*!40000 ALTER TABLE `ratingtenant` DISABLE KEYS */;
INSERT INTO `ratingtenant` VALUES (1,1,1,1),(2,1,1,5),(3,1,1,4),(4,1,1,5),(5,1,1,5),(6,1,1,5),(7,1,1,5),(8,1,1,5),(9,1,1,5),(10,1,1,5),(11,1,2,5),(12,1,1,5);
/*!40000 ALTER TABLE `ratingtenant` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `report`
--

DROP TABLE IF EXISTS `report`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `report` (
  `idReport` int(11) NOT NULL AUTO_INCREMENT,
  `konsumenId` int(11) NOT NULL,
  `orderRideId` int(11) NOT NULL,
  `Admin_id` int(11) DEFAULT NULL,
  `statusReport` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idReport`),
  KEY `fk_Konsumen_has_OrderRide_OrderRide1_idx` (`orderRideId`),
  KEY `fk_Konsumen_has_OrderRide_Konsumen1_idx` (`konsumenId`),
  KEY `fk_Report_Admin1_idx` (`Admin_id`),
  CONSTRAINT `fk_Konsumen_has_OrderRide_Konsumen1` FOREIGN KEY (`konsumenId`) REFERENCES `konsumen` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Konsumen_has_OrderRide_OrderRide1` FOREIGN KEY (`orderRideId`) REFERENCES `orderride` (`idOrderRide`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Report_Admin1` FOREIGN KEY (`Admin_id`) REFERENCES `admin` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `report`
--

LOCK TABLES `report` WRITE;
/*!40000 ALTER TABLE `report` DISABLE KEYS */;
INSERT INTO `report` VALUES (1,1,72,NULL,0),(2,1,74,NULL,0),(3,1,87,NULL,1);
/*!40000 ALTER TABLE `report` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tenant`
--

DROP TABLE IF EXISTS `tenant`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tenant` (
  `idTenant` int(11) NOT NULL AUTO_INCREMENT,
  `nama` varchar(45) DEFAULT NULL,
  `lokasiId` int(11) NOT NULL,
  `rating` double DEFAULT NULL,
  `username` varchar(45) DEFAULT NULL,
  `password` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idTenant`),
  UNIQUE KEY `username_UNIQUE` (`username`),
  KEY `fk_Tenant_Lokasi1_idx` (`lokasiId`),
  CONSTRAINT `fk_Tenant_Lokasi1` FOREIGN KEY (`lokasiId`) REFERENCES `lokasi` (`idLokasi`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tenant`
--

LOCK TABLES `tenant` WRITE;
/*!40000 ALTER TABLE `tenant` DISABLE KEYS */;
INSERT INTO `tenant` VALUES (1,'kluwih',1,4.545454545,'kluwih','123'),(2,'fk',1,5,'fk','123');
/*!40000 ALTER TABLE `tenant` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `topup`
--

DROP TABLE IF EXISTS `topup`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `topup` (
  `idTopUp` int(11) NOT NULL AUTO_INCREMENT,
  `konsumenId` int(11) NOT NULL,
  `gassmonId` int(11) NOT NULL,
  `nominal` int(11) DEFAULT NULL,
  `tanggal` datetime DEFAULT NULL,
  PRIMARY KEY (`idTopUp`),
  KEY `fk_Konsumen_has_Gass-Mon_Gass-Mon1_idx` (`gassmonId`),
  KEY `fk_Konsumen_has_Gass-Mon_Konsumen1_idx` (`konsumenId`),
  CONSTRAINT `fk_Konsumen_has_Gass-Mon_Gass-Mon1` FOREIGN KEY (`gassmonId`) REFERENCES `gass-mon` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Konsumen_has_Gass-Mon_Konsumen1` FOREIGN KEY (`konsumenId`) REFERENCES `konsumen` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `topup`
--

LOCK TABLES `topup` WRITE;
/*!40000 ALTER TABLE `topup` DISABLE KEYS */;
INSERT INTO `topup` VALUES (1,1,1,100,'2026-01-12 19:38:12'),(2,1,1,3,'2026-01-12 20:20:53'),(3,1,1,3,'2026-01-12 20:20:59'),(4,1,1,4,'2026-01-12 20:23:28'),(5,1,1,100,'2026-01-14 23:39:24'),(6,1,1,100,'2026-01-14 23:40:05');
/*!40000 ALTER TABLE `topup` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `waktu`
--

DROP TABLE IF EXISTS `waktu`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `waktu` (
  `idWaktu` int(11) NOT NULL,
  `jamAwal` int(11) DEFAULT NULL,
  `harga` int(11) DEFAULT NULL,
  `jamAkhir` int(11) DEFAULT NULL,
  `kategori` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idWaktu`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `waktu`
--

LOCK TABLES `waktu` WRITE;
/*!40000 ALTER TABLE `waktu` DISABLE KEYS */;
INSERT INTO `waktu` VALUES (1,6,2000,7,'gassride'),(2,16,2000,17,'gassride'),(3,0,1000,5,'gassride'),(4,8,1000,15,'gassride'),(5,18,1000,24,'gassride'),(6,0,750,10,'gasskan'),(7,11,1500,12,'gasskan'),(8,13,750,16,'gasskan'),(9,17,1500,18,'gasskan'),(10,19,750,24,'gasskan');
/*!40000 ALTER TABLE `waktu` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-01-21 10:33:22

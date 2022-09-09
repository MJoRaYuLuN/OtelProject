-- MySQL dump 10.13  Distrib 8.0.28, for Win64 (x86_64)
--
-- Host: localhost    Database: otel
-- ------------------------------------------------------
-- Server version	8.0.17

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `__efmigrationshistory`
--

DROP TABLE IF EXISTS `__efmigrationshistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(95) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `__efmigrationshistory`
--

LOCK TABLES `__efmigrationshistory` WRITE;
/*!40000 ALTER TABLE `__efmigrationshistory` DISABLE KEYS */;
INSERT INTO `__efmigrationshistory` VALUES ('20220905071052_FirstDbCreate','3.1.28'),('20220905073504_tabloIliskilendirme','3.1.28'),('20220905074252_Hakkimizda_OdaResim_OdaOzellik','3.1.28'),('20220905074347_Hakkimizda_OdaResim_OdaOzellik2','3.1.28'),('20220905080903_OdaOzellikGuncelle','3.1.28'),('20220905081109_YoneticiAdd','3.1.28'),('20220905081153_YoneticiAdds','3.1.28'),('20220905125940_ActUpdate','3.1.28'),('20220905141737_RezervasyonOdaTip_Update','3.1.28'),('20220906103847_RezervasyonYetiskinCocuk_ADD','3.1.28'),('20220906113223_OdalarOzellik_ADD','3.1.28'),('20220906120112_OdaAcikalamaAnasayfa_ADD','3.1.28');
/*!40000 ALTER TABLE `__efmigrationshistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `altmusteris`
--

DROP TABLE IF EXISTS `altmusteris`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `altmusteris` (
  `Idno` int(11) NOT NULL AUTO_INCREMENT,
  `MusteriId` int(11) NOT NULL,
  `AdiSoyadi` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `DogumTarihi` datetime(6) NOT NULL,
  `TCNo` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Uyruk` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Act` int(11) NOT NULL,
  PRIMARY KEY (`Idno`),
  KEY `IX_AltMusteris_MusteriId` (`MusteriId`),
  CONSTRAINT `FK_AltMusteris_Musteris_MusteriId` FOREIGN KEY (`MusteriId`) REFERENCES `musteris` (`Idno`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `altmusteris`
--

LOCK TABLES `altmusteris` WRITE;
/*!40000 ALTER TABLE `altmusteris` DISABLE KEYS */;
/*!40000 ALTER TABLE `altmusteris` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `hakkimizdas`
--

DROP TABLE IF EXISTS `hakkimizdas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `hakkimizdas` (
  `Idno` int(11) NOT NULL AUTO_INCREMENT,
  `Baslik` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `AltBaslik` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Icerik` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  PRIMARY KEY (`Idno`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hakkimizdas`
--

LOCK TABLES `hakkimizdas` WRITE;
/*!40000 ALTER TABLE `hakkimizdas` DISABLE KEYS */;
/*!40000 ALTER TABLE `hakkimizdas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `musteris`
--

DROP TABLE IF EXISTS `musteris`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `musteris` (
  `Idno` int(11) NOT NULL AUTO_INCREMENT,
  `Adisoyadi` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `DogumTarihi` datetime(6) NOT NULL,
  `TCNo` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Uyruk` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Telefon` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Act` int(11) NOT NULL,
  PRIMARY KEY (`Idno`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `musteris`
--

LOCK TABLES `musteris` WRITE;
/*!40000 ALTER TABLE `musteris` DISABLE KEYS */;
INSERT INTO `musteris` VALUES (1,'Deneme İsim','1990-10-06 00:00:00.000000','12345678901','TC','5065235436',1),(7,NULL,'0001-01-01 00:00:00.000000',NULL,NULL,'5559998877',0),(8,NULL,'0001-01-01 00:00:00.000000',NULL,NULL,'5559998877',0),(9,NULL,'0001-01-01 00:00:00.000000',NULL,NULL,'5051234567',1);
/*!40000 ALTER TABLE `musteris` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `odalars`
--

DROP TABLE IF EXISTS `odalars`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `odalars` (
  `Idno` int(11) NOT NULL AUTO_INCREMENT,
  `OdaAdi` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `OdaNo` int(11) NOT NULL,
  `OdaTip` int(11) NOT NULL,
  `Cephe` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `YatakSayisi` int(11) NOT NULL,
  `Act` int(11) NOT NULL,
  `Ozellikler` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Aciklama` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Anasayfa` tinyint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`Idno`),
  KEY `IX_Odalars_OdaTip` (`OdaTip`),
  CONSTRAINT `FK_Odalars_OdaTips_OdaTip` FOREIGN KEY (`OdaTip`) REFERENCES `odatips` (`Idno`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `odalars`
--

LOCK TABLES `odalars` WRITE;
/*!40000 ALTER TABLE `odalars` DISABLE KEYS */;
INSERT INTO `odalars` VALUES (1,'BOŞ ODA',0,1,'YOK',0,1,'1,2,3,6',NULL,0),(2,'Tek Kişilik',101,1,'Kara',2,1,'1,2,3,5,10,12',NULL,1),(3,'Tek Kişilik',102,1,'Deniz',2,1,'1,2,3,5,10,12',NULL,1),(4,'Tek Kişilik',103,1,'Yamaç',2,1,'1,2,3,5,10,12',NULL,1),(5,'Çift Kişilik',104,2,'Bahçe',1,1,'1,2,4,5,7,9,10,12',NULL,1),(6,'Çift Kişilik',201,2,'Kara',1,1,'1,2,4,5,10,12',NULL,1),(7,'Çift Kişilik',202,2,'Deniz',1,1,'1,2,4,5,9,10,12',NULL,1),(8,'Çift Kişilik Çocuklu',203,3,'Bahçe',2,1,'1,2,3,4,5,6,7,9,10,12',NULL,1),(9,'Çift Kişilik Çocuklu',204,3,'Yamaç',2,1,'1,2,3,4,5,6,7,10,12',NULL,1),(10,'Aile Oda (2+1+1)',301,8,'Bahçe',3,1,'1,2,3,4,5,6,7,8,9,10,12',NULL,1),(11,'Aile Oda (2+1+1)',302,8,'Deniz',3,1,'1,2,3,4,5,6,7,8,9,10,12',NULL,1),(12,'Aile Oda (2+1+1)',303,8,'Yamaç',3,1,'1,2,3,4,5,6,7,8,9,10,12',NULL,1),(13,'Junior Suite (1 Yatak)',304,5,'Deniz',1,1,'1,2,4,5,6,7,8,9,10,12',NULL,1),(14,'Junior Suite (2+1 Yatak)',305,5,'Bahçe',2,1,'1,2,3,4,5,6,7,8,9,10,12',NULL,1),(15,'Suit Oda (2+1)',401,6,'Deniz',2,1,'1,2,3,4,5,6,7,8,9,10,12,13',NULL,1),(16,'Suit Oda (2+1+1)',402,6,'Deniz',3,1,'1,2,3,4,5,6,7,8,9,10,12,13',NULL,1),(17,'Dubleks (2+2+1+1)',403,7,'Deniz+Yamaç',4,1,'1,2,3,4,5,6,7,8,9,10,12,13,15',NULL,1),(18,'Kral Dairesi',501,9,'Tüm Cephe',5,1,'1,2,3,4,5,6,7,8,9,10,11,12,13,14,15',NULL,1);
/*!40000 ALTER TABLE `odalars` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `odaozelliks`
--

DROP TABLE IF EXISTS `odaozelliks`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `odaozelliks` (
  `Idno` int(11) NOT NULL AUTO_INCREMENT,
  `Ikon` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Baslik` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Act` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`Idno`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `odaozelliks`
--

LOCK TABLES `odaozelliks` WRITE;
/*!40000 ALTER TABLE `odaozelliks` DISABLE KEYS */;
INSERT INTO `odaozelliks` VALUES (1,'fas fa-wind','Klima',1),(2,'fas fa-wifi','Ücretsiz Wifi',1),(3,'fas fa-bed','Tek Kişilik Yatak',1),(4,'fas fa-bed','Çift Kişilik Yatak',1),(5,'fas fa-tv','Kablo Tv',1),(6,'fas fa-mug-hot','Ücretsiz İkramlar',1),(7,'fas fa-glass-cheers','Minibar',1),(8,'fas fa-hot-tub','Jakuzi',1),(9,'fas fa-lock','Kasa',1),(10,'fas fa-smoking-ban','Sigara İçilmez',1),(11,'fas fa-smoking','Sigara İçilebilir',1),(12,'fas fa-tty','7/24 Resepsiyon',1),(13,'fas fa-couch','Koltuk',1),(14,'fas fa-couch','Oturma Grubu',1),(15,'fas fa-utensils','Mutfak',1);
/*!40000 ALTER TABLE `odaozelliks` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `odaozelliksecims`
--

DROP TABLE IF EXISTS `odaozelliksecims`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `odaozelliksecims` (
  `Idno` int(11) NOT NULL AUTO_INCREMENT,
  `OdaId` int(11) NOT NULL,
  `OzellikId` int(11) NOT NULL,
  PRIMARY KEY (`Idno`),
  KEY `IX_OdaOzellikSecims_OdaId` (`OdaId`),
  KEY `IX_OdaOzellikSecims_OzellikId` (`OzellikId`),
  CONSTRAINT `FK_OdaOzellikSecims_OdaOzelliks_OzellikId` FOREIGN KEY (`OzellikId`) REFERENCES `odaozelliks` (`Idno`) ON DELETE CASCADE,
  CONSTRAINT `FK_OdaOzellikSecims_Odalars_OdaId` FOREIGN KEY (`OdaId`) REFERENCES `odalars` (`Idno`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `odaozelliksecims`
--

LOCK TABLES `odaozelliksecims` WRITE;
/*!40000 ALTER TABLE `odaozelliksecims` DISABLE KEYS */;
/*!40000 ALTER TABLE `odaozelliksecims` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `odaresims`
--

DROP TABLE IF EXISTS `odaresims`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `odaresims` (
  `Idno` int(11) NOT NULL AUTO_INCREMENT,
  `OdaId` int(11) NOT NULL,
  `Resim` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Act` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`Idno`),
  KEY `IX_OdaResims_OdaId` (`OdaId`),
  CONSTRAINT `FK_OdaResims_Odalars_OdaId` FOREIGN KEY (`OdaId`) REFERENCES `odalars` (`Idno`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=37 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `odaresims`
--

LOCK TABLES `odaresims` WRITE;
/*!40000 ALTER TABLE `odaresims` DISABLE KEYS */;
INSERT INTO `odaresims` VALUES (1,2,'1.jpg',1),(2,2,'2.jpg',1),(3,3,'3.jpg',1),(4,3,'4.jpg',1),(5,4,'5.jpg',1),(6,5,'6.jpg',1),(7,5,'7.jpg',1),(8,4,'8.jpg',1),(9,6,'9.jpg',1),(10,6,'10.jpg',1),(11,7,'11.jpg',1),(12,7,'12.jpg',1),(13,8,'13.jpg',1),(14,8,'14.jpg',1),(15,9,'15.jpg',1),(16,9,'16.jpg',1),(17,10,'17.jpg',1),(18,10,'18.jpg',1),(19,11,'19.jpg',1),(20,11,'20.jpg',1),(21,12,'21.jpg',1),(22,12,'22.jpg',1),(23,13,'23.jpg',1),(24,13,'24.jpg',1),(25,14,'25.jpg',1),(26,14,'26.jpg',1),(27,15,'27.jpg',1),(28,15,'28.jpg',1),(29,16,'29.jpg',1),(30,16,'30.jpg',1),(31,17,'31.jpg',1),(32,17,'32.jpg',1),(33,18,'33.jpg',1),(34,18,'34.jpg',1),(35,17,'35.jpg',1),(36,17,'36.jpg',1);
/*!40000 ALTER TABLE `odaresims` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `odatips`
--

DROP TABLE IF EXISTS `odatips`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `odatips` (
  `Idno` int(11) NOT NULL AUTO_INCREMENT,
  `Baslik` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Ozellikler` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Ucret` double NOT NULL,
  `Act` int(11) NOT NULL,
  PRIMARY KEY (`Idno`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `odatips`
--

LOCK TABLES `odatips` WRITE;
/*!40000 ALTER TABLE `odatips` DISABLE KEYS */;
INSERT INTO `odatips` VALUES (1,'Tek Kişilik',NULL,100,1),(2,'Çift Kişilik',NULL,125,1),(3,'Üç Kişilik',NULL,150,1),(4,'Dört Kişilik',NULL,160,1),(5,'Junior Suite',NULL,180,1),(6,'Suit',NULL,220,1),(7,'Dubleks',NULL,260,1),(8,'Aile Odası',NULL,300,1),(9,'Kral Dairesi',NULL,500,1);
/*!40000 ALTER TABLE `odatips` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pansiyons`
--

DROP TABLE IF EXISTS `pansiyons`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pansiyons` (
  `Idno` int(11) NOT NULL AUTO_INCREMENT,
  `Baslik` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Ucret` double NOT NULL,
  `Act` int(11) NOT NULL,
  PRIMARY KEY (`Idno`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pansiyons`
--

LOCK TABLES `pansiyons` WRITE;
/*!40000 ALTER TABLE `pansiyons` DISABLE KEYS */;
INSERT INTO `pansiyons` VALUES (1,'Sadece Oda',0,1),(2,'Yarım Pansiyon',150,1),(3,'Tam Pansiyon',250,1),(4,'Oda Kahvaltı',500,1);
/*!40000 ALTER TABLE `pansiyons` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rezervasyons`
--

DROP TABLE IF EXISTS `rezervasyons`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `rezervasyons` (
  `Idno` int(11) NOT NULL AUTO_INCREMENT,
  `MusteriId` int(11) NOT NULL,
  `OdaId` int(11) NOT NULL,
  `GirisTarihi` datetime(6) NOT NULL,
  `CikisTarihi` datetime(6) NOT NULL,
  `Ucret` double NOT NULL,
  `Pansiyon` int(11) NOT NULL,
  `EkUcret` double NOT NULL,
  `Aciklama` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Act` int(11) NOT NULL,
  `OdaTipId` int(11) NOT NULL DEFAULT '0',
  `Cocuk` int(11) NOT NULL DEFAULT '0',
  `Yetiskin` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`Idno`),
  KEY `IX_Rezervasyons_MusteriId` (`MusteriId`),
  KEY `IX_Rezervasyons_OdaId` (`OdaId`),
  KEY `IX_Rezervasyons_Pansiyon` (`Pansiyon`),
  KEY `IX_Rezervasyons_OdaTipId` (`OdaTipId`),
  CONSTRAINT `FK_Rezervasyons_Musteris_MusteriId` FOREIGN KEY (`MusteriId`) REFERENCES `musteris` (`Idno`) ON DELETE CASCADE,
  CONSTRAINT `FK_Rezervasyons_OdaTips_OdaTipId` FOREIGN KEY (`OdaTipId`) REFERENCES `odatips` (`Idno`) ON DELETE CASCADE,
  CONSTRAINT `FK_Rezervasyons_Odalars_OdaId` FOREIGN KEY (`OdaId`) REFERENCES `odalars` (`Idno`) ON DELETE CASCADE,
  CONSTRAINT `FK_Rezervasyons_Pansiyons_Pansiyon` FOREIGN KEY (`Pansiyon`) REFERENCES `pansiyons` (`Idno`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rezervasyons`
--

LOCK TABLES `rezervasyons` WRITE;
/*!40000 ALTER TABLE `rezervasyons` DISABLE KEYS */;
INSERT INTO `rezervasyons` VALUES (1,1,1,'2022-09-01 00:00:00.000000','2022-09-06 13:59:22.000000',200,1,150,'Dolaptan birşeyler içti, odaya zarar verdi',3,1,0,0),(7,7,1,'2022-09-18 16:27:25.000000','2022-09-20 16:27:25.000000',400,1,0,NULL,1,1,1,2),(8,8,1,'2022-09-18 16:27:52.000000','2022-09-20 16:27:52.000000',400,1,0,NULL,1,1,1,2),(12,9,1,'2022-09-18 11:29:57.000000','2022-10-02 11:29:57.000000',5250,3,0,NULL,0,2,0,2),(13,9,7,'2022-09-18 11:31:22.000000','2022-09-07 11:37:34.000000',5250,3,300,'Minibardan yiyecek içecek + Oda Kahvaltısı',3,2,0,2);
/*!40000 ALTER TABLE `rezervasyons` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `yoneticis`
--

DROP TABLE IF EXISTS `yoneticis`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `yoneticis` (
  `Idno` int(11) NOT NULL AUTO_INCREMENT,
  `Email` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Password` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Act` int(11) NOT NULL,
  PRIMARY KEY (`Idno`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `yoneticis`
--

LOCK TABLES `yoneticis` WRITE;
/*!40000 ALTER TABLE `yoneticis` DISABLE KEYS */;
/*!40000 ALTER TABLE `yoneticis` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-09-09 12:44:24

CREATE DATABASE  IF NOT EXISTS `rasvjetadb` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `rasvjetadb`;
-- MySQL dump 10.13  Distrib 8.0.32, for Win64 (x86_64)
--
-- Host: localhost    Database: rasvjetadb
-- ------------------------------------------------------
-- Server version	8.0.32

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
-- Table structure for table `korisnik`
--

DROP TABLE IF EXISTS `korisnik`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `korisnik` (
  `id` int NOT NULL AUTO_INCREMENT,
  `username` varchar(45) DEFAULT NULL,
  `password` varchar(45) NOT NULL,
  `ime` varchar(45) DEFAULT NULL,
  `prezime` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `korisnik`
--

LOCK TABLES `korisnik` WRITE;
/*!40000 ALTER TABLE `korisnik` DISABLE KEYS */;
INSERT INTO `korisnik` VALUES (1,'admin','admin','nikola','horvat'),(2,'korisnik','korisnik','leon','novak');
/*!40000 ALTER TABLE `korisnik` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `senzor`
--

DROP TABLE IF EXISTS `senzor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `senzor` (
  `id` int NOT NULL AUTO_INCREMENT,
  `status` enum('ok','kvar','popravak') NOT NULL,
  `aktivan` int NOT NULL,
  `zona_id` int NOT NULL,
  `svjetlo` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=32 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `senzor`
--

LOCK TABLES `senzor` WRITE;
/*!40000 ALTER TABLE `senzor` DISABLE KEYS */;
INSERT INTO `senzor` VALUES (1,'kvar',0,1,0),(2,'ok',1,1,0),(3,'ok',1,1,8),(4,'ok',0,1,5),(5,'ok',0,1,23),(6,'ok',0,1,6),(7,'ok',0,1,1),(8,'ok',0,2,4),(9,'ok',0,2,5),(10,'ok',0,2,7),(11,'ok',0,2,0),(12,'kvar',0,2,0),(13,'ok',0,2,6),(14,'popravak',0,2,0),(15,'ok',1,2,4),(16,'ok',0,2,1),(17,'ok',0,2,13),(18,'ok',0,2,23),(31,'ok',0,1,0);
/*!40000 ALTER TABLE `senzor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `svjetlo`
--

DROP TABLE IF EXISTS `svjetlo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `svjetlo` (
  `id` int NOT NULL AUTO_INCREMENT,
  `status` enum('ok','kvar','popravak','Disconnected','Izvanredno') NOT NULL,
  `zona_id` int NOT NULL,
  `upaljeno` int DEFAULT NULL,
  `snaga` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `svjetlo`
--

LOCK TABLES `svjetlo` WRITE;
/*!40000 ALTER TABLE `svjetlo` DISABLE KEYS */;
INSERT INTO `svjetlo` VALUES (1,'ok',1,0,90),(2,'ok',1,1,90),(3,'ok',1,1,90),(4,'ok',1,1,90),(5,'ok',1,1,90),(6,'kvar',2,0,0),(7,'popravak',2,1,0),(8,'ok',2,1,90),(9,'ok',2,0,90),(10,'Disconnected',1,0,0),(11,'Disconnected',1,0,0),(12,'Disconnected',1,0,0),(13,'Disconnected',2,0,0),(14,'Disconnected',2,0,0);
/*!40000 ALTER TABLE `svjetlo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `zona`
--

DROP TABLE IF EXISTS `zona`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `zona` (
  `id` int NOT NULL AUTO_INCREMENT,
  `ime` varchar(45) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `zona`
--

LOCK TABLES `zona` WRITE;
/*!40000 ALTER TABLE `zona` DISABLE KEYS */;
INSERT INTO `zona` VALUES (1,'Zona1'),(2,'Zona2'),(3,'Zona3'),(4,'neka zona'),(8,'test1'),(9,'test2'),(10,'Bla bla'),(11,'testtt');
/*!40000 ALTER TABLE `zona` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'rasvjetadb'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-01-28  2:06:33

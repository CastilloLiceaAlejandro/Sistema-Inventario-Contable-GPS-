-- MySQL dump 10.13  Distrib 8.0.26, for Win64 (x86_64)
--
-- Host: localhost    Database: gddds
-- ------------------------------------------------------
-- Server version	8.0.26

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
-- Table structure for table `permisos`
--

DROP TABLE IF EXISTS `permisos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `permisos` (
  `cventasPERMISO` tinyint NOT NULL,
  `rventasPERMISO` tinyint NOT NULL,
  `uventasPERMISO` tinyint NOT NULL,
  `dventasPERMISO` tinyint NOT NULL,
  `ccomprasPERMISO` tinyint NOT NULL,
  `rcomprasPERMISO` tinyint NOT NULL,
  `ucomprasPERMISO` tinyint NOT NULL,
  `dcomprasPERMISO` tinyint NOT NULL,
  `cusuariosPERMISO` tinyint NOT NULL,
  `rusuariosPERMISO` tinyint NOT NULL,
  `uusuariosPERMISO` tinyint NOT NULL,
  `dusuariosPERMISO` tinyint NOT NULL,
  `cproductosPERMISO` tinyint NOT NULL,
  `rproductosPERMISO` tinyint NOT NULL,
  `uproductosPERMISO` tinyint NOT NULL,
  `dproductosPERMISO` tinyint NOT NULL,
  `cinventarioPERMISO` tinyint NOT NULL,
  `rinventarioPERMISO` tinyint NOT NULL,
  `dinventarioPERMISO` tinyint NOT NULL,
  `cvitrinaPERMISO` tinyint NOT NULL,
  `rvitrinaPERMISO` tinyint NOT NULL,
  `dvitrinaPERMISO` tinyint NOT NULL,
  `idPUESTO` int NOT NULL,
  UNIQUE KEY `idPUESTO_UNIQUE` (`idPUESTO`),
  CONSTRAINT `idPUESTO` FOREIGN KEY (`idPUESTO`) REFERENCES `puesto` (`idPUESTO`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `permisos`
--

LOCK TABLES `permisos` WRITE;
/*!40000 ALTER TABLE `permisos` DISABLE KEYS */;
/*!40000 ALTER TABLE `permisos` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-10-26 17:35:08

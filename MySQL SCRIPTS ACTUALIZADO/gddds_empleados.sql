-- MySQL dump 10.13  Distrib 8.0.27, for Win64 (x86_64)
--
-- Host: localhost    Database: gddds
-- ------------------------------------------------------
-- Server version	8.0.27

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
-- Table structure for table `empleados`
--

DROP TABLE IF EXISTS `empleados`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `empleados` (
  `idEMPLEADOS` int NOT NULL AUTO_INCREMENT,
  `nombreEMPLEADOS` varchar(50) NOT NULL,
  `edadEMPLEADOS` varchar(3) NOT NULL,
  `telefonoEMPLEADOS` varchar(15) NOT NULL,
  `correoEMPLEADOS` varchar(50) NOT NULL,
  `contrasenaEMPLEADOS` varchar(80) NOT NULL,
  `turnoEMPLEADOS` varchar(15) NOT NULL,
  `idPUESTO` int NOT NULL,
  PRIMARY KEY (`idEMPLEADOS`),
  UNIQUE KEY `idEMPLEADOS_UNIQUE` (`idEMPLEADOS`),
  UNIQUE KEY `correoEMPLEADOS_UNIQUE` (`correoEMPLEADOS`),
  UNIQUE KEY `telefonoEMPLEADOS_UNIQUE` (`telefonoEMPLEADOS`),
  KEY `idPUESTO_idx` (`idPUESTO`),
  CONSTRAINT `idPUESTO` FOREIGN KEY (`idPUESTO`) REFERENCES `puesto` (`idPUESTO`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empleados`
--

LOCK TABLES `empleados` WRITE;
/*!40000 ALTER TABLE `empleados` DISABLE KEYS */;
INSERT INTO `empleados` VALUES (1,'admin','22','6631170316','admin@gmail.com','d033e22ae348aeb5660fc2140aec35850c4da997','Matutino',1),(4,'admin','22','6631170315','admin2@gmail.com','d033e22ae348aeb5660fc2140aec35850c4da997','Vespertino',1);
/*!40000 ALTER TABLE `empleados` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-11-18  1:30:51

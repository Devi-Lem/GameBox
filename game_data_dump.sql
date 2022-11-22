-- MySQL dump 10.13  Distrib 8.0.27, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: game_data
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
-- Table structure for table `age`
--

DROP TABLE IF EXISTS `age`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `age` (
  `id` int NOT NULL AUTO_INCREMENT,
  `age` varchar(250) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `age` (`age`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `age`
--

LOCK TABLES `age` WRITE;
/*!40000 ALTER TABLE `age` DISABLE KEYS */;
INSERT INTO `age` VALUES (3,'12+'),(4,'16+'),(5,'18+'),(1,'3+'),(2,'7+');
/*!40000 ALTER TABLE `age` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dev`
--

DROP TABLE IF EXISTS `dev`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `dev` (
  `id` int NOT NULL AUTO_INCREMENT,
  `dev` varchar(250) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `dev` (`dev`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dev`
--

LOCK TABLES `dev` WRITE;
/*!40000 ALTER TABLE `dev` DISABLE KEYS */;
INSERT INTO `dev` VALUES (5,'Activision Blizzard'),(8,'Bethesda Softworks'),(9,'Capcom'),(3,'Electronic Arts'),(7,'Microsoft Game Studios'),(10,'Naughty Dog'),(6,'Nintendo'),(2,'RockStar Games'),(1,'Ubisoft'),(4,'Valve Corporation');
/*!40000 ALTER TABLE `dev` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `genre`
--

DROP TABLE IF EXISTS `genre`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `genre` (
  `id` int NOT NULL AUTO_INCREMENT,
  `genre` varchar(250) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `gener` (`genre`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `genre`
--

LOCK TABLES `genre` WRITE;
/*!40000 ALTER TABLE `genre` DISABLE KEYS */;
INSERT INTO `genre` VALUES (8,'Action'),(10,'Adventure'),(6,'Battle Royale'),(7,'Indie'),(5,'Moba'),(13,'Open World'),(2,'Platformer'),(11,'Puzzle'),(12,'Racing'),(1,'RPG'),(15,'Sandbox'),(3,'Shooter'),(9,'Simulator'),(14,'Stealth'),(4,'Stratege');
/*!40000 ALTER TABLE `genre` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mag`
--

DROP TABLE IF EXISTS `mag`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mag` (
  `id` int NOT NULL AUTO_INCREMENT,
  `mag` varchar(250) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `mag` (`mag`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mag`
--

LOCK TABLES `mag` WRITE;
/*!40000 ALTER TABLE `mag` DISABLE KEYS */;
INSERT INTO `mag` VALUES (5,'Battle.net'),(3,'Epic Games Store'),(8,'eShop'),(9,'GOG '),(6,'Microsoft Store'),(4,'Origin'),(7,'PSS'),(1,'Steam'),(2,'Uplay');
/*!40000 ALTER TABLE `mag` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `main`
--

DROP TABLE IF EXISTS `main`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `main` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(250) NOT NULL,
  `genre` varchar(120) NOT NULL,
  `data` year NOT NULL,
  `dev` enum('Ubisoft','RockStar Games','Electronic Arts','Valve Corporation','Activision Blizzard','Nintendo','Microsoft Game Studios','Bethesda Softworks','Capcom','Naughty Dog') NOT NULL,
  `age` enum('3+','7+','12+','16+','18+','0+') NOT NULL,
  `plat` set('PC','Xbox','PS','Nintendo') NOT NULL,
  `mag` set('Steam','Uplay','EpicGamesStore','Origin','Battle.net','Microsoft Store','PSS','eShop','GOG') NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=90 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `main`
--

LOCK TABLES `main` WRITE;
/*!40000 ALTER TABLE `main` DISABLE KEYS */;
INSERT INTO `main` VALUES (1,'Assassin\'s Creed','Action,Open World,Stealth',2007,'Ubisoft','18+','PC,Xbox,PS','Steam,Uplay,EpicGamesStore,Microsoft Store,PSS'),(2,'Assassin’s Creed II','Action,Open World,Stealth',2009,'Ubisoft','18+','PC,Xbox,PS','Steam,Uplay,EpicGamesStore,Origin,Microsoft Store,PSS'),(3,'Assassin\'s Creed: Brotherhood','Action,Open World,Stealth',2010,'Ubisoft','18+','PC,Xbox,PS','Steam,Uplay,EpicGamesStore,Origin,Microsoft Store,PSS'),(4,'Assassin\'s Creed: Altair\'s Chronicles ','Action,Open World,Stealth',2008,'Ubisoft','18+','Nintendo','eShop'),(5,'Assassin’s Creed: Revelations','Action,Open World,Stealth',2011,'Ubisoft','18+','PC,Xbox,PS','Steam,Uplay,Microsoft Store,PSS'),(6,'Assassin\'s Creed III','Action,Open World,Stealth',2012,'Ubisoft','18+','PC,Xbox,PS','Steam,Uplay,EpicGamesStore,Microsoft Store,PSS'),(7,'Assassin\'s Creed III: Liberation','Action,Open World,Stealth',2012,'Ubisoft','18+','PC,Xbox,PS,Nintendo','Steam,Uplay,Microsoft Store,PSS,eShop'),(8,'Assassin’s Creed IV: Black Flag ','Action,Open World,Stealth',2013,'Ubisoft','18+','PC,Xbox,PS,Nintendo','Steam,Uplay,Origin,Microsoft Store,PSS,eShop'),(9,'Assassin’s Creed: Unity','Action,Open World,Stealth',2014,'Ubisoft','18+','PC,Xbox,PS','Steam,Uplay,EpicGamesStore,Microsoft Store,PSS'),(10,'Assassin\'s Creed:Rogue ','Action,Open World,Stealth',2014,'Ubisoft','18+','PC,Xbox,PS','Steam,Uplay,EpicGamesStore,Microsoft Store,PSS'),(11,'Assassin\'s Creed Syndicate','Action,Open World,Stealth',2015,'Ubisoft','18+','PC,Xbox,PS','Steam,Uplay,EpicGamesStore,Microsoft Store,PSS'),(12,'Assassin\'s Creed Origins','Action,Open World,Stealth',2017,'Ubisoft','18+','PC,Xbox,PS','Steam,Uplay,EpicGamesStore,Origin,Microsoft Store,PSS'),(13,'Assassin’s Creed Odyssey','Action,Open World,Stealth',2018,'Ubisoft','18+','PC,Xbox,PS,Nintendo','Steam,Uplay,EpicGamesStore,Origin,Microsoft Store,PSS,eShop'),(14,'Assassin\'s Creed Valhalla ','Action,Open World,Stealth',2020,'Ubisoft','18+','PC,Xbox,PS','Steam,Uplay,EpicGamesStore,Microsoft Store,PSS'),(15,'Far Cry','Action,Shooter,Stealth',2004,'Ubisoft','16+','PC','Steam,EpicGamesStore'),(16,'Far Cry Instincts ','Action,Shooter,Stealth',2005,'Ubisoft','16+','Xbox','Microsoft Store'),(17,'Far Cry 2','Action,Shooter,Stealth',2008,'Ubisoft','16+','PC,Xbox,PS','Steam,Uplay,EpicGamesStore,Microsoft Store,PSS'),(18,'Far Cry 3','Action,Shooter,Stealth',2012,'Ubisoft','16+','PC,Xbox,PS','Steam,Uplay,EpicGamesStore,Origin,Microsoft Store,PSS'),(19,'Far Cry 3: Blood Dragon','Action,Shooter,Stealth',2013,'Ubisoft','16+','PC,Xbox,PS','Steam,Uplay,EpicGamesStore,Origin,Microsoft Store,PSS'),(20,'Far Cry 4','Action,Shooter,Open World,Stealth',2014,'Ubisoft','18+','PC,Xbox,PS','Steam,Uplay,EpicGamesStore,Origin,Microsoft Store,PSS'),(21,'Far Cry Primal','Action,Shooter,Open World,Stealth',2016,'Ubisoft','18+','PC,Xbox,PS','Steam,Uplay,EpicGamesStore,Origin,Microsoft Store,PSS'),(22,'Far Cry 5','Action,Shooter,Open World,Stealth',2018,'Ubisoft','18+','PC,Xbox,PS','Steam,Uplay,EpicGamesStore,Origin,Microsoft Store,PSS'),(23,'Far Cry New Dawn','Action,Shooter,Open World,Stealth',2019,'Ubisoft','18+','PC,Xbox,PS','Steam,Uplay,EpicGamesStore,Origin,Microsoft Store,PSS'),(24,'Far Cry 6','Action,Shooter,Open World,Stealth',2021,'Ubisoft','18+','PC,Xbox,PS','Steam,Uplay,EpicGamesStore,Origin,Microsoft Store,PSS'),(25,'For Honor','Action',2017,'Ubisoft','18+','PC,Xbox,PS','Steam,Uplay,EpicGamesStore,Origin,Microsoft Store,PSS'),(26,'Tom Clancy’s Rainbow Six Siege','Stratege,Shooter',2015,'Ubisoft','18+','PC,Xbox,PS','Steam,Uplay,EpicGamesStore,Origin,Microsoft Store,PSS'),(27,'Tom Clancy’s: The Division','Action,Shooter,Open World',2016,'Ubisoft','18+','PC,Xbox,PS','Steam,Uplay,EpicGamesStore,Microsoft Store,PSS'),(28,'Grand Theft Auto 2','Adventure,Action,Open World',2000,'RockStar Games','18+','PC,PS','Steam,PSS'),(29,'Grand Theft Auto III','Action,Open World',2002,'RockStar Games','18+','PC,Xbox,PS','Steam,Microsoft Store,PSS'),(30,'Grand Theft Auto: San Andreas','Action,Open World',2004,'RockStar Games','18+','PC,Xbox,PS','Steam,EpicGamesStore,Microsoft Store,PSS'),(31,'Grand Theft Auto: Liberty City Stories','Action,Open World',2005,'RockStar Games','18+','PS','PSS'),(32,'Grand Theft Auto IV','Action,Open World',2008,'RockStar Games','18+','PC,Xbox,PS','Steam,Microsoft Store,PSS'),(33,'Red Dead Revolver','Action,Shooter,Open World',2004,'RockStar Games','18+','Xbox,PS','Microsoft Store,PSS'),(34,'Red Dead Redemption','Action,Shooter,Open World',2010,'RockStar Games','18+','Xbox,PS','Microsoft Store,PSS'),(35,'Grand Theft Auto V','Action,Open World',2013,'RockStar Games','18+','PC,Xbox,PS','Steam,EpicGamesStore,Microsoft Store,PSS'),(36,'Grand Theft Auto Online','Action,Open World',2013,'RockStar Games','18+','PC,Xbox,PS','Steam,EpicGamesStore,Microsoft Store,PSS'),(37,'Red Dead Redemption 2','Action,Open World',2018,'RockStar Games','18+','PC,Xbox,PS','Steam,EpicGamesStore,Microsoft Store,PSS'),(38,'Red Dead Online','Action,Open World',2019,'RockStar Games','18+','PC,Xbox,PS','Steam,EpicGamesStore,Microsoft Store,PSS'),(39,'Need for Speed: Most Wanted','Racing,Open World',2005,'Electronic Arts','12+','PC,Xbox,PS,Nintendo','Steam,Origin,Microsoft Store,PSS,eShop'),(40,'Battlefield 3','Action,Shooter',2011,'Electronic Arts','18+','PC,Xbox,PS','Steam,Origin,Microsoft Store,PSS'),(41,'Crysis 2','Action,Shooter',2011,'Electronic Arts','18+','PC,Xbox,PS,Nintendo','Steam,Origin,Microsoft Store,PSS'),(42,'Battlefield 4','Shooter',2013,'Electronic Arts','18+','PC,Xbox,PS','Steam,Origin,Microsoft Store,PSS'),(43,'Crysis 3','Action,Shooter,Stealth',2013,'Electronic Arts','18+','PC,Xbox,PS,Nintendo','Steam,EpicGamesStore,Origin,Microsoft Store,PSS,eShop'),(44,'The Sims 4','Simulator',2014,'Electronic Arts','7+','PC,Xbox,PS','Steam,Origin,Microsoft Store,PSS'),(45,'Battlefield 1','Shooter',2016,'Electronic Arts','16+','PC,Xbox,PS','Steam,Origin,Microsoft Store,PSS'),(46,'Need for Speed: Payback','Racing',2017,'Electronic Arts','12+','PC,Xbox,PS','Steam,Origin,Microsoft Store,PSS'),(47,'Star Wars: Battlefront II','Action,Shooter',2017,'Electronic Arts','16+','PC,Xbox,PS','Steam,EpicGamesStore,Origin,Microsoft Store,PSS'),(48,'FIFA 21','Simulator',2020,'Electronic Arts','3+','PC,Xbox,PS,Nintendo','Steam,Origin,Microsoft Store,PSS,eShop'),(49,'Half-Life','Shooter',1998,'Valve Corporation','16+','PC,PS','Steam,PSS'),(50,'Counter-Strike','Shooter',2000,'Valve Corporation','16+','PC,Xbox','Steam,Microsoft Store'),(51,'Counter-Strike: Source','Shooter',2004,'Valve Corporation','16+','PC','Steam'),(52,'Half-Life 2','Shooter',2004,'Valve Corporation','16+','PC,PS','Steam,PSS'),(53,'Garry’s Mod','Shooter,Sandbox',2005,'Valve Corporation','0+','PC','Steam'),(54,'Team Fortress 2','Shooter',2007,'Valve Corporation','16+','PC,Xbox,PS','Steam,Microsoft Store,PSS'),(55,'Portal','Puzzle',2007,'Valve Corporation','12+','PC,Xbox,PS','Steam,Microsoft Store,PSS'),(56,'Left 4 Dead','Action,Shooter',2008,'Valve Corporation','18+','PC,Xbox','Steam,Microsoft Store'),(57,'Left 4 Dead 2','Action,Shooter',2009,'Valve Corporation','18+','PC,Xbox','Steam,Microsoft Store'),(58,'Portal 2','Puzzle',2011,'Valve Corporation','12+','PC,Xbox,PS','Steam,Microsoft Store,PSS'),(59,'Counter-Strike: Global Offensive','Action,Shooter',2012,'Valve Corporation','18+','PC,Xbox,PS','Steam,Microsoft Store,PSS'),(60,'Dota 2','Stratege',2013,'Valve Corporation','12+','PC','Steam'),(61,'Warcraft: Orcs & Humans','Stratege',1994,'Activision Blizzard','12+','PC','GOG'),(62,'Diablo','Stratege',1996,'Activision Blizzard','16+','PC','Battle.net,GOG'),(63,'StarCraft','Stratege',1998,'Activision Blizzard','16+','PC','Battle.net'),(64,'Diablo II','Stratege',2000,'Activision Blizzard','16+','PC','Battle.net'),(65,'World of Warcraft','Stratege',2004,'Activision Blizzard','16+','PC','Battle.net'),(66,'Diablo III','Stratege',2012,'Activision Blizzard','16+','PC,Xbox,PS,Nintendo','Battle.net,Microsoft Store,PSS,eShop'),(67,'Hearthstone','Stratege',2014,'Activision Blizzard','0+','PC','Battle.net'),(68,'Heroes of the Storm','Stratege',2015,'Activision Blizzard','12+','PC','Battle.net'),(69,'Overwatch','Shooter',2016,'Activision Blizzard','12+','PC,Xbox,PS,Nintendo','Battle.net,Microsoft Store,PSS,eShop'),(70,'Halo 3','Action,Shooter',2007,'Microsoft Game Studios','16+','PC,Xbox','Steam,Microsoft Store'),(71,'Forza Horizon 4','Racing,Open World',2018,'Microsoft Game Studios','3+','PC,Xbox','Steam,Microsoft Store'),(72,'Sea of Thieves','Adventure,Open World,Sandbox',2018,'Microsoft Game Studios','12+','PC,Xbox','Steam,Microsoft Store'),(73,'Grounded','Adventure,Open World',2020,'Microsoft Game Studios','0+','PC,Xbox','Steam,Microsoft Store'),(74,'Ori and the Will of the Wisps','Adventure',2020,'Microsoft Game Studios','0+','PC,Xbox','Steam,Microsoft Store'),(75,'Bleeding Edge','Action,Shooter',2020,'Microsoft Game Studios','12+','PC,Xbox','Steam,Microsoft Store'),(76,'Gears Tactics','Stratege',2020,'Microsoft Game Studios','0+','PC,Xbox','Steam,Microsoft Store'),(77,'Halo Infinite','Action,Shooter',2021,'Microsoft Game Studios','16+','PC,Xbox','Steam,Microsoft Store'),(78,'Forza Horizon 5','Racing,Open World',2021,'Microsoft Game Studios','3+','PC,Xbox','Steam,Microsoft Store'),(79,'Age of Empires IV','Stratege',2021,'Microsoft Game Studios','0+','PC','Steam'),(80,'Crash Team Racing','Racing',1999,'Naughty Dog','7+','PS','PSS'),(81,'Jak 3','Shooter',2004,'Naughty Dog','12+','PS','PSS'),(82,'The Last of Us','Adventure',2013,'Naughty Dog','18+','PS','PSS'),(83,'Uncharted 2: Among Thieves','Adventure,Shooter',2009,'Naughty Dog','16+','PS','PSS'),(84,'Uncharted 3: Drake’s Deception','Adventure,Shooter',2011,'Naughty Dog','16+','PS','PSS'),(85,'The Last of Us Part II','Adventure',2020,'Naughty Dog','18+','PS','PSS'),(86,'Uncharted 4: A Thief’s End','Adventure,Shooter',2016,'Naughty Dog','16+','PS','PSS'),(87,'Uncharted: The Lost Legacy','Shooter',2017,'Naughty Dog','16+','PS','PSS'),(88,'Jak X: Combat Racing','Racing',2005,'Naughty Dog','12+','PS','PSS'),(89,'Jak II','Platformer',2003,'Naughty Dog','12+','PS','PSS');
/*!40000 ALTER TABLE `main` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `plat`
--

DROP TABLE IF EXISTS `plat`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `plat` (
  `id` int NOT NULL AUTO_INCREMENT,
  `plat` varchar(250) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `plat` (`plat`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `plat`
--

LOCK TABLES `plat` WRITE;
/*!40000 ALTER TABLE `plat` DISABLE KEYS */;
INSERT INTO `plat` VALUES (4,'Nintendo'),(1,'PC'),(3,'PS'),(2,'Xbox');
/*!40000 ALTER TABLE `plat` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(250) NOT NULL,
  `login` varchar(250) NOT NULL,
  `pass` varchar(250) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `name_UNIQUE` (`name`),
  UNIQUE KEY `login_UNIQUE` (`login`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (1,'admin','admin','admin'),(2,'user1','user1','qwerty'),(3,'user2','user2','1'),(4,'login','login','1'),(5,'user3','user3','user3'),(6,'kekw','kekw','pog'),(7,'1','1','1');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user_choice`
--

DROP TABLE IF EXISTS `user_choice`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user_choice` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_user` int NOT NULL,
  `id_game` int NOT NULL,
  `game_dev` enum('Ubisoft','RockStar Games','Electronic Arts','Valve Corporation','Activision Blizzard','Nintendo','Microsoft Game Studios','Bethesda Softworks','Capcom','Naughty Dog') NOT NULL,
  `game_genre` varchar(120) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=66 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user_choice`
--

LOCK TABLES `user_choice` WRITE;
/*!40000 ALTER TABLE `user_choice` DISABLE KEYS */;
INSERT INTO `user_choice` VALUES (24,2,28,'RockStar Games','Adventure,Action,Open World'),(25,2,45,'Electronic Arts','Shooter'),(26,2,58,'Valve Corporation','Puzzle'),(28,2,49,'Valve Corporation','Shooter'),(30,2,14,'Ubisoft','Action,Open World,Stealth'),(32,2,46,'Electronic Arts','Racing'),(33,2,39,'Electronic Arts','Racing,Open World'),(34,2,28,'RockStar Games','Adventure,Action,Open World'),(35,2,39,'Electronic Arts','Racing,Open World'),(36,2,39,'Electronic Arts','Racing,Open World'),(37,2,28,'RockStar Games','Adventure,Action,Open World'),(38,2,28,'RockStar Games','Adventure,Action,Open World'),(39,2,28,'RockStar Games','Adventure,Action,Open World'),(40,2,45,'Electronic Arts','Shooter'),(41,2,58,'Valve Corporation','Puzzle'),(42,2,28,'RockStar Games','Adventure,Action,Open World'),(44,4,22,'Ubisoft','Action,Shooter,Open World,Stealth'),(45,4,56,'Valve Corporation','Action,Shooter'),(46,4,44,'Electronic Arts','Simulator'),(48,4,14,'Ubisoft','Action,Open World,Stealth'),(49,4,46,'Electronic Arts','Racing'),(50,5,3,'Ubisoft','Action,Open World,Stealth'),(52,5,45,'Electronic Arts','Shooter'),(54,5,37,'RockStar Games','Action,Open World'),(55,5,32,'RockStar Games','Action,Open World'),(58,6,12,'Ubisoft','Action,Open World,Stealth'),(59,6,32,'RockStar Games','Action,Open World'),(61,6,49,'Valve Corporation','Shooter'),(62,6,60,'Valve Corporation','Stratege'),(63,1,18,'Ubisoft','Action,Shooter,Stealth'),(64,1,33,'RockStar Games','Action,Shooter,Open World'),(65,1,37,'RockStar Games','Action,Open World');
/*!40000 ALTER TABLE `user_choice` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-11-22 23:02:07

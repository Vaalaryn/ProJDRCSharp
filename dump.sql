-- --------------------------------------------------------
-- Hôte :                        
-- Version du serveur:           5.7.24 - MySQL Community Server (GPL)
-- SE du serveur:                Win64
-- HeidiSQL Version:             9.5.0.5332
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Listage de la structure de la base pour projdr
CREATE DATABASE IF NOT EXISTS `projdr` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `projdr`;

-- Listage de la structure de la table projdr. t_classes
CREATE TABLE IF NOT EXISTS `t_classes` (
  `id_classe` int(11) NOT NULL AUTO_INCREMENT,
  `PV` smallint(2) NOT NULL,
  `PM` smallint(6) NOT NULL,
  `PF` smallint(6) NOT NULL,
  `magie` smallint(6) NOT NULL,
  `dext` smallint(6) NOT NULL,
  `observ` smallint(6) NOT NULL,
  `intel` smallint(6) NOT NULL,
  `chance` smallint(6) NOT NULL,
  `charisme` smallint(6) NOT NULL,
  `force` smallint(6) NOT NULL,
  `nom` varchar(50) NOT NULL,
  PRIMARY KEY (`id_classe`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

-- Listage des données de la table projdr.t_classes : ~4 rows (environ)
/*!40000 ALTER TABLE `t_classes` DISABLE KEYS */;
INSERT INTO `t_classes` (`id_classe`, `PV`, `PM`, `PF`, `magie`, `dext`, `observ`, `intel`, `chance`, `charisme`, `force`, `nom`) VALUES
	(1, 50, 50, 50, 5, 5, 5, 5, 5, 5, 5, 'Guerrier'),
	(2, 60, 60, 60, 6, 6, 6, 6, 6, 6, 6, 'Mage'),
	(3, 70, 70, 70, 7, 7, 7, 7, 7, 7, 7, 'Voleur'),
	(4, 80, 80, 80, 8, 8, 8, 8, 8, 8, 8, 'Paladin');
/*!40000 ALTER TABLE `t_classes` ENABLE KEYS */;

-- Listage de la structure de la table projdr. t_log
CREATE TABLE IF NOT EXISTS `t_log` (
  `id_log` int(11) NOT NULL,
  `id_partie` varchar(16) NOT NULL,
  `id_perso` int(11) DEFAULT NULL,
  `type` tinyint(4) NOT NULL,
  `date` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `image` longblob,
  `text` text,
  PRIMARY KEY (`id_log`),
  KEY `FK_t_log_t_partie` (`id_partie`),
  KEY `FK_t_log_t_personnage` (`id_perso`),
  CONSTRAINT `FK_t_log_t_partie` FOREIGN KEY (`id_partie`) REFERENCES `t_partie` (`id_partie`),
  CONSTRAINT `FK_t_log_t_personnage` FOREIGN KEY (`id_perso`) REFERENCES `t_personnage` (`id_perso`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Listage des données de la table projdr.t_log : ~0 rows (environ)
/*!40000 ALTER TABLE `t_log` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_log` ENABLE KEYS */;

-- Listage de la structure de la table projdr. t_partie
CREATE TABLE IF NOT EXISTS `t_partie` (
  `id_partie` varchar(16) NOT NULL,
  `nom` varchar(50) NOT NULL DEFAULT '0',
  `description` mediumtext,
  PRIMARY KEY (`id_partie`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Listage des données de la table projdr.t_partie : ~0 rows (environ)
/*!40000 ALTER TABLE `t_partie` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_partie` ENABLE KEYS */;

-- Listage de la structure de la table projdr. t_personnage
CREATE TABLE IF NOT EXISTS `t_personnage` (
  `id_perso` int(11) NOT NULL AUTO_INCREMENT,
  `id_partie` varchar(16) NOT NULL DEFAULT '0',
  `id_util` int(11) NOT NULL,
  `nom` varchar(50) NOT NULL,
  `prenom` varchar(50) NOT NULL,
  `MJ` bit(1) DEFAULT NULL,
  `Actif` bit(1) DEFAULT b'1',
  `PV` smallint(6) NOT NULL,
  `PM` smallint(6) NOT NULL,
  `XP` smallint(6) NOT NULL,
  `LVL` smallint(6) NOT NULL,
  `PF` smallint(6) NOT NULL,
  `magie` smallint(6) NOT NULL,
  `dext` smallint(6) NOT NULL,
  `observ` smallint(6) NOT NULL,
  `intel` smallint(6) NOT NULL,
  `chance` smallint(6) NOT NULL,
  `charisme` smallint(6) NOT NULL,
  `force` smallint(6) NOT NULL,
  `bloc` varchar(50) NOT NULL,
  `classe` int(11) NOT NULL,
  PRIMARY KEY (`id_perso`),
  KEY `FK_t_personnage_t_partie` (`id_partie`),
  KEY `FK_t_personnage_t_utilisateur` (`id_util`),
  KEY `FK_t_personnage_t_classes` (`classe`),
  CONSTRAINT `FK_t_personnage_t_classes` FOREIGN KEY (`classe`) REFERENCES `t_classes` (`id_classe`),
  CONSTRAINT `FK_t_personnage_t_partie` FOREIGN KEY (`id_partie`) REFERENCES `t_partie` (`id_partie`),
  CONSTRAINT `FK_t_personnage_t_utilisateur` FOREIGN KEY (`id_util`) REFERENCES `t_utilisateur` (`id_util`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Listage des données de la table projdr.t_personnage : ~0 rows (environ)
/*!40000 ALTER TABLE `t_personnage` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_personnage` ENABLE KEYS */;

-- Listage de la structure de la table projdr. t_utilisateur
CREATE TABLE IF NOT EXISTS `t_utilisateur` (
  `id_util` int(11) NOT NULL AUTO_INCREMENT,
  `mail` varchar(50) NOT NULL,
  `pseudo` varchar(50) NOT NULL,
  `mdp` varchar(50) NOT NULL,
  `avatar` longblob,
  PRIMARY KEY (`id_util`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- Listage des données de la table projdr.t_utilisateur : ~2 rows (environ)
/*!40000 ALTER TABLE `t_utilisateur` DISABLE KEYS */;
INSERT INTO `t_utilisateur` (`id_util`, `mail`, `pseudo`, `mdp`, `avatar`) VALUES
	(1, 'enzo.caron@mail.fr', 'Nzo', 'azerty', NULL),
	(2, 'machin@machin.com', 'brice', '1234', NULL);
/*!40000 ALTER TABLE `t_utilisateur` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;

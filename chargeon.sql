-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : lun. 23 mai 2022 à 08:36
-- Version du serveur :  5.7.31
-- Version de PHP : 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `chargeon`
--

-- --------------------------------------------------------

--
-- Structure de la table `chargeur`
--

DROP TABLE IF EXISTS `chargeur`;
CREATE TABLE IF NOT EXISTS `chargeur` (
  `num_serie` int(11) NOT NULL AUTO_INCREMENT,
  `type` varchar(255) NOT NULL COMMENT 'Extérieur / intérieur',
  `protection` varchar(255) NOT NULL COMMENT 'IP 44 ou 55 etc...',
  `puissance` varchar(255) NOT NULL COMMENT 'KW',
  `priorite` varchar(255) NOT NULL COMMENT 'Haute prio = 1\r\nMoyenne = 2\r\nBasse = 3',
  `latitude` varchar(255) NOT NULL,
  `longitude` varchar(255) NOT NULL,
  `altitude` varchar(255) NOT NULL,
  PRIMARY KEY (`num_serie`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `cout`
--

DROP TABLE IF EXISTS `cout`;
CREATE TABLE IF NOT EXISTS `cout` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `montant` varchar(255) NOT NULL,
  `support` varchar(255) DEFAULT NULL,
  `zone` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `intervention`
--

DROP TABLE IF EXISTS `intervention`;
CREATE TABLE IF NOT EXISTS `intervention` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_cout` int(11) NOT NULL,
  `id_chargeur` int(11) NOT NULL,
  `mission` int(11) NOT NULL COMMENT 'Installation 1/entretien 2 / Panne 3',
  `temps` varchar(255) NOT NULL,
  `concurrence` int(11) NOT NULL COMMENT '1 = concurrence proche\r\n0 = pas de concurrence',
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `technicien`
--

DROP TABLE IF EXISTS `technicien`;
CREATE TABLE IF NOT EXISTS `technicien` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_intervention` int(11) NOT NULL,
  `niveau` varchar(255) NOT NULL COMMENT 'B1/B2 etc...',
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

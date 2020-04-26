-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Creato il: Apr 26, 2020 alle 09:59
-- Versione del server: 10.3.22-MariaDB-0+deb10u1
-- Versione PHP: 7.3.14-1~deb10u1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `bbs`
--
CREATE DATABASE IF NOT EXISTS `bbs` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `bbs`;

-- --------------------------------------------------------

--
-- Struttura della tabella `Log`
--

CREATE TABLE IF NOT EXISTS `Log` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `DateTime` datetime NOT NULL DEFAULT current_timestamp(),
  `Remote` varchar(24) NOT NULL DEFAULT '',
  `Level` tinyint(4) NOT NULL DEFAULT 1,
  `Description` varchar(250) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `DateTime` (`DateTime`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Events log';

--
-- RELAZIONI PER TABELLA `Log`:
--

-- --------------------------------------------------------

--
-- Struttura della tabella `Logins`
--

CREATE TABLE IF NOT EXISTS `Logins` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `UserId` varchar(30) NOT NULL,
  `DateTime` datetime NOT NULL DEFAULT current_timestamp(),
  `From` varchar(24) NOT NULL DEFAULT '',
  `Success` tinyint(1) NOT NULL DEFAULT 0,
  PRIMARY KEY (`ID`),
  KEY `UserId` (`UserId`),
  KEY `DateTime` (`DateTime`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Users logins';

--
-- RELAZIONI PER TABELLA `Logins`:
--   `UserId`
--       `Users` -> `userid`
--   `UserId`
--       `Users` -> `userid`
--

-- --------------------------------------------------------

--
-- Struttura della tabella `MessageAreas`
--

CREATE TABLE IF NOT EXISTS `MessageAreas` (
  `ID` varchar(20) NOT NULL,
  `Description` varchar(200) NOT NULL DEFAULT '',
  `FIDOID` varchar(30) NOT NULL DEFAULT '',
  `AREAGROUP` varchar(20) NOT NULL DEFAULT '',
  `AllowedGroupRead` varchar(30) DEFAULT '',
  `AllowedGroupWrite` varchar(30) DEFAULT '',
  PRIMARY KEY (`ID`),
  KEY `Description` (`Description`),
  KEY `FIDOID` (`FIDOID`),
  KEY `MessageAreas_AreaGroupId_MessageAreasGroups` (`AREAGROUP`),
  KEY `MessageAreas_AllowedRead_UsersGroups` (`AllowedGroupRead`),
  KEY `MessageAreas_AllowedWrite_UsersGroups` (`AllowedGroupWrite`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Message Areas List';

--
-- RELAZIONI PER TABELLA `MessageAreas`:
--   `AREAGROUP`
--       `MessageAreasGroups` -> `ID`
--   `AllowedGroupRead`
--       `UsersGroups` -> `Groupid`
--   `AllowedGroupWrite`
--       `UsersGroups` -> `Groupid`
--   `AllowedGroupRead`
--       `UsersGroups` -> `groupid`
--   `AllowedGroupWrite`
--       `UsersGroups` -> `groupid`
--   `AREAGROUP`
--       `MessageAreasGroups` -> `ID`
--

-- --------------------------------------------------------

--
-- Struttura della tabella `MessageAreasGroups`
--

CREATE TABLE IF NOT EXISTS `MessageAreasGroups` (
  `ID` varchar(20) NOT NULL,
  `Description` varchar(200) NOT NULL DEFAULT '',
  `AllowedGroupId` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `Description` (`Description`),
  KEY `MessageAreasGroups_Allowed_UsersGroups` (`AllowedGroupId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- RELAZIONI PER TABELLA `MessageAreasGroups`:
--   `AllowedGroupId`
--       `UsersGroups` -> `Groupid`
--   `AllowedGroupId`
--       `UsersGroups` -> `groupid`
--

-- --------------------------------------------------------

--
-- Struttura della tabella `MessageRead`
--

CREATE TABLE IF NOT EXISTS `MessageRead` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `MessgeId` int(11) NOT NULL,
  `UserId` varchar(30) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `MessageId` (`MessgeId`),
  KEY `UserId` (`UserId`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Flags for messages read';

--
-- RELAZIONI PER TABELLA `MessageRead`:
--   `MessgeId`
--       `Messages` -> `ID`
--   `UserId`
--       `Users` -> `userid`
--

-- --------------------------------------------------------

--
-- Struttura della tabella `Messages`
--

CREATE TABLE IF NOT EXISTS `Messages` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Area` varchar(20) DEFAULT NULL,
  `MessageFrom` varchar(100) NOT NULL,
  `MessageTo` varchar(100) DEFAULT NULL,
  `Subject` varchar(72) NOT NULL DEFAULT '',
  `DateTime` datetime NOT NULL DEFAULT current_timestamp(),
  `FidoID` varchar(50) NOT NULL DEFAULT '',
  `FidoReplyTo` varchar(50) NOT NULL DEFAULT '',
  `TimesRead` int(11) NOT NULL DEFAULT 0,
  `OrigZone` int(11) NOT NULL DEFAULT 0,
  `OrigNet` int(11) NOT NULL DEFAULT 0,
  `OrigNode` int(11) NOT NULL DEFAULT 0,
  `OrigPoint` int(11) NOT NULL DEFAULT 0,
  `DestZone` int(11) NOT NULL DEFAULT 0,
  `DestNet` int(11) NOT NULL DEFAULT 0,
  `DestNode` int(11) NOT NULL DEFAULT 0,
  `DestPoint` int(11) NOT NULL DEFAULT 0,
  `Body` text NOT NULL DEFAULT '',
  PRIMARY KEY (`ID`),
  KEY `Area` (`Area`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Messages';

--
-- RELAZIONI PER TABELLA `Messages`:
--   `Area`
--       `MessageAreas` -> `ID`
--   `Area`
--       `MessageAreas` -> `ID`
--

-- --------------------------------------------------------

--
-- Struttura della tabella `MessageSeenBy`
--

CREATE TABLE IF NOT EXISTS `MessageSeenBy` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `MessageId` int(11) NOT NULL,
  `SeenBy` varchar(50) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `MessageId` (`MessageId`),
  KEY `SeenBy` (`SeenBy`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='System that already received the message';

--
-- RELAZIONI PER TABELLA `MessageSeenBy`:
--   `MessageId`
--       `Messages` -> `ID`
--   `MessageId`
--       `Messages` -> `ID`
--

-- --------------------------------------------------------

--
-- Struttura della tabella `Users`
--

CREATE TABLE IF NOT EXISTS `Users` (
  `userid` varchar(30) NOT NULL,
  `realname` varchar(50) NOT NULL DEFAULT '',
  `city` varchar(50) NOT NULL DEFAULT '',
  `nation` varchar(50) NOT NULL DEFAULT '',
  `password` varchar(32) NOT NULL COMMENT 'MD5 Hash of the password',
  `status` varchar(1) NOT NULL DEFAULT '0',
  `signature` text NOT NULL DEFAULT '',
  `LastLoginFrom` varchar(24) NOT NULL DEFAULT '0.0.0.0',
  `LastLoginDate` datetime NOT NULL DEFAULT current_timestamp(),
  `Registered` datetime NOT NULL DEFAULT current_timestamp(),
  `LastPasswordModify` datetime NOT NULL DEFAULT current_timestamp(),
  `email` varchar(100) NOT NULL DEFAULT '',
  `Locked` tinyint(1) NOT NULL DEFAULT 0,
  PRIMARY KEY (`userid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='BBS users' ROW_FORMAT=COMPACT;

--
-- RELAZIONI PER TABELLA `Users`:
--

-- --------------------------------------------------------

--
-- Struttura della tabella `UsersGroups`
--

CREATE TABLE IF NOT EXISTS `UsersGroups` (
  `Groupid` varchar(30) NOT NULL DEFAULT '',
  `Description` varchar(200) NOT NULL DEFAULT '',
  PRIMARY KEY (`Groupid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Users groups definition' ROW_FORMAT=COMPACT;

--
-- RELAZIONI PER TABELLA `UsersGroups`:
--

-- --------------------------------------------------------

--
-- Struttura della tabella `UsersGroupsLinks`
--

CREATE TABLE IF NOT EXISTS `UsersGroupsLinks` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `userid` varchar(30) DEFAULT NULL,
  `groupid` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `userid` (`userid`),
  KEY `UsersGroupsLinks_groupid_groups` (`groupid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Users groups' ROW_FORMAT=COMPACT;

--
-- RELAZIONI PER TABELLA `UsersGroupsLinks`:
--   `groupid`
--       `UsersGroups` -> `Groupid`
--   `userid`
--       `Users` -> `userid`
--   `groupid`
--       `UsersGroups` -> `groupid`
--   `userid`
--       `Users` -> `userid`
--

--
-- Limiti per le tabelle scaricate
--

--
-- Limiti per la tabella `Logins`
--
ALTER TABLE `Logins`
  ADD CONSTRAINT `Logins_UserId_Users` FOREIGN KEY (`UserId`) REFERENCES `Users` (`userid`);

--
-- Limiti per la tabella `MessageAreas`
--
ALTER TABLE `MessageAreas`
  ADD CONSTRAINT `MessageAreas_AllowedRead_UsersGroups` FOREIGN KEY (`AllowedGroupRead`) REFERENCES `UsersGroups` (`groupid`) ON DELETE SET NULL,
  ADD CONSTRAINT `MessageAreas_AllowedWrite_UsersGroups` FOREIGN KEY (`AllowedGroupWrite`) REFERENCES `UsersGroups` (`groupid`) ON DELETE SET NULL,
  ADD CONSTRAINT `MessageAreas_AreaGroupId_MessageAreasGroups` FOREIGN KEY (`AREAGROUP`) REFERENCES `MessageAreasGroups` (`ID`);

--
-- Limiti per la tabella `MessageAreasGroups`
--
ALTER TABLE `MessageAreasGroups`
  ADD CONSTRAINT `MessageAreasGroups_Allowed_UsersGroups` FOREIGN KEY (`AllowedGroupId`) REFERENCES `UsersGroups` (`groupid`) ON DELETE SET NULL;

--
-- Limiti per la tabella `MessageRead`
--
ALTER TABLE `MessageRead`
  ADD CONSTRAINT `MessageRead_MessageId_Messages` FOREIGN KEY (`MessgeId`) REFERENCES `Messages` (`ID`),
  ADD CONSTRAINT `MessageRead_UserId_Users` FOREIGN KEY (`UserId`) REFERENCES `Users` (`userid`);

--
-- Limiti per la tabella `Messages`
--
ALTER TABLE `Messages`
  ADD CONSTRAINT `Message_Area_MessageAreas` FOREIGN KEY (`Area`) REFERENCES `MessageAreas` (`ID`) ON DELETE SET NULL;

--
-- Limiti per la tabella `MessageSeenBy`
--
ALTER TABLE `MessageSeenBy`
  ADD CONSTRAINT `MessageSeenBy_MsgId_Messages` FOREIGN KEY (`MessageId`) REFERENCES `Messages` (`ID`);

--
-- Limiti per la tabella `UsersGroupsLinks`
--
ALTER TABLE `UsersGroupsLinks`
  ADD CONSTRAINT `UsersGroupsLinks_groupid_groups` FOREIGN KEY (`groupid`) REFERENCES `UsersGroups` (`groupid`),
  ADD CONSTRAINT `UsersGroupsLinks_userid_users` FOREIGN KEY (`userid`) REFERENCES `Users` (`userid`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

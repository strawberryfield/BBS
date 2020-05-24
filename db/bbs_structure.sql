-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Creato il: Mag 24, 2020 alle 11:47
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
-- Struttura della tabella `FidoNetworks`
--

CREATE TABLE `FidoNetworks` (
  `ID` varchar(30) NOT NULL DEFAULT '' COMMENT 'Fido style network identifier',
  `zone` int(11) NOT NULL DEFAULT 0,
  `net` int(11) NOT NULL DEFAULT 0,
  `host` int(11) NOT NULL DEFAULT 0,
  `point` int(11) NOT NULL DEFAULT 0,
  `description` varchar(80) NOT NULL COMMENT 'Network description'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='List of fdo-style networks';

-- --------------------------------------------------------

--
-- Struttura della tabella `Log`
--

CREATE TABLE `Log` (
  `id` int(11) NOT NULL,
  `DateTime` datetime NOT NULL DEFAULT current_timestamp() COMMENT 'Timestamp of the event, set to current timestamp by default',
  `Remote` varchar(24) NOT NULL DEFAULT '' COMMENT 'Remote ip address and port of the client (if applicable)',
  `Level` tinyint(4) NOT NULL DEFAULT 1 COMMENT 'Severity level',
  `Description` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Events log';

-- --------------------------------------------------------

--
-- Struttura della tabella `Logins`
--

CREATE TABLE `Logins` (
  `ID` int(11) NOT NULL,
  `UserId` varchar(30) NOT NULL COMMENT 'username supplied for the login',
  `DateTime` datetime NOT NULL DEFAULT current_timestamp() COMMENT 'timestamp set to current timestamp by default',
  `From` varchar(24) NOT NULL DEFAULT '' COMMENT 'remote ip address and port of the client',
  `Success` tinyint(1) NOT NULL DEFAULT 0 COMMENT 'true if login was successful'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Users logins';

-- --------------------------------------------------------

--
-- Struttura della tabella `MessageAreas`
--

CREATE TABLE `MessageAreas` (
  `ID` varchar(20) NOT NULL COMMENT 'Message area identifier',
  `Description` varchar(200) NOT NULL DEFAULT '',
  `FIDOID` varchar(30) NOT NULL DEFAULT '' COMMENT 'Message area identifier for fido network',
  `AREAGROUP` varchar(20) NOT NULL DEFAULT '' COMMENT 'Gruop that area belongs to',
  `AllowedGroupRead` varchar(30) DEFAULT '' COMMENT 'User group needed to access this area',
  `AllowedGroupWrite` varchar(30) DEFAULT '' COMMENT 'User group needed to write in this area'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Message Areas List';

-- --------------------------------------------------------

--
-- Struttura della tabella `MessageAreasGroups`
--

CREATE TABLE `MessageAreasGroups` (
  `ID` varchar(20) NOT NULL DEFAULT '' COMMENT 'Areas group id',
  `Description` varchar(200) NOT NULL DEFAULT '',
  `AllowedGroupId` varchar(30) DEFAULT NULL COMMENT 'User group needed for access this group',
  `FidoNetwork` varchar(30) DEFAULT NULL COMMENT 'Fido style network for exchange'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Struttura della tabella `MessageRead`
--

CREATE TABLE `MessageRead` (
  `ID` int(11) NOT NULL,
  `MessgeId` int(11) NOT NULL,
  `UserId` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Flags for messages read';

-- --------------------------------------------------------

--
-- Struttura della tabella `Messages`
--

CREATE TABLE `Messages` (
  `ID` int(11) NOT NULL,
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
  `Body` text NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Messages';

-- --------------------------------------------------------

--
-- Struttura della tabella `MessageSeenBy`
--

CREATE TABLE `MessageSeenBy` (
  `ID` int(11) NOT NULL,
  `MessageId` int(11) NOT NULL,
  `SeenBy` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='System that already received the message';

-- --------------------------------------------------------

--
-- Struttura della tabella `Users`
--

CREATE TABLE `Users` (
  `userid` varchar(30) NOT NULL COMMENT 'Nickname',
  `realname` varchar(50) NOT NULL DEFAULT '' COMMENT 'Real name',
  `city` varchar(50) NOT NULL DEFAULT '' COMMENT 'city of the user',
  `nation` varchar(50) NOT NULL DEFAULT '' COMMENT 'nation of the user',
  `password` varchar(32) NOT NULL COMMENT 'MD5 Hash of the password',
  `status` varchar(1) NOT NULL DEFAULT '0',
  `signature` text NOT NULL DEFAULT '\'\'' COMMENT 'signature for messages',
  `LastLoginFrom` varchar(24) NOT NULL DEFAULT '0.0.0.0',
  `LastLoginDate` datetime NOT NULL DEFAULT current_timestamp(),
  `Registered` datetime NOT NULL DEFAULT current_timestamp() COMMENT 'timestamp of registration to the bbs',
  `LastPasswordModify` datetime NOT NULL DEFAULT current_timestamp(),
  `email` varchar(100) NOT NULL DEFAULT '' COMMENT 'internet email address',
  `Locked` tinyint(1) NOT NULL DEFAULT 0 COMMENT 'true for locked users',
  `locale` varchar(5) NOT NULL DEFAULT '' COMMENT 'user preferred locale'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='BBS users' ROW_FORMAT=COMPACT;

-- --------------------------------------------------------

--
-- Struttura della tabella `UsersGroups`
--

CREATE TABLE `UsersGroups` (
  `Groupid` varchar(30) NOT NULL DEFAULT '',
  `Description` varchar(200) NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Users groups definition' ROW_FORMAT=COMPACT;

-- --------------------------------------------------------

--
-- Struttura della tabella `UsersGroupsLinks`
--

CREATE TABLE `UsersGroupsLinks` (
  `id` int(11) NOT NULL,
  `userid` varchar(30) DEFAULT NULL,
  `groupid` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Users groups' ROW_FORMAT=COMPACT;

--
-- Indici per le tabelle scaricate
--

--
-- Indici per le tabelle `FidoNetworks`
--
ALTER TABLE `FidoNetworks`
  ADD PRIMARY KEY (`ID`);

--
-- Indici per le tabelle `Log`
--
ALTER TABLE `Log`
  ADD PRIMARY KEY (`id`),
  ADD KEY `DateTime` (`DateTime`);

--
-- Indici per le tabelle `Logins`
--
ALTER TABLE `Logins`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `UserId` (`UserId`),
  ADD KEY `DateTime` (`DateTime`);

--
-- Indici per le tabelle `MessageAreas`
--
ALTER TABLE `MessageAreas`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `Description` (`Description`),
  ADD KEY `FIDOID` (`FIDOID`),
  ADD KEY `MessageAreas_AreaGroupId_MessageAreasGroups` (`AREAGROUP`),
  ADD KEY `MessageAreas_AllowedRead_UsersGroups` (`AllowedGroupRead`),
  ADD KEY `MessageAreas_AllowedWrite_UsersGroups` (`AllowedGroupWrite`);

--
-- Indici per le tabelle `MessageAreasGroups`
--
ALTER TABLE `MessageAreasGroups`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `Description` (`Description`),
  ADD KEY `MessageAreasGroups_Allowed_UsersGroups` (`AllowedGroupId`),
  ADD KEY `MessageAreasGroups_FidoNetwork_Fidonetworks` (`FidoNetwork`);

--
-- Indici per le tabelle `MessageRead`
--
ALTER TABLE `MessageRead`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `MessageId` (`MessgeId`),
  ADD KEY `UserId` (`UserId`) USING BTREE;

--
-- Indici per le tabelle `Messages`
--
ALTER TABLE `Messages`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `Area` (`Area`);

--
-- Indici per le tabelle `MessageSeenBy`
--
ALTER TABLE `MessageSeenBy`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `MessageId` (`MessageId`),
  ADD KEY `SeenBy` (`SeenBy`);

--
-- Indici per le tabelle `Users`
--
ALTER TABLE `Users`
  ADD PRIMARY KEY (`userid`);

--
-- Indici per le tabelle `UsersGroups`
--
ALTER TABLE `UsersGroups`
  ADD PRIMARY KEY (`Groupid`);

--
-- Indici per le tabelle `UsersGroupsLinks`
--
ALTER TABLE `UsersGroupsLinks`
  ADD PRIMARY KEY (`id`),
  ADD KEY `userid` (`userid`),
  ADD KEY `UsersGroupsLinks_groupid_groups` (`groupid`);

--
-- AUTO_INCREMENT per le tabelle scaricate
--

--
-- AUTO_INCREMENT per la tabella `Log`
--
ALTER TABLE `Log`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT per la tabella `Logins`
--
ALTER TABLE `Logins`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT per la tabella `MessageRead`
--
ALTER TABLE `MessageRead`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT per la tabella `Messages`
--
ALTER TABLE `Messages`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT per la tabella `MessageSeenBy`
--
ALTER TABLE `MessageSeenBy`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT per la tabella `UsersGroupsLinks`
--
ALTER TABLE `UsersGroupsLinks`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

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
  ADD CONSTRAINT `MessageAreasGroups_Allowed_UsersGroups` FOREIGN KEY (`AllowedGroupId`) REFERENCES `UsersGroups` (`groupid`) ON DELETE SET NULL,
  ADD CONSTRAINT `MessageAreasGroups_FidoNetwork_Fidonetworks` FOREIGN KEY (`FidoNetwork`) REFERENCES `FidoNetworks` (`ID`) ON DELETE SET NULL;

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

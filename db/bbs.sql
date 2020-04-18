-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Creato il: Apr 18, 2020 alle 21:17
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

CREATE TABLE `Log` (
  `id` int(11) NOT NULL,
  `DateTime` datetime NOT NULL DEFAULT current_timestamp(),
  `Remote` varchar(24) NOT NULL DEFAULT '',
  `Level` tinyint(4) NOT NULL DEFAULT 1,
  `Description` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Events log';

-- --------------------------------------------------------

--
-- Struttura della tabella `Logins`
--

CREATE TABLE `Logins` (
  `ID` int(11) NOT NULL,
  `UserId` varchar(30) NOT NULL,
  `DateTime` datetime NOT NULL DEFAULT current_timestamp(),
  `From` varchar(24) NOT NULL DEFAULT '',
  `Success` tinyint(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Users logins';

-- --------------------------------------------------------

--
-- Struttura della tabella `MessageAreaAllowedUsersGroups`
--

CREATE TABLE `MessageAreaAllowedUsersGroups` (
  `ID` int(11) NOT NULL,
  `MessageAreaId` varchar(20) NOT NULL,
  `UsersGroupId` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Groups allowed to message areas';

-- --------------------------------------------------------

--
-- Struttura della tabella `MessageAreaGroupsAllowedUsersGroups`
--

CREATE TABLE `MessageAreaGroupsAllowedUsersGroups` (
  `ID` int(11) NOT NULL,
  `MessageAreaGroupId` varchar(20) NOT NULL,
  `UsersGroupId` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Groups allowed to message areas groups';

-- --------------------------------------------------------

--
-- Struttura della tabella `MessageAreas`
--

CREATE TABLE `MessageAreas` (
  `ID` varchar(20) NOT NULL,
  `Description` varchar(200) NOT NULL DEFAULT '',
  `FIDOID` varchar(30) NOT NULL DEFAULT '',
  `AREAGROUP` varchar(20) NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Message Areas List';

-- --------------------------------------------------------

--
-- Struttura della tabella `MessageAreasGroups`
--

CREATE TABLE `MessageAreasGroups` (
  `ID` varchar(20) NOT NULL,
  `Description` varchar(200) NOT NULL DEFAULT ''
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
  `Area` varchar(20) NOT NULL,
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
  `Locked` tinyint(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='BBS users' ROW_FORMAT=COMPACT;

--
-- Dump dei dati per la tabella `Users`
--

INSERT INTO `Users` (`userid`, `realname`, `city`, `nation`, `password`, `status`, `signature`, `LastLoginFrom`, `LastLoginDate`, `Registered`, `LastPasswordModify`, `email`, `Locked`) VALUES
('SYSOP', 'Your real name', 'Your city', 'Your Country', '7A7B1FFA5FD5C25177AD14AA6FE4F3CD', '0', '', '127.0.0.1:49907', '2020-04-17 22:36:42', '2020-04-14 18:49:41', '2020-04-14 18:49:10', '', 0);

-- --------------------------------------------------------

--
-- Struttura della tabella `UsersGroups`
--

CREATE TABLE `UsersGroups` (
  `Groupid` varchar(30) NOT NULL DEFAULT '',
  `Description` varchar(200) NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Users groups definition' ROW_FORMAT=COMPACT;

--
-- Dump dei dati per la tabella `UsersGroups`
--

INSERT INTO `UsersGroups` (`Groupid`, `Description`) VALUES
('POWERUSERS', 'Users with extended privileges'),
('ROOT', 'Administrators'),
('USERS', 'Standard Users');

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
-- Indici per le tabelle `MessageAreaAllowedUsersGroups`
--
ALTER TABLE `MessageAreaAllowedUsersGroups`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `MessageAreaId` (`MessageAreaId`),
  ADD KEY `MAAUG_UsersGroupID_UsersGroups` (`UsersGroupId`);

--
-- Indici per le tabelle `MessageAreaGroupsAllowedUsersGroups`
--
ALTER TABLE `MessageAreaGroupsAllowedUsersGroups`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `MessageAreaGroupId` (`MessageAreaGroupId`),
  ADD KEY `MAGAUG_UsersGroupID_UsersGroups` (`UsersGroupId`);

--
-- Indici per le tabelle `MessageAreas`
--
ALTER TABLE `MessageAreas`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `Description` (`Description`),
  ADD KEY `FIDOID` (`FIDOID`),
  ADD KEY `MessageAreas_AreaGroupId_MessageAreasGroups` (`AREAGROUP`);

--
-- Indici per le tabelle `MessageAreasGroups`
--
ALTER TABLE `MessageAreasGroups`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `Description` (`Description`);

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
-- AUTO_INCREMENT per la tabella `MessageAreaAllowedUsersGroups`
--
ALTER TABLE `MessageAreaAllowedUsersGroups`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT per la tabella `MessageAreaGroupsAllowedUsersGroups`
--
ALTER TABLE `MessageAreaGroupsAllowedUsersGroups`
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
-- Limiti per la tabella `MessageAreaAllowedUsersGroups`
--
ALTER TABLE `MessageAreaAllowedUsersGroups`
  ADD CONSTRAINT `MAAUG_MessageAreaId_MessageAreas` FOREIGN KEY (`MessageAreaId`) REFERENCES `MessageAreas` (`ID`),
  ADD CONSTRAINT `MAAUG_UsersGroupID_UsersGroups` FOREIGN KEY (`UsersGroupId`) REFERENCES `UsersGroups` (`groupid`);

--
-- Limiti per la tabella `MessageAreaGroupsAllowedUsersGroups`
--
ALTER TABLE `MessageAreaGroupsAllowedUsersGroups`
  ADD CONSTRAINT `MAGAUG_MessageAreaGroupId_MessageAreasGroups` FOREIGN KEY (`MessageAreaGroupId`) REFERENCES `MessageAreasGroups` (`ID`),
  ADD CONSTRAINT `MAGAUG_UsersGroupID_UsersGroups` FOREIGN KEY (`UsersGroupId`) REFERENCES `UsersGroups` (`groupid`);

--
-- Limiti per la tabella `MessageAreas`
--
ALTER TABLE `MessageAreas`
  ADD CONSTRAINT `MessageAreas_AreaGroupId_MessageAreasGroups` FOREIGN KEY (`AREAGROUP`) REFERENCES `MessageAreasGroups` (`ID`);

--
-- Limiti per la tabella `MessageRead`
--
ALTER TABLE `MessageRead`
  ADD CONSTRAINT `MessageRead_MessageId_Messages` FOREIGN KEY (`MessgeId`) REFERENCES `Messages` (`ID`),
  ADD CONSTRAINT `MessageRead_UserId_Users` FOREIGN KEY (`UserId`) REFERENCES `Users` (`userid`);

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

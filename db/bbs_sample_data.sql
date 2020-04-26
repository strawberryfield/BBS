-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Creato il: Apr 26, 2020 alle 10:01
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
USE `bbs`;

--
-- Dump dei dati per la tabella `MessageAreas`
--

INSERT INTO `MessageAreas` (`ID`, `Description`, `FIDOID`, `AREAGROUP`, `AllowedGroupRead`, `AllowedGroupWrite`) VALUES
('BBSDEV', 'Topics about developing the BBS software', '', 'BBSSUPPORT', NULL, 'BBSSUPPORT'),
('BBSNEWS', 'News and annuncements', '', 'BBSSUPPORT', NULL, 'POWERUSERS'),
('BBSSETUP', 'Topics about BBS install', '', 'BBSSUPPORT', NULL, 'BBSSUPPORT'),
('BBSUSE', 'Topics about operating the BBS', '', 'BBSSUPPORT', NULL, 'BBSSUPPORT'),
('CHAT', 'Chiacchiere in libertà', '', 'GENERAL', NULL, NULL),
('PRESENTAZIONI', 'Presentazioni e prove', '', 'GENERAL', NULL, NULL);

--
-- Dump dei dati per la tabella `MessageAreasGroups`
--

INSERT INTO `MessageAreasGroups` (`ID`, `Description`, `AllowedGroupId`) VALUES
('BBSSUPPORT', 'Casasoft BBS support', 'BBSSUPPORT'),
('GENERAL', 'Genreric message areas', NULL);

--
-- Dump dei dati per la tabella `Users`
--

INSERT INTO `Users` (`userid`, `realname`, `city`, `nation`, `password`, `status`, `signature`, `LastLoginFrom`, `LastLoginDate`, `Registered`, `LastPasswordModify`, `email`, `Locked`) VALUES
('SYSOP', 'Your real name', 'Your city', 'Your Country', '7A7B1FFA5FD5C25177AD14AA6FE4F3CD', '0', '', '127.0.0.1:49907', '2020-04-17 22:36:42', '2020-04-14 18:49:41', '2020-04-14 18:49:10', '', 0);

--
-- Dump dei dati per la tabella `UsersGroups`
--

INSERT INTO `UsersGroups` (`Groupid`, `Description`) VALUES
('BBSSUPPORT', 'BBS support message areas access'),
('POWERUSERS', 'Users with extended privileges'),
('ROOT', 'Administrators'),
('USERS', 'Standard Users');

--
-- Dump dei dati per la tabella `UsersGroupsLinks`
--

INSERT INTO `UsersGroupsLinks` (`id`, `userid`, `groupid`) VALUES
(6, 'SYSOP', 'POWERUSERS'),
(7, 'SYSOP', 'USERS'),
(8, 'SYSOP', 'ROOT'),
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

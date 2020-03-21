-- phpMyAdmin SQL Dump
-- version 4.6.6deb5
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Creato il: Mar 20, 2020 alle 22:22
-- Versione del server: 10.3.22-MariaDB-0+deb10u1
-- Versione PHP: 7.3.14-1~deb10u1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
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
-- Struttura della tabella `groups`
--

CREATE TABLE `groups` (
  `groupid` varchar(30) NOT NULL DEFAULT '',
  `description` varchar(200) NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Users groups definition' ROW_FORMAT=COMPACT;

--
-- Dump dei dati per la tabella `groups`
--

INSERT INTO `groups` VALUES
('ROOT', 'Superuser');

-- --------------------------------------------------------

--
-- Struttura della tabella `log`
--

CREATE TABLE `log` (
  `id` int(11) NOT NULL,
  `DateTime` datetime NOT NULL DEFAULT current_timestamp(),
  `Level` tinyint(4) NOT NULL DEFAULT 0,
  `Description` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Events log';

--
-- Dump dei dati per la tabella `log`
--

INSERT INTO `log` VALUES
(1, '2020-01-24 22:27:30', 0, 'Hello World!');

-- --------------------------------------------------------

--
-- Struttura della tabella `logins`
--

CREATE TABLE `logins` (
  `id` int(11) NOT NULL,
  `userid` varchar(30) NOT NULL,
  `DateTime` datetime NOT NULL DEFAULT current_timestamp(),
  `From` varchar(15) NOT NULL DEFAULT '0.0.0.0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='List of users logins' ROW_FORMAT=COMPACT;

-- --------------------------------------------------------

--
-- Struttura della tabella `users`
--

CREATE TABLE `users` (
  `userid` varchar(30) NOT NULL,
  `realname` varchar(50) NOT NULL DEFAULT '',
  `password` varchar(20) NOT NULL,
  `status` varchar(1) NOT NULL DEFAULT '0',
  `signature` text NOT NULL DEFAULT '',
  `LastLoginFrom` varchar(15) NOT NULL DEFAULT '0.0.0.0',
  `LastLoginDate` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='BBS users' ROW_FORMAT=COMPACT;

-- --------------------------------------------------------

--
-- Struttura della tabella `users_groups`
--

CREATE TABLE `users_groups` (
  `id` int(11) NOT NULL,
  `userid` varchar(30) DEFAULT NULL,
  `groupid` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Users groups' ROW_FORMAT=COMPACT;

--
-- Indici per le tabelle scaricate
--

--
-- Indici per le tabelle `groups`
--
ALTER TABLE `groups`
  ADD PRIMARY KEY (`groupid`);

--
-- Indici per le tabelle `log`
--
ALTER TABLE `log`
  ADD PRIMARY KEY (`id`),
  ADD KEY `DateTime` (`DateTime`);

--
-- Indici per le tabelle `logins`
--
ALTER TABLE `logins`
  ADD PRIMARY KEY (`id`),
  ADD KEY `userid` (`userid`),
  ADD KEY `DateTime` (`DateTime`);

--
-- Indici per le tabelle `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`userid`);

--
-- Indici per le tabelle `users_groups`
--
ALTER TABLE `users_groups`
  ADD PRIMARY KEY (`id`),
  ADD KEY `userid` (`userid`),
  ADD KEY `group_groups` (`groupid`);

--
-- AUTO_INCREMENT per le tabelle scaricate
--

--
-- AUTO_INCREMENT per la tabella `log`
--
ALTER TABLE `log`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT per la tabella `logins`
--
ALTER TABLE `logins`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT per la tabella `users_groups`
--
ALTER TABLE `users_groups`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- Limiti per le tabelle scaricate
--

--
-- Limiti per la tabella `logins`
--
ALTER TABLE `logins`
  ADD CONSTRAINT `logins_users` FOREIGN KEY (`userid`) REFERENCES `users` (`userid`);

--
-- Limiti per la tabella `users_groups`
--
ALTER TABLE `users_groups`
  ADD CONSTRAINT `group_groups` FOREIGN KEY (`groupid`) REFERENCES `groups` (`groupid`),
  ADD CONSTRAINT `user_users` FOREIGN KEY (`userid`) REFERENCES `users` (`userid`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

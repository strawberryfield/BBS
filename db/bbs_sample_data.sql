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
('2MANO.ITA', 'Mercatino di materiale usato', '2MANO.ITA', 'FIDONET', NULL, NULL),
('AEREI.ITA', 'Aviazione e aeromodellismo', 'AEREI.ITA', 'FIDONET', NULL, NULL),
('AFI.ITA', 'Associazione Fidonet Italia', 'AFI.ITA', 'FIDONET', NULL, NULL),
('AI.ITA', 'Area Intelligenza Artificiale', 'AI.ITA', 'FIDONET', NULL, NULL),
('AIR.ITA', 'Area per l\'hobby del radioascolto', 'AIR.ITA', 'FIDONET', NULL, NULL),
('AMY_HARD.ITA', 'Hardware e accessori dei computer Amiga', 'AMY_HARD.ITA', 'FIDONET', NULL, NULL),
('AMY_INET.ITA', 'Supporto internet per Amiga', 'AMY_INET.ITA', 'FIDONET', NULL, NULL),
('AMY_MISC.ITA', 'Discussioni varie su Amiga', 'AMY_MISC.ITA', 'FIDONET', NULL, NULL),
('AMY_NEWS.ITA', 'Novita\' file su Amiga', 'AMY_NEWS.ITA', 'FIDONET', NULL, NULL),
('AMY_SOFT.ITA', 'Software per computer Amiga', 'AMY_SOFT.ITA', 'FIDONET', NULL, NULL),
('AMY_SYSOP.ITA', 'Conferenza italiana per SysOps Amiga', 'AMY_SYSOP.ITA', 'FIDONET', NULL, NULL),
('ANIMALI.ITA', 'tutto su tutti gli animali', 'ANIMALI.ITA', 'FIDONET', NULL, NULL),
('ARGUS.ITA', 'Supporto tecnico per il mailer ARGUS', 'ARGUS.ITA', 'FIDONET', NULL, NULL),
('ARMI.ITA', 'Armi, tecniche di sicurezza, militaria', 'ARMI.ITA', 'FIDONET', NULL, NULL),
('ASTRO.ITA', 'Astronomia e Astronautica', 'ASTRO.ITA', 'FIDONET', NULL, NULL),
('ATARI.ITA', 'Area nazionale computer Atari e Atariani', 'ATARI.ITA', 'FIDONET', NULL, NULL),
('BBSDEV', 'Topics about developing the BBS software', '', 'BBSSUPPORT', NULL, 'BBSSUPPORT'),
('BBSNEWS', 'News and annuncements', '', 'BBSSUPPORT', NULL, 'POWERUSERS'),
('BBSSETUP', 'Topics about BBS install', '', 'BBSSUPPORT', NULL, 'BBSSUPPORT'),
('BBSUSE', 'Topics about operating the BBS', '', 'BBSSUPPORT', NULL, 'BBSSUPPORT'),
('BBS_SOFT.ITA', 'Annunci e ricerche soft per gestire BBS', 'BBS_SOFT.ITA', 'FIDONET', NULL, NULL),
('CARDS.ITA', 'Area dedicata ai giochi di carte', 'CARDS.ITA', 'FIDONET', NULL, NULL),
('CARTONI.ITA', 'Cartoni animati', 'CARTONI.ITA', 'FIDONET', NULL, NULL),
('CHAT', 'Chiacchiere in libertà', '', 'GENERAL', NULL, NULL),
('CHATTER.ITA', 'Chiacchere in tutta Italia', 'CHATTER.ITA', 'FIDONET', NULL, NULL),
('CINEMA.ITA', 'Cinema', 'CINEMA.ITA', 'FIDONET', NULL, NULL),
('CLANG.ITA', 'Programmazione in C e C++', 'CLANG.ITA', 'FIDONET', NULL, NULL),
('COMMS_MODEM.ITA', 'Conferenza sui modem e come configurarli', 'COMMS_MODEM.ITA', 'FIDONET', NULL, NULL),
('COMMS_PHONE.ITA', 'Telefonia base, cellulare e tanto altro', 'COMMS_PHONE.ITA', 'FIDONET', NULL, NULL),
('COMMS_RETI.ITA', 'Reti Geografiche e Metropolitane', 'COMMS_RETI.ITA', 'FIDONET', NULL, NULL),
('CUCINA.ITA', 'Tutto cio\' che concerne il cibo', 'CUCINA.ITA', 'FIDONET', NULL, NULL),
('DBASE.ITA', 'Programmi per gestione di database', 'DBASE.ITA', 'FIDONET', NULL, NULL),
('DELPHI.ITA', 'Sviluppo sotto ambiente DELPHI', 'DELPHI.ITA', 'FIDONET', NULL, NULL),
('DEMO.ITA', 'Sviluppatori DEMO', 'DEMO.ITA', 'FIDONET', NULL, NULL),
('DEWDNEY.ITA', '(Ri)creazioni al calcolatore', 'DEWDNEY.ITA', 'FIDONET', NULL, NULL),
('DIRITTO.ITA', 'Area di discussione questioni giuridiche', 'DIRITTO.ITA', 'FIDONET', NULL, NULL),
('ECOLOGIA.ITA', 'Ecologia e ambiente', 'ECOLOGIA.ITA', 'FIDONET', NULL, NULL),
('ECONOMIA.ITA', 'Economia e finanza', 'ECONOMIA.ITA', 'FIDONET', NULL, NULL),
('ELETTRONICA.ITA', 'Applicazioni elettroniche', 'ELETTRONICA.ITA', 'FIDONET', NULL, NULL),
('EMULATORI.ITA', 'Emulatori software', 'EMULATORI.ITA', 'FIDONET', NULL, NULL),
('FASTECHO.ITA', 'FastEcho Mail Proc. e utilility relative', 'FASTECHO.ITA', 'FIDONET', NULL, NULL),
('FD.ITA', 'Supporto FrontDoor', 'FD.ITA', 'FIDONET', NULL, NULL),
('FILOSOFIA.ITA', 'Filosofia', 'FILOSOFIA.ITA', 'FIDONET', NULL, NULL),
('FOTO.ITA', 'Fotografia e cultura fotografica', 'FOTO.ITA', 'FIDONET', NULL, NULL),
('FUMETTI.ITA', 'Fumetti', 'FUMETTI.ITA', 'FIDONET', NULL, NULL),
('GAMES.ITA', 'Discussioni su giochi da computer', 'GAMES.ITA', 'FIDONET', NULL, NULL),
('GRAFICA.ITA', 'Il mondo della computer graphics', 'GRAFICA.ITA', 'FIDONET', NULL, NULL),
('HAM.ITA', 'Amanti della radio - OM - CB - SWL', 'HAM.ITA', 'FIDONET', NULL, NULL),
('HANDHELD.ITA', 'Calcolatrici programmabili', 'HANDHELD.ITA', 'FIDONET', NULL, NULL),
('HIFI.ITA', 'L\'audio ad alta fedelta`', 'HIFI.ITA', 'FIDONET', NULL, NULL),
('HUMAN.ITA', 'Problemi sociali, solidarieta\' handicap', 'HUMAN.ITA', 'FIDONET', NULL, NULL),
('IMAIL.ITA', 'IMail e le sue utility', 'IMAIL.ITA', 'FIDONET', NULL, NULL),
('IPERTESTI.ITA', 'Da gli ipertesti alle pagine HTML a JAVA', 'IPERTESTI.ITA', 'FIDONET', NULL, NULL),
('IP_CONNECT.ITA', 'La tecnologia FTN e internet', 'IP_CONNECT.ITA', 'FIDONET', NULL, NULL),
('LAN.ITA', 'Networking, Internetworking & Security', 'LAN.ITA', 'FIDONET', NULL, NULL),
('LAVORO.ITA', 'Tematiche inerenti il mondo del lavoro', 'LAVORO.ITA', 'FIDONET', NULL, NULL),
('LIBRI.ITA', 'Libri, Narrativa, Saggistica, Letture', 'LIBRI.ITA', 'FIDONET', NULL, NULL),
('LORA.ITA', 'LoraBBS e sue utility', 'LORA.ITA', 'FIDONET', NULL, NULL),
('LUI_LEI.ITA', 'Relazioni sociali ed affettive tra sessi', 'LUI_LEI.ITA', 'FIDONET', NULL, NULL),
('MAC.ITA', 'Macintosh, Apple, SysOps', 'MAC.ITA', 'FIDONET', NULL, NULL),
('MANGA.ITA', 'Manga (fumetti di produzione giapponese)', 'MANGA.ITA', 'FIDONET', NULL, NULL),
('MATE.ITA', 'Matematica e metodi matematici', 'MATE.ITA', 'FIDONET', NULL, NULL),
('MAXIMUS.ITA', 'Supporto per il sofware BBS Maximus', 'MAXIMUS.ITA', 'FIDONET', NULL, NULL),
('MIDI.ITA', 'MIDI, Music, Sound', 'MIDI.ITA', 'FIDONET', NULL, NULL),
('MISTERI.ITA', 'Mistero e Paranormale', 'MISTERI.ITA', 'FIDONET', NULL, NULL),
('MOTORI.ITA', 'Motori e sport motoristici', 'MOTORI.ITA', 'FIDONET', NULL, NULL),
('MSDOS.ITA', 'Sistema Operativo MSDOS & C.', 'MSDOS.ITA', 'FIDONET', NULL, NULL),
('MULTIMEDIA.ITA', 'Il Mondo del multimediale', 'MULTIMEDIA.ITA', 'FIDONET', NULL, NULL),
('MUSICA.ITA', 'Musica', 'MUSICA.ITA', 'FIDONET', NULL, NULL),
('MUSICISTI.ITA', 'Area musicisti', 'MUSICISTI.ITA', 'FIDONET', NULL, NULL),
('NEWS.ITA', 'Annunci Nuovi Files in Distribuzione', 'NEWS.ITA', 'FIDONET', NULL, NULL),
('OPTICAL_MEDIA.ITA', 'Supporti ottici e removibili', 'OPTICAL_MEDIA.ITA', 'FIDONET', NULL, NULL),
('OS2_APPL.ITA', 'Programmi Applicativi sotto OS/2', 'OS2_APPL.ITA', 'FIDONET', NULL, NULL),
('OS2_INST.ITA', 'Installazione e Sistema Operativo OS/2', 'OS2_INST.ITA', 'FIDONET', NULL, NULL),
('PC_CHIP.ITA', 'Cpu e schede madri', 'PC_CHIP.ITA', 'FIDONET', NULL, NULL),
('PC_CRT.ITA', 'Video, schede video e LCD', 'PC_CRT.ITA', 'FIDONET', NULL, NULL),
('PC_DEBATE.ITA', 'Confronti sui Personal Computer', 'PC_DEBATE.ITA', 'FIDONET', NULL, NULL),
('PC_HARD.ITA', 'Dischi e resto PC_*.ITA', 'PC_HARD.ITA', 'FIDONET', NULL, NULL),
('PC_LPT.ITA', 'Periferiche: stampanti, mouse, ...', 'PC_LPT.ITA', 'FIDONET', NULL, NULL),
('PEACELINK.ITA', 'Pace, diritti umani e solidarieta\'', 'PEACELINK.ITA', 'FIDONET', NULL, NULL),
('PLUTO.ITA', 'PLUTO - Linux User Group', 'PLUTO.ITA', 'FIDONET', NULL, NULL),
('POINT.ITA', 'Come installare/usare un POINT Fidonet', 'POINT.ITA', 'FIDONET', NULL, NULL),
('POLITICA.ITA', 'Discutiamo di politica', 'POLITICA.ITA', 'FIDONET', NULL, NULL),
('PRESENTAZIONI', 'Presentazioni e prove', '', 'GENERAL', NULL, NULL),
('PRG.ITA', 'La programmazione in generale', 'PRG.ITA', 'FIDONET', NULL, NULL),
('PSICOLOGIA.ITA', 'Gli aspetti della psiche umana', 'PSICOLOGIA.ITA', 'FIDONET', NULL, NULL),
('RA.ITA', 'Supporto RemoteAccess', 'RA.ITA', 'FIDONET', NULL, NULL),
('RELIGIONI.ITA', 'Le Religioni e le relative Dottrine', 'RELIGIONI.ITA', 'FIDONET', NULL, NULL),
('RIDERE.ITA', 'Barzellette,battute,episodi divertenti', 'RIDERE.ITA', 'FIDONET', NULL, NULL),
('SALUTE.ITA', 'Chiacchiere sulla salute (medici e no)', 'SALUTE.ITA', 'FIDONET', NULL, NULL),
('SAT.ITA', 'Satelliti, TV Sat, Codifiche, Cards,...', 'SAT.ITA', 'FIDONET', NULL, NULL),
('SCIENZA.ITA', 'Dibattito sui temi della Scienza', 'SCIENZA.ITA', 'FIDONET', NULL, NULL),
('SCOUT.ITA', 'Scautismo in generale (movimento educ.)', 'SCOUT.ITA', 'FIDONET', NULL, NULL),
('SCRITTORI.ITA', 'Scrittori e poeti in erba', 'SCRITTORI.ITA', 'FIDONET', NULL, NULL),
('SCUOLA.ITA', 'Scuola e didattica, professori e alunni', 'SCUOLA.ITA', 'FIDONET', NULL, NULL),
('SEMPOINT.ITA', 'Discussione sull\'uso dell\'OLR SemPoint', 'SEMPOINT.ITA', 'FIDONET', NULL, NULL),
('SF.ITA', 'Fantascienza e Fantasy', 'SF.ITA', 'FIDONET', NULL, NULL),
('SICUREZZA.ITA', 'La sicurezza dei sistemi informatici', 'SICUREZZA.ITA', 'FIDONET', NULL, NULL),
('SINCLAIR.ITA', 'Computer Sinclair: QL, Spectrum, ZX81..', 'SINCLAIR.ITA', 'FIDONET', NULL, NULL),
('SOFTINFO.ITA', 'Info e ricerca software free/share/PD', 'SOFTINFO.ITA', 'FIDONET', NULL, NULL),
('SPORT.ITA', 'Sport e avvenimenti sportivi', 'SPORT.ITA', 'FIDONET', NULL, NULL),
('STARTREK.ITA', 'Star Trek, in tutte le sue forme', 'STARTREK.ITA', 'FIDONET', NULL, NULL),
('SYSOP_CHAT.ITA', 'Chatter tra SysOps', 'SYSOP_CHAT.ITA', 'FIDONET', NULL, NULL),
('TECH_NET.ITA', 'Software reti Fido e BBS', 'TECH_NET.ITA', 'FIDONET', NULL, NULL),
('TERMINATE.ITA', 'Software Terminate', 'TERMINATE.ITA', 'FIDONET', NULL, NULL),
('TEX.ITA', 'TeX incluso LaTeX, METAFONT e METAPOST', 'TEX.ITA', 'FIDONET', NULL, NULL),
('TORNEI.ITA', 'Partecipazione attiva a giochi vari', 'TORNEI.ITA', 'FIDONET', NULL, NULL),
('TURBO_P.ITA', 'Ogni implementazione del Pascal', 'TURBO_P.ITA', 'FIDONET', NULL, NULL),
('TV.ITA', 'Area dedicata ai programmi televisivi', 'TV.ITA', 'FIDONET', NULL, NULL),
('UNIVERSITA.ITA', 'Dialoghi fra universitari', 'UNIVERSITA.ITA', 'FIDONET', NULL, NULL),
('UNIX.ITA', 'I sistemi operativi UNIX', 'UNIX.ITA', 'FIDONET', NULL, NULL),
('VIAGGI.ITA', 'Conferenza dedicata a turismo e vacanze', 'VIAGGI.ITA', 'FIDONET', NULL, NULL),
('VIRUS.ITA', 'Lotta contro i virus informatici', 'VIRUS.ITA', 'FIDONET', NULL, NULL),
('VREALITY.ITA', 'Realta\' Virtuale, in ogni sua forma', 'VREALITY.ITA', 'FIDONET', NULL, NULL),
('WINDOWS.ITA', 'Area utenti Windows e Windows 95', 'WINDOWS.ITA', 'FIDONET', NULL, NULL),
('WIN_NT.ITA', 'WinNT Server WinNT Client e s/w relativo', 'WIN_NT.ITA', 'FIDONET', NULL, NULL),
('WIN_PROG.ITA', 'Programmazione in ambiente Windows', 'WIN_PROG.ITA', 'FIDONET', NULL, NULL);

--
-- Dump dei dati per la tabella `MessageAreasGroups`
--

INSERT INTO `MessageAreasGroups` (`ID`, `Description`, `AllowedGroupId`) VALUES
('BBSSUPPORT', 'Casasoft BBS support', 'BBSSUPPORT'),
('FIDONET', 'Aree echomail FidoNet Italia', NULL),
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

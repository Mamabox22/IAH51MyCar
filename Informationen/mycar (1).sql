-- phpMyAdmin SQL Dump
-- version 4.7.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Erstellungszeit: 13. Dez 2017 um 10:07
-- Server-Version: 10.1.26-MariaDB
-- PHP-Version: 7.1.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Datenbank: `mycar`
--

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `auto`
--

CREATE TABLE `auto` (
  `A_ID` int(100) NOT NULL,
  `Hersteller` varchar(24) NOT NULL,
  `Modell` varchar(20) NOT NULL,
  `Name` varchar(20) NOT NULL,
  `Baujahr` int(11) NOT NULL,
  `Sitzplätze` int(10) NOT NULL,
  `Farbe` varchar(20) NOT NULL,
  `Variante` int(11) NOT NULL,
  `Preis` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Daten für Tabelle `auto`
--

INSERT INTO `auto` (`A_ID`, `Hersteller`, `Modell`, `Name`, `Baujahr`, `Sitzplätze`, `Farbe`, `Variante`, `Preis`) VALUES
(1, 'Audi', 'TEst', 'Audi R8', 19980628, 2, 'Rot', 0, 0);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `reservierung`
--

CREATE TABLE `reservierung` (
  `R_ID` int(10) NOT NULL,
  `A_ID` int(10) NOT NULL,
  `U_ID` int(10) NOT NULL,
  `Datum` date NOT NULL,
  `Betrag` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `user`
--

CREATE TABLE `user` (
  `U_ID` int(100) NOT NULL,
  `Name` text NOT NULL,
  `Vorname` text NOT NULL,
  `Email` varchar(30) NOT NULL,
  `Telefon` int(15) NOT NULL,
  `Adresse` varchar(40) NOT NULL,
  `Postleitzahl` int(5) NOT NULL,
  `Ort` text NOT NULL,
  `Passwort` varchar(24) NOT NULL,
  `Username` varchar(24) NOT NULL,
  `Admin` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indizes der exportierten Tabellen
--

--
-- Indizes für die Tabelle `auto`
--
ALTER TABLE `auto`
  ADD PRIMARY KEY (`A_ID`);

--
-- Indizes für die Tabelle `reservierung`
--
ALTER TABLE `reservierung`
  ADD PRIMARY KEY (`R_ID`),
  ADD KEY `A_ID` (`A_ID`),
  ADD KEY `U_ID` (`U_ID`);

--
-- Indizes für die Tabelle `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`U_ID`);

--
-- Constraints der exportierten Tabellen
--

--
-- Constraints der Tabelle `reservierung`
--
ALTER TABLE `reservierung`
  ADD CONSTRAINT `reservierung_ibfk_1` FOREIGN KEY (`A_ID`) REFERENCES `auto` (`A_ID`),
  ADD CONSTRAINT `reservierung_ibfk_2` FOREIGN KEY (`U_ID`) REFERENCES `user` (`U_ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

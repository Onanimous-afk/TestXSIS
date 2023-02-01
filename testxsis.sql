-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 01, 2023 at 05:18 AM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.0.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `testxsis`
--

-- --------------------------------------------------------

--
-- Table structure for table `movies`
--

CREATE TABLE `movies` (
  `id` int(11) NOT NULL,
  `title` varchar(100) NOT NULL,
  `description` varchar(4000) NOT NULL,
  `rating` float DEFAULT NULL,
  `image` varchar(4000) DEFAULT NULL,
  `created_at` datetime(6) DEFAULT NULL,
  `updated_at` datetime(6) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `movies`
--

INSERT INTO `movies` (`id`, `title`, `description`, `rating`, `image`, `created_at`, `updated_at`) VALUES
(1, 'Pengabdi Setan', 'Pengabdi Setan (bahasa Inggris: Satan\'s Slaves) merupakan film horor Indonesia yang dirilis pada 28 September 2017, yang ditulis dan disutradarai oleh Joko Anwar. Film ini adalah buat ulang (remake) dari film berjudul sama pada tahun 1980 silam.', 9, '', '2023-02-01 09:45:09.000000', '2023-02-01 09:45:09.000000'),
(2, 'Pengabdi Setan 2', 'Serial ke 2 dari Pengabdi Setan', 10, '', '2023-02-01 09:45:09.000000', '2023-02-01 09:45:09.000000'),
(4, 'asd2a', 'asd2', 8.9, NULL, '2023-02-01 09:58:10.266154', '2023-02-01 09:59:54.738967');

-- --------------------------------------------------------

--
-- Table structure for table `__efmigrationshistory`
--

CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `__efmigrationshistory`
--

INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
('20230201021903_Initial', '7.0.2'),
('20230201025501_updateNullableImage', '7.0.2');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `movies`
--
ALTER TABLE `movies`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `__efmigrationshistory`
--
ALTER TABLE `__efmigrationshistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `movies`
--
ALTER TABLE `movies`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

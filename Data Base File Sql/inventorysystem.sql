-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 13, 2019 at 01:24 AM
-- Server version: 10.4.6-MariaDB
-- PHP Version: 7.3.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `inventorysystem`
--

-- --------------------------------------------------------

--
-- Table structure for table `brands`
--

CREATE TABLE `brands` (
  `bid` int(11) NOT NULL,
  `brandName` varchar(50) NOT NULL,
  `addedDate` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `brands`
--

INSERT INTO `brands` (`bid`, `brandName`, `addedDate`) VALUES
(61, 'Samsung', '2019-12-10 15:33:32'),
(62, 'OPPO', '2019-12-10 15:34:01'),
(63, 'ASUS', '2019-12-10 15:34:05'),
(65, 'Cherry Mobile', '2019-12-10 15:34:21'),
(66, 'Apple ', '2019-12-10 15:59:23'),
(69, 'Rakk', '2019-12-13 07:51:19');

-- --------------------------------------------------------

--
-- Table structure for table `categories`
--

CREATE TABLE `categories` (
  `cid` int(11) NOT NULL,
  `categoryName` varchar(50) NOT NULL,
  `addedDate` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `categories`
--

INSERT INTO `categories` (`cid`, `categoryName`, `addedDate`) VALUES
(27, 'Android ', '2019-12-10 15:33:39'),
(28, 'IOS', '2019-12-10 15:33:47'),
(29, 'Laptop', '2019-12-10 15:33:52'),
(33, 'Computer Peripherals', '2019-12-13 07:53:13');

-- --------------------------------------------------------

--
-- Table structure for table `dashboardstat`
--

CREATE TABLE `dashboardstat` (
  `did` int(11) NOT NULL,
  `totalSales` int(99) NOT NULL,
  `soldProductqty` int(99) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `dashboardstat`
--

INSERT INTO `dashboardstat` (`did`, `totalSales`, `soldProductqty`) VALUES
(4, 2264, 0);

-- --------------------------------------------------------

--
-- Table structure for table `loginhistory`
--

CREATE TABLE `loginhistory` (
  `id` int(99) NOT NULL,
  `username` varchar(30) NOT NULL,
  `timeLogin` datetime NOT NULL,
  `timeLogout` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `loginhistory`
--

INSERT INTO `loginhistory` (`id`, `username`, `timeLogin`, `timeLogout`) VALUES
(499, 'admin', '2019-12-11 14:15:13', NULL),
(500, 'admin', '2019-12-11 14:19:37', NULL),
(501, 'user', '2019-12-11 14:21:07', NULL),
(502, 'admin', '2019-12-11 14:52:02', NULL),
(503, 'user', '2019-12-11 15:04:21', NULL),
(504, 'admin', '2019-12-13 07:36:00', NULL),
(505, 'admin', '2019-12-13 07:49:23', NULL),
(506, 'admin', '2019-12-13 07:58:22', NULL),
(507, 'pi3', '2019-12-13 08:00:45', NULL),
(508, 'admin', '2019-12-13 08:10:06', NULL),
(509, 'admin', '2019-12-13 08:11:57', NULL),
(510, 'admin', '2019-12-13 08:13:49', NULL),
(511, 'admin', '2019-12-13 08:14:23', NULL),
(512, 'admin', '2019-12-13 08:15:43', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `products`
--

CREATE TABLE `products` (
  `pid` int(11) NOT NULL,
  `productName` varchar(50) NOT NULL,
  `productCategory` varchar(50) NOT NULL,
  `productBrand` varchar(50) NOT NULL,
  `productPrice` double NOT NULL,
  `productStock` int(11) NOT NULL,
  `addedDate` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `products`
--

INSERT INTO `products` (`pid`, `productName`, `productCategory`, `productBrand`, `productPrice`, `productStock`, `addedDate`) VALUES
(80, 'ASUS ROG', 'Laptop', 'ASUS', 50000, 25, '2019-12-10 15:48:05'),
(81, 'Iphone X', 'IOS', 'Apple', 455000, 50, '2019-12-10 15:55:06'),
(82, 'Iphone 5s', 'IOS', 'Apple', 45000, 10, '2019-12-10 15:58:21'),
(84, 'Samsung J1', 'Android ', 'Samsung', 9990, 75, '2019-12-10 16:09:39'),
(88, 'Mouse', 'Computer Hardware', 'Samsung', 350, 8, '2019-12-11 14:54:07'),
(89, 'Mechanical Keyboard', 'Computer Peripherals', 'Rakk', 2130, 9, '2019-12-13 07:50:51');

-- --------------------------------------------------------

--
-- Table structure for table `sales`
--

CREATE TABLE `sales` (
  `saleid` int(11) NOT NULL,
  `customerName` varchar(100) NOT NULL,
  `productName` varchar(100) NOT NULL,
  `productPrice` int(99) NOT NULL,
  `qty` int(99) NOT NULL,
  `discount` int(3) NOT NULL,
  `total` int(99) NOT NULL,
  `paid` int(99) NOT NULL,
  `due` int(99) NOT NULL,
  `date` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `sales`
--

INSERT INTO `sales` (`saleid`, `customerName`, `productName`, `productPrice`, `qty`, `discount`, `total`, `paid`, `due`, `date`) VALUES
(31, 'Abas', 'Iphone 7s', 45000, 1, 0, 45000, 45000, 0, '2019-12-10 16:12:19'),
(32, 'Leynard', 'Iphone 7s', 45000, 1, 0, 45000, 45000, 0, '2019-12-11 13:10:11'),
(33, 'John Michael', 'Mouse', 1000, 2, 0, 2000, 2000, 0, '2019-12-11 13:13:16'),
(37, 'Leynard', 'Iphone X', 455000, 2, 0, 910000, 91000, 819000, '2019-12-11 13:37:57'),
(38, 'JC', 'ASUS ROG', 50, 2, 30, 100, 100, 0, '2019-12-11 13:47:42'),
(39, 'JC Nitro', 'Mouse', 350, 2, 20, 560, 560, 0, '2019-12-11 14:59:49'),
(40, 'John Crist', 'Mechanical Keyboard', 2130, 1, 20, 1704, 1704, 0, '2019-12-13 07:55:40');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `uID` int(11) NOT NULL,
  `firstName` varchar(50) NOT NULL,
  `lastName` varchar(50) NOT NULL,
  `userName` varchar(30) NOT NULL,
  `userPassword` varchar(200) NOT NULL,
  `userEmail` varchar(50) NOT NULL,
  `userRole` text NOT NULL,
  `dateCreated` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`uID`, `firstName`, `lastName`, `userName`, `userPassword`, `userEmail`, `userRole`, `dateCreated`) VALUES
(13, 'Robert', 'Miras', 'Admin', 'admin', 'example@yahoo.com', 'Admin', '2019-12-04 03:05:05'),
(14, 'Riennel', 'Abas', 'User', 'user', 'example@email.com', 'User', '2019-12-04 13:30:18'),
(21, 'rieniel', 'abas', 'abas24', 'abas', 'absa@yahoo.com', 'Admin', '2019-12-11 15:03:22'),
(22, 'John', 'Helbrg', 'pi3', 'Friend', 'john22@gmail.com', 'User', '2019-12-13 08:00:16');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `brands`
--
ALTER TABLE `brands`
  ADD PRIMARY KEY (`bid`);

--
-- Indexes for table `categories`
--
ALTER TABLE `categories`
  ADD PRIMARY KEY (`cid`);

--
-- Indexes for table `dashboardstat`
--
ALTER TABLE `dashboardstat`
  ADD PRIMARY KEY (`did`);

--
-- Indexes for table `loginhistory`
--
ALTER TABLE `loginhistory`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`pid`);

--
-- Indexes for table `sales`
--
ALTER TABLE `sales`
  ADD PRIMARY KEY (`saleid`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`uID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `brands`
--
ALTER TABLE `brands`
  MODIFY `bid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=70;

--
-- AUTO_INCREMENT for table `categories`
--
ALTER TABLE `categories`
  MODIFY `cid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=34;

--
-- AUTO_INCREMENT for table `dashboardstat`
--
ALTER TABLE `dashboardstat`
  MODIFY `did` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `loginhistory`
--
ALTER TABLE `loginhistory`
  MODIFY `id` int(99) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=513;

--
-- AUTO_INCREMENT for table `products`
--
ALTER TABLE `products`
  MODIFY `pid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=90;

--
-- AUTO_INCREMENT for table `sales`
--
ALTER TABLE `sales`
  MODIFY `saleid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=41;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `uID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

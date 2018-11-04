-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 04, 2018 at 12:59 PM
-- Server version: 10.1.35-MariaDB
-- PHP Version: 7.2.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `frs_school`
--

-- --------------------------------------------------------

--
-- Table structure for table `frs_attendance`
--

CREATE TABLE `frs_attendance` (
  `attId` int(10) NOT NULL,
  `datetime` datetime(6) NOT NULL,
  `studentid` int(10) NOT NULL,
  `studentName` varchar(50) NOT NULL,
  `class` varchar(20) NOT NULL,
  `pid` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `frs_attendance`
--

INSERT INTO `frs_attendance` (`attId`, `datetime`, `studentid`, `studentName`, `class`, `pid`) VALUES
(1, '2018-09-28 09:30:05.123456', 1, 'Md. Hasan Mahmood', 'CSE', '9de6a93ed542417b90b1a6185c2a45b5'),
(2, '2018-09-28 09:31:06.123456', 6, 'Sumaiya', 'CSE', 'ae9859f4929a496f9f3d4a7492d35c06'),
(3, '2018-10-08 01:33:05.000000', 2, 'Ariful', 'EEE', 'da1f8fdd66b64baba796a3a33d775fa5'),
(4, '2018-10-09 12:33:24.000000', 2, 'Ariful', 'EEE', 'da1f8fdd66b64baba796a3a33d775fa5'),
(5, '2018-10-10 11:47:58.000000', 2, 'Ariful', 'EEE', 'da1f8fdd66b64baba796a3a33d775fa5'),
(6, '2018-10-11 12:32:34.000000', 2, 'Ariful', 'EEE', 'da1f8fdd66b64baba796a3a33d775fa5'),
(7, '2018-10-13 02:09:53.000000', 2, 'Ariful', 'EEE', 'da1f8fdd66b64baba796a3a33d775fa5'),
(8, '2018-10-14 11:58:38.000000', 2, 'Ariful', 'EEE', 'da1f8fdd66b64baba796a3a33d775fa5'),
(9, '2018-10-15 10:06:43.000000', 2, 'Ariful', 'EEE', 'da1f8fdd66b64baba796a3a33d775fa5'),
(10, '2018-10-16 03:37:06.000000', 2, 'Ariful', 'EEE', 'da1f8fdd66b64baba796a3a33d775fa5');

-- --------------------------------------------------------

--
-- Table structure for table `frs_ble`
--

CREATE TABLE `frs_ble` (
  `bleuid` varchar(32) NOT NULL,
  `student_name` varchar(50) NOT NULL,
  `student_id` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `frs_ble`
--

INSERT INTO `frs_ble` (`bleuid`, `student_name`, `student_id`) VALUES
('30cac36016da43a687c88098e790e345', 'AZM Ariful Haque Real', 15),
('aaa', 'Md Hasan Mahmud', 16);

-- --------------------------------------------------------

--
-- Table structure for table `frs_blegateway`
--

CREATE TABLE `frs_blegateway` (
  `gatewayid` varchar(32) NOT NULL,
  `location` varchar(32) NOT NULL,
  `floor` varchar(10) NOT NULL,
  `building` varchar(20) NOT NULL,
  `room` varchar(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `frs_blegateway`
--

INSERT INTO `frs_blegateway` (`gatewayid`, `location`, `floor`, `building`, `room`) VALUES
('1', 'PPL', '14', 'Rupayun Shelford', 'IOT');

-- --------------------------------------------------------

--
-- Table structure for table `frs_blelocation`
--

CREATE TABLE `frs_blelocation` (
  `bleuid` varchar(32) NOT NULL,
  `gatewayid` varchar(32) NOT NULL,
  `datetime` datetime(6) NOT NULL,
  `rssi` varchar(10) NOT NULL,
  `ble_location` varchar(10) NOT NULL,
  `distance` int(5) NOT NULL,
  `status` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `frs_blelocation`
--

INSERT INTO `frs_blelocation` (`bleuid`, `gatewayid`, `datetime`, `rssi`, `ble_location`, `distance`, `status`) VALUES
('1', '1', '0000-00-00 00:00:00.000000', '10', '(150,650)', 10, 0),
('2', '1', '0000-00-00 00:00:00.000000', '10', '(150,650)', 10, 0),
('aaa', '1', '0000-00-00 00:00:00.000000', '10', '(150,650)', 10, 0),
('nnnn', '1', '0000-00-00 00:00:00.000000', '10', '(150,650)', 10, 0);

-- --------------------------------------------------------

--
-- Table structure for table `frs_blelogs`
--

CREATE TABLE `frs_blelogs` (
  `logid` int(10) NOT NULL,
  `bleid` varchar(32) NOT NULL,
  `gatewayid` int(10) NOT NULL,
  `entrytime` datetime(6) NOT NULL,
  `exittime` datetime(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `frs_camera_list`
--

CREATE TABLE `frs_camera_list` (
  `camera_id` int(10) NOT NULL,
  `camera_location` varchar(50) NOT NULL,
  `camera_ip` varchar(50) NOT NULL,
  `username` varchar(10) NOT NULL,
  `password` varchar(10) NOT NULL,
  `protocol` varchar(10) NOT NULL,
  `camera_url` varchar(50) NOT NULL,
  `stream_url` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `frs_camera_list`
--

INSERT INTO `frs_camera_list` (`camera_id`, `camera_location`, `camera_ip`, `username`, `password`, `protocol`, `camera_url`, `stream_url`) VALUES
(1, 'conference_room', '192.168.0.105', 'admin', '20160404', 'rtsp', 'rtsp://admin:20160404@192.168.0.103/onvif2', 'http://192.168.0.111:8080/'),
(2, 'conference_room2', '192.168.0.116', 'admin', '20160404', 'rtsp', 'rtsp://admin:20160404@192.168.0.103/onvif2', 'http://192.168.0.103:8080/');

-- --------------------------------------------------------

--
-- Table structure for table `frs_captureresult`
--

CREATE TABLE `frs_captureresult` (
  `frameIdx` int(10) NOT NULL,
  `objects_class` int(1) NOT NULL,
  `rect_bottom` int(4) NOT NULL,
  `rect_left` int(4) NOT NULL,
  `rect_right` int(4) NOT NULL,
  `rect_top` int(4) NOT NULL,
  `track_Idx` int(10) NOT NULL,
  `time` datetime NOT NULL,
  `image_url` varchar(100) NOT NULL,
  `dataLen` int(10) NOT NULL,
  `data` int(20) NOT NULL,
  `height` int(4) NOT NULL,
  `width` int(4) NOT NULL,
  `indexx` int(6) NOT NULL,
  `rebackInfo` int(9) NOT NULL,
  `flag` int(1) NOT NULL,
  `9632` int(6) NOT NULL,
  `url` varchar(50) NOT NULL,
  `taskIdx` int(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `frs_captureresult`
--

INSERT INTO `frs_captureresult` (`frameIdx`, `objects_class`, `rect_bottom`, `rect_left`, `rect_right`, `rect_top`, `track_Idx`, `time`, `image_url`, `dataLen`, `data`, `height`, `width`, `indexx`, `rebackInfo`, `flag`, `9632`, `url`, `taskIdx`) VALUES
(921, 1, 261, 1823, 1823, 191, 2356, '2017-05-05 12:27:15', 'http://172.18.0.163:18080/g1/M01/00/00/r.jpg', 6266880, 2147483647, 1088, 1920, 921, 347013120, 0, 0, 'http://172.18.0.163:18080/g1/M01/00/00/r.jpg', 2147483647),
(921, 3, 152, 1009, 1061, 108, 7806, '2017-05-05 12:27:15', 'http://172.18.0.163:18080/g1/M01/00/00/r.jpg', 6266880, 2147483647, 1088, 1920, 921, 347013120, 0, 0, 'http://172.18.0.163:18080/g1/M01/00/00/r.jpg', 2147483647),
(921, 3, 152, 1009, 1061, 108, 7807, '2017-05-05 12:27:15', 'http://172.18.0.163:18080/g1/M01/00/00/r.jpg', 6266880, 2147483647, 1088, 1920, 921, 347013120, 0, 0, 'http://172.18.0.163:18080/g1/M01/00/00/r.jpg', 2147483647),
(921, 3, 512, 538, 858, 309, 7966, '2017-05-05 12:27:15', 'http://172.18.0.163:18080/g1/M01/00/00/r.jpg', 6266880, 2147483647, 1088, 1920, 921, 347013120, 0, 0, 'http://172.18.0.163:18080/g1/M01/00/00/r.jpg', 2147483647);

-- --------------------------------------------------------

--
-- Table structure for table `frs_classtable`
--

CREATE TABLE `frs_classtable` (
  `class_id` int(3) NOT NULL,
  `day` varchar(10) NOT NULL,
  `class_start` time(6) NOT NULL,
  `class_end` time(6) NOT NULL,
  `course_name` varchar(20) NOT NULL,
  `section` int(10) NOT NULL,
  `course_id` varchar(10) NOT NULL,
  `instructor_name` varchar(20) NOT NULL,
  `room_no` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `frs_classtable`
--

INSERT INTO `frs_classtable` (`class_id`, `day`, `class_start`, `class_end`, `course_name`, `section`, `course_id`, `instructor_name`, `room_no`) VALUES
(3, 'Sunday', '09:00:00.000000', '12:00:00.000000', 'Machine Learning', 1, 'CSE501', 'Shorif Hossain', 'IOT'),
(4, 'Monday', '12:00:00.000000', '15:00:00.000000', 'Advanced Database', 2, 'CSE502', 'Hafizur Rahman', 'NAC203'),
(5, 'Tuesday', '09:00:00.000000', '12:00:00.000000', 'Machine Learning', 1, 'CSE501', 'Shorif Hossain', 'IOT'),
(6, 'Wednesday', '12:00:00.000000', '15:00:00.000000', 'Advanced Database', 1, 'CSE502', 'Hafizur Rahman', 'NAC203'),
(7, 'Sunday', '15:00:00.000000', '18:00:00.000000', 'Neural Network', 1, 'CSE503', 'Emdadul Haque', 'IOT'),
(8, 'Tuesday', '15:00:00.000000', '18:00:00.000000', 'Neural Network', 1, 'CSE503', 'Emdadul Haque', 'IOT'),
(9, 'Sunday', '12:00:00.000000', '15:00:00.000000', 'Bioinformatics', 1, 'CSE504', 'Lamia Iftekhar', 'IOT'),
(10, 'Tuesday', '12:00:00.000000', '15:00:00.000000', 'Bioinformatics', 1, 'CSE504', 'Lamia Iftekhar', 'IOT');

-- --------------------------------------------------------

--
-- Table structure for table `frs_image`
--

CREATE TABLE `frs_image` (
  `full_name` varchar(50) NOT NULL,
  `student_id` int(5) NOT NULL,
  `phone` varchar(15) NOT NULL,
  `class` varchar(50) NOT NULL,
  `address` varchar(100) NOT NULL,
  `dob` varchar(50) NOT NULL,
  `image_path` varchar(100) NOT NULL,
  `imageId` varchar(32) NOT NULL,
  `personId` varchar(32) NOT NULL,
  `qualityScore` double NOT NULL,
  `feature` varchar(3000) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `frs_image`
--

INSERT INTO `frs_image` (`full_name`, `student_id`, `phone`, `class`, `address`, `dob`, `image_path`, `imageId`, `personId`, `qualityScore`, `feature`) VALUES
('Aktar', 1, '01700123123', 'EEE', 'Farm Gate, Dhaka', '1990-05-04', 'C:\\xampp\\htdocs\\frs2018\\db\\image\\00001_Aktar.jpg', 'ae9859f4929a496f9f3d4a7492d35c01', 'ae9859f4929a496f9f3d4a7492d35c06', 78, '7qpXQiVeAAAAAQAAUmwDPQDvNz2q2dq8PA8hPeH53j3Ls7W9YqLrPY1hjL3HK dAAjvToGoQ=='),
('Ariful', 2, '01911227945', 'EEE', 'Adabor, Dhaka', '1992-04-21', 'C:\\xampp\\htdocs\\frs2018\\db\\image\\00002_Ariful.jpg', 'ae9859f4929a496f9f3d4a7492d35c02', 'da1f8fdd66b64baba796a3a33d775fa5', 79.21, '7qpXQiVeAAAAAQAAUmwDPQDvNz2q2dq8PA8hPeH53j3Ls7W9YqLrPY1hjL3HK dA7ANAjvoGoQ=='),
('Apurbo', 3, '01700123456', 'CSE', 'Dhaka', '1991-05-15', 'C:\\xampp\\htdocs\\frs2018\\db\\image\\00001_Apurbo.jpg', 'ae9859f4929a496f9f3d4a7492d35c01', 'ae9859f4929a496f9f3d4a7492d35c01', 79.21, '7qpXQiVeAAAAAQAAUmwDPQDvNz2q2dq8PA8hPeH53j3Ls7W9YqLrPY1hjL3HK dA7ANAjvToQ=='),
('Nasirul', 4, '01700123456', 'CSE', 'Mirpur, DHaka', '1991-05-16', 'C:\\xampp\\htdocs\\frs2018\\db\\image\\00004_Nasirul.jpg', 'ae9859f4929a496f9f3d4a7492d35c04', 'ae9859f4929a496f9f3d4a7492d35c04', 81, 'qpXQiVeAAAAAQAAUmwDPQDvNz2q2dq8PA8hPeH53j3Ls7W9YqLrPY1hjL3HK dA7ANAjvToQ=='),
('Hasan', 5, '01700123456', 'CSE', 'Uttora, Dhaka', '1991-06-20', 'C:\\xampp\\htdocs\\frs2018\\db\\image\\00005_Hasan.jpg', 'ae9859f4929a496f9f3d4a7492d35c05', 'ae9859f4929a496f9f3d4a7492d35c05', 80.11, '8qpXQiVeAAAAAQAAUmwDPQDvNz2q2dq8PA8hPeH53j3Ls7W9YqLrPY1hjL3HK dA7ANAjvToQ=='),
('Sumaiya', 6, '01700123456', 'CSE', 'Uttora, Dhaka', '1991-06-20', 'C:\\xampp\\htdocs\\frs2018\\db\\image\\00006_Sumaiya.jpg', 'ae9859f4929a496f9f3d4a7492d35c06', 'ae9859f4929a496f9f3d4a7492d35c06', 78, '9qpXQiVeAAAAAQAAUmwDPQDvNz2q2dq8PA8hPeH53j3Ls7W9YqLrPY1hjL3HK dA7ANAjvToQ==');

-- --------------------------------------------------------

--
-- Table structure for table `frs_login`
--

CREATE TABLE `frs_login` (
  `loginid` int(10) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `frs_login`
--

INSERT INTO `frs_login` (`loginid`, `username`, `password`) VALUES
(1, 'admin', '123456');

-- --------------------------------------------------------

--
-- Table structure for table `frs_pedes_result`
--

CREATE TABLE `frs_pedes_result` (
  `type` int(1) NOT NULL,
  `seq` int(5) NOT NULL,
  `taskIdx` int(30) NOT NULL,
  `time` datetime(6) NOT NULL,
  `trackIdx` int(10) NOT NULL,
  `feature_file` varchar(100) NOT NULL,
  `url` varchar(100) NOT NULL,
  `rect_left` int(4) NOT NULL,
  `rect_top` int(4) NOT NULL,
  `rect_right` int(4) NOT NULL,
  `rect_bottom` int(4) NOT NULL,
  `age_conf` int(4) NOT NULL,
  `age_label` int(1) NOT NULL,
  `angle_conf` int(4) NOT NULL,
  `angle_label` int(1) NOT NULL,
  `gender_conf` int(4) NOT NULL,
  `gender_label` int(1) NOT NULL,
  `bag_conf` int(4) NOT NULL,
  `bag_label` int(1) NOT NULL,
  `hat_conf` int(4) NOT NULL,
  `hat_label` int(1) NOT NULL,
  `holdObjectInFront_conf` int(4) NOT NULL,
  `holdObjectInFront_label` int(1) NOT NULL,
  `longcoat_conf` int(4) NOT NULL,
  `longcoat_label` int(1) NOT NULL,
  `pants_conf` int(4) NOT NULL,
  `pants_label` int(1) NOT NULL,
  `plasticBag_conf` int(4) NOT NULL,
  `plasticBag_label` int(1) NOT NULL,
  `shoes_conf` int(4) NOT NULL,
  `shoes_label` int(1) NOT NULL,
  `upperClothing_conf` int(4) NOT NULL,
  `upperClothing_label` int(1) NOT NULL,
  `glasses_conf` int(4) NOT NULL,
  `glasses_label` int(1) NOT NULL,
  `mask_conf` int(4) NOT NULL,
  `mask_label` int(1) NOT NULL,
  `upperColor_conf` int(4) NOT NULL,
  `upperColor_label` int(1) NOT NULL,
  `lowerColor_conf` int(4) NOT NULL,
  `lowerColor_label` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `frs_pedes_result`
--

INSERT INTO `frs_pedes_result` (`type`, `seq`, `taskIdx`, `time`, `trackIdx`, `feature_file`, `url`, `rect_left`, `rect_top`, `rect_right`, `rect_bottom`, `age_conf`, `age_label`, `angle_conf`, `angle_label`, `gender_conf`, `gender_label`, `bag_conf`, `bag_label`, `hat_conf`, `hat_label`, `holdObjectInFront_conf`, `holdObjectInFront_label`, `longcoat_conf`, `longcoat_label`, `pants_conf`, `pants_label`, `plasticBag_conf`, `plasticBag_label`, `shoes_conf`, `shoes_label`, `upperClothing_conf`, `upperClothing_label`, `glasses_conf`, `glasses_label`, `mask_conf`, `mask_label`, `upperColor_conf`, `upperColor_label`, `lowerColor_conf`, `lowerColor_label`) VALUES
(1, 27398, 2147483647, '2017-09-11 16:00:21.000000', 1, 'C:/xampp/htdocs/frs2018/ped_result/187_1.txt', 'http://172.18.0.210:18080/g1/M01/00/00/rBIA0lm2XrWIZtb_AAAH21ILQ6cAAAADAf2ZIoAA Afz122.jpg', 0, 0, 108, 135, 1, 1, 1, 1, 1, 0, 1, 4, 0, 0, 0, 1, 0, 1, 1, 0, 0, 1, 0, 0, 1, 1, 0, 0, 0, 0, 1, 3, 1, 3),
(1, 27398, 2147483647, '2017-09-11 16:00:21.000000', 48000, 'C:/xampp/htdocs/frs2018/ped_result/187_48000.txt', 'http://172.18.0.210:18080/g1/M01/00/00/rBIA0lm2XrWIZtb_AAAH21ILQ6cAAAADAf2ZIoAAAfz122.jpg', 0, 0, 108, 135, 1, 1, 1, 1, 1, 0, 1, 4, 0, 0, 0, 1, 0, 1, 1, 0, 0, 1, 0, 0, 1, 1, 0, 0, 0, 0, 1, 3, 1, 3);

-- --------------------------------------------------------

--
-- Table structure for table `frs_student`
--

CREATE TABLE `frs_student` (
  `student_id` int(32) NOT NULL,
  `first_name` varchar(32) NOT NULL,
  `last_name` varchar(32) NOT NULL,
  `email_address` varchar(50) NOT NULL,
  `password` varchar(500) NOT NULL,
  `phone_number` int(50) NOT NULL,
  `address` varchar(100) NOT NULL,
  `building_number` varchar(20) NOT NULL,
  `road` varchar(50) NOT NULL,
  `postal_code` int(32) NOT NULL,
  `additional_details` varchar(32) NOT NULL,
  `district` varchar(32) NOT NULL,
  `city` varchar(32) NOT NULL,
  `country` varchar(32) NOT NULL,
  `time` varchar(50) NOT NULL,
  `father_name` varchar(50) NOT NULL,
  `mother_name` varchar(50) NOT NULL,
  `student_image` varchar(100) NOT NULL,
  `dob` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `frs_student`
--

INSERT INTO `frs_student` (`student_id`, `first_name`, `last_name`, `email_address`, `password`, `phone_number`, `address`, `building_number`, `road`, `postal_code`, `additional_details`, `district`, `city`, `country`, `time`, `father_name`, `mother_name`, `student_image`, `dob`) VALUES
(15, 'Md Hasan', 'Mahmood', 'hasan.mahmood@dma-bd.com', '123456', 1700000000, '', 'Dhaka', 'Uttora', 1208, 'Dhaka', 'Dhaka', 'Dhaka', 'Bangladesh', '2018-08-30 21:21:37', 'NA', 'NA', 'db\\students\\Md.Hasan Mahmud.jpg', '1991-05-15'),
(16, 'AZM Ariful', 'Real', 'ariful.haque@dma-bd.com', '123456', 1911227945, '', 'Dhaka/1207', 'Ring Road', 1207, 'Dhaka', 'Dhaka', 'Dhaka', 'Bangladesh', '2018-08-30 21:22:56', 'NA', 'NA', 'db/students/AZM Ariful Haque Real.jpg', '1992-04-21'),
(17, 'Apurbo Kumar', 'Saha', 'apurbo.saha@dma-bd.com', '123456', 1800000000, '', 'Dhaka/1211', 'Mirpur', 1211, 'Dhaka', 'Dhaka', 'Dhaka', 'Bangladesh', '2018-08-30 21:24:13', 'NA', 'NA', 'db/students/Apurbo Kumar Saha.jpg', '1992-06-06'),
(18, 'MM', 'Aktaruzzaman', 'aktar.uzzaman@dma-bd.com', '123456', 1900000000, '', 'Farm Gate', 'Farm Gate', 1209, 'Dhaka', 'Dhaka', 'Dhaka', 'Bangladesh', '2018-08-30 21:26:19', 'NA', 'NA', 'db/students/M. M. Aktaruzzaman.jpg', '0000-00-00'),
(19, 'Sumaiya Tasnim ', 'Nuha', 'sumaiya.nuha@dma-bd.com', '123456', 1760000000, '', 'Dhaka/1207', 'Dhanmondi', 1215, 'Dhaka', 'Dhaka', 'Dhaka', 'Bangladesh', '2018-08-30 21:28:05', 'NA', 'NA', 'db/students/Sumaiya Tasmim Nuha.jpg', '0000-00-00'),
(20, 'Md Nasirul ', 'Haque', 'nasirul.haque@dma-bd.com', '123456', 1760000000, '', 'Dhaka/1211', 'Mirpur', 1219, 'Dhaka', 'Dhaka', 'Dhaka', 'Bangladesh', '2018-08-30 21:30:06', 'NA', 'NA', 'db/students/MD. NASIRUL HAQUE.jpg', '0000-00-00');

-- --------------------------------------------------------

--
-- Table structure for table `frs_studentcourses`
--

CREATE TABLE `frs_studentcourses` (
  `number` int(11) NOT NULL,
  `student_id` int(10) NOT NULL,
  `student_name` varchar(20) NOT NULL,
  `course_id` varchar(20) NOT NULL,
  `course_name` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `frs_studentcourses`
--

INSERT INTO `frs_studentcourses` (`number`, `student_id`, `student_name`, `course_id`, `course_name`) VALUES
(1, 15, 'Md Hasan Mahmood', 'CSE501', 'Machine Learning'),
(2, 16, 'AZM Ariful 	Real', 'CSE502', 'Advanced Database'),
(3, 16, 'AZM Ariful 	Real', 'CSE501', 'Machine Learning'),
(4, 16, 'AZM Ariful 	Real', 'CSE504', 'Bioinformatics');

-- --------------------------------------------------------

--
-- Table structure for table `frs_targetdatabase`
--

CREATE TABLE `frs_targetdatabase` (
  `db_id` int(10) NOT NULL,
  `db_name` varchar(20) NOT NULL,
  `reg_time` datetime(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `frs_targetdatabase`
--

INSERT INTO `frs_targetdatabase` (`db_id`, `db_name`, `reg_time`) VALUES
(1, 'newdbtext', '2018-09-04 17:31:08.000000');

-- --------------------------------------------------------

--
-- Table structure for table `frs_vehicle`
--

CREATE TABLE `frs_vehicle` (
  `vehicle_id` int(50) NOT NULL,
  `student_name` varchar(20) NOT NULL,
  `student_id` varchar(32) NOT NULL,
  `vehicle_brand` varchar(50) NOT NULL,
  `vehicle_model` varchar(50) NOT NULL,
  `vehicle_image` varchar(100) NOT NULL,
  `vehicle_plate` varchar(50) NOT NULL,
  `vehicle_color` varchar(32) NOT NULL,
  `vehicle_owner` varchar(50) NOT NULL,
  `time` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `frs_vehicle`
--

INSERT INTO `frs_vehicle` (`vehicle_id`, `student_name`, `student_id`, `vehicle_brand`, `vehicle_model`, `vehicle_image`, `vehicle_plate`, `vehicle_color`, `vehicle_owner`, `time`) VALUES
(37, 'Hasan Mahmood', '1001', 'Toyota', 'Corolla', 'db\\vehicle\\car1.jpg', 'DHAKA METRO-GA 15-9591', 'dark blue', 'Hasan Mahmood', '2018-08-29 15:36:11'),
(38, 'Apurbo Saha', '1002', 'Toyota', 'Allion 2010', 'db\\vehicle\\car2.jpg', 'DHAKA METRO-GA 33-7440', 'white', 'Apurbo Saha', '2018-08-29 15:38:56'),
(39, 'MM Aktaruzzaman', '1003', 'Toyota', 'Aqua 2010', 'db\\vehicle\\car3.jpg', 'DHAKA METRO 37-1636', 'Sky Blue', 'MM Aktaruzzaman', '2018-08-29 15:41:11'),
(40, 'Ariful Haque', '1004', 'Honda', 'Civic', 'db\\vehicle\\car4.jpg', 'DHAKA METRO-GA 25-9892', 'Red', 'Ariful Haque', '2018-08-29 15:45:10'),
(41, 'Nuha Khan', '1005', 'Honda', 'Civic', 'db\\vehicle\\car5.jpg', 'DHAKA METRO-GA 23-5953', 'White', 'Nuha Khan', '2018-08-29 15:47:21'),
(42, 'Ridoy', '1006', 'Toyota', 'Premio', 'db\\vehicle\\car6.jpg', 'DHAKA METRO-GA 27-2567', 'Red', 'Riodoy', '2018-08-29 15:49:19');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_admin`
--

CREATE TABLE `tbl_admin` (
  `admin_id` int(32) NOT NULL,
  `user_id` int(32) NOT NULL,
  `privilege` int(1) NOT NULL DEFAULT '1',
  `user_name` varchar(32) NOT NULL,
  `time` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_admin`
--

INSERT INTO `tbl_admin` (`admin_id`, `user_id`, `privilege`, `user_name`, `time`) VALUES
(900001, 3, 1, 'admin', '0000-00-00 00:00:00');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_company`
--

CREATE TABLE `tbl_company` (
  `company_id` int(32) NOT NULL,
  `company_name` varchar(50) NOT NULL,
  `contact_number` varchar(32) NOT NULL,
  `email_address` varchar(32) NOT NULL,
  `company_additional_address` varchar(32) NOT NULL,
  `company_area` varchar(32) NOT NULL,
  `company_district` varchar(32) NOT NULL,
  `company_city` varchar(32) NOT NULL,
  `time` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_company`
--

INSERT INTO `tbl_company` (`company_id`, `company_name`, `contact_number`, `email_address`, `company_additional_address`, `company_area`, `company_district`, `company_city`, `time`) VALUES
(20001, 'DataSoft Manufacturing & Assembly Inc. Ltd.', '+8801749466468', 'info@dma-bd.com', 'Bangobandhu Hi Tech City', 'Kaliakoir', 'Gazipur', 'Dhaka', '2018-07-01 05:15:00');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_customer`
--

CREATE TABLE `tbl_customer` (
  `customer_id` int(32) NOT NULL,
  `user_id` int(32) NOT NULL,
  `user_name` varchar(32) NOT NULL,
  `privilege` int(1) NOT NULL DEFAULT '3',
  `time` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_customer`
--

INSERT INTO `tbl_customer` (`customer_id`, `user_id`, `user_name`, `privilege`, `time`) VALUES
(1, 4, 'nuha', 3, '2018-08-13 12:11:50');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_operator`
--

CREATE TABLE `tbl_operator` (
  `operator_id` int(32) NOT NULL,
  `user_id` int(32) NOT NULL,
  `privilege` int(1) NOT NULL DEFAULT '2',
  `user_name` varchar(32) NOT NULL,
  `time` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_secret`
--

CREATE TABLE `tbl_secret` (
  `code_id` int(11) NOT NULL,
  `puk_code` varchar(20) NOT NULL,
  `hash_code` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_secret`
--

INSERT INTO `tbl_secret` (`code_id`, `puk_code`, `hash_code`) VALUES
(51, '4Z0US148', 'd451b6247efc013cb1c45c0020be0f3f'),
(52, 'OKHRETCD', '42bbf1faa904db802af2d2f16e3df514'),
(53, 'HSW42ELZ', '7b1b602c14fec7e66a35d909fe822d43'),
(54, 'U6QWE67X', '7c31001432aaa353347fdf2c26098881'),
(55, 'THYVVY5A', '376759bb6290939e646372b2c48e931d'),
(56, '2T53TVMK', 'a0cc2fe436b0ee3221f7f05f97c1cfd9'),
(57, 'EI441N3V', '60c3699f0526cb70dde4e5d6536684f6'),
(58, 'AB8O6JV3', 'ae4c54d023399547336d2a32dc4af363'),
(59, 'EGYWH81Q', '3ba00d5867d24c94d643a75a3f9163c7'),
(60, 'O4HYKYPZ', 'c27af76654b1d8c4ddd2b76527ef5aa0'),
(61, 'CT1BYPNE', 'e71bd1ab83ced9159aba134e54eb4a6d'),
(62, 'I7IALD5T', '4e1002418d82b766ab32f9952e318be1'),
(63, '3BQP8Z8Y', '0ec3033480be4ebb0de818f3d9f561de'),
(64, 'YQ3XYU40', '87a990e788d070975f41f137ccb2f3ad'),
(65, 'KQ719L31', '0367004910662bdd52c1089c9febdf37'),
(66, '2HVOP3L1', '87f05a2b79bfb80ee944ec54019ce4cf'),
(67, 'RSB3YFYQ', '5e67e95187964a9223bc82a0a1745f66'),
(68, 'SLYW58UB', '40fc7c0efe58beba097a764ed85c0dd7'),
(69, 'Y0JWB0MK', 'b002fbc4d51da02e47c8950a66977817'),
(70, 'XO30BPAU', '75d8a208afbcd226341326c1d975d836'),
(71, 'D3LPCRCY', '0740beda4f742194cefd37459b7d243e'),
(72, '8L2SSS1F', '647563466a3eae04d90ceaf981959ecb'),
(73, '87XR29IB', 'd83b8b2d6fcb6c4e66b0d947797ba393'),
(74, 'TC0ITIAJ', '4d8570137eb55da0c7d267a0bb050e83'),
(75, 'EN535GGB', 'ca51ee38d6f03165bd8b2bf3fc1bada6'),
(76, 'MLW9ZA1P', '80206a63e56f7ca32e938011da18503b'),
(77, '4ZVCPD0I', '8d1e0e5f359bc598896d4392062fcfe7'),
(78, 'C2SFHPPD', 'aed8f7c51aff52dbebaf06004cfc2b9a'),
(79, '2EGEW337', '8f48623a7349e77930d1d93d3c7a9724'),
(80, '98IS61EU', '79e8ae2015e3ef7226f7e7c56b09e0a7'),
(81, '6X0S0NT5', 'd96f4b20bff3bd6a4cdefdf364e71dba'),
(82, 'UVV5L8O9', '47b5a8383cd39aaf1c6b051fa9cdec32'),
(83, 'MHB7XQC6', 'c6d73e860bca9fe346e4da1c3fe90dc9'),
(84, 'VR9H1ZVH', '32fd9d318f8c52504b0ee6f4c4e48e81'),
(85, '3EYMPF5C', '78a579077e8bd37518dcfe0ca5eb6399'),
(86, 'GKF5OO3H', '7501c9d7af61bf27f658e934b1f25f6b'),
(87, 'TGVWLEUW', '21cf791b833535994896865d7849d414'),
(88, 'L7I9F8TF', 'fcbe21761ec6b7b27ae0cf7d784e1484'),
(89, 'Y9M5TEHY', 'de0a0476a0bac81784062a75186758a6'),
(90, 'FG1H0YGH', '28028fd2e722e8d3a742c5f6a3d007be'),
(91, '92AG95J6', 'a19ecdfec73ba3d3da9d04294b2b8dba'),
(92, 'XIA2MUVD', '4c154052e92d3c45d0ffe3e00e21ce56'),
(93, 'OTJ5OFIT', '3f9c851005154a269db7c1fc18c9818c'),
(94, 'XC4JHQT9', '90c511fa091ea54a6a0751fcf2d4a179'),
(95, 'OIZF5NH5', '9278805f2bc3fa6d4f7b34435381a0b1'),
(96, 'O4RHLI7G', '0aa8d9c9d7ebcc2368f06b8e308f35e7'),
(97, '7AC03YJQ', 'cd6d47fbb517e8658278c96142739c19'),
(98, 'K7DGBA7K', 'f742d09c04759be0f3c1329f2488c842'),
(99, '6MIES357', '8cd60138fb504e2af8656ab0799ad0c0'),
(100, 'B5W07EHZ', '5cc86855687b01a80ecdd7d16aae2877');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_shared_users`
--

CREATE TABLE `tbl_shared_users` (
  `shared_id` int(32) NOT NULL,
  `shared_tank_id` int(32) NOT NULL,
  `shared_device_id` varchar(32) NOT NULL,
  `shared_user_id` varchar(32) NOT NULL,
  `shared_user_name` varchar(32) NOT NULL,
  `time` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_user`
--

CREATE TABLE `tbl_user` (
  `user_id` int(32) NOT NULL,
  `email_address` varchar(50) NOT NULL,
  `user_name` varchar(32) NOT NULL,
  `full_name` varchar(32) NOT NULL,
  `user_address` text NOT NULL,
  `phone_number` varchar(32) NOT NULL,
  `password` varchar(500) NOT NULL,
  `time` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_user`
--

INSERT INTO `tbl_user` (`user_id`, `email_address`, `user_name`, `full_name`, `user_address`, `phone_number`, `password`, `time`) VALUES
(3, 'admin@dma-bd.com', 'admin', 'admin', 'Dhaka', '+8801749466468', 'e10adc3949ba59abbe56e057f20f883e', '2018-08-03 22:44:29'),
(4, 'nuha.khan4@gmail.com', 'nuha', 'Sumaiya Tasmim', 'Dhaka', '+8801749466468', 'e10adc3949ba59abbe56e057f20f883e', '2018-08-13 12:11:50'),
(5, 'real_ariful@hotmail.com', 'real', 'Real Haque', 'Dhaka', '01911227945', '123', '2018-10-08 17:41:53');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `frs_attendance`
--
ALTER TABLE `frs_attendance`
  ADD PRIMARY KEY (`attId`);

--
-- Indexes for table `frs_ble`
--
ALTER TABLE `frs_ble`
  ADD PRIMARY KEY (`bleuid`);

--
-- Indexes for table `frs_blegateway`
--
ALTER TABLE `frs_blegateway`
  ADD PRIMARY KEY (`gatewayid`);

--
-- Indexes for table `frs_blelocation`
--
ALTER TABLE `frs_blelocation`
  ADD PRIMARY KEY (`bleuid`);

--
-- Indexes for table `frs_blelogs`
--
ALTER TABLE `frs_blelogs`
  ADD PRIMARY KEY (`logid`);

--
-- Indexes for table `frs_camera_list`
--
ALTER TABLE `frs_camera_list`
  ADD PRIMARY KEY (`camera_id`);

--
-- Indexes for table `frs_captureresult`
--
ALTER TABLE `frs_captureresult`
  ADD UNIQUE KEY `track_Idx` (`track_Idx`);

--
-- Indexes for table `frs_classtable`
--
ALTER TABLE `frs_classtable`
  ADD PRIMARY KEY (`class_id`);

--
-- Indexes for table `frs_image`
--
ALTER TABLE `frs_image`
  ADD PRIMARY KEY (`student_id`);

--
-- Indexes for table `frs_login`
--
ALTER TABLE `frs_login`
  ADD PRIMARY KEY (`loginid`);

--
-- Indexes for table `frs_pedes_result`
--
ALTER TABLE `frs_pedes_result`
  ADD PRIMARY KEY (`trackIdx`);

--
-- Indexes for table `frs_student`
--
ALTER TABLE `frs_student`
  ADD PRIMARY KEY (`student_id`);

--
-- Indexes for table `frs_studentcourses`
--
ALTER TABLE `frs_studentcourses`
  ADD PRIMARY KEY (`number`);

--
-- Indexes for table `frs_targetdatabase`
--
ALTER TABLE `frs_targetdatabase`
  ADD PRIMARY KEY (`db_id`);

--
-- Indexes for table `frs_vehicle`
--
ALTER TABLE `frs_vehicle`
  ADD PRIMARY KEY (`vehicle_id`);

--
-- Indexes for table `tbl_admin`
--
ALTER TABLE `tbl_admin`
  ADD PRIMARY KEY (`admin_id`);

--
-- Indexes for table `tbl_company`
--
ALTER TABLE `tbl_company`
  ADD PRIMARY KEY (`company_id`);

--
-- Indexes for table `tbl_customer`
--
ALTER TABLE `tbl_customer`
  ADD PRIMARY KEY (`customer_id`);

--
-- Indexes for table `tbl_operator`
--
ALTER TABLE `tbl_operator`
  ADD PRIMARY KEY (`operator_id`);

--
-- Indexes for table `tbl_secret`
--
ALTER TABLE `tbl_secret`
  ADD PRIMARY KEY (`code_id`);

--
-- Indexes for table `tbl_shared_users`
--
ALTER TABLE `tbl_shared_users`
  ADD PRIMARY KEY (`shared_id`);

--
-- Indexes for table `tbl_user`
--
ALTER TABLE `tbl_user`
  ADD PRIMARY KEY (`user_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `frs_attendance`
--
ALTER TABLE `frs_attendance`
  MODIFY `attId` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `frs_blelogs`
--
ALTER TABLE `frs_blelogs`
  MODIFY `logid` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `frs_camera_list`
--
ALTER TABLE `frs_camera_list`
  MODIFY `camera_id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `frs_classtable`
--
ALTER TABLE `frs_classtable`
  MODIFY `class_id` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `frs_login`
--
ALTER TABLE `frs_login`
  MODIFY `loginid` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `frs_student`
--
ALTER TABLE `frs_student`
  MODIFY `student_id` int(32) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT for table `frs_studentcourses`
--
ALTER TABLE `frs_studentcourses`
  MODIFY `number` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `frs_targetdatabase`
--
ALTER TABLE `frs_targetdatabase`
  MODIFY `db_id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `frs_vehicle`
--
ALTER TABLE `frs_vehicle`
  MODIFY `vehicle_id` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=43;

--
-- AUTO_INCREMENT for table `tbl_admin`
--
ALTER TABLE `tbl_admin`
  MODIFY `admin_id` int(32) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=900002;

--
-- AUTO_INCREMENT for table `tbl_company`
--
ALTER TABLE `tbl_company`
  MODIFY `company_id` int(32) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20002;

--
-- AUTO_INCREMENT for table `tbl_customer`
--
ALTER TABLE `tbl_customer`
  MODIFY `customer_id` int(32) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `tbl_operator`
--
ALTER TABLE `tbl_operator`
  MODIFY `operator_id` int(32) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tbl_secret`
--
ALTER TABLE `tbl_secret`
  MODIFY `code_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=101;

--
-- AUTO_INCREMENT for table `tbl_shared_users`
--
ALTER TABLE `tbl_shared_users`
  MODIFY `shared_id` int(32) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tbl_user`
--
ALTER TABLE `tbl_user`
  MODIFY `user_id` int(32) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

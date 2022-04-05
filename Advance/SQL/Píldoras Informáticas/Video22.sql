-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1:3306
-- Tiempo de generación: 30-03-2022 a las 23:44:20
-- Versión del servidor: 8.0.23
-- Versión de PHP: 8.0.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `video14`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `prod_eliminados`
--

CREATE TABLE `prod_eliminados` (
  `C_ART` varchar(5) DEFAULT NULL,
  `NOMBRE` varchar(19) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `SECCION` varchar(15) DEFAULT NULL,
  `PRECIO` int DEFAULT NULL,
  `PAIS_ORIGEN` varchar(15) DEFAULT NULL,
  `USUARIO` varchar(15) DEFAULT NULL,
  `FECHA_MODIF` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `prod_eliminados`
--

INSERT INTO `prod_eliminados` (`C_ART`, `NOMBRE`, `SECCION`, `PRECIO`, `PAIS_ORIGEN`, `USUARIO`, `FECHA_MODIF`) VALUES
('AR41', 'PALAS DE PING PONG', 'DEPORTES', 22, 'ESPAÑA', NULL, NULL),
('AR40', 'BOTA ALPINISMO', 'DEPORTES', 144, 'ESPAÑA', 'root@localhost', '2022-03-30');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

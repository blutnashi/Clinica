-- phpMyAdmin SQL Dump
-- version 5.1.3
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 19-10-2022 a las 01:12:48
-- Versión del servidor: 10.4.24-MariaDB
-- Versión de PHP: 7.4.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `consulta_externa`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `consulta`
--

CREATE TABLE `consulta` (
  `id` int(6) NOT NULL,
  `paciente` int(11) NOT NULL,
  `fechahora` date NOT NULL,
  `signosvitales` int(6) NOT NULL,
  `Diagnostico` varchar(535) COLLATE utf8mb4_bin NOT NULL,
  `Receta` varchar(535) COLLATE utf8mb4_bin NOT NULL,
  `observacion` varchar(535) COLLATE utf8mb4_bin NOT NULL,
  `medico` int(11) DEFAULT NULL,
  `user` int(11) DEFAULT NULL,
  `jinx` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `medico`
--

CREATE TABLE `medico` (
  `id_medi` int(4) NOT NULL,
  `nombre` varchar(20) COLLATE utf8mb4_bin NOT NULL,
  `apellido` varchar(20) COLLATE utf8mb4_bin NOT NULL,
  `especialidad` varchar(15) COLLATE utf8mb4_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

--
-- Volcado de datos para la tabla `medico`
--

INSERT INTO `medico` (`id_medi`, `nombre`, `apellido`, `especialidad`) VALUES
(1111, 'Faker', 'Blandino', ''),
(4444, 'Faker', 'Blandino', 'Pediatra'),
(12345, 'Eliezer', 'Blandino', 'Medico General'),
(661626, 'Juan', 'Amador', 'pediatra');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `paciente`
--

CREATE TABLE `paciente` (
  `num_seguro` int(11) NOT NULL,
  `nombre` varchar(20) COLLATE utf8mb4_bin NOT NULL,
  `apellido` varchar(20) COLLATE utf8mb4_bin NOT NULL,
  `cedula` varchar(14) COLLATE utf8mb4_bin NOT NULL,
  `fcha_nac` date NOT NULL,
  `telefono` varchar(15) COLLATE utf8mb4_bin NOT NULL,
  `numero_emergencia` varchar(15) COLLATE utf8mb4_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

--
-- Volcado de datos para la tabla `paciente`
--

INSERT INTO `paciente` (`num_seguro`, `nombre`, `apellido`, `cedula`, `fcha_nac`, `telefono`, `numero_emergencia`) VALUES
(666, 'Diluc', 'Kaedehara', '098988912999', '2022-10-12', '(234) 2354-5435', '(234) 3424-2342'),
(1234, 'Juan', 'Blandino', '081190998100', '2022-12-21', '(505) 1282-8282', '(500) 2181-7313'),
(77777, 'Akali', 'Heimerdinger', '081098765998', '2022-09-09', '(987) 4126-4182', '(174) 8293-7492');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `signosvitales`
--

CREATE TABLE `signosvitales` (
  `id_sv` int(6) NOT NULL,
  `idpaciente` int(11) NOT NULL,
  `peso` float NOT NULL,
  `presion` varchar(7) COLLATE utf8mb4_bin NOT NULL,
  `talla` int(2) NOT NULL,
  `temperatura` varchar(4) COLLATE utf8mb4_bin NOT NULL,
  `observaciones` varchar(535) COLLATE utf8mb4_bin NOT NULL,
  `estatura` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

--
-- Volcado de datos para la tabla `signosvitales`
--

INSERT INTO `signosvitales` (`id_sv`, `idpaciente`, `peso`, `presion`, `talla`, `temperatura`, `observaciones`, `estatura`) VALUES
(1, 77777, 21, '12', 12, '12', '22', 12),
(2, 77777, 12, '43', 53, '2', 'aaaa', 243),
(12, 1234, 12, '12', 12, '12', '12', 12);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `user`
--

CREATE TABLE `user` (
  `id` int(4) NOT NULL,
  `password` varchar(32) COLLATE utf8mb4_bin NOT NULL,
  `id_medi` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

--
-- Volcado de datos para la tabla `user`
--

INSERT INTO `user` (`id`, `password`, `id_medi`) VALUES
(12345, 'ekko', 12345);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `user_admin`
--

CREATE TABLE `user_admin` (
  `user` int(4) NOT NULL,
  `password` varchar(64) COLLATE utf8mb4_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

--
-- Volcado de datos para la tabla `user_admin`
--

INSERT INTO `user_admin` (`user`, `password`) VALUES
(0, 'admin');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `consulta`
--
ALTER TABLE `consulta`
  ADD PRIMARY KEY (`id`),
  ADD KEY `ipaciente_consulta` (`paciente`),
  ADD KEY `isignosvitales_consulta` (`signosvitales`),
  ADD KEY `imedico_consulta` (`medico`),
  ADD KEY `iuser_consulta` (`user`),
  ADD KEY `ijinx_consulta` (`jinx`);

--
-- Indices de la tabla `medico`
--
ALTER TABLE `medico`
  ADD PRIMARY KEY (`id_medi`);

--
-- Indices de la tabla `paciente`
--
ALTER TABLE `paciente`
  ADD PRIMARY KEY (`num_seguro`);

--
-- Indices de la tabla `signosvitales`
--
ALTER TABLE `signosvitales`
  ADD PRIMARY KEY (`id_sv`),
  ADD KEY `idpaciente` (`idpaciente`);

--
-- Indices de la tabla `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_medi` (`id_medi`);

--
-- Indices de la tabla `user_admin`
--
ALTER TABLE `user_admin`
  ADD PRIMARY KEY (`user`);

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `consulta`
--
ALTER TABLE `consulta`
  ADD CONSTRAINT `FK_consulta_jinx` FOREIGN KEY (`jinx`) REFERENCES `medico` (`id_medi`),
  ADD CONSTRAINT `FK_consulta_medico` FOREIGN KEY (`medico`) REFERENCES `medico` (`id_medi`),
  ADD CONSTRAINT `FK_consulta_user` FOREIGN KEY (`user`) REFERENCES `medico` (`id_medi`),
  ADD CONSTRAINT `consulta_ibfk_2` FOREIGN KEY (`paciente`) REFERENCES `paciente` (`num_seguro`),
  ADD CONSTRAINT `consulta_ibfk_3` FOREIGN KEY (`signosvitales`) REFERENCES `signosvitales` (`id_sv`);

--
-- Filtros para la tabla `signosvitales`
--
ALTER TABLE `signosvitales`
  ADD CONSTRAINT `signosvitales_ibfk_1` FOREIGN KEY (`idpaciente`) REFERENCES `paciente` (`num_seguro`);

--
-- Filtros para la tabla `user`
--
ALTER TABLE `user`
  ADD CONSTRAINT `user_ibfk_1` FOREIGN KEY (`id_medi`) REFERENCES `medico` (`id_medi`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

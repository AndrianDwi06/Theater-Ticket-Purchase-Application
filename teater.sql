-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 01 Jul 2024 pada 15.59
-- Versi server: 10.4.32-MariaDB
-- Versi PHP: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `teater`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `transaksi`
--

CREATE TABLE `transaksi` (
  `idtransaksi` char(10) NOT NULL,
  `nama` char(20) DEFAULT NULL,
  `jumlah` int(5) DEFAULT NULL,
  `jenis` char(20) DEFAULT NULL,
  `harga` int(15) DEFAULT NULL,
  `total` int(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `transaksi`
--

INSERT INTO `transaksi` (`idtransaksi`, `nama`, `jumlah`, `jenis`, `harga`, `total`) VALUES
('TR1', 'Andrian', 1, 'Tiket VIP', 45000, 45000),
('TR2', 'Rama', 2, 'Tiket VVIP', 50000, 100000),
('TR3', 'Azam F', 2, 'Tiket VIP', 45000, 90000),
('TR5', 'Andri', 2, 'Tiket Biasa', 25000, 50000),
('TR6', 'Adi', 1, 'Tiket VIP', 45000, 45000),
('TR7', 'Meli', 1, 'Tiket Biasa', 25000, 25000),
('TR8', 'Dani', 2, 'Tiket VIP', 45000, 90000);

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `transaksi`
--
ALTER TABLE `transaksi`
  ADD PRIMARY KEY (`idtransaksi`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

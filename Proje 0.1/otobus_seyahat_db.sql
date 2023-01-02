-- phpMyAdmin SQL Dump
-- version 5.1.3
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1:3307
-- Üretim Zamanı: 02 Oca 2023, 17:48:02
-- Sunucu sürümü: 5.7.37
-- PHP Sürümü: 8.1.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `otobus_seyahat_db`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `tbl_firmalar`
--

CREATE TABLE `tbl_firmalar` (
  `ID` int(11) NOT NULL,
  `firma` varchar(255) COLLATE utf8_turkish_ci NOT NULL,
  `fiyat` varchar(255) COLLATE utf8_turkish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `tbl_firmalar`
--

INSERT INTO `tbl_firmalar` (`ID`, `firma`, `fiyat`) VALUES
(1, 'Anafartalar Turizm', '150'),
(2, 'Ankara As Turizm', '140'),
(3, 'Antalya Net Turizm', '210'),
(4, 'Astor Turizm', '1000'),
(5, 'Balıkesir Hakser Turizm', '120'),
(6, 'Dadaş Turizm', '250'),
(7, 'Efe Tur', '270'),
(8, 'Metro Turizm', '290'),
(9, 'Kamil Koç', '145'),
(10, 'Pamukkale Turizm', '130'),
(11, 'Varan Turizm', '165'),
(12, 'Ulusoy Turizm', '120'),
(13, 'Nilüfer Turizm', '140'),
(14, 'Isparta Petrol', '160'),
(15, 'Villa Seyahat', '130'),
(16, 'Lüks Mersin', '110'),
(17, 'Lüks Erzincan', '150'),
(18, 'Kütahyalılar Turizm', '170'),
(19, 'Gürkan Turizm', '200'),
(20, 'İzmit Seyahat', '210');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `tbl_kart`
--

CREATE TABLE `tbl_kart` (
  `id` int(11) NOT NULL,
  `ad` varchar(255) COLLATE utf8_turkish_ci NOT NULL,
  `soyad` varchar(255) COLLATE utf8_turkish_ci NOT NULL,
  `kart_numara` varchar(255) COLLATE utf8_turkish_ci NOT NULL,
  `kart_skt` varchar(255) COLLATE utf8_turkish_ci NOT NULL,
  `kart_cvc` varchar(255) COLLATE utf8_turkish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `tbl_kart`
--

INSERT INTO `tbl_kart` (`id`, `ad`, `soyad`, `kart_numara`, `kart_skt`, `kart_cvc`) VALUES
(1, 'adads', 'asdasd', '1231-2312-3123-1231', '12.31', '132'),
(3, 'Sabir', 'Terzi', '2070-6912-4756-2833', '05.26', '453'),
(4, 'Kadir', 'Haslar', '1231-2312-3123-1231', '30.01', '244'),
(5, 'i', 'k', '4789-3473-4899-2384', '23.45', ' 53'),
(6, '', '', '    -    -    -', '  .', ''),
(7, 'wqwewq', 'qweqw', '    -    -    -', '  .', ''),
(8, 'wqwewq', 'qweqw', '1123-1231-2312-3123', '12.31', '123');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `tbl_koltuk_numara`
--

CREATE TABLE `tbl_koltuk_numara` (
  `id` int(11) NOT NULL,
  `koltuk_numara` varchar(255) COLLATE utf8_turkish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `tbl_koltuk_numara`
--

INSERT INTO `tbl_koltuk_numara` (`id`, `koltuk_numara`) VALUES
(1, 'Koltuk 1'),
(2, 'Koltuk 2'),
(3, 'Koltuk 3'),
(4, 'Koltuk 4'),
(5, 'Koltuk 5'),
(6, 'Koltuk 6'),
(7, 'Koltuk 7'),
(8, 'Koltuk 8'),
(9, 'Koltuk 9'),
(10, 'Koltuk 10'),
(11, 'Koltuk 11'),
(12, 'Koltuk 12'),
(13, 'Koltuk 13'),
(14, 'Koltuk 14'),
(15, 'Koltuk 15'),
(16, 'Koltuk 16'),
(17, 'Koltuk 17'),
(18, 'Koltuk 18'),
(19, 'Koltuk 19'),
(20, 'Koltuk 20'),
(21, 'Koltuk 21'),
(22, 'Koltuk 22'),
(23, 'Koltuk 23'),
(24, 'Koltuk 24'),
(25, 'Koltuk 25'),
(26, 'Koltuk 26'),
(27, 'Koltuk 27'),
(28, 'Koltuk 28'),
(29, 'Koltuk 29'),
(30, 'Koltuk 30'),
(31, 'Koltuk 31'),
(32, 'Koltuk 32'),
(33, 'Koltuk 33'),
(34, 'Koltuk 34'),
(35, 'Koltuk 35'),
(36, 'Koltuk 36'),
(37, 'Koltuk 37'),
(38, 'Koltuk 38'),
(39, 'Koltuk 39');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `tbl_login`
--

CREATE TABLE `tbl_login` (
  `ID` int(11) NOT NULL,
  `KullaniciAd` varchar(25) COLLATE utf8_turkish_ci NOT NULL,
  `Sifre` varchar(25) COLLATE utf8_turkish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `tbl_login`
--

INSERT INTO `tbl_login` (`ID`, `KullaniciAd`, `Sifre`) VALUES
(1, 'admin41', '001122'),
(2, 'oguzturan', '3001');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `tbl_osdb`
--

CREATE TABLE `tbl_osdb` (
  `OSPNR` int(11) NOT NULL,
  `OSNereden` varchar(25) COLLATE utf8_turkish_ci NOT NULL,
  `OSNereye` varchar(25) COLLATE utf8_turkish_ci NOT NULL,
  `OSTarih` varchar(50) COLLATE utf8_turkish_ci NOT NULL,
  `OSOtobusFirma` varchar(25) COLLATE utf8_turkish_ci NOT NULL,
  `OSSaat` varchar(25) COLLATE utf8_turkish_ci NOT NULL,
  `OSKoltukStil` varchar(25) COLLATE utf8_turkish_ci NOT NULL,
  `OSKoltukNumara` varchar(25) COLLATE utf8_turkish_ci NOT NULL,
  `OSEmail` varchar(50) COLLATE utf8_turkish_ci NOT NULL,
  `OSTelefon` varchar(25) COLLATE utf8_turkish_ci NOT NULL,
  `OSAd` varchar(50) COLLATE utf8_turkish_ci NOT NULL,
  `OSSoyad` varchar(50) COLLATE utf8_turkish_ci NOT NULL,
  `OSTC` varchar(25) COLLATE utf8_turkish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `tbl_osdb`
--

INSERT INTO `tbl_osdb` (`OSPNR`, `OSNereden`, `OSNereye`, `OSTarih`, `OSOtobusFirma`, `OSSaat`, `OSKoltukStil`, `OSKoltukNumara`, `OSEmail`, `OSTelefon`, `OSAd`, `OSSoyad`, `OSTC`) VALUES
(1, 'ISTANBUL', 'ANKARA', '11/22/2022', 'Kamil Koç', '15:07', '2+1', 'Koltuk 11', 'adad@asdasd.com', '(0533) 580-5433', 'Oguz Emre', 'Turan', '17726712766'),
(3, 'AGRI', 'AYDIN', '30 Aralik 2022 Cuma', 'Pamukkale Turizm', '06:45', '2+2', 'Koltuk 21', 'aq@gmail.com', '(2322) 133-3121', 'Sabir', 'Terzi', '21122121121'),
(4, 'BALIKESIR', 'ANKARA', '30 Aralik 2022 Cuma', 'Efe Tur', '17:00', '2+2', 'Koltuk 14', 'muratsari@gmail.com', '(0533) 450-7685', 'Murat', 'Sari', '14517518002'),
(5, 'KUTAHYA', 'SAKARYA', '5 Ocak 2023 Persembe', 'Metro Turizm', '09:30', '2+1', 'Koltuk 12', 'kadri@gmail.com', '(0533) 987-3210', 'Kadir', 'Haslar', '25220055258'),
(6, 'KUTAHYA', 'KOCAELI', '12 Ocak 2023 Persembe', 'Kamil Koç', '14:00', '2+1', 'Koltuk 8', 'ilaydakahraman89@gmail.com', '(0535) 585-9812', 'i', 'k', '37823467246');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `tbl_saatler`
--

CREATE TABLE `tbl_saatler` (
  `id` int(11) NOT NULL,
  `saat` varchar(255) COLLATE utf8_turkish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `tbl_saatler`
--

INSERT INTO `tbl_saatler` (`id`, `saat`) VALUES
(1, '00:00'),
(2, '00:30'),
(3, '01:00'),
(4, '01:30'),
(5, '02:00'),
(6, '02:30'),
(7, '03:00'),
(8, '03:30'),
(9, '04:00'),
(10, '04:30'),
(11, '05:00'),
(12, '05:30'),
(13, '06:00'),
(14, '06:30'),
(15, '07:00'),
(16, '07:30'),
(17, '08:00'),
(18, '08:30'),
(19, '09:00'),
(20, '09:30'),
(21, '10:00'),
(22, '10:30'),
(23, '11:00'),
(24, '11:30'),
(25, '12:00'),
(26, '12:30'),
(27, '13:00'),
(28, '13:30'),
(29, '14:00'),
(30, '14:30'),
(31, '15:00'),
(32, '15:30'),
(33, '16:00'),
(34, '16:30'),
(35, '17:00'),
(36, '17:30'),
(37, '18:00'),
(38, '18:30'),
(39, '19:00'),
(40, '19:30'),
(41, '20:00'),
(42, '20:30'),
(43, '21:00'),
(44, '21:30'),
(45, '22:00'),
(46, '22:30'),
(47, '23:00'),
(48, '23:30');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `tbl_sehirler`
--

CREATE TABLE `tbl_sehirler` (
  `ID` int(11) NOT NULL,
  `sehir` varchar(255) COLLATE utf8_turkish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `tbl_sehirler`
--

INSERT INTO `tbl_sehirler` (`ID`, `sehir`) VALUES
(1, 'ADANA'),
(2, 'ADIYAMAN'),
(3, 'AFYONKARAHISAR'),
(4, 'AGRI'),
(5, 'AMASYA'),
(6, 'ANKARA'),
(7, 'ANTALYA'),
(8, 'ARTVIN'),
(9, 'AYDIN'),
(10, 'BALIKESIR'),
(11, 'BILECIK'),
(12, 'BINGOL'),
(13, 'BITLIS'),
(14, 'BOLU'),
(15, 'BURDUR'),
(16, 'BURSA'),
(17, 'CANAKKALE'),
(18, 'CANKIRI'),
(19, 'CORUM'),
(20, 'DENIZLI'),
(21, 'DIYARBAKIR'),
(22, 'EDIRNE'),
(23, 'ELAZIG'),
(24, 'ERZINCAN'),
(25, 'ERZURUM'),
(26, 'ESKISEHIR'),
(27, 'GAZIANTEP'),
(28, 'GIRESUN'),
(29, 'GUMUSHANE'),
(30, 'HAKKARI'),
(31, 'HATAY'),
(32, 'ISPARTA'),
(33, 'MERSIN'),
(34, 'ISTANBUL'),
(35, 'IZMIR'),
(36, 'KARS'),
(37, 'KASTAMONU'),
(38, 'KAYSERI'),
(39, 'KIRKLARELI'),
(40, 'KIRSEHİR'),
(41, 'KOCAELI'),
(42, 'KONYA'),
(43, 'KUTAHYA'),
(44, 'MALATYA'),
(45, 'MANISA'),
(46, 'KAHRAMANMARAS'),
(47, 'MARDIN'),
(48, 'MUGLA'),
(49, 'MUS'),
(50, 'NEVSEHİR'),
(51, 'NIGDE'),
(52, 'ORDU'),
(53, 'RIZE'),
(54, 'SAKARYA'),
(55, 'SAMSUN'),
(56, 'SIIRT'),
(57, 'SINOP'),
(58, 'SIVAS'),
(59, 'TEKIRDAG'),
(60, 'TOKAT'),
(61, 'TRABZON'),
(62, 'TUNCELI'),
(63, 'SANLIURFA'),
(64, 'USAK'),
(65, 'VAN'),
(66, 'YOZGAT'),
(67, 'ZONGULDAK'),
(68, 'AKSARAY'),
(69, 'BAYBURT'),
(70, 'KARAMAN'),
(71, 'KIRIKKALE'),
(72, 'BATMAN'),
(73, 'SIRNAK'),
(74, 'BARTIN'),
(75, 'ARDAHAN'),
(76, 'IGDIR'),
(77, 'YALOVA'),
(78, 'KARABUK'),
(79, 'KILIS'),
(80, 'OSMANIYE'),
(81, 'DUZCE');

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `tbl_firmalar`
--
ALTER TABLE `tbl_firmalar`
  ADD PRIMARY KEY (`ID`);

--
-- Tablo için indeksler `tbl_kart`
--
ALTER TABLE `tbl_kart`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `tbl_koltuk_numara`
--
ALTER TABLE `tbl_koltuk_numara`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `tbl_login`
--
ALTER TABLE `tbl_login`
  ADD PRIMARY KEY (`ID`);

--
-- Tablo için indeksler `tbl_osdb`
--
ALTER TABLE `tbl_osdb`
  ADD PRIMARY KEY (`OSPNR`);

--
-- Tablo için indeksler `tbl_saatler`
--
ALTER TABLE `tbl_saatler`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `tbl_sehirler`
--
ALTER TABLE `tbl_sehirler`
  ADD PRIMARY KEY (`ID`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `tbl_firmalar`
--
ALTER TABLE `tbl_firmalar`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- Tablo için AUTO_INCREMENT değeri `tbl_kart`
--
ALTER TABLE `tbl_kart`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- Tablo için AUTO_INCREMENT değeri `tbl_koltuk_numara`
--
ALTER TABLE `tbl_koltuk_numara`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=40;

--
-- Tablo için AUTO_INCREMENT değeri `tbl_login`
--
ALTER TABLE `tbl_login`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Tablo için AUTO_INCREMENT değeri `tbl_osdb`
--
ALTER TABLE `tbl_osdb`
  MODIFY `OSPNR` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Tablo için AUTO_INCREMENT değeri `tbl_saatler`
--
ALTER TABLE `tbl_saatler`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=49;

--
-- Tablo için AUTO_INCREMENT değeri `tbl_sehirler`
--
ALTER TABLE `tbl_sehirler`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=84;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

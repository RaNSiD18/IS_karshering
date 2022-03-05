-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Хост: localhost:3306
-- Время создания: Мар 05 2022 г., 10:53
-- Версия сервера: 5.7.24
-- Версия PHP: 8.0.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `is_seryakov`
--

-- --------------------------------------------------------

--
-- Структура таблицы `cars`
--

CREATE TABLE `cars` (
  `id` int(11) NOT NULL,
  `Модель` varchar(50) NOT NULL,
  `Марка` varchar(50) NOT NULL,
  `Госномер` varchar(30) NOT NULL,
  `Класс` varchar(5) NOT NULL,
  `Статус` varchar(15) NOT NULL,
  `ВИН_номер` varchar(50) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `cars`
--

INSERT INTO `cars` (`id`, `Модель`, `Марка`, `Госномер`, `Класс`, `Статус`, `ВИН_номер`) VALUES
(1, 'Kia ', 'Rio X-Line', 'А000АА96RUS', 'А', 'Свободен', 'DKFHROC922NFAQ4FG'),
(2, 'Kia ', 'Rio X-Line', 'А000АА96RUS', 'А', 'Свободен', 'DKFHROC922NFAQ4FG'),
(3, 'Hyundai', 'Creta', 'В111ВВ96RUS', 'A', 'Свободен', 'ASDZXCQWE81HFYRDK'),
(4, 'Hyundai', 'Creta', 'В111ВВ96RUS', 'A', 'Свободен', 'ASDZXCQWE81HFYRDK'),
(5, 'Renault', 'Duster', 'С222СС96RUS', 'A', 'В ремонте', 'RTYSDFUIOCVB92ORD'),
(6, 'Kia', ' Rio X-Line', 'М000ММ98RUS', 'А', 'Арендован', 'QWKFURN2LD91PR85');

-- --------------------------------------------------------

--
-- Структура таблицы `clients`
--

CREATE TABLE `clients` (
  `id` int(11) NOT NULL,
  `Фамилия` varchar(100) NOT NULL,
  `Имя` varchar(100) NOT NULL,
  `Отчество` varchar(100) NOT NULL,
  `Серия_паспорта` int(4) NOT NULL,
  `Номер_паспорта` int(6) NOT NULL,
  `Дата_рождения` date NOT NULL,
  `Пол` varchar(1) NOT NULL,
  `Водительское удостоверение` int(20) NOT NULL,
  `Гражданство` varchar(50) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `clients`
--

INSERT INTO `clients` (`id`, `Фамилия`, `Имя`, `Отчество`, `Серия_паспорта`, `Номер_паспорта`, `Дата_рождения`, `Пол`, `Водительское удостоверение`, `Гражданство`) VALUES
(1, 'Серяков', 'Алексей', 'Валерьевич', 1234, 123456, '2016-06-20', 'М', 1234123456, 'РФ'),
(2, 'Гречкин', 'Николай', 'Александрович', 1234, 123456, '2000-03-22', 'М', 1234123456, 'РФ'),
(3, 'Гречкин', 'Николай', 'Александрович', 1234, 123456, '2000-03-22', 'М', 1234123456, 'РФ');

-- --------------------------------------------------------

--
-- Структура таблицы `rent`
--

CREATE TABLE `rent` (
  `id` int(11) NOT NULL,
  `Дата_и_время_аренды` varchar(20) NOT NULL,
  `Город` varchar(20) NOT NULL,
  `Стоимость` int(20) NOT NULL,
  `Срок_аренды` varchar(20) NOT NULL,
  `Тариф` varchar(20) NOT NULL,
  `код_автомобиля` int(20) NOT NULL,
  `код_клиента` int(20) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `rent`
--

INSERT INTO `rent` (`id`, `Дата_и_время_аренды`, `Город`, `Стоимость`, `Срок_аренды`, `Тариф`, `код_автомобиля`, `код_клиента`) VALUES
(1, '01.01.2022', 'Москва', 967, '290', 'Минуты', 1, 1),
(2, '01.01.2022', 'Москва', 967, '290', 'Минуты', 1, 1);

-- --------------------------------------------------------

--
-- Структура таблицы `users`
--

CREATE TABLE `users` (
  `id` int(11) UNSIGNED NOT NULL,
  `login` varchar(100) NOT NULL,
  `password` varchar(32) NOT NULL,
  `name` varchar(100) NOT NULL,
  `surname` varchar(100) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `users`
--

INSERT INTO `users` (`id`, `login`, `password`, `name`, `surname`) VALUES
(1, 'admin', 'admin', '', ''),
(2, 'Seryakov', '123', 'Алексей', 'Серяков'),
(3, 'den', 'den', 'Денис', 'Текстович'),
(4, 'kol', 'kol', 'Николай', 'Станков');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `cars`
--
ALTER TABLE `cars`
  ADD KEY `id` (`id`);

--
-- Индексы таблицы `clients`
--
ALTER TABLE `clients`
  ADD KEY `id` (`id`);

--
-- Индексы таблицы `rent`
--
ALTER TABLE `rent`
  ADD KEY `id` (`id`);

--
-- Индексы таблицы `users`
--
ALTER TABLE `users`
  ADD UNIQUE KEY `id` (`id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `cars`
--
ALTER TABLE `cars`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT для таблицы `clients`
--
ALTER TABLE `clients`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT для таблицы `rent`
--
ALTER TABLE `rent`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT для таблицы `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

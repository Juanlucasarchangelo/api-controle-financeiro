-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           8.0.40 - MySQL Community Server - GPL
-- OS do Servidor:               Win64
-- HeidiSQL Versão:              12.8.0.6908
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

-- Copiando dados para a tabela financeirodb.categorias: ~3 rows (aproximadamente)
INSERT INTO `categorias` (`Id`, `Nome`, `Tipo`, `Ativo`) VALUES
	(1, 'Cat. 1', '1', 1),
	(2, 'Cat. 2', '2', 1),
	(3, 'Cat. 3', '1', 1);

-- Copiando dados para a tabela financeirodb.transacoes: ~3 rows (aproximadamente)
INSERT INTO `transacoes` (`Id`, `Descricao`, `Valor`, `Data`, `CategoriaId`, `Observacoes`, `DataCriacao`) VALUES
	(1, 'AWS', 845.000000000000000000000000000000, '2025-09-28 11:10:19.000000', 2, 'Mensalidade', '2025-09-28 11:10:29.000000'),
	(2, 'Fornecedor', 6843.000000000000000000000000000000, '2025-09-25 16:20:00.000000', 1, 'Gabinete', '2025-09-26 16:20:00.000000'),
	(3, 'Mercado Livre', 12342.000000000000000000000000000000, '2025-09-28 11:11:54.000000', 1, 'Hardware', '2025-09-28 11:12:08.000000');

-- Copiando dados para a tabela financeirodb.__efmigrationshistory: ~0 rows (aproximadamente)
INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
	('20250925175724_InitialCreate', '9.0.9');

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;

CREATE TABLE `__EFMigrationsHistory` (
    `MigrationId` varchar(95) NOT NULL,
    `ProductVersion` varchar(32) NOT NULL,
    CONSTRAINT `PK___EFMigrationsHistory` PRIMARY KEY (`MigrationId`)
);

CREATE TABLE `DDD` (
    `Id` bigint NOT NULL AUTO_INCREMENT,
    `codigo_ddd` int NOT NULL,
    CONSTRAINT `PK_DDD` PRIMARY KEY (`Id`)
);

CREATE TABLE `Operadoras` (
    `Id` bigint NOT NULL AUTO_INCREMENT,
    `nome` varchar(30) NOT NULL,
    CONSTRAINT `PK_Operadoras` PRIMARY KEY (`Id`)
);

CREATE TABLE `Plano` (
    `Id` bigint NOT NULL AUTO_INCREMENT,
    `codigo_plano` int NOT NULL,
    `minutos` int NOT NULL,
    `franquia_internet` int NOT NULL,
    `valor` decimal(65, 30) NOT NULL,
    `tipo` int NOT NULL,
    `operadora_id` bigint NOT NULL,
    CONSTRAINT `PK_Plano` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Plano_Operadoras_operadora_id` FOREIGN KEY (`operadora_id`) REFERENCES `Operadoras` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `PlanoDDDs` (
    `plano_id` bigint NOT NULL,
    `ddd_id` bigint NOT NULL,
    CONSTRAINT `PK_PlanoDDDs` PRIMARY KEY (`plano_id`, `ddd_id`),
    CONSTRAINT `FK_PlanoDDDs_DDD_ddd_id` FOREIGN KEY (`ddd_id`) REFERENCES `DDD` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_PlanoDDDs_Plano_plano_id` FOREIGN KEY (`plano_id`) REFERENCES `Plano` (`Id`) ON DELETE CASCADE
);

CREATE INDEX `IX_Plano_operadora_id` ON `Plano` (`operadora_id`);

CREATE INDEX `IX_PlanoDDDs_ddd_id` ON `PlanoDDDs` (`ddd_id`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20200208204256_Initial', '2.1.14-servicing-32113');


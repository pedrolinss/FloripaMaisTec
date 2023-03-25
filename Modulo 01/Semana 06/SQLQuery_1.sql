-------- EXERCÍCIO 03 -------------
      -----------------

--BANCO DE DADOS BERCARIO CRIADO
-- CREATE DATABASE Bercario;

-- CREATE TABLE Mae(
-- Id int,
-- Endereco varchar (60),
-- Telefone varchar(20),
-- Data_Nascimento DateTime,
-- Primary Key (Id)
-- );

-- CREATE TABLE Bebe(
--     Id int,
--     Data_Nascimento DateTime,
--     Peso_Nascimento decimal(4,2),
--     Altura int,
--     Id_Mae int,
--     Id_Parto int,
--     Primary Key (Id)
-- );

-- CREATE TABLE Parto(
-- Id int PRIMARY KEY,
-- Id_Medico int NOT NULL,
-- Data_Parto DateTime NOT NULL,
-- Horario_Parto TimeStamp NOT NULL,
-- CRM varchar (20)
-- );

-- CREATE TABLE Medico (
-- CRM varchar(15) PRIMARY KEY,
-- Id int,
-- Nome varchar(60),
-- Telefone varchar(20),
-- Especialiade varchar(100)
-- );

ALTER TABLE dbo.Parto 
ALTER COLUMN Id_Medico VARCHAR(15) NOT NULL;
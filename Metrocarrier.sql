create database Practica
go
use Practica

create table RegistrosdeEstadoTemp 
(
Id int identity (1,1) primary key,
ColaboradorID nvarchar (100),
Estado nvarchar (100),
Hora datetime,
TiempoEnEstado int
)
use Practica
create table RegistrosdeEstado 
(
Id int identity (1,1) primary key,
ColaboradorID nvarchar (100),
Estado nvarchar (100),
Hora datetime,
TiempoEnEstado int
)
--go
--use Practica
--SET ANSI_NULLS ON
--GO
--SET QUOTED_IDENTIFIER ON
--GO
---- =============================================
---- Author:		<Author,GERMAN,VILLEGAS>
---- Create date: <27,03,2020>
---- Description:	<TRIGGER CALCULA TIEMPO DE ESTADO,,>
---- =============================================
--CREATE TRIGGER [dbo].[history] ON [Practica].[dbo].[RegistrosdeEstadoTemp]
--   AFTER INSERT
--AS 
--BEGIN
--	SET NOCOUNT ON;
--	INSERT INTO RegistrosdeEstado (
--	ColaboradorID, 
--	Estado, 
--	Hora, 
--	TiempoEnEstado
--	)
--SELECT 
--	ColaboradorID,
--	Estado, 
--	Hora,
--	DATEDIFF(minute, hora, LEAD( hora ) OVER( PARTITION BY ColaboradorID ORDER BY ColaboradorID )) as TiempoEnEstado
-- FROM RegistrosdeEstadoTemp
--END
--GO

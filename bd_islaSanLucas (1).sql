use [master]
 CREATE database [islaSanLucasBD]

USE [islaSanLucasBD]
go

-- -----------------------------------------------------
-- Table `Usuario`
-- -----------------------------------------------------
CREATE TABLE [Usuario] (
  idUsuario INT not null identity(1,1),
  nombreUsuario VARCHAR(50) NOT NULL,
  password VARCHAR(45) NOT NULL,
  email VARCHAR(50) NOT NULL,
  PRIMARY KEY (idUsuario))
  go

-- -----------------------------------------------------
-- Table Infractor
-- -----------------------------------------------------
CREATE TABLE [Infractor](
	idInfractor int not null identity(1,1),
	nombreResponsable varchar(100) not null,
	cedulaResponsable varchar(20) not null,
	tipoResponsable varchar(50) not null,
	estado bit, 
	primary key (idInfractor))
	go

	-- -----------------------------------------------------
-- Table Infractor
-- -----------------------------------------------------
CREATE TABLE [ActividadIlegal](
	idActividadIlegal int not null identity(1,1),
	nombreActividadIlegal varchar(100) not null,
	Descripcion varchar(max) not null,
	primary key (idActividadIlegal))
	go

		-- -----------------------------------------------------
-- Table InfractorActividad
-- -----------------------------------------------------

CREATE TABLE [infractorActividad](
	idInfractorActividad int not null identity(1,1),
	idInfractor int not null,
	idActividad int not null,
	primary key(idInfractorActividad))
	go

-- -----------------------------------------------------
-- Table `Reporte`
-- -----------------------------------------------------
CREATE TABLE [Reporte] (
  idReporte int not null identity(1,1),
  idInfractor int not null, 
  funcionarioResponsable varchar(50) not null,
  centroOperativo varchar(50) not null,
  codigoPresupuestario varchar(50) not null,
  viatico int not null,
  horaInicio date not null,
  lugaresRecorridos varchar(max),
  horaFinalizacion date not null,
  numeroOficio varchar(50),
  accionDesarrollada varchar(100),
  fechaReporte date not null,
  recomendacion varchar(max),
  observacion varchar(max),
  matricula varchar(100),
  combustible int not null,
  kilometroIncio varchar(100),
  kilometroFinal varchar(100),
  primary key(idReporte))
  go

 -- -----------------------------------------------------
-- Table Infractor
-- -----------------------------------------------------
CREATE TABLE [FuncionarioParticipanteReporte](
	idFuncionario int not null identity(1,1),
	nombreFuncionario varchar(100) not null,
	idReporte int not null,
	primary key (idFuncionario))
	go

-- -----------------------------------------------------
-- Table `Bitacora` - LLeva un registro de los movimientos realizados 
-- en la base de datos (Control de uso)
-- -----------------------------------------------------
CREATE TABLE [Bitacora] (
  idBitacora INT NOT NULL identity(1,1),
  tabla VARCHAR(50) NULL,
  descripcion VARCHAR(200) NULL,
  idUsuario INT NOT NULL,
  PRIMARY KEY (idBitacora)
  )

  go
  -- Procedimientos necesarios para interaccion de la base de datos
if exists(select name from dbo.sysobjects where name = 'insertar_infractor')
drop procedure [insertar_infractor]
go

create procedure [insertar_infractor](
@nombreResponsable varchar(100) ,
@cedulaResponsable varchar(20) ,
@tipoResponsable varchar(50),
@estado bit)
as
-- se guarda el cliente
insert into Infractor(nombreResponsable, cedulaResponsable, tipoResponsable, estado) values(@nombreResponsable, @cedulaResponsable, @tipoResponsable, @estado)

if exists (select name from dbo.sysobjects where name = 'consulta_infractor_cedula')
drop procedure [consulta_infractor_cedula]
go
create procedure [consulta_infractor_cedula](
@cedulaResponsable varchar(20))
as
select COUNT(*) from Infractor where cedulaResponsable = @cedulaResponsable;

if exists (select name from dbo.sysobjects where name = 'consultaInfractores')
drop procedure [consultaInfractores]
go
create procedure [consultaInfractores]
as
select idInfractor as Id, nombreResponsable as Nombre , cedulaResponsable as Cedula, tipoResponsable as Tipo from Infractor where estado = 1;

if exists (select name from dbo.sysobjects where name = 'busqueda')
drop procedure [busqueda]
go

create procedure [busqueda](
@criterio varchar(100))
as
select idInfractor as Id, nombreResponsable as Nombre , cedulaResponsable as Cedula, tipoResponsable as Tipo  from Infractor where estado = 1 and (idInfractor like '%'+@criterio+'%' or nombreResponsable like '%'+@criterio+'%'
or cedulaResponsable like '%'+@criterio+'%' or tipoResponsable like '%'+@criterio+'%');

exec busqueda 'Je';

if exists (select name from dbo.sysobjects where name = 'modificarInfractor')
drop procedure [modificarInfractor]
go

create procedure [modificarInfractor](
@cedulaResponsable varchar(20),
@nombreResponsable varchar(100),
@tipoResponsable varchar(50),
@idResponsable int)
as
Update Infractor set cedulaResponsable = @cedulaResponsable, nombreResponsable = @nombreResponsable, tipoResponsable = @tipoResponsable where idInfractor = @idResponsable;

if exists (select name from dbo.sysobjects where name = 'deshabilitarInfractor')
drop procedure [deshabilitarInfractor]
go

create procedure [deshabilitarInfractor](
@identificador int)
as
Update Infractor set estado = 0 where idInfractor = @identificador;

if exists (select name from dbo.sysobjects where name = 'cantidadInfractorActivos')
drop procedure [cantidadInfractorActivos]
go

create procedure [cantidadInfractorActivos]
as
select count(*) from Infractor where estado = 1;

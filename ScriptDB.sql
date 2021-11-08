--CREATE DATABASE BANCO;
--drop database BANCO
USE BANCO

CREATE TABLE TIPOS_CUENTA(
	idTipoCuenta int,
	tipoCuenta varchar(40)

	CONSTRAINT pk_tipos_cuenta PRIMARY KEY(idTipoCuenta)
)
CREATE TABLE USUARIOS(
	nombreUsuario varchar(40),
	contrasenia varchar(50) not null

	CONSTRAINT pk_usuarios PRIMARY KEY(nombreUsuario)
)

CREATE TABLE CLIENTES(
	idCliente int,
	nombre varchar(40) not null,
	apellido varchar(40) not null,
	nroDoc decimal(10,0) not null,
	fechaBaja date

	CONSTRAINT pk_clientes PRIMARY KEY(idCliente)
)

CREATE TABLE CUENTAS(
	idCliente int not null,
	cbu decimal(22,0),
	saldo decimal (19,4) not null,
	idTipoCuenta int not null,
	fechaBaja date


	CONSTRAINT pk_cuentas PRIMARY KEY(cbu),
	CONSTRAINT fk_cuentas_tipoCuenta FOREIGN KEY(idTipoCuenta) REFERENCES TIPOS_CUENTA(idTipoCuenta),
	CONSTRAINT fk_cuentas_idCliente FOREIGN KEY(idCliente) REFERENCES CLIENTES(idCliente)
)

CREATE TABLE MOVIMIENTOS(
	idMovimiento int,
	cbuOrigen decimal(22,0) not null,
	cbuDestino decimal(22,0) not null,
	monto decimal(19,4) not null,
	fecha datetime not null

	CONSTRAINT pk_movimientos PRIMARY KEY(idMovimiento),
	CONSTRAINT fk_movimientos_cbuRemitente FOREIGN KEY(cbuOrigen) REFERENCES CUENTAS(cbu)
)

ALTER TABLE CUENTAS
ADD ultimoMovimiento int

ALTER TABLE CUENTAS
ADD CONSTRAINT fk_cuentas_ultimoMovimiento FOREIGN KEY(ultimoMovimiento) REFERENCES MOVIMIENTOS(idMovimiento)

--Usuarios de Prueba para ingresar a la app | select * from USUARIOS
insert into USUARIOS values('a','a')
--Tipos de Cuenta de Prueba select * from TIPOS_CUENTA
insert into TIPOS_CUENTA values(1,'Caja de ahorro'),(2,'Cuenta Corriente');
--Clientes de Prueba select * from CLIENTES
insert into CLIENTES values(1,'Diego', 'Maradona',10000000,null);
insert into CLIENTES values(2,'Martin', 'Palermo',49999999,null);
insert into CLIENTES values(3,'Lionel', 'Messi',10101010,null);
--Cuentas de Prueba select * from CUENTAS
insert into CUENTAS values(1,1234567891234567891234,10000000,1,null,null)
insert into CUENTAS values(1,1234567891234567891235,2000000,2,null,null)
insert into CUENTAS values(1,1234567891234567891236,500000,1,null,null)
insert into CUENTAS values(2,1234567891234567891237,1000000,2,null,null)
insert into CUENTAS values(2,1234567891234567891238,3567000,1,null,null)
insert into CUENTAS values(3,1234567891234567891239,990000,1,null,null)
--Movimientos de prueba select * from MOVIMIENTOS
insert into MOVIMIENTOS values(1,1234567891234567891234,1234567891234567891238,2000,GETDATE())
insert into MOVIMIENTOS values(2,1234567891234567891238,1234567891234567891299,5000,GETDATE())
insert into MOVIMIENTOS values(3,1234567891234567891234,1234567891234567891238,8000,GETDATE())
insert into MOVIMIENTOS values(4,1234567891234567891238,1234567891234567891232,12000,GETDATE())
insert into MOVIMIENTOS values(5,1234567891234567891239,1234567891234567891235,2500,GETDATE())

--Deletear datos de prueba
--delete from CLIENTES
--delete from MOVIMIENTOS
--delete from CUENTAS
--delete from USUARIOS
--delete from TIPOS_CUENTA

--Dar de baja/alta clientes
--update CLIENTES set fechaBaja = GETDATE() where idCliente = 1
--update CLIENTES set fechaBaja = null where idCliente = 1
--Dar de baja/alta cuentas
--update cuentas set fechaBaja = null where idCliente = 1
--update cuentas set fechaBaja = GETDATE() where idCliente = 1
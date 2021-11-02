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
	nombre varchar(40),
	apellido varchar(40),
	nroDoc decimal(10,0),

	CONSTRAINT pk_clientes PRIMARY KEY(idCliente)
)

CREATE TABLE CUENTAS(
	idCliente int,
	cbu decimal(22,0),
	saldo decimal (19,4),
	idTipoCuenta int

	CONSTRAINT pk_cuentas PRIMARY KEY(cbu),
	CONSTRAINT fk_cuentas_tipoCuenta FOREIGN KEY(idTipoCuenta) REFERENCES TIPOS_CUENTA(idTipoCuenta),
	CONSTRAINT fk_cuentas_idCliente FOREIGN KEY(idCliente) REFERENCES CLIENTES(idCliente)
)

CREATE TABLE MOVIMIENTOS(
	idMovimiento int,
	cbuOrigen decimal(22,0),
	cbuDestino decimal(22,0),
	monto decimal(19,4),
	fecha datetime

	CONSTRAINT pk_movimientos PRIMARY KEY(idMovimiento),
	CONSTRAINT fk_movimientos_cbuRemitente FOREIGN KEY(cbuOrigen) REFERENCES CUENTAS(cbu)
)

ALTER TABLE CUENTAS
ADD ultimoMovimiento int

ALTER TABLE CUENTAS
ADD CONSTRAINT fk_cuentas_ultimoMovimiento FOREIGN KEY(ultimoMovimiento) REFERENCES MOVIMIENTOS(idMovimiento)

insert into TIPOS_CUENTA values(1,'Caja de ahorro'),(2,'Cuenta Corriente');
insert into CLIENTES values(1,'Martin', 'Palermo',43272181);
insert into CLIENTES values(2,'asd', 'asad',12313);
insert into CUENTAS values(1,1234567891234567891234,20000,1,null),(1,0987654321098765432109,9500000,2,null);
insert into MOVIMIENTOS values(1,1234567891234567891234,0987654321098765432200,30000,'2021-10-23 12:30:00'),(2,1234567891234567891234,0987654321025965432200,20000,'2021-10-23 18:20:00');

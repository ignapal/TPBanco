--Obtener Usuario
CREATE PROCEDURE SP_OBTENER_USUARIO 
@nombreUsuario varchar(50),
@contrasenia varchar(50)
AS
BEGIN
	select * from USUARIOS u
	where (u.nombreUsuario = @nombreUsuario)
	and (u.contrasenia = @contrasenia)
END
delete from USUARIOS

--Insertar Usuario
CREATE PROCEDURE SP_INSERTAR_USUARIO 
@nombreUsuario varchar(50),
@contrasenia varchar(50)
AS
BEGIN
	insert into USUARIOS
	values(@nombreUsuario,@contrasenia)
END
-----------------------------------------
exec SP_INSERTAR_USUARIO 'Palermo',NULL
exec SP_OBTENER_USUARIO 'Palermo','1234'
select * from USUARIOS
delete from USUARIOS



----------------------------------------
--Obtener id ultimo cliente
CREATE PROCEDURE OBTENER_PROXIMO_ID
@proximoID int output
AS
	BEGIN
		if (SELECT  MAX(idCliente) + 1 FROM CLIENTES) is not null
			 set @proximoID = (SELECT  MAX(idCliente) + 1 FROM CLIENTES)
		else
			set @proximoID = 1
		select @proximoID
	END
----------------------------------------
--Obtener Tipos de Cuenta
CREATE PROCEDURE OBTENER_TIPOS_CUENTA
AS
	BEGIN
		select * from
		TIPOS_CUENTA
	END
----------------------------------------
----------------------------------------
--Validar CBU Repetida
CREATE PROCEDURE VALIDAR_CBU_REPETIDA
@cbu decimal(22,0)
AS
	BEGIN
		select cbu from
		CUENTAS
		where cbu = @cbu
	END
----------------------------------------
--Insertar Cliente
CREATE PROCEDURE SP_INSERTAR_CLIENTE
@idCliente int,
@nombre varchar(50),
@apellido varchar(50),
@dni int
AS
	BEGIN
		INSERT INTO CLIENTES
		VALUES(@idCliente,@nombre,@apellido,@dni)
	END
----------------------------------------
--Insertar Cuenta
CREATE PROCEDURE SP_INSERTAR_CUENTA
@idCliente int,
@cbu decimal(22,0),
@saldo decimal(19,4),
@idTipoCuenta int

AS
	BEGIN
		INSERT INTO CUENTAS
		VALUES(@idCliente,@cbu,@saldo,@idTipoCuenta,null)
	END

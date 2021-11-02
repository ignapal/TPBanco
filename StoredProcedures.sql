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
CREATE PROCEDURE SP_INSERTAR_CLIENTE
@id int,
@nombre varchar(50),
@apellido varchar(50),
@dni int
AS
	BEGIN
		INSERT INTO CLIENTES
		VALUES(@id,@nombre,@apellido,@dni)
	END

exec INSERTAR_CLIENTE 'Martin','Palermo',43272176

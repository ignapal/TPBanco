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

exec SP_INSERTAR_USUARIO 'Palermo',NULL
exec SP_OBTENER_USUARIO 'Palermo','1234'
select * from USUARIOS
delete from USUARIOS
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

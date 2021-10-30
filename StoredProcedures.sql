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

delete from USUARIOS
insert into USUARIOS values('pepessj',123213)
exec SP_OBTENER_USUARIO 'pepessj',123213


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

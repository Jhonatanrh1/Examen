use examen 

--************************ PROCEDIMIENTOS PARA CREAR ************************--
create procedure usp_registrar(
@nombre varchar(50),
@apellido_paterno varchar(50), 
@apellido_materno varchar(50),
@fecha_nacimiento date ,
@direccion varchar(100)
)
as
begin
insert into Persona(NOMBRE,APELLIDO_PATERNO,APELLIDO_MATERNO,FECHA_NACIMIENTO,DIRECCION)
values
(
@nombre,
@apellido_paterno,
@apellido_materno, 
@fecha_nacimiento,
@direccion
)
end
go
--......................
create procedure usp_editar(
@id int,
@nombre varchar(50),
@apellido_paterno varchar(50), 
@apellido_materno varchar(50),
@fecha_nacimiento date ,
@direccion varchar(100)
)
as
begin
update Persona set 
NOMBRE = @nombre,
APELLIDO_PATERNO = @apellido_paterno,
APELLIDO_MATERNO = @apellido_materno,
FECHA_NACIMIENTO = @fecha_nacimiento,
DIRECCION = @direccion
where ID_PERSONA = @id
end
go
---------------------------
create  procedure usp_obtener(@id int)
as
begin
SELECT
        c.ID_CASA, c.DIRECCION, c.NUMERO_HABITACIONES, c.ID_PERSONA,
        p.NOMBRE, p.APELLIDO_PATERNO, p.APELLIDO_MATERNO
    FROM
        Casa c
    INNER JOIN
        Persona p ON p.ID_PERSONA = c.ID_PERSONA
    WHERE
        c.ID_CASA = @id
end
go
----------------------------------------------------------
create  procedure usp_listar
as
begin
select * from Persona
end
go



-------------------------------------------------------
create  procedure usp_eliminar(
@idpersona int
)
as
begin
delete from Persona where ID_PERSONA = @idpersona
end
go
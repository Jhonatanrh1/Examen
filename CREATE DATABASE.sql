CREATE DATABASE examen;

use examen 

CREATE TABLE Persona (
    ID_PERSONA INT PRIMARY KEY IDENTITY(1,1),
    NOMBRE VARCHAR(50) not null ,
    APELLIDO_PATERNO VARCHAR(50) not null,
    APELLIDO_MATERNO VARCHAR(50) not null,
    FECHA_NACIMIENTO DATE not null,
    DIRECCION VARCHAR(100) not null
);
select * from Persona
select * from Casa 

insert Persona values ('Lucho','Reyes','Santos','10-10-1979', 'San Isidro')
insert Persona values ('Pepe','Mendez','Rios','10-10-1989', 'Lima')
insert Persona values ('Juan','Salaz','Gree','10-10-1999', 'Los Olivos')
insert Persona values ('Lius','Contreras','Arenas','10-10-1969', 'Comas')
insert Persona values ('Pedro','Montes','Santos','10-10-1965', 'Surco')

CREATE TABLE Casa (
    ID_CASA INT PRIMARY KEY IDENTITY(1,1),
    DIRECCION VARCHAR(100) not null,
    NUMERO_HABITACIONES INT not null,
    ID_PERSONA INT not null,
    FOREIGN KEY (ID_PERSONA) REFERENCES Persona(ID_PERSONA)
);

insert Casa values ('call los incas 343 - Lima ', 2,2)
insert Casa values ('Av. las rocas 443 - Lima ', 5,2)
insert Casa values ('Jr. los rosales - San Isidro ', 3,1)
insert Casa values ('Av. san lorenzo - Los Olivos ', 6,3)
insert Casa values ('call las palmeras 342 - Comas ', 4,4)
insert Casa values ('Jr. los olivos 553 - Surco ', 3,5)

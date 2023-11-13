create database CineProg
use CineProg
go
--Agregar posible estado de peliculas (activada,desactivada)
--Hacer sp sobre las funciones (abm de funciones?)
--

create table Sucursales(
id_sucursal int,
barrio varchar(50) not null,
nombre_sucursal varchar(50),
CONSTRAINT pk_id_sucursal PRIMARY KEY (id_sucursal),
)
go

Create Table Generos_pelis(
id_genero int identity(1,1),
descripcion varchar (100)
constraint pk_genero primary key (id_genero)
)
go

Create Table Edades(
id_edad int identity(1,1),
clasificacion varchar (100)
constraint pk_edad primary key (id_edad)
)
go

create table Salas(
nro_sala int,
capacidad int not null,
id_sucursal int not null,
CONSTRAINT pk_nro_sala PRIMARY KEY (nro_sala),
CONSTRAINT fk_id_sucursal FOREIGN KEY (id_sucursal) references Sucursales (id_sucursal)
)
go

create table Butacas(
id_butaca int identity(1,1),
nro_butaca int not null,
nro_sala int not null,
CONSTRAINT pk_butaca PRIMARY KEY (id_butaca),
CONSTRAINT fk_nro_Sala FOREIGN KEY (nro_sala) REFERENCES Salas (nro_sala)
)
go

Create Table Peliculas(
id_pelicula int identity (1, 1),
titulo varchar (100),
id_genero int,
id_edad int,
duracion smallint,
descripcion varchar (100),
estado_pelicula varchar(15),
constraint pk_pelicula primary key (id_pelicula),
constraint fk_genero foreign key (id_genero) references Generos_pelis (id_genero),
constraint fk_edad foreign key (id_edad) references Edades (id_edad)
)
go

Create Table Funciones(
nro_funcion int identity(1,1),
dia datetime,
hora time,
id_pelicula int,
nro_sala int, 
constraint pk_nro_funcion PRIMARY KEY (nro_funcion),
FOREIGN KEY (id_pelicula) REFERENCES Peliculas (id_pelicula),
FOREIGN KEY (nro_sala) REFERENCES Salas (nro_sala)
)
go

create table butacaXfunciones(
nro_funcion int,
id_butaca int,
disponible varchar(15),
constraint pk_butacaXfunciones primary key (nro_funcion, id_butaca),
constraint fk_butaca foreign key (id_butaca) references Butacas (id_butaca),
constraint fk_funcion foreign key (nro_funcion) references Funciones (nro_funcion)
)

Create Table Formas_de_pago(
id_forma_de_pago int,
descripcion varchar (100),
Constraint pk_id_forma_de_pago PRIMARY KEY (id_forma_de_pago)
)
go

create table Facturas(
nro_factura int identity(1,1),
fecha datetime, 
id_forma_de_pago int,
dni_cliente int,
CONSTRAINT pk_nro_factura PRIMARY KEY (nro_factura),
CONSTRAINT fk_id_forma_de_pago FOREIGN KEY (id_forma_de_pago) REFERENCES Formas_de_pago (id_forma_de_pago),
)
go

create table Tipo_Entradas(
id_entrada int identity(1,1),
tipo_entrada varchar (20),
precio money,
constraint pk_Tipo_entrada primary key (id_entrada)
)
go

create table Detalle_Factura(
id_detalle_factura int,
nro_funcion int,
nro_factura int,
id_entrada int,
id_butaca int,
constraint pk_Detalle_factura primary key (id_detalle_factura, nro_factura),
constraint fk_DetFac_Factura foreign key (nro_factura) references Facturas (nro_factura),
constraint fk_DetFac_Funcion foreign key (nro_funcion) references Funciones (nro_funcion),
constraint fk_DetFac_TEntrada foreign key (id_entrada) references Tipo_Entradas (id_entrada),
constraint fk_detalle_butaca foreign key (id_butaca) references Butacas (id_butaca)
)
go

-- Inserts for Sucursales table
INSERT INTO Sucursales (id_sucursal, barrio, nombre_sucursal) VALUES (1, 'Villa Belgrano', 'Cine Belgrano');
INSERT INTO Sucursales (id_sucursal, barrio, nombre_sucursal) VALUES (2, 'Villa Allende', 'Cine VAS');

INSERT INTO Generos_pelis (descripcion) VALUES ('Accion');
INSERT INTO Generos_pelis (descripcion) VALUES ('Comedia');
INSERT INTO Generos_pelis (descripcion) VALUES ('Ciencia Ficcion');

INSERT INTO Edades (clasificacion) VALUES ('ATP');
INSERT INTO Edades (clasificacion) VALUES ('+18');

INSERT INTO Salas (nro_sala, capacidad, id_sucursal) VALUES (101, 9, 1);
INSERT INTO Salas (nro_sala, capacidad, id_sucursal) VALUES (102, 9, 1);
INSERT INTO Salas (nro_sala, capacidad, id_sucursal) VALUES (103, 9, 1);
INSERT INTO Salas (nro_sala, capacidad, id_sucursal) VALUES (201, 9, 2);
INSERT INTO Salas (nro_sala, capacidad, id_sucursal) VALUES (202, 9, 2);
INSERT INTO Salas (nro_sala, capacidad, id_sucursal) VALUES (203, 9, 2);


INSERT INTO Butacas (nro_butaca, nro_sala) VALUES (1, 101);
INSERT INTO Butacas (nro_butaca, nro_sala) VALUES (2, 101);
INSERT INTO Butacas (nro_butaca, nro_sala) VALUES (3, 101);
INSERT INTO Butacas (nro_butaca, nro_sala) VALUES (4, 101);
INSERT INTO Butacas (nro_butaca, nro_sala) VALUES (5, 101);
INSERT INTO Butacas (nro_butaca, nro_sala) VALUES (6, 101);
INSERT INTO Butacas (nro_butaca, nro_sala) VALUES (7, 101);
INSERT INTO Butacas (nro_butaca, nro_sala) VALUES (8, 101);
INSERT INTO Butacas (nro_butaca, nro_sala) VALUES (9, 101);

INSERT INTO Butacas (nro_butaca, nro_sala) VALUES (1, 102);
INSERT INTO Butacas (nro_butaca, nro_sala) VALUES (2, 102);
INSERT INTO Butacas (nro_butaca, nro_sala) VALUES (3, 102);
INSERT INTO Butacas (nro_butaca, nro_sala) VALUES (4, 102);
INSERT INTO Butacas (nro_butaca, nro_sala) VALUES (5, 102);
INSERT INTO Butacas (nro_butaca, nro_sala) VALUES (6, 102);
INSERT INTO Butacas (nro_butaca, nro_sala) VALUES (7, 102);
INSERT INTO Butacas (nro_butaca, nro_sala) VALUES (8, 102);
INSERT INTO Butacas (nro_butaca, nro_sala) VALUES (9, 102);

INSERT INTO Butacas (nro_butaca, nro_sala) VALUES (1, 103);
INSERT INTO Butacas (nro_butaca, nro_sala) VALUES (2, 103);
INSERT INTO Butacas (nro_butaca, nro_sala) VALUES (3, 103);
INSERT INTO Butacas (nro_butaca, nro_sala) VALUES (4, 103);
INSERT INTO Butacas (nro_butaca, nro_sala) VALUES (5, 103);
INSERT INTO Butacas (nro_butaca, nro_sala) VALUES (6, 103);
INSERT INTO Butacas (nro_butaca, nro_sala) VALUES (7, 103);
INSERT INTO Butacas (nro_butaca, nro_sala) VALUES (8, 103);
INSERT INTO Butacas (nro_butaca, nro_sala) VALUES (9, 103);

INSERT INTO Butacas (nro_butaca, nro_sala) VALUES (1, 201);
INSERT INTO Butacas (nro_butaca, nro_sala) VALUES (2, 201);
INSERT INTO Butacas (nro_butaca, nro_sala) VALUES (3, 201);
INSERT INTO Butacas (nro_butaca, nro_sala) VALUES (4, 201);
INSERT INTO Butacas (nro_butaca, nro_sala) VALUES (5, 201);
INSERT INTO Butacas (nro_butaca, nro_sala) VALUES (6, 201);
INSERT INTO Butacas (nro_butaca, nro_sala) VALUES (7, 201);
INSERT INTO Butacas (nro_butaca, nro_sala) VALUES (8, 201);
INSERT INTO Butacas (nro_butaca, nro_sala) VALUES (9, 201);

INSERT INTO Butacas (nro_butaca, nro_sala) VALUES (1, 202);
INSERT INTO Butacas (nro_butaca, nro_sala) VALUES (2, 202);
INSERT INTO Butacas (nro_butaca, nro_sala) VALUES (3, 202);
INSERT INTO Butacas (nro_butaca, nro_sala) VALUES (4, 202);
INSERT INTO Butacas (nro_butaca, nro_sala) VALUES (5, 202);
INSERT INTO Butacas (nro_butaca, nro_sala) VALUES (6, 202);
INSERT INTO Butacas (nro_butaca, nro_sala) VALUES (7, 202);
INSERT INTO Butacas (nro_butaca, nro_sala) VALUES (8, 202);
INSERT INTO Butacas (nro_butaca, nro_sala) VALUES (9, 202);

INSERT INTO Butacas (nro_butaca, nro_sala) VALUES (1, 203);
INSERT INTO Butacas (nro_butaca, nro_sala) VALUES (2, 203);
INSERT INTO Butacas (nro_butaca, nro_sala) VALUES (3, 203);
INSERT INTO Butacas (nro_butaca, nro_sala) VALUES (4, 203);
INSERT INTO Butacas (nro_butaca, nro_sala) VALUES (5, 203);
INSERT INTO Butacas (nro_butaca, nro_sala) VALUES (6, 203);
INSERT INTO Butacas (nro_butaca, nro_sala) VALUES (7, 203);
INSERT INTO Butacas (nro_butaca, nro_sala) VALUES (8, 203);
INSERT INTO Butacas (nro_butaca, nro_sala) VALUES (9, 203);


INSERT INTO Peliculas (titulo, id_genero, id_edad, duracion, descripcion, estado_pelicula) VALUES ('The Avengers', 1, 1, 150, 'Superhero movie', 'Disponible');
INSERT INTO Peliculas (titulo, id_genero, id_edad, duracion, descripcion, estado_pelicula) VALUES ('The Hangover', 2, 2, 120, 'Comedy','Disponible');
INSERT INTO Peliculas (titulo, id_genero, id_edad, duracion, descripcion, estado_pelicula) VALUES ('Inception', 3, 2, 160, 'Mind-bending thriller','Disponible');


INSERT INTO Funciones (dia, hora, id_pelicula, nro_sala) VALUES ('2023-11-15', '12:00:00', 1, 101);
INSERT INTO Funciones (dia, hora, id_pelicula, nro_sala) VALUES ('2023-11-15', '14:00:00', 2, 101);
INSERT INTO Funciones (dia, hora, id_pelicula, nro_sala) VALUES ('2023-11-15', '18:00:00', 3, 101);

INSERT INTO Funciones (dia, hora, id_pelicula, nro_sala) VALUES ('2023-11-16', '16:00:00', 1, 102);
INSERT INTO Funciones (dia, hora, id_pelicula, nro_sala) VALUES ('2023-11-16', '18:00:00', 2, 102);
INSERT INTO Funciones (dia, hora, id_pelicula, nro_sala) VALUES ('2023-11-16', '20:00:00', 3, 102);

INSERT INTO Funciones (dia, hora, id_pelicula, nro_sala) VALUES ('2023-11-17', '15:30:00', 1, 103);
INSERT INTO Funciones (dia, hora, id_pelicula, nro_sala) VALUES ('2023-11-17', '19:30:00', 2, 103);
INSERT INTO Funciones (dia, hora, id_pelicula, nro_sala) VALUES ('2023-11-17', '21:30:00', 3, 103);

INSERT INTO Funciones (dia, hora, id_pelicula, nro_sala) VALUES ('2023-11-18', '08:15:00', 1, 201);
INSERT INTO Funciones (dia, hora, id_pelicula, nro_sala) VALUES ('2023-11-18', '10:15:00', 2, 201);
INSERT INTO Funciones (dia, hora, id_pelicula, nro_sala) VALUES ('2023-11-18', '12:15:00', 3, 201);

INSERT INTO Funciones (dia, hora, id_pelicula, nro_sala) VALUES ('2023-11-19', '17:45:00', 1, 202);
INSERT INTO Funciones (dia, hora, id_pelicula, nro_sala) VALUES ('2023-11-19', '19:45:00', 2, 202);
INSERT INTO Funciones (dia, hora, id_pelicula, nro_sala) VALUES ('2023-11-19', '21:45:00', 3, 202);

INSERT INTO Funciones (dia, hora, id_pelicula, nro_sala) VALUES ('2023-11-20', '18:30:00', 1, 203);
INSERT INTO Funciones (dia, hora, id_pelicula, nro_sala) VALUES ('2023-11-20', '21:30:00', 2, 203);
INSERT INTO Funciones (dia, hora, id_pelicula, nro_sala) VALUES ('2023-11-20', '23:30:00', 3, 203);


INSERT INTO Tipo_Entradas (tipo_entrada, precio) VALUES ('Adulto', 1500.00);
INSERT INTO Tipo_Entradas (tipo_entrada, precio) VALUES ('Adulto Mayor', 1100.00);
INSERT INTO Tipo_Entradas (tipo_entrada, precio) VALUES ('Niño', 1000.00);


INSERT INTO Formas_de_pago (id_forma_de_pago, descripcion) VALUES (1, 'Targeta de Credito');
INSERT INTO Formas_de_pago (id_forma_de_pago, descripcion) VALUES (2, 'Efectivo');


INSERT INTO Facturas (fecha, id_forma_de_pago, dni_cliente) VALUES ('2023-11-21', 1, 123456789);
INSERT INTO Facturas (fecha, id_forma_de_pago, dni_cliente) VALUES ('2023-11-22', 2, 987654321);


INSERT INTO Detalle_Factura (id_detalle_factura,nro_funcion, nro_factura, id_entrada, id_butaca) VALUES (1, 1, 1, 1, 1);
INSERT INTO Detalle_Factura (id_detalle_factura,nro_funcion, nro_factura, id_entrada, id_butaca) VALUES (2, 1, 1, 3, 2);
INSERT INTO Detalle_Factura (id_detalle_factura,nro_funcion, nro_factura, id_entrada, id_butaca) VALUES (1, 5, 2, 1, 4);
go



--SP
create proc sp_InsertarMaestro
    @fecha datetime, 
    @id_forma_de_pago int,
    @dni_cliente int,
	@nro_Factura int OUTPUT
AS
BEGIN
	INSERT INTO Facturas (fecha,id_forma_de_pago,dni_cliente)
    VALUES (GETDATE(), @id_forma_de_pago, @dni_cliente, @dni_cliente);
    --Asignamos el valor del último ID autogenerado (obtenido --  
    --mediante la función SCOPE_IDENTITY() de SQLServer)	
    SET @nro_Factura = SCOPE_IDENTITY();
END
go

create proc sp_detallefactura
   @nro_detalleFactura int,
   @nro_funcion int,
   @nro_Factura int,
   @id_entrada int,
   @id_butaca int
AS
BEGIN
	INSERT INTO Detalle_Factura(id_detalle_factura, nro_funcion, nro_factura, id_entrada, id_butaca)
    VALUES (@nro_detalleFactura, @nro_funcion, @nro_Factura, @id_entrada, @id_butaca);
END
go

create proc sp_InsertarPelicula
@titulo varchar(100),
@id_genero int,
@id_edad int,
@duracion smallint,
@descripcion varchar(500)
as
begin
     insert into Peliculas (titulo,id_genero,id_edad,duracion,descripcion,estado_pelicula)
	 values (@titulo,@id_genero,@id_edad,@duracion,@descripcion,'Disponible')
end
go

create trigger t_insert_Funcion
on funciones
for insert
as
declare @min int
set @min = (select MIN(id_butaca) from inserted i join Salas s on i.nro_sala = s.nro_sala
                                  join Butacas b on s.nro_sala = b.nro_sala)
declare @max int
set @max = (select MAX(id_butaca) from inserted i join Salas s on i.nro_sala = s.nro_sala
                                  join Butacas b on s.nro_sala = b.nro_sala)

WHILE @min <=@max
BEGIN
    INSERT INTO butacaXfunciones(nro_funcion,id_butaca,disponible)
    VALUES ((select nro_funcion from inserted),@min,'Disponibles');
    SET @min = @min + 1;
END;
go

select * from Butacas
delete from Facturas	
DBCC CHECKIDENT (Facturas, RESEED, 0)
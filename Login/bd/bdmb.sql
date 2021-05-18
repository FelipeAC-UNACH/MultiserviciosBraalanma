DROP DATABASE IF EXISTS bdmb;
CREATE DATABASE bdmb;
USE bdmb;

create table usuario(Idusuario int NOT NULL AUTO_INCREMENT PRIMARY KEY,
			nombrecompleto varchar(120),
			usuario varchar(120),
			tipo Int,
			correo varchar(150),
			password varchar(50)
);

CREATE TABLE Producto(Idproducto INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
			Nombrep VARCHAR(150),
			Precio FLOAT,
			images VARCHAR(150)
);

CREATE TABLE Servicio(Idservicio INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
			NombreS VARCHAR(200),
			images VARCHAR(150),
			imagen VARCHAR(150)
);

CREATE TABLE PedidoProducto(Idpedido int NOT NULL AUTO_INCREMENT PRIMARY KEY,
			 Nombrec varchar(100),
			 Correoc varchar(100),
			 Telefonoc varchar(20),
			 Direccionc varchar(100),
			 Idproducto INT,
			 Cantidad varchar(10),
			 FOREIGN KEY  (Idproducto) REFERENCES Producto(IdProducto)
);

CREATE TABLE PedidoServicio(Idpservicio int NOT NULL AUTO_INCREMENT PRIMARY KEY,
			 Nombrec varchar(100),
			 Correoc varchar(100),
			 Telefonoc varchar(20),
			 Direccionc varchar(100),
			 Precio FLOAT,
			 Idservicio INT,
			 FOREIGN KEY  (Idservicio) REFERENCES Servicio(Idservicio)
);

CREATE TABLE Herramienta(IdHerramienta INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
			NombreHerra VARCHAR(100),
			Usuario VARCHAR(150),
			Area VARCHAR(100),
			FechaEgreso DATE,
			FechaIngreso DATE,
			Estado VARCHAR(50)
);

CREATE TABLE MaterialUnit(IdMaterialUnit INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
			NombreMaterial VARCHAR(100),
			Cantidad INT,
			Medidas VARCHAR(100),
			Idproducto INT,
			FOREIGN KEY  (Idproducto) REFERENCES Producto(Idproducto)
);

Create Table TabularPrecio(IdTabularPrecio INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
			Idproducto INT,
			CantProd INT,
			FOREIGN KEY  (Idproducto) REFERENCES Producto(Idproducto)
);

CREATE TABLE GastoIndirecto(IdGastoIndirecto INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
			NombreGasto VARCHAR(50),
			Cantidad FLOAT,
			Fecha DATE
);

CREATE TABLE VentadeCreditoP(IdVentadeCreditoP INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
			Nombrec varchar(100),
			 Correoc varchar(100),
			 Telefonoc varchar(20),
			 Direccionc varchar(100),
			 Idproducto INT,
			 Abono FLOAT,
			 Fecha_Abono DATE,
			 FOREIGN KEY  (Idproducto) REFERENCES Producto(IdProducto)
);
CREATE TABLE VentadeCreditoS(IdVentadeCreditoS INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
			Nombrec varchar(100),
			 Correoc varchar(100),
			 Telefonoc varchar(20),
			 Direccionc varchar(100),
			 Idservicio INT,
			 Precio FLOAT,
			 Abono FLOAT,
			 Fecha_Abono DATE,
			 FOREIGN KEY  (Idservicio) REFERENCES Servicio(Idservicio)
);

INSERT INTO GastoIndirecto(NombreGasto, Cantidad, Fecha) VALUES('Gasolina', '560.00', '2021/05/17');

Insert into usuario(nombrecompleto,usuario,tipo ,correo,password)Values('Alexander Perez Hernandez','Alex',1,'braalanma1981@gmail.com','12345');
Insert into usuario(nombrecompleto,usuario,tipo ,correo,password)Values('Jose Felipe Acosta Cambrano','FelipeAC',2,'a170041@unach.mx','12345');

Insert into Producto(Nombrep,Precio,images) Values('Mesa Vidrio',699.99,'../img_index/mesas/mesa (4).jpg');
Insert into Producto(Nombrep,Precio,images) Values('Mesa de Centro',749.99,'../img_index/mesas/mesa (2).jpg');
Insert into Producto(Nombrep,Precio,images) Values('Mesa Posa Pie',449.99,'../img_index/mesas/mesa (5).jpg');
Insert into Producto(Nombrep,Precio,images) Values('Mesa de Centro 8',699.99,'../img_index/mesas/mesa (1).jpg');
Insert into Producto(Nombrep,Precio,images) Values('Mesa de Centro 10',899.99,'../img_index/mesas/mesa (3).jpg');

Insert into Producto(Nombrep,Precio,images) Values('Silla Reposet',1499.99,'../img_index/sillas/silla (2).jpg');
Insert into Producto(Nombrep,Precio,images) Values('Silla Naui',799.99,'../img_index/sillas/silla (3).jpg');
Insert into Producto(Nombrep,Precio,images) Values('Silla hexagonal',849.99,'../img_index/sillas/silla (4).jpg');
Insert into Producto(Nombrep,Precio,images) Values('Silla Mesedora porta vaso',1249.99,'../img_index/sillas/silla (1).jpg');
Insert into Producto(Nombrep,Precio,images) Values('Silla Acapulco fija o Mesedora',849.99,'../img_index/sillas/silla (5).jpg');

Insert into Producto(Nombrep,Precio,images) Values('Sala Jardin',3199.99,'../img_index/salas/sala (2).jpg');
Insert into Producto(Nombrep,Precio,images) Values('Sala Hexagonal 9',2399.99,'../img_index/salas/sala (3).jpg');
Insert into Producto(Nombrep,Precio,images) Values('Sala Hexagonal 8',2099.99,'../img_index/salas/sala (4).jpg');
Insert into Producto(Nombrep,Precio,images) Values('Sala Acapulco',2399.99,'../img_index/salas/sala (5).jpg');
Insert into Producto(Nombrep,Precio,images) Values('Sala Acapulco 8',4399.99,'../img_index/salas/sala (1).jpg');

Insert into Producto(Nombrep,Precio,images) Values('Soporte de metal para macetas',749.99,'../img_index/estante/estante1.jpg');
Insert into Producto(Nombrep,Precio,images) Values('Soporte para macetas Corazon',299.99,'../img_index/estante/estante2.jpg');
Insert into Producto(Nombrep,Precio,images) Values('Soporte para macetas Bicicleta',1799.99,'../img_index/estante/estante3.jpg');
Insert into Producto(Nombrep,Precio,images) Values('Soporte para macetas Arco',249.99,'../img_index/estante/estante4.jpg');
Insert into Producto(Nombrep,Precio,images) Values('Soporte para macetas Mesa',699.99,'../img_index/estante/estante5.jpg');


Insert into Servicio(NombreS,images,imagen) Values('Servicio de Balconeria','../../img_index/Servicios/Balconeria.jpeg','../img_index/Servicios/Balconeria.jpeg');
Insert into Servicio(NombreS,images,imagen) Values('Servicio de Herreria','../../img_index/Servicios/Herreria.jpeg','../img_index/Servicios/Herreria.jpeg');
Insert into Servicio(NombreS,images,imagen) Values('Servicio de Electricidad','../../img_index/Servicios/Electricidad.jpg','../img_index/Servicios/Electricidad.jpg');
Insert into Servicio(NombreS,images,imagen) Values('Servicio de Fontaneria','../../img_index/Servicios/Fontaneria.jpg','../img_index/Servicios/Fontaneria.jpg');
Insert into Servicio(NombreS,images,imagen) Values('Servicio de Plomeria','../../img_index/Servicios/Plomeria.jpg','../img_index/Servicios/Plomeria.jpg');
Insert into Servicio(NombreS,images,imagen) Values('Servicio de Pintura de casas','../../img_index/Servicios/PinturaCasa.jpg','../img_index/Servicios/PinturaCasa.jpg');
Insert into Servicio(NombreS,images,imagen) Values('Servicio de Tabla Roca','../../img_index/Servicios/Tablaroca.jpeg','../img_index/Servicios/Tablaroca.jpeg');
Insert into Servicio(NombreS,images,imagen) Values('Servicio de Impermeabilizacion','../../img_index/Servicios/Impermeabilizacion.jpg','../img_index/Servicios/Impermeabilizacion.jpg');
Insert into Servicio(NombreS,images,imagen) Values('Servicio de Carpinteria','../../img_index/Servicios/carpinteria.jpg','../img_index/Servicios/carpinteria.jpg');

INSERT INTO MaterialUnit(NombreMaterial, Cantidad, Medidas, Idproducto) VALUES ('Perfil Tubla de 1 1/2 Calibre 18', 4, '50cm de largo', 1);
INSERT INTO MaterialUnit(NombreMaterial, Cantidad, Medidas, Idproducto) VALUES ('Perfil Tubla de 1 1/2 Calibre 18', 2, '70cm de largo', 1);
INSERT INTO MaterialUnit(NombreMaterial, Cantidad, Medidas, Idproducto) VALUES ('Perfil Tubla de 1 1/2 Calibre 18', 2, '100cm de largo', 1);
INSERT INTO MaterialUnit(NombreMaterial, Cantidad, Medidas, Idproducto) VALUES ('Tablas', 2, '35cm de ancho X 100cm de largo', 1);
INSERT INTO MaterialUnit(NombreMaterial, Cantidad, Medidas, Idproducto) VALUES ('Resistol 950 amarillo para madera', 1, '500ml', 1);
INSERT INTO MaterialUnit(NombreMaterial, Cantidad, Medidas, Idproducto) VALUES ('Barniz', 1, '1/2 Litro', 1);

INSERT INTO PedidoProducto(Nombrec, Correoc, Telefonoc, Direccionc, Idproducto, Cantidad) VALUES('Pancho Villa', 'pancho.villa@revolucionario.com', '9613152518', '2da. Sur Oriente #636-A, Tuxtla Gutierrez, Chis.', 1, 2);
INSERT INTO PedidoProducto(Nombrec, Correoc, Telefonoc, Direccionc, Idproducto, Cantidad) VALUES('Juan Martinez Ovando', 'martinez.ovando@gmail.com', '9614152569', 'Las palmas #53 CP-512, Tuxtla Gutierrez, Chis.', 2, 4);

INSERT INTO PedidoServicio(Nombrec, Correoc, Telefonoc, Direccionc, Idservicio) VALUES('Ricardo Jimenez Aguilar', 'rica.jiag@gmail.com', '9182569845', 'Calichal #315, CP-256, Tuxtla Gtz', 1);
INSERT INTO PedidoServicio(Nombrec, Correoc, Telefonoc, Direccionc, Idservicio) VALUES('Bladimir Perez Mendez', 'mendez_bla@gmail.com', '9162549864', '4ta. sur, 1ra. Poniente, Tuxtla Gtz', 2);

INSERT INTO Herramienta(NombreHerra, Usuario, Area, FechaEgreso, FechaIngreso, Estado) Values('Martillo de mano', 'Juan Pérez López', 'Tabla Roca', '2021/05/10', '2021/05/13', 'En uso');

INSERT INTO VentadeCreditoP(Nombrec, Correoc, Telefonoc, Direccionc, Idproducto, Abono, Fecha_Abono) VALUES('Mateo Gómez de la Cruz', 'mat.gocruz@gmail.com', '9615245325', 'Tuxtla Gutiérrez', 1, '150.00', '2021/05/17');
INSERT INTO VentadeCreditoS(Nombrec, Correoc, Telefonoc, Direccionc, Idservicio, Precio, Abono, Fecha_Abono) VALUES('Catalina Otoniel Campos', 'cata@gmail.com', '9615489632', 'Tuxtla Gutiérrez', 2, '900.00', '200.00', '2021/05/17');
CREATE DATABASE Grupo_Restaurante
GO

USE Grupo_Restaurante
GO

-----------------------TABLAS PROVEEDOR, MENAJE Y CATEGORIA PRODUCTO

CREATE TABLE Proveedor
(
	Proveedor_ID int NOT NULL IDENTITY (1,1),
	Razon_Social_o_ID nvarchar(20) NOT NULL,
	Nombre nvarchar(20) NOT NULL,
	Telefono nchar(10) NOT NULL,
	Correo nvarchar(20) NOT NULL,
	Direccion varchar(60) NOT NULL,
	Metodo_pago nvarchar(10) NOT NULL
CONSTRAINT PK_Proveedor_ID PRIMARY KEY (Proveedor_ID)
)

CREATE TABLE Menaje
(
	Menaje_ID int NOT NULL IDENTITY (1,1),
	Nombre nvarchar(40) NOT NULL,
	Ubicacion nvarchar(20) NOT NULL,
	Placa_Serie nvarchar(15) NOT NULL,
	Fecha_Registro datetime NOT NULL,
	Cantidad tinyint NOT NULL,
	Proveedor_ID int NOT NULL
CONSTRAINT PK_Menaje_ID PRIMARY KEY (Menaje_ID),
CONSTRAINT FK_Menaje_Proveedor_Proveedor_ID FOREIGN KEY (Proveedor_ID) REFERENCES Proveedor (Proveedor_ID)
)

CREATE TABLE Categoria_Producto
(
	Categoria_ID int NOT NULL IDENTITY (1,1),	
	Nombre nvarchar(20) NOT NULL,
	Descripcion nvarchar(40) NOT NULL
CONSTRAINT PK_Categoria_ID PRIMARY KEY (Categoria_ID)
)


---------------------TABLAS DE PLATILLOS, MENÚ, PRODUCTOS Y MERMAS
CREATE TABLE Productos
(
	Producto_ID int NOT NULL IDENTITY(1,1),
	Nombre varchar(50) NOT NULL,
	Cantidad tinyint NOT NULL,
	Costo_x_Unidad money NULL,
	Precio_Venta money NULL,
	Cantidad_minima tinyint NOT NULL,
	Categoria_ID int NOT NULL,
	Proveedor_ID int NOT NULL,
	Fecha_registro datetime NOT NULL

CONSTRAINT PK_Producto_ID PRIMARY KEY (Producto_ID),
CONSTRAINT FK_Productos_Categoria_Producto_Categoria_ID FOREIGN KEY (Categoria_ID) REFERENCES Categoria_Producto (Categoria_ID),
CONSTRAINT FK_Productos_Proveedor_Proveedor_ID FOREIGN KEY (Proveedor_ID) REFERENCES Proveedor (Proveedor_ID)
)

CREATE TABLE Platillo
(
	Platillo_ID int NOT NULL IDENTITY(1,1),
	Nombre varchar(50) NOT NULL,
	Precio_Con_IVA money NOT NULL
CONSTRAINT PK_Platillo_ID PRIMARY KEY (Platillo_ID)
)

CREATE TABLE Menu
(
	Menu_ID int NOT NULL,
	Platillo_ID int NOT NULL,
	Producto_ID int NOT NULL,
	Cantidad nvarchar(10) NOT NULL,
CONSTRAINT COMP_PK_Menu_ID PRIMARY KEY (Menu_ID,Platillo_ID,Producto_ID),
CONSTRAINT FK_Menu_Productos_Producto_ID FOREIGN KEY (Producto_ID) REFERENCES Productos (Producto_ID),
CONSTRAINT FK_Menu_Platillo_Platillo_ID FOREIGN KEY (Platillo_ID) REFERENCES Platillo (Platillo_ID)
)

CREATE TABLE Merma_Productos
(
	Merma_Producto_ID int NOT NULL IDENTITY(1,1),
	Producto_ID int NOT NULL,
	Fecha datetime NOT NULL,
	Motivo nvarchar(50) NOT NULL,
CONSTRAINT PK_Merma_Producto_ID PRIMARY KEY (Merma_Producto_ID),
CONSTRAINT FK_Merma_Productos_Producto_ID FOREIGN KEY (Producto_ID) REFERENCES Productos (Producto_ID),

)

CREATE TABLE Merma_Platillo
(
	Merma_Platillo_ID int NOT NULL IDENTITY(1,1),
	Platillo_ID int NOT NULL,
	Fecha datetime NOT NULL,
	Motivo nvarchar(50) NOT NULL,
CONSTRAINT PK_Merma_Platillo_ID PRIMARY KEY (Merma_Platillo_ID),
CONSTRAINT FK_Merma_Platillo_Platillo_ID FOREIGN KEY (Platillo_ID) REFERENCES Platillo (Platillo_ID)
)

---------------------TABLAS DE INCAPACIDADES, VACIONES, PUESTOS, EMPLEADOS, USUARIOS Y SERVICIOS PROFESIONALES




CREATE TABLE Puesto
(
	Puesto_ID int NOT NULL IDENTITY(1,1),
	Nombre nvarchar(40) NOT NULL,
	Funciones varchar(200) NOT NULL,
	Salario money NOT NULL
CONSTRAINT Puesto_ID PRIMARY KEY (Puesto_ID)

)

CREATE TABLE Empleados
(
	Empleado_ID nvarchar(20) NOT NULL,
	Nombre nvarchar(40) NOT NULL,
	Apellidos nvarchar(40) NOT NULL,
	Direccion nvarchar(100) NOT NULL,
	Telefono_Personal nvarchar(20) NOT NULL,
	Contacto_Emergencia nvarchar(60) NOT NULL,
	Correo nvarchar(50) NOT NULL,
	Fecha_Nacimiento date NOT NULL,
	Fecha_Ingreso datetime NOT NULL,
	Puesto_ID int NOT NULL,
	Vacaciones_ID int NOT NULL
CONSTRAINT Empleado_ID PRIMARY KEY (Empleado_ID)
CONSTRAINT FK_Empleados_Puesto_Puesto_ID FOREIGN KEY (Puesto_ID) REFERENCES Puesto (Puesto_ID),
)

CREATE TABLE Vacaciones
(
	Vacaciones_ID int NOT NULL IDENTITY(1,1),
	Empleado_ID nvarchar(20),
	Dias_Disponibles decimal NOT NULL,
	Dias_tomados int NOT NULL,
	Fecha_Inicio_Vacaciones datetime NULL
CONSTRAINT PK_Vacaciones_ID PRIMARY KEY (Vacaciones_ID),
CONSTRAINT FK_Vacaciones_Empleado_Empleado_ID FOREIGN KEY (Empleado_ID) REFERENCES Empleados (Empleado_ID)

)

CREATE TABLE Incapacidades
(
	Incapacidad_ID int NOT NULL IDENTITY(1,1),
	Empleado_ID nvarchar(20) NOT NULL,
	Fecha_Inicio date NOT NULL,
	Fecha_Final date NOT NULL,
	Numero_Orden int NOT NULL,
	Descripcion nvarchar(60)
CONSTRAINT Incapacidad_ID PRIMARY KEY (Incapacidad_ID)
CONSTRAINT FK_Incapacidades_Empleados_Empleado_ID FOREIGN KEY (Empleado_ID) REFERENCES Empleados (Empleado_ID)
)

CREATE TABLE Usuarios
(
	Usuario_ID int NOT NULL IDENTITY(1,1),
	Usuario nvarchar(20) NOT NULL,
	Clave nvarchar(20) NOT NULL,
	Empleado_ID nvarchar(20) NOT NULL,
	Codigo_Recuperacion nvarchar(10) NULL
CONSTRAINT Usuario_ID PRIMARY KEY (Usuario_ID)
CONSTRAINT FK_Usuarios_Empleados_Empleado_ID FOREIGN KEY (Empleado_ID) REFERENCES Empleados (Empleado_ID),
CONSTRAINT UK_Usuarios_Empleados_Empleado_ID UNIQUE (Empleado_ID)
)

CREATE TABLE Servicios_Profesionales
(
	Servicio_ID int NOT NULL IDENTITY(1,1),
	Nombre nvarchar(50) NOT NULL,
	Oferente_ID nvarchar(20) NOT NULL,
	Puesto_ID int NOT NULL,
	Horas_Laboradas smallint NOT NULL,
	Monto_Cancelado money NOT NULL,
	Servicio_recibido nvarchar(50),
	Fecha_Servicio datetime NOT NULL,
	Empleado_ID nvarchar(20) NOT NULL
CONSTRAINT Servicio_ID PRIMARY KEY (Servicio_ID)
CONSTRAINT FK_Servicios_Profesionales_Puesto_Puesto_ID FOREIGN KEY (Puesto_ID) REFERENCES Puesto (Puesto_ID),
CONSTRAINT FK_Servicios_Profesionales_Empleados_Empleado_ID FOREIGN KEY (Empleado_ID) REFERENCES Empleados (Empleado_ID)
)


---------------------TABLAS DE METODO DE PAGO, TIPO DE COMANDA, ORDEN DETALLADA Y FACTURA

CREATE TABLE Tipo_Comanda
(
	Tipo_Comanda_ID int NOT NULL IDENTITY(1,1),
	Nombre nvarchar(15) NOT NULL,
	Descripcion nvarchar(30) NULL
CONSTRAINT Tipo_Comanda_ID PRIMARY KEY (Tipo_Comanda_ID)
)

CREATE TABLE Metodo_Pago
(
	Metodo_Pago_ID int NOT NULL IDENTITY(1,1),
	Nombre nvarchar(15) NOT NULL,
	Descripcion nvarchar(30) NULL
CONSTRAINT Metodo_Pago_ID PRIMARY KEY (Metodo_Pago_ID)
)

CREATE TABLE Orden_Detallada
(
	Orden_Detalle_ID int NOT NULL IDENTITY(1,1),
	Platillo_ID int NOT NULL,
	Producto_ID int NOT NULL,
	Cantidad int NOT NULL,
	Mesa nchar NOT NULL,
	Empleado_ID nvarchar(20) NOT NULL,
    Tipo_Comanda_ID int NOT NULL
CONSTRAINT Orden_Detalle_ID PRIMARY KEY (Orden_Detalle_ID),
CONSTRAINT FK_Orden_Detallada_Platillo_Empleados_Empleado_ID FOREIGN KEY (Platillo_ID) REFERENCES Platillo (Platillo_ID),
CONSTRAINT FK_Orden_Detallada_Productos_Producto_ID FOREIGN KEY (Producto_ID) REFERENCES Productos (Producto_ID),
CONSTRAINT FK_Orden_Detallada_Empleados_Empleado_ID FOREIGN KEY (Empleado_ID) REFERENCES Empleados (Empleado_ID),
CONSTRAINT FK_Orden_Detallada_Tipo_Comanda_Tipo_Comanda_ID FOREIGN KEY (Tipo_Comanda_ID) REFERENCES Tipo_Comanda (Tipo_Comanda_ID)
)

CREATE TABLE Factura
(
	Factura_ID int NOT NULL IDENTITY(1,1),
	Orden_Detalle_ID int NOT NULL,
	Fecha datetime NOT NULL,
	Metodo_Pago_ID int NOT NULL,
	Subtotal money NOT NULL,
	IVA money NOT NULL,
	Descuento money NOT NULL,
	Impuesto_Servicio money NOT NULL,
	TIPS_Propina money NULL,
	Total_Pago money NOT NULL
CONSTRAINT Factura_ID PRIMARY KEY (Factura_ID),
CONSTRAINT FK_Factura_Orden_Detallada_Orden_Detalle_ID FOREIGN KEY (Orden_Detalle_ID) REFERENCES Orden_Detallada (Orden_Detalle_ID),
CONSTRAINT FK_Factura_Metodo_Pago_Metodo_Pago_ID FOREIGN KEY (Metodo_Pago_ID) REFERENCES Metodo_Pago (Metodo_Pago_ID)
)
/*
-------Genera datos para Platillo, Menú y Productos
INSERT INTO [dbo].[Productos]
           ([Producto_ID]
           ,[Nombre])
     VALUES
           (1,'Arroz'),
		   (2,'Frijoles'),
		   (3,'Huevos'),
		   (4,'Mantequilla'),
		   (5,'Platano'),
		   (6,'Natilla'),
		   (7,'Salchichon')

INSERT INTO [dbo].[Platillo]
           ([Platillo_ID]
           ,[Nombre])
     VALUES
           (1,'Pinto Desayuno'),
		   (2,'Pinto Arroz'),
		   (3,'Boca Chifrijo')

INSERT INTO [dbo].[Menu]
           ([Menu_ID]
           ,[Platillo_ID]
           ,[Producto_ID]
           ,[Cantidad])
     VALUES
           (1,1,1,'200 gramos'),
		   (1,1,2,'100 gramos'),
           (1,1,3,'3 und'),
           (1,1,4,'10 gramos'),
           (1,1,5,'1/2 und'),
           (1,1,6,'100 gramos'),
           (1,1,7,'100 gramos'),

		   (2,2,1,'200 gramos'),
           (2,2,2,'100 gramos')

INSERT INTO [dbo].[Merma_Platillo]
           ([Platillo_ID]
           ,[Fecha]
           ,[Motivo])
     VALUES
           (1,'05/05/2019','Frijoles malos'),
           (2,'05/20/2020','Arroz frio y cliente se fue'),
		   (1,'11/05/2022','Natilla agria')

INSERT INTO [dbo].[Merma_Productos]
           ([Producto_ID]
           ,[Fecha]
           ,[Motivo])
     VALUES
           (7,'05/05/2019','Estaba verde'),
           (3,'05/20/2020','Estaban pasados ya')
		   
-----------CONSULTAS DE PRUEBAS EN TABLAS PRODUCTOS; PLATILLO Y MENÚ

--Pruebas Merma
SELECT 		
		P.Nombre [Producto],
		MP.Fecha [Fecha registro],
		MP.Motivo [Motivo de merma]
		
FROM
	[dbo].[Merma_Productos] MP
	INNER JOIN [dbo].[Productos] P
	ON MP.Producto_ID = P.Producto_ID
	

SELECT 		
		P.Nombre [Producto],
		MP.Fecha [Fecha registro],
		MP.Motivo [Motivo de merma]
		
FROM
	 [dbo].[Merma_Platillo] MP
	INNER JOIN [dbo].[Platillo] P
	ON MP.Merma_Platillo_ID = P.Platillo_ID



---Pruebas Menu, Platillo y Prodcutos
SELECT M.Menu_ID AS [ID Menu],
 p.Nombre as [Nombre de platillo],
 PRO.Nombre as [Nombre producto],
 M.Cantidad as [Cantidad]
		
			
FROM [dbo].[Menu] AS M
INNER JOIN [dbo].[Platillo] AS P
ON M.Platillo_ID = P.Platillo_ID
INNER JOIN [dbo].[Productos] AS PRO
ON M.Producto_ID = PRO.Producto_ID



SELECT DISTINCT 
 P.Nombre as [Nombre platillo]
 
					
FROM [dbo].[Menu] AS M
INNER JOIN [dbo].[Platillo] AS P
ON M.Platillo_ID = P.Platillo_ID
*/

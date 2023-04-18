--SPS AGREGAR
CREATE PROCEDURE SP_AGREGAR_INCAPACIDADES (@Empleado_ID nvarchar(20), @Fecha_Inicio date, @Fecha_Final date, @Numero_Orden int, @Descripcion nvarchar(60))
AS
BEGIN
INSERT INTO [dbo].[Incapacidades]
            ([Empleado_ID]
			,[Fecha_Inicio]
			,[Fecha_Final]
			,[Numero_Orden]
			,[Descripcion])
     VALUES
           (@Empleado_ID, 
			@Fecha_Inicio, 
			@Fecha_Final, 
			@Numero_Orden,
			@Descripcion)
	END
GO

CREATE PROCEDURE SP_AGREGAR_FACTURA (@Orden_Detalle_ID int ,@fecha datetime, @Metodo_Pago_ID int ,@Subtotal money ,@IVA money ,@Descuento money ,@Impuesto_Servicio money ,@TIPS_Propina money ,@Total_Pago money)
AS
	BEGIN
		INSERT INTO [dbo].[Factura]
				 ([Orden_Detalle_ID]
				 ,[Fecha]
				 ,[Metodo_Pago_ID]
				 ,[Subtotal]
				 ,[IVA]
				 ,[Descuento]
				 ,[Impuesto_Servicio]
				 ,[TIPS_Propina]
				 ,[Total_Pago])
			 VALUES
				   (@Orden_Detalle_ID
				   ,@fecha
				   ,@Metodo_Pago_ID
				   ,@Subtotal
				   ,@IVA
				   ,@Descuento
				   ,@Impuesto_Servicio
				   ,@TIPS_Propina
				   ,@Total_Pago)
	END
GO

CREATE PROCEDURE SP_AGREGAR_VACACIONES(@Empleado_ID int, @Dias_Disponibles decimal(18,0),@Dias_tomados tinyint,@Fecha_Inicio_Vacaciones datetime)
AS
BEGIN
INSERT INTO [dbo].[Vacaciones]
           ([Empleado_ID]
           ,[Dias_Disponibles]
           ,[Dias_tomados]
           ,[Fecha_Inicio_Vacaciones])
     VALUES
           (@Empleado_ID
           ,@Dias_Disponibles
           ,@Dias_tomados
           ,@Fecha_Inicio_Vacaciones)

		    select max(Vacaciones_ID) from [dbo].[Vacaciones]
  END
GO
CREATE PROCEDURE SP_AGREGAR_USUARIOS(@Usuario nvarchar(20),@Clave nvarchar(20),@Empleado_ID int,@Codigo_Recuperacion nvarchar( 10 ))  
AS
BEGIN
INSERT INTO [dbo].[Usuarios]
           ([Usuario]
           ,[Clave]
           ,[Empleado_ID]
           ,[Codigo_Recuperacion])
     VALUES
           (@Usuario
           ,@Clave
           ,@Empleado_ID
           ,@Codigo_Recuperacion)

		    select max(Usuario_ID) from [dbo].[Usuarios]
	END
GO


CREATE PROCEDURE SP_AGREGAR_PRODUCTOS 
					(@Nombre varchar(50)
				   ,@Cantidad tinyint
				   ,@Costo_x_Unidad money
				   ,@Precio_Venta money
				   ,@Cantidad_minima tinyint
				   ,@Categoria_ID int
				   ,@Proveedor_ID int
				   ,@Fecha_registro int
				   )
AS
	BEGIN
		INSERT INTO [dbo].[Productos]
				   ([Nombre]
				   ,[Cantidad]
				   ,[Costo_x_Unidad]
				   ,[Precio_Venta]
				   ,[Cantidad_minima]
				   ,[Categoria_ID]
				   ,[Proveedor_ID]
				   ,[Fecha_registro])
			 VALUES
				   (@Nombre 
				   ,@Cantidad 
				   ,@Costo_x_Unidad 
				   ,@Precio_Venta
				   ,@Cantidad_minima 
				   ,@Categoria_ID 
				   ,@Proveedor_ID
				   ,@Fecha_registro)

				    select max(Producto_ID) from [dbo].[Productos]
	END
GO
CREATE PROCEDURE SP_AGREGAR_TIPO_COMANDA (@Nombre nvarchar(15),@Descripcion nvarchar(30))
AS
BEGIN
INSERT INTO [dbo].[Tipo_Comanda]
           ([Nombre]
           ,[Descripcion])
    VALUES
           (@Nombre,
            @Descripcion)

			select max(Tipo_Comanda_ID) from [dbo].[Tipo_Comanda]
	END
GO	

CREATE PROCEDURE SP_AGREGAR_SERVICIOS_PROFESIONALES(@Nombre nvarchar(50),@Oferente_ID nvarchar(20),@Puesto_ID int, @Horas_Laboradas tinyint,
          @Monto_Cancelado money,@Servicio_recibido nvarchar(50),@Fecha_Servicio datetime,@Empleado_ID nvarchar(20))
AS
BEGIN
INSERT INTO [dbo].[Servicios_Profesionales]
           ([Nombre]
           ,[Oferente_ID]
           ,[Puesto_ID]
           ,[Horas_Laboradas]
           ,[Monto_Cancelado]
           ,[Servicio_recibido]
           ,[Fecha_Servicio]
           ,[Empleado_ID])
     VALUES
           (@Nombre,
		    @Oferente_ID ,
            @Puesto_ID,
            @Horas_Laboradas,
            @Monto_Cancelado,
            @Servicio_recibido,
            @Fecha_Servicio,
            @Empleado_ID)			

			select max(Servicio_ID) from [dbo].[Servicios_Profesionales]
END
GO
CREATE PROCEDURE SP_AGREGAR_PUESTO(@Nombre nvarchar(40), @Funciones varchar (200), @Salario money)
AS
BEGIN
INSERT INTO [dbo].[Puesto]
           ([Nombre]
           ,[Funciones]
           ,[Salario])
     VALUES
           (@Nombre
           ,@Funciones
           ,@Salario)

		   select max(Puesto_ID) from [dbo].[Puesto]
	END
GO

CREATE PROCEDURE SP_AGREGAR_PROVEEVOR(@Razon_Social_o_ID nvarchar(20), @Nombre nvarchar(20), @Telefono nchar(10), @Correo nvarchar(20), @Direccion varchar(60),@Metodo_pago varchar(10))
AS
BEGIN
INSERT INTO [dbo].[Proveedor]
           ([Razon_Social_o_ID]
           ,[Nombre]
           ,[Telefono]
           ,[Correo]
           ,[Direccion]
           ,[Metodo_pago])
     VALUES
           (@Razon_Social_o_ID
           ,@Nombre
           ,@Telefono
           ,@Correo
           ,@Direccion
           ,@Metodo_pago)

		    select max(Proveedor_ID) from [dbo].[Proveedor]
	END
GO
CREATE PROCEDURE SP_AGREGAR_ORDENDETALLADA(@Platillo_ID int,@Producto_ID int,@Cantidad int,@Mesa nchar(1),@Empleado_ID int,@Tipo_Comanda_ID int)
AS
BEGIN
INSERT INTO [dbo].[Orden_Detallada]
           ([Platillo_ID],
           [Producto_ID],
		   [Cantidad],
           [Mesa],
		   [Empleado_ID],
		   [Tipo_Comanda_ID])
     VALUES
           (@Platillo_ID,
			@Producto_ID,
			@Cantidad,
			@Mesa,
			@Empleado_ID,
			@Tipo_Comanda_ID)

			select max(Orden_Detalle_ID) from [dbo].[Orden_Detallada]
	END
GO

CREATE PROCEDURE SP_AGREGAR_METODODEPAGO(@Nombre nvarchar(15), @Descripcion nvarchar(30))
AS
BEGIN
INSERT INTO [dbo].[Metodo_Pago]
           ([Nombre]
           ,Descripcion)
     VALUES
           (@Nombre
           ,@Descripcion)
	END
GO
CREATE PROCEDURE SP_AGREGAR_MERMA_PRODUCTO(@Producto_ID int, @Fecha datetime, @Motivo nvarchar(50))
AS
BEGIN
INSERT INTO [dbo].[Merma_Productos]

            ([Producto_ID]
           ,[Fecha]
           ,[Motivo])
     VALUES
           (@Producto_ID
           ,@Fecha
           ,@Motivo)
	END
GO

CREATE PROCEDURE SP_AGREGAR_MERMA_PLATILLO(@Platillo_ID int, @Fecha datetime, @Motivo nvarchar(50))
AS
BEGIN
INSERT INTO [dbo].[Merma_Platillo]

            ([Platillo_ID]
           ,[Fecha]
           ,[Motivo])
     VALUES
           (@Platillo_ID
           ,@Fecha
           ,@Motivo)
	END
GO
CREATE PROCEDURE SP_AGREGAR_EMPLEADOS(@Empleado_ID nvarchar(20), @Nombre nvarchar(40),@Apellidos nvarchar(40),@Direccion nvarchar(100),@Telefono_Personal nvarchar(20),@Contacto_Emergencia nvarchar(60),@Correo nvarchar(50),@Fecha_Nacimiento date,@Fecha_Ingreso datetime,@Puesto_ID int,@Vacaciones_ID int)  
AS
BEGIN
INSERT INTO [dbo].[Empleados]
           ([Empleado_ID]
           ,[Nombre]
           ,[Apellidos]
           ,[Direccion]
           ,[Telefono_Personal]
           ,[Contacto_Emergencia]
           ,[Correo]
           ,[Fecha_Nacimiento]
           ,[Fecha_Ingreso]
           ,[Puesto_ID]
           ,[Vacaciones_ID])
     VALUES
           (@Empleado_ID
		   ,@Nombre
           ,@Apellidos
           ,@Direccion
           ,@Telefono_Personal
           ,@Contacto_Emergencia
           ,@Correo
           ,@Fecha_Nacimiento
           ,@Fecha_Ingreso
           ,@Puesto_ID
           ,@Vacaciones_ID)
		   END
GO
CREATE PROCEDURE SP_AGREGAR_CATEGORIA_PRODUCTO(@Nombre nvarchar(20),@Descripcion nvarchar(40))  
AS
BEGIN
INSERT INTO [dbo].[Categoria_Producto]
           ([Nombre]
           ,[Descripcion])
     VALUES
           (@Nombre
           ,@Descripcion )
END
GO
CREATE PROCEDURE SP_AGREGAR_MENAJE(@Nombre nvarchar(40),@Ubicacion nvarchar(20), @Placa_Serie nvarchar(15), @Fecha_Registro datetime, @Cantidad tinyint,@Proveedor_ID int)
AS
BEGIN
INSERT INTO [dbo].[Menaje]
           ([Nombre]
           ,[Ubicacion]
           ,[Placa_Serie]
           ,[Fecha_Registro]
           ,[Cantidad]
           ,[Proveedor_ID])
     VALUES
           (@Nombre
           ,@Ubicacion 
           ,@Placa_Serie 
           ,@Fecha_Registro 
           ,@Cantidad
           ,@Proveedor_ID)
END
GO

CREATE PROCEDURE SP_AGREGAR_MENU(@Menu_ID int ,@Platillo_ID int, @Producto_ID int, @Cantidad nvarchar(10))
AS
BEGIN


INSERT INTO [dbo].[Menu]
           ([Menu_ID]
           ,[Platillo_ID]
           ,[Producto_ID]
           ,[Cantidad])
     VALUES
           (@Menu_ID
           ,@Platillo_ID
           ,@Producto_ID
           ,@Cantidad)
END
GO

CREATE PROCEDURE SP_AGREGAR_PLATILLO(@Nombre varchar(50), @Precio_Con_IVA money)
AS
BEGIN

INSERT INTO [dbo].[Platillo]
           ([Nombre]
           ,[Precio_Con_IVA])
     VALUES
           (@Nombre
           ,@Precio_Con_IVA)

		    select max(Platillo_ID) from [dbo].[Platillo]
END
GO
/*-------------------------------------------------MODIFICAR--------------------------------------------------------*/
USE Grupo_Restaurante
GO  

CREATE PROCEDURE SP_MODIFICAR_INCAPACIDADES

				 
				
				(@Empleado_ID nvarchar(20), 
				@Fecha_Inicio date, 
				@Fecha_Final date, 
				@Numero_Orden int,
				@Descripcion nvarchar(60),
				@Id_Seleccionado INT)

AS
BEGIN
UPDATE [dbo].[Incapacidades]
   SET 
       [Empleado_ID] = @Empleado_ID
      ,[Fecha_Inicio] = @Fecha_Inicio
      ,[Fecha_Final] = @Fecha_Final
      ,[Numero_Orden] = @Numero_Orden
      ,[Descripcion]= @Descripcion
	  WHERE Incapacidad_ID=@Id_Seleccionado
	END
GO

CREATE PROCEDURE SP_MODIFICAR_VACACIONES(@Id_Seleccionado int,@Empleado_ID nvarchar(20), @Dias_Disponibles decimal(18,0),@Dias_tomados tinyint,@Fecha_Inicio_Vacaciones datetime)
AS
BEGIN
UPDATE [dbo].[Vacaciones]
   SET [Empleado_ID] = @Empleado_ID
      ,[Dias_Disponibles] = @Dias_Disponibles
      ,[Dias_tomados] = @Dias_tomados
      ,[Fecha_Inicio_Vacaciones] = @Fecha_Inicio_Vacaciones
	  WHERE Vacaciones_ID=@Id_Seleccionado
 END
GO

CREATE PROCEDURE SP_MODIFICAR_USUARIOS(@Id_Seleccionado int,@Usuario nvarchar(20),@Clave nvarchar(20),@Empleado_ID int,@Codigo_Recuperacion nvarchar( 10 ))  
AS
BEGIN

UPDATE [dbo].[Usuarios]
   SET [Usuario] = @Usuario
      ,[Clave] = @Clave
      ,[Empleado_ID] = @Empleado_ID
      ,[Codigo_Recuperacion] = @Codigo_Recuperacion
	  WHERE Usuario_ID=@Id_Seleccionado
 END
GO


CREATE PROCEDURE SP_MODIFICAR_PRODUCTOS 
					(@Id_Seleccionado int,
					@Nombre varchar(50)
				   ,@Cantidad tinyint
				   ,@Costo_x_Unidad money
				   ,@Cantidad_minima tinyint
				   ,@Categoria_ID int
				   ,@Proveedor_ID int
				   ,@Fecha_registro datetime
				   )
AS
	BEGIN
		UPDATE [dbo].[Productos]
		   SET [Nombre] = @Nombre
			  ,[Cantidad] = @Cantidad
			  ,[Costo_x_Unidad] = @Costo_x_Unidad
			  ,[Cantidad_minima] = @Cantidad_minima
			  ,[Categoria_ID] = @Categoria_ID
			  ,[Proveedor_ID] = @Proveedor_ID
			  ,[Fecha_registro] = @Fecha_registro
		 WHERE Producto_ID=@Id_Seleccionado
	 END 
 GO

CREATE PROCEDURE SP_MODIFICAR_TIPO_COMANDA (@Id_Seleccionado int,@Nombre nvarchar(15),@Descripcion nvarchar(30))
AS
BEGIN
UPDATE [dbo].[Tipo_Comanda]
   SET [Nombre] = @Nombre, 
       [Descripcion] = @Descripcion
	   WHERE Tipo_Comanda_ID=@Id_Seleccionado
	END	   
GO

CREATE PROCEDURE SP_MODIFICAR_SERVICIOS_PROFESIONALES(@Id_Seleccionado int,@Nombre nvarchar(50),@Oferente_ID nvarchar(20),@Puesto_ID int, @Horas_Laboradas smallint,
          @Monto_Cancelado money,@Servicio_recibido nvarchar(50),@Fecha_Servicio datetime,@Empleado_ID nvarchar(20))
AS
BEGIN
UPDATE [dbo].[Servicios_Profesionales]
   SET [Nombre] = @Nombre 
      ,[Oferente_ID] = @Oferente_ID
      ,[Puesto_ID] = @Puesto_ID
      ,[Horas_Laboradas] = @Horas_Laboradas 
      ,[Monto_Cancelado] = @Monto_Cancelado
      ,[Servicio_recibido] = @Servicio_recibido
      ,[Fecha_Servicio] = @Fecha_Servicio
	  ,[Empleado_ID] = @Empleado_ID
      WHERE  Servicio_ID=@Id_Seleccionado

END
GO

CREATE PROCEDURE SP_MODIFICAR_PUESTO(@Id_Seleccionado int,@Nombre NVARCHAR(40), @Funciones VARCHAR(200), @Salario MONEY)
AS
BEGIN
UPDATE [dbo].[Puesto]
   SET [Nombre] = @Nombre
      ,[Funciones] = @Funciones
      ,[Salario] = @Salario
	  WHERE Puesto_ID=@Id_Seleccionado
	END
GO


CREATE PROCEDURE SP_MODIFICAR_PROVEEDOR(@Id_Seleccionado int,@Razon_Social_o_ID nvarchar(20), @Nombre nvarchar(20), @Telefono nchar(10), @Correo nvarchar(20), @Direccion varchar(60),@Metodo_pago varchar(10))
AS
BEGIN
UPDATE [dbo].[Proveedor]
   SET [Razon_Social_o_ID] = @Razon_Social_o_ID
      ,[Nombre] = @Nombre
      ,[Telefono] = @Telefono
      ,[Correo] = @Correo
      ,[Direccion] = @Direccion
      ,[Metodo_pago] = @Metodo_pago
	  WHERE  Proveedor_ID=@Id_Seleccionado
	END
GO

CREATE PROCEDURE SP_MODIFICAR_ORDENDETALLADA(@Id_Seleccionado int,@Platillo_ID int,@Producto_ID int,@Cantidad int,@Mesa nchar,@EmpleadoId int,@TipoComanda int)
AS
BEGIN
UPDATE [dbo].[Orden_Detallada]
   SET [Platillo_ID] = @Platillo_ID,
       [Producto_ID] = @Producto_ID,
	   [Cantidad] = @Cantidad,
	   [Mesa] = @Mesa,
	   [Empleado_ID] = @EmpleadoId,
       [Tipo_Comanda_ID] = @TipoComanda
	   WHERE Orden_Detalle_ID=@Id_Seleccionado

	END
GO

CREATE PROCEDURE SP_MODIFICAR_METODODEPAGO(@Id_Seleccionado int,@Nombre nvarchar(15), @Descripcion nvarchar(30))
AS
BEGIN
UPDATE [dbo].[Metodo_Pago]
   SET [Nombre] = @Nombre
      ,[Descripcion] = @Descripcion
	  WHERE Metodo_Pago_ID=@Id_Seleccionado

	END
GO


CREATE PROCEDURE SP_MODIFICAR_MERMA_PRODUCTO(@Id_Seleccionado int,@Producto_ID int, @Fecha datetime, @Motivo nvarchar(50))
AS
BEGIN
UPDATE [dbo].[Merma_Productos]
   SET [Producto_ID] = @Producto_ID
      ,[Fecha] = @Fecha
      ,[Motivo] = @Motivo
	  WHERE Merma_Producto_ID=@Id_Seleccionado
	END

GO

CREATE PROCEDURE SP_MODIFICAR_MERMA_PLATILLO(@Id_Seleccionado int,@Platillo_ID int, @Fecha datetime, @Motivo nvarchar(50))
AS
BEGIN
UPDATE [dbo].[Merma_Platillo]
   SET [Platillo_ID] = @Platillo_ID
      ,[Fecha] = @Fecha
      ,[Motivo] = @Motivo
	  WHERE Merma_Platillo_ID=@Id_Seleccionado
	END
GO


CREATE PROCEDURE SP_MODIFICAR_EMPLEADOS(@Id_Seleccionado nvarchar(20),@Nombre nvarchar(40),@Apellidos nvarchar(40),@Direccion nvarchar(100),@Telefono_Personal nvarchar(20),@Contacto_Emergencia nvarchar(60),@Correo nvarchar(50),@Fecha_Nacimiento date,@Fecha_Ingreso datetime,@Puesto_ID int,@Vacaciones_ID int)  
AS
BEGIN
UPDATE [dbo].[Empleados]
   SET [Nombre] = @Nombre
      ,[Apellidos] = @Apellidos
      ,[Direccion] = @Direccion
      ,[Telefono_Personal] = @Telefono_Personal
      ,[Contacto_Emergencia] = @Contacto_Emergencia
      ,[Correo] = @Correo
      ,[Fecha_Nacimiento] = @Fecha_Nacimiento
      ,[Fecha_Ingreso] = @Fecha_Ingreso
      ,[Puesto_ID] = @Puesto_ID
      ,[Vacaciones_ID] = @Vacaciones_ID
	  WHERE Empleado_ID=@Id_Seleccionado
	  END

GO

CREATE PROCEDURE SP_MODIFICAR_CATEGORIA_PRODUCTO(@Id_Seleccionado int,@Nombre nvarchar(20),@Descripcion nvarchar(40))  
AS
BEGIN
UPDATE [dbo].[Categoria_Producto]
   SET [Nombre] = @Nombre 
      ,[Descripcion] = @Descripcion 
	  WHERE Categoria_ID=@Id_Seleccionado
	  END

GO



CREATE PROCEDURE SP_MODIFICAR_MENAJE(@Id_Seleccionado int,@Nombre nvarchar(40), @Ubicacion nvarchar(20), @Placa_Serie nvarchar(15), @FEcha_Registro datetime, @Cantidad tinyint,@Proveedor_ID int)
AS
BEGIN
UPDATE [dbo].[Menaje]
   SET [Nombre] = @Nombre
      ,[Ubicacion] = @Ubicacion
      ,[Placa_Serie] = @Placa_Serie
      ,[FEcha_Registro] = @FEcha_Registro
      ,[Cantidad] = @Cantidad
      ,[Proveedor_ID] = @Proveedor_ID
		WHERE dbo.Menaje.Menaje_ID= @Id_Seleccionado
		END
GO

CREATE PROCEDURE SP_MODIFICAR_MENU(@Id_Seleccionado int,@Platillo_ID INT, @Producto_ID INT, @Cantidad NVARCHAR(10))
AS
BEGIN

UPDATE [dbo].[Menu] 
   SET [Cantidad] = @Cantidad
 WHERE  dbo.Menu.Menu_ID = @Id_Seleccionado
      
END

GO
CREATE PROCEDURE SP_MODIFICAR_PLATILLO(@Id_Seleccionado int,@Nombre varchar(50), @Precio_Con_IVA money)
as
BEGIN

UPDATE [dbo].[Platillo] 
   SET [Nombre] = @Nombre
		,[Precio_Con_IVA] = @Precio_Con_IVA
 WHERE  dbo.Platillo.Platillo_ID = @Id_Seleccionado
      
END
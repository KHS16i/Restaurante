/*-------------------------------------------------------FILTRAR---------------------------------------------------------*/
USE Grupo_Restaurante
GO  

CREATE PROCEDURE SP_FILTRAR_INCAPACIDADES(@filtro nvarchar)
AS
BEGIN
SELECT [Incapacidad_ID]
      ,[Empleado_ID]
      ,[Fecha_Inicio]
      ,[Fecha_Final]
      ,[Numero_Orden]
      ,[Descripcion]
  FROM [dbo].[Incapacidades]
WHERE ltrim(rtrim([Empleado_ID])) like '%' + ltrim(rtrim(@filtro)) + '%' 
END
GO

CREATE PROCEDURE SP_FILTRAR_FACTURA(@filtro int)
AS
	BEGIN
		SELECT [Factura_ID]
		  ,[Orden_Detalle_ID]
		  ,[Fecha]
		  ,[Metodo_Pago_ID]
		  ,[Subtotal]
		  ,[IVA]
		  ,[Descuento]
		  ,[Impuesto_Servicio]
		  ,[TIPS_Propina]
		  ,[Total_Pago]
	  FROM [dbo].[Factura]
		  WHERE dbo.Factura.Factura_ID = @filtro
	END
GO

CREATE PROCEDURE SP_FILTRAR_VACACIONES(@filtro nvarchar) /* emplado id */
AS
BEGIN
SELECT DISTINCT V.[Vacaciones_ID]
      ,V.[Empleado_ID]
      ,[Dias_Disponibles] = (DATEDIFF(MONTH,EM.Fecha_Ingreso,GETDATE())*1.25)-[Dias_tomados]
      ,[Dias_tomados]
      ,[Fecha_Inicio_Vacaciones]
  FROM [dbo].[Vacaciones] V, [dbo].[Empleados] EM
  WHERE ltrim(rtrim(V.[Empleado_ID])) like '%' + ltrim(rtrim(@filtro)) + '%' 
END
GO

CREATE PROCEDURE SP_FILTRAR_USUARIOS(@filtro nvarchar(20))  /* usuario */
AS
BEGIN
SELECT [Usuario_ID]
      ,[Usuario]
      ,[Clave]
      ,[Empleado_ID]
      ,[Codigo_Recuperacion]
  FROM [dbo].[Usuarios]
  WHERE dbo.Usuarios.Usuario = @filtro
  END

GO


CREATE PROCEDURE SP_FILTRAR_PRODUCTOS(@filtro varchar(50))
AS
	BEGIN
		SELECT [Producto_ID]
			  ,[Nombre]
			  ,[Cantidad]
			  ,[Costo_x_Unidad]
			  ,[Precio_Venta]
			  ,[Cantidad_minima]
			  ,[Categoria_ID]
			  ,[Proveedor_ID]
			  ,[Fecha_registro]
		  FROM [dbo].[Productos]
		  WHERE dbo.Productos.Nombre = @filtro
	END
GO


CREATE PROCEDURE SP_FILTRAR_TIPO_COMANDA (@filtro nvarchar(15))
AS
BEGIN
SELECT [Tipo_Comanda_ID]
      ,[Nombre]
      ,[Descripcion]
  FROM [dbo].[Tipo_Comanda]
  WHERE dbo.Tipo_Comanda.Nombre = @filtro
END
GO

CREATE PROCEDURE SP_FILTRAR_SERVICIOS_PROFESIONALES (@filtro nvarchar(50))
AS
BEGIN

SELECT [Servicio_ID]
      ,[Nombre]
      ,[Oferente_ID]
      ,[Puesto_ID]
      ,[Horas_Laboradas]
      ,[Monto_Cancelado]
      ,[Servicio_recibido]
      ,[Fecha_Servicio]
      ,[Empleado_ID]
  FROM [dbo].[Servicios_Profesionales]
  WHERE ltrim(rtrim([Servicio_recibido])) like '%' + ltrim(rtrim(@filtro)) + '%' 
END
GO

CREATE PROCEDURE SP_FILTRAR_PUESTO(@filtro NVARCHAR(40))
AS
BEGIN
SELECT [Puesto_ID]
      ,[Nombre]
      ,[Funciones]
      ,[Salario]
  FROM [dbo].[Puesto]
WHERE dbo.Puesto.Nombre = @filtro
	END

GO

CREATE PROCEDURE SP_FILTRAR_PROVEEVOR(@filtro nvarchar(20))
AS
BEGIN
SELECT [Proveedor_ID]
      ,[Razon_Social_o_ID]
      ,[Nombre]
      ,[Telefono]
      ,[Correo]
      ,[Direccion]
      ,[Metodo_pago]
  FROM [dbo].[Proveedor]
WHERE dbo.Proveedor.Nombre = @filtro
END
GO

CREATE PROCEDURE [dbo].[SP_FILTRAR_REPORTE_VENTAS_X_DIAS]
(
 @Fecha datetime
)
AS
BEGIN
SELECT [Factura_ID]     
      ,[Fecha]
      ,[Metodo_Pago_ID]
      ,[Subtotal]
      ,[IVA]
      ,[Descuento] 
      ,[Impuesto_Servicio] 
      ,[TIPS_Propina]	  
      ,[Total_Pago]
	  
  FROM [dbo].[Factura] 
  WHERE Fecha = @Fecha 
  ORDER BY [Fecha]
END
GO


CREATE PROCEDURE [dbo].[SP_FILTRAR_REPORTE_VENTAS_X_FECHA]
(
 @Fecha_Inicio datetime,
 @Fecha_Final datetime
)
AS
SELECT [Factura_ID]     
      ,[Fecha]
      ,[Metodo_Pago_ID]
      ,[Subtotal]
      ,[IVA]
      ,[Descuento] 
      ,[Impuesto_Servicio] 
      ,[TIPS_Propina]	  
      ,[Total_Pago]
	  
  FROM [dbo].[Factura] F
  WHERE F.Fecha >= @Fecha_Inicio AND F.Fecha <= @Fecha_Final

  ORDER BY [Fecha]

GO


CREATE PROCEDURE SP_FILTRAR_ORDENDETALLADA(@filtro int)
AS
BEGIN
SELECT 
		   [Orden_Detalle_ID],
		   [Platillo_ID],
           [Producto_ID],
		   [Cantidad],
           [Mesa],
		   [Empleado_ID],
		   [Tipo_Comanda_ID]

  FROM [dbo].[Orden_Detallada]
WHERE dbo.Orden_Detallada.Orden_Detalle_ID= @filtro
END
GO

CREATE PROCEDURE SP_FILTRAR_METODODEPAGO(@filtro nvarchar(15))
AS
BEGIN
SELECT 
      [Metodo_Pago_ID]
	  [Nombre]
      ,[Descripcion]

  FROM [dbo].[Metodo_Pago]
WHERE dbo.Metodo_Pago.Nombre = @filtro
END
GO

CREATE PROCEDURE SP_FILTRAR_MERMA_PRODUCTO(@filtro int)
AS
BEGIN
SELECT 
	   [Merma_Producto_ID]
      ,[Producto_ID]
	  ,[Fecha]
      ,[Motivo]
  FROM [dbo].[Merma_Productos]
WHERE dbo.Merma_Productos.Producto_ID = @filtro 
END
GO

CREATE PROCEDURE SP_FILTRAR_MERMA_PLATILLO(@filtro int)
AS
BEGIN
SELECT 
	   [Merma_Platillo_ID]
	   ,[Platillo_ID]
      ,[Fecha]
      ,[Motivo]
  FROM [dbo].[Merma_Platillo]
WHERE dbo.Merma_Platillo.Platillo_ID = @filtro 
END
GO

CREATE PROCEDURE SP_FILTRAR_EMPLEADOS(@filtro nvarchar(20))  /* Empleado_ID*/
AS
BEGIN
SELECT [Empleado_ID]
      ,[Nombre]
      ,[Apellidos]
      ,[Direccion]
      ,[Telefono_Personal]
      ,[Contacto_Emergencia]
      ,[Correo]
      ,[Fecha_Nacimiento]
      ,[Fecha_Ingreso]
      ,[Puesto_ID]
      ,[Vacaciones_ID]
FROM [dbo].[Empleados]
  WHERE ltrim(rtrim([Empleado_ID])) like '%' + ltrim(rtrim(@filtro)) + '%' 
END
GO


CREATE PROCEDURE SP_FILTRAR_CATEGORIA_PRODUCTO(@filtro nvarchar(20))  /* NOMBRE */
AS
BEGIN
SELECT [Categoria_ID]
      ,[Nombre]
      ,[Descripcion]
  FROM [dbo].[Categoria_Producto]
  WHERE dbo.Categoria_Producto.Nombre = @filtro
  END
GO


CREATE PROCEDURE SP_FILTRAR_MENAJE(@filtro nvarchar(40))
AS
BEGIN
SELECT [Menaje_ID]
      ,[Nombre]
      ,[Ubicacion]
      ,[Placa_Serie]
      ,[FEcha_Registro]
      ,[Cantidad]
      ,[Proveedor_ID]
  FROM [dbo].[Menaje]
  WHERE dbo.Menaje.Nombre =@filtro
  END

GO

CREATE PROCEDURE SP_FILTRAR_MENU(@filtro INT)  /* NOMBRE */
AS
BEGIN
SELECT [Menu_ID]
      ,[Platillo_ID]
      ,[Producto_ID]
	  ,[Cantidad]
  FROM [dbo].[Menu]
  WHERE dbo.Menu.Menu_ID = @filtro
  END
GO


CREATE PROCEDURE SP_FILTRAR_PLATILLO(@filtro nvarchar(50))
AS
BEGIN
SELECT [Platillo_ID]
      ,[Nombre]
  FROM [dbo].[Platillo]
  WHERE dbo.Platillo.Nombre =@filtro
  END

GO
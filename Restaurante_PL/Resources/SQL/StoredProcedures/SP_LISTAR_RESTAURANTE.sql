USE Grupo_Restaurante
GO


CREATE PROCEDURE SP_LISTAR_CATEGORIA_PRODUCTO /* listo*/
AS
BEGIN
SELECT [Categoria_ID]
      ,[Nombre]
      ,[Descripcion]
  FROM [dbo].[Categoria_Producto]
  END
GO

CREATE PROCEDURE SP_LISTAR_EMPLEADOS  /* listo*/
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
END
GO

CREATE PROCEDURE [dbo].[SP_LISTAR_EMPLEADO_DIAS_DISPONIBLES](@Empleado_ID nvarchar(20)) /* ID Empleado */
AS
BEGIN
SELECT DISTINCT      
      Empleado_ID,
      DATEDIFF(MONTH,Fecha_Ingreso,GETDATE())*1.25 [Dias_Disponibles]
 
  FROM [dbo].[Empleados]
  WHERE Empleado_ID = @Empleado_ID
  END
GO


CREATE PROCEDURE SP_LISTAR_FACTURA/*listo*/
AS
	BEGIN
		SELECT [Factura_ID]
		  ,[Orden_Detalle_ID]
		  ,[Metodo_Pago_ID]
		  ,[Subtotal]
		  ,[IVA]
		  ,[Descuento]
		  ,[Impuesto_Servicio]
		  ,TIPS_Propina
		  ,[Total_Pago]
	  FROM [dbo].[Factura]
	END
GO

CREATE PROCEDURE SP_LISTAR_INCAPACIDADES/*listo*/
AS
BEGIN
SELECT [Incapacidad_ID]
      ,[Empleado_ID]
      ,[Fecha_Inicio]
      ,[Fecha_Final]
      ,[Numero_Orden]
      ,[Descripcion]
	 
  FROM [dbo].[Incapacidades]
END
GO
 
 CREATE PROCEDURE SP_LISTAR_MENAJE  /* listo*/
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
  END
GO

CREATE OR ALTER PROCEDURE SP_LISTAR_MENU /* listo*/
AS
BEGIN

SELECT [Menu_ID]
      ,[Platillo_ID]
      ,[Producto_ID]
      ,[Cantidad]
FROM [dbo].[Menu]
  
  END
GO

CREATE OR ALTER PROCEDURE SP_LISTAR_MENU_2 /* listo*/
AS
BEGIN

SELECT	 M.Menu_ID AS [ID MENÚ]
		,PLA.Nombre AS [NOMBRE PLATILLO]
		,PRO.Nombre AS [NOMBRE PRODUCTO]
		,M.Cantidad AS [CANTIDAD DE PRODUCTO]
      
  FROM [dbo].[Menu] AS M
  INNER JOIN [dbo].[Productos] AS PRO
	ON M.Producto_ID = PRO.Producto_ID
  INNER JOIN Platillo AS PLA
	ON M.Platillo_ID = PLA.Platillo_ID

/*
SELECT [Menu_ID]
      ,[Platillo_ID]
      ,[Producto_ID]
      ,[Cantidad]
FROM [dbo].[Menu]
*/
  
  END
GO



CREATE PROCEDURE SP_LISTAR_MERMA_PRODUCTO /* listo*/
AS
BEGIN
SELECT [Merma_Producto_ID]
      ,[Fecha]
      ,[Motivo]
  FROM [dbo].[Merma_Productos]
END
GO

CREATE PROCEDURE SP_LISTAR_MERMA_PLATILLO  /* listo*/
AS
BEGIN
SELECT [Merma_Platillo_ID]
	  ,[Platillo_ID]
      ,[Fecha]
      ,[Motivo]
  FROM [dbo].[Merma_Platillo]
END
GO

CREATE PROCEDURE SP_LISTAR_METODODEPAGO /*listo*/
AS
BEGIN
SELECT [Metodo_Pago_ID]
      ,[Nombre]
      ,[Descripcion]      
  FROM [dbo].[Metodo_Pago]
END
GO

CREATE PROCEDURE SP_LISTAR_ORDENDETALLADA /* Listo  */
AS
BEGIN
SELECT [Orden_Detalle_ID]
      ,[Platillo_ID]
      ,[Producto_ID]
      ,[Cantidad]
      ,[Mesa]
      ,[Empleado_ID]
      ,[Tipo_Comanda_ID]
  FROM [dbo].[Orden_Detallada]
END
GO

CREATE PROCEDURE SP_LISTAR_PLATILLO /* Listo  */
AS
BEGIN
SELECT [Platillo_ID]
      ,[Nombre]
      ,[Precio_Con_IVA]
  FROM [dbo].[Platillo]
END
GO


CREATE PROCEDURE SP_LISTAR_PRODUCTOS/*listo*/
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
	END
GO

CREATE OR ALTER PROCEDURE SP_LISTAR_PRODUCTOS_2/*listo*/
AS
	BEGIN
		SELECT	[Producto_ID] as [ID PRODUCTO]
				,[Nombre] AS [NOMBRE DEL PRODUCTO]
				,[Cantidad] AS [CANT. DISP. PRODUCTO]
				  
	  FROM [dbo].[Productos]
	END
GO



CREATE PROCEDURE SP_LISTAR_PROVEEVOR/*listo*/
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
END
GO

CREATE PROCEDURE SP_LISTAR_PUESTO/*listo*/
AS
BEGIN
SELECT [Puesto_ID]
      ,[Nombre]
      ,[Funciones]
      ,[Salario]
  FROM [dbo].[Puesto]
  END
GO

CREATE PROCEDURE SP_LISTAR_SERVICIOS_PROFESIONALES/*listo*/
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
END
GO

CREATE PROCEDURE SP_LISTAR_TIPO_COMANDA/*listo*/
AS
BEGIN
SELECT [Tipo_Comanda_ID]
      ,[Nombre]
      ,[Descripcion]
  FROM [dbo].[Tipo_Comanda]
END
GO

CREATE PROCEDURE SP_LISTAR_USUARIOS/*listo*/
AS
BEGIN
SELECT [Usuario_ID]
      ,[Usuario]
      ,[Clave]
      ,[Empleado_ID]
      ,[Codigo_Recuperacion]
  FROM [dbo].[Usuarios]
  END
GO

CREATE PROCEDURE SP_LISTAR_VACACIONES/*listo*/
AS
BEGIN
SELECT V.[Vacaciones_ID]
      ,V.[Empleado_ID]
      ,[Dias_Disponibles] = (DATEDIFF(MONTH,EM.Fecha_Ingreso,GETDATE())*1.25)-[Dias_tomados]
      ,[Dias_tomados]
      ,[Fecha_Inicio_Vacaciones]
  FROM [dbo].[Vacaciones] V, [dbo].[Empleados] EM
  WHERE V.Empleado_ID = EM.Empleado_ID
END
GO

CREATE PROCEDURE [dbo].[SP_LISTAR_VACACIONES_POR_ID_EMPLEADO](@Empleado_ID nvarchar(20)) /* Listo */
AS
BEGIN
SELECT 
       [Vacaciones_ID]
      ,[Empleado_ID]
      ,[Dias_Disponibles]
      ,[Dias_tomados]
      ,[Fecha_Inicio_Vacaciones]
   
  FROM [dbo].[Vacaciones]
  WHERE dbo.Vacaciones.Empleado_ID = @Empleado_ID
  END
















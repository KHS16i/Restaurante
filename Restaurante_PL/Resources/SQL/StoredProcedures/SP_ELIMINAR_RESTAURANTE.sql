/*-------------------------------------------------------ELIMINAR--------------------------------------------------------------*/
USE Grupo_Restaurante
GO  

CREATE PROCEDURE SP_ELIMINAR_INCAPACIDADES(@filtro int)
AS
BEGIN
DELETE FROM [dbo].[Incapacidades]
      WHERE dbo.Incapacidades.Incapacidad_ID= @filtro
	END
GO


CREATE PROCEDURE SP_ELIMINAR_VACACIONES(@filtro int) 
AS
BEGIN
DELETE FROM [dbo].[Vacaciones]
      WHERE dbo.Vacaciones.Vacaciones_ID = @filtro
  END
GO


CREATE PROCEDURE SP_ELIMINAR_USUARIOS(@filtro int ) 
AS
BEGIN
DELETE FROM [dbo].[Usuarios]
      WHERE dbo.Usuarios.Usuario_ID = @filtro

	  END
GO

CREATE PROCEDURE SP_ELIMINAR_PRODUCTOS(@filtro int)
AS
BEGIN
DELETE FROM [dbo].[Productos]
      WHERE dbo.Productos.Producto_ID = @filtro
	END
GO


CREATE PROCEDURE SP_ELIMINAR_TIPO_COMANDA (@filtro int)
AS
BEGIN

DELETE FROM [dbo].[Tipo_Comanda]
      WHERE  dbo.Tipo_Comanda.Tipo_Comanda_ID = @filtro
	  END
GO


CREATE PROCEDURE SP_ELIMINAR_SERVICIOS_PROFESIONALES(@filtro int)
AS
BEGIN
DELETE FROM [dbo].[Servicios_Profesionales]
      WHERE dbo.Servicios_Profesionales.Servicio_ID = @filtro
	  END
GO

CREATE PROCEDURE SP_ELIMINAR_PUESTO(@filtro NVARCHAR(40))
AS
BEGIN
DELETE FROM [dbo].[Puesto]
      WHERE dbo.Puesto.Puesto_ID = @filtro
	END
GO


CREATE PROCEDURE SP_ELIMINAR_PROVEEVOR(@filtro int)
AS
BEGIN
DELETE FROM [dbo].[Proveedor]
      WHERE dbo.Proveedor.Proveedor_ID = @filtro
	END
GO


CREATE PROCEDURE SP_ELIMINAR_ORDENDETALLADA(@filtro int)
AS
BEGIN
DELETE FROM [dbo].[Orden_Detallada]
      WHERE dbo.Orden_Detallada.Orden_Detalle_ID = @filtro
	END
GO

CREATE PROCEDURE SP_ELIMINAR_METODODEPAGO(@filtro int)
AS
BEGIN
DELETE FROM [dbo].[Metodo_Pago]
      WHERE dbo.Metodo_Pago.Metodo_Pago_ID = @filtro
	END
GO

CREATE PROCEDURE SP_ELIMINAR_MERMA_PRODUCTO(@filtro int)
AS
BEGIN
DELETE FROM [dbo].[Merma_Productos]
      WHERE dbo.Merma_Productos.Merma_Producto_ID = @filtro
	END
GO

CREATE PROCEDURE SP_ELIMINAR_MERMA_PLATILLO(@filtro int)
AS
BEGIN
DELETE FROM [dbo].[Merma_Platillo]
      WHERE dbo.Merma_Platillo.Merma_Platillo_ID = @filtro
	END
GO

CREATE PROCEDURE SP_ELIMINAR_EMPLEADOS(@filtro nvarchar(20)) 
AS
BEGIN
DELETE FROM [dbo].[Empleados]
      WHERE dbo.Empleados.Empleado_ID = @filtro
	  END
GO

CREATE PROCEDURE SP_ELIMINAR_CATEGORIA_PRODUCTO( @filtro int) 
AS
BEGIN
DELETE FROM [dbo].[Categoria_Producto]
      WHERE dbo.Categoria_Producto.Categoria_ID = @filtro
END
GO


CREATE PROCEDURE SP_ELIMINAR_MENAJE(@filtro int)
AS
BEGIN
DELETE FROM [dbo].[Menaje]
      WHERE  dbo.Menaje.Menaje_ID= @filtro
	  END
GO
CREATE PROCEDURE SP_ELIMINAR_MENU(@filtro int)
AS
BEGIN
DELETE FROM [dbo].[Menu]
      WHERE  dbo.Menu.Menu_ID=@filtro
END

GO
CREATE PROCEDURE SP_ELIMINAR_PLATILLO(@filtro int)
AS
BEGIN
DELETE FROM [dbo].[Platillo]
      WHERE  dbo.Platillo.Platillo_ID=@filtro
END

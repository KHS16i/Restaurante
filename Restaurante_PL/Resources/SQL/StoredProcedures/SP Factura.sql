USE [Grupo_Restaurante]
GO

CREATE PROCEDURE SP_ORDEN(@Mesa char(1))
AS
BEGIN
SELECT PL.Nombre AS Nombre, PL.Precio_Con_IVA AS Precio, OD.Cantidad AS Cantidad
  FROM [dbo].[Orden_Detallada] AS OD
  INNER JOIN [dbo].[Platillo] AS PL
  ON OD.Platillo_ID = PL.Platillo_ID
  INNER JOIN [dbo].[Productos] AS P
  ON OD.Producto_ID = P.Producto_ID
  WHERE OD.Mesa = @Mesa
  END

GO










-- =============================================
-- Author:		WALDER MAYEN JUAN
-- Create date: 08/03/2025
-- Description:	MOSTRAR DATOS VEHICULOS DE LA TABLA VEHICULOS
-- =============================================
CREATE PROCEDURE ups_mostrar_vehiculos
	
AS
BEGIN
	
	SET NOCOUNT ON;
	select * from tblVehiculos;
    
END


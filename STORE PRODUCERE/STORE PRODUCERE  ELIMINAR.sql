
-- =============================================
-- Author:		WALDER MAYEN JUAN
-- Create date: 08/03/2025
-- Description:	ELIMINAR DATOS VEHICULOS DE LA TABLA VEHICULOS
-- ============================================
CREATE PROCEDURE ups_eliminar_vehiculos
	(@VehiculoID INT)
AS
BEGIN
	
	SET NOCOUNT ON;
	delete tblVehiculos
	where VehiculoID = @VehiculoID;
    
END


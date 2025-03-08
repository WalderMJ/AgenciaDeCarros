
-- =============================================
-- Author:		WALDER MAYEN JUAN
-- Create date: 08/03/2025
-- Description:	ACTUALIZAR DATOS VEHICULOS DE LA TABLA VEHICULOS
-- ============================================
CREATE PROCEDURE ups_actualizar_vehiculos
	@VehiculoID int ,
	@Marca varchar (30),
	@Modelo varchar (30),
	@Año int ,
	@Precio decimal (10,2),
	@Estado varchar (30)
AS
BEGIN
	
	SET NOCOUNT ON;
	update tblVehiculos
	set
	Marca = @Marca,
	Modelo = @Modelo,
	Año = @Año,
	Precio = @Precio,
	Estado = @Estado
	where VehiculoID = @VehiculoID;

    
END



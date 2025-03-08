
-- =============================================
-- Author:		WALDER MAYEN JUAN
-- Create date: 08/03/2025
-- Description:	CREAR DATOS VEHICULOS DE LA TABLA VEHICULOS
-- ============================================
CREATE PROCEDURE ups_crear_vehiculo
	
	@Marca varchar (30),
	@Modelo varchar (30),
	@A�o int ,
	@Precio decimal (10,2),
	@Estado varchar (30)

AS
BEGIN
	
	SET NOCOUNT ON;
	insert into tblVehiculos
	(
	Marca,
	Modelo,
	A�o,
	Precio,
	Estado
	)
	values
	(
	@Marca,
	@Modelo,
	@A�o,
	@Precio,
	@Estado
	)
   
END


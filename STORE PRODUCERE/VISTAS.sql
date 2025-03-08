--a)  Mostrar nombre, apellido y precio de todos los vehículos con un precio mayor a 20,000.

create view VW_DATOS_CLIENTE_PRECIOS AS
select 
c.Nombre,
c.Apellido,
vh.Precio
from tblClientes c
inner join tblVentas v
on c.ClienteID = v.ClienteID
inner join tblVehiculos vh
on v.VehiculoID = vh.VehiculoID
where vh.Precio > 20000;

-- b) Mostrar nombre, apellido y monto total gastado por cada cliente.

create view VW_VENTA_TOTAL_CLIENTES AS
select 
C.Nombre,
C.Apellido,
sum(v.Monto) as MONTO_VENDIDO
from tblClientes c
inner join tblVentas v
on c.ClienteID = v.ClienteID
group by c.Nombre,c.Apellido;


-- c) Listar información de todas las ventas, incluyendo el cliente, el vehículo y el monto de
--	  la venta.

create view VW_VENTA_CLIENTE_VEHICULO AS
select 
v.ClienteID,
c.Nombre,
c.Apellido,
v.VehiculoID,
vh.Marca,
vh.Modelo,
vh.Precio,
v.FechaVenta,
v.Monto
from tblClientes c
inner join tblVentas v
on c.ClienteID = v.ClienteID
inner join tblVehiculos vh
on v.VehiculoID = vh.VehiculoID;

-- d) Mostrar datos de los clientes que han realizado más de una compra.
create view VW_CONTEO_VENTAS AS
select 
c.Nombre,
c.Apellido,
count (v.VentaID) as NUMERODECOMPRADOR
from tblClientes c
inner join tblVentas v
on c.ClienteID= v.ClienteID
group by c.Nombre, c.Apellido
having
count (v.VentaID) > 1;

-- e) Listar todos los vehículos que están disponibles para la venta, ordenados por precio de
--	  forma ascendente.

CREATE VIEW VW_DATOS_VEHICULO AS
SELECT TOP 100 PERCENT *
FROM tblVehiculos
WHERE Estado = 'Disponible'
ORDER BY Precio ASC;
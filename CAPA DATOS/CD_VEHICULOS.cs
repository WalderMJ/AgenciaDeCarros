using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace CAPA_DATOS
{
   public class CD_VEHICULOS
    {
        CD_CONEXION db_conexion = new CD_CONEXION();

        public DataTable MtMostrarVehiculos()
        {
            string QryMostrarVehiculos = "ups_mostrar_vehiculos";
            SqlDataAdapter adapter = new SqlDataAdapter(QryMostrarVehiculos, db_conexion.MtdAbrirConexion());
            DataTable dtMostrarVehiculos = new DataTable();
            adapter.Fill(dtMostrarVehiculos);
            db_conexion.MtdCerrarConexion();
            return dtMostrarVehiculos;


        }
        public void MtInsertarVehiculo(string Marca, string Modelo, int Año, decimal Precio, string Estado)
        {
            try
            {
                string Usp_crear = "ups_crear_vehiculo";

                using (SqlCommand cmd_InsertarVehiculos = new SqlCommand(Usp_crear, db_conexion.MtdAbrirConexion()))
                {
                    cmd_InsertarVehiculos.CommandType = CommandType.StoredProcedure;

                    cmd_InsertarVehiculos.Parameters.AddWithValue("@Marca", Marca);
                    cmd_InsertarVehiculos.Parameters.AddWithValue("@Modelo", Modelo);
                    cmd_InsertarVehiculos.Parameters.AddWithValue("@Año", Año);
                    cmd_InsertarVehiculos.Parameters.AddWithValue("@Precio", Precio);
                    cmd_InsertarVehiculos.Parameters.AddWithValue("@Estado", Estado);

                    cmd_InsertarVehiculos.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al insertar estudiante: {ex.Message}");
            }
            finally
            {
                db_conexion.MtdCerrarConexion();
            }
        }

        public void MtdActualizarVehiculo(int VehiculoID, string Marca, string Modelo, int Año, decimal Precio, string Estado)
        {

            String usp_actualizar = "ups_actualizar_vehiculos";

            SqlCommand cmduspActualizar = new SqlCommand(usp_actualizar, db_conexion.MtdAbrirConexion());

            cmduspActualizar.CommandType = CommandType.StoredProcedure;

            cmduspActualizar.Parameters.AddWithValue("@VehiculoID", VehiculoID);

            cmduspActualizar.Parameters.AddWithValue("@Marca", Marca);
            cmduspActualizar.Parameters.AddWithValue("@Modelo", Modelo);
            cmduspActualizar.Parameters.AddWithValue("@Año", Año);
            cmduspActualizar.Parameters.AddWithValue("@Precio", Precio);
            cmduspActualizar.Parameters.AddWithValue("@Estado", Estado);
            cmduspActualizar.ExecuteNonQuery();

            db_conexion.MtdCerrarConexion();


        }

        public void CD_mtdEliminarrVehiculo(int VehiculoID)
        {



            string UspEliminarVehiculo = "ups_eliminar_vehiculos";
            SqlCommand commUspEliminarVehiculo = new SqlCommand(UspEliminarVehiculo, db_conexion.MtdAbrirConexion());
            commUspEliminarVehiculo.CommandType = CommandType.StoredProcedure;

            commUspEliminarVehiculo.Parameters.AddWithValue("@VehiculoID", VehiculoID);
            commUspEliminarVehiculo.ExecuteNonQuery();



            db_conexion.MtdCerrarConexion();

        }

    }
}

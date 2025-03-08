using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DATOS
{
    public class CD_CONEXION
    {
        private SqlConnection db_conexion = new SqlConnection("Data Source=WALDERMJ\\SQLEXPRESS;Initial Catalog=db_AgenciaCarros;Integrated Security=True;Encrypt=False");

        public SqlConnection MtdAbrirConexion()
        {
            if (db_conexion.State == ConnectionState.Closed)
                db_conexion.Open();
            return db_conexion;
        }

        public SqlConnection MtdCerrarConexion()
        {
            if (db_conexion.State == ConnectionState.Closed)
                db_conexion.Close();
            return db_conexion;
        }
    }
}

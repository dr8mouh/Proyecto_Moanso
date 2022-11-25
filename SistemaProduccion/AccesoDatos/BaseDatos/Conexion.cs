using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.BaseDatos
{
    public class Conexion
    {
        private static readonly Conexion instancia = new Conexion();
        public static Conexion Instancia
        {
            get { return Conexion.instancia; }
        }
        public SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=LAPTOP-CLR629GA\\SQLEXPRESS;Initial Catalog = DBSistemaProduccion;" + "Integrated Security = true";

            return cn;
        }
    }
}

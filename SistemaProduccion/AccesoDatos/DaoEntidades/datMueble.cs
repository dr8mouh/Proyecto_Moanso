using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.BaseDatos;
using entMueble;

namespace AccesoDatos.DaoEntidades
{
    public class datMueble
    {
        #region sigleton
        private static readonly datMueble _instancia = new datMueble();
        public static datMueble Instancia
        {
            get
            {
                return datMueble._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<Mueble> ListarMueble()
        {
            SqlCommand cmd = null;
            List<Mueble> lista = new List<Mueble>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaMueble", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Mueble Mu = new Mueble();
                    Mu.MuebleID = Convert.ToInt32(dr["MuebleID"]);
                    Mu.IDsupervisor = Convert.ToInt32(dr["IDsupervisor"]);
                    Mu.OrdenIngresoptID = Convert.ToInt32(dr["OrdenIngresoptID"]);

                    lista.Add(Mu);
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }
        /////////////////////////InsertaCliente
        public Boolean InsertarMueble(Mueble Mu)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarMueble", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MuebleID", Mu.MuebleID);
                cmd.Parameters.AddWithValue("@IDsupervisor", Mu.IDsupervisor);
                cmd.Parameters.AddWithValue("@OrdenIngresoptID", Mu.OrdenIngresoptID);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }


        //////////////////////////////////EditaCliente
        public Boolean EditarMueble(Mueble Mu)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaMueble", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MuebleID", Mu.MuebleID);
                cmd.Parameters.AddWithValue("@IDsupervisor", Mu.IDsupervisor);
                cmd.Parameters.AddWithValue("@OrdenIngresoptID", Mu.OrdenIngresoptID);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return edita;
        }

        //deshabilitaCliente


        public List<Mueble> Buscar(string id)
        {
            SqlCommand cmd = null;
            List<Mueble> lista = new List<Mueble>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spBuscarMueble", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MuebleID", id);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    Mueble Mu = new Mueble();
                    Mu.MuebleID = Convert.ToInt32(dr[".MuebleID"]);
                    Mu.IDsupervisor = Convert.ToInt32(dr["IDsupervisor"]);
                    Mu.OrdenIngresoptID = Convert.ToInt32(dr["OrdenIngresoptID"]);

                    lista.Add(Mu);
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }

        #endregion metodos
    }
}


using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.BaseDatos;
using entCategoriaMueble;

namespace AccesoDatos.DaoEntidades
{
    public class datCategoriaMueble
    {

        #region sigleton
        private static readonly datCategoriaMueble _instancia = new datCategoriaMueble();
        public static datCategoriaMueble Instancia
        {
            get
            {
                return datCategoriaMueble._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<CategoriaMueble> ListarCategoriaMueble()
        {
            SqlCommand cmd = null;
            List<CategoriaMueble> lista = new List<CategoriaMueble>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaCategoriaMueble", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CategoriaMueble Cat = new CategoriaMueble();
                    Cat.CategoriaMuebleID = Convert.ToInt32(dr["CategoriaMuebleID"]);
                    Cat.CatMueble = dr["CategoriaMueble"].ToString();
                    Cat.MuebleID = Convert.ToInt32(dr["MuebleID"]);

                    lista.Add(Cat);
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
        public Boolean InsertarCategoriaMueble(CategoriaMueble Cat)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarCategoriaMueble", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CategoriaMuebleID", Cat.CategoriaMuebleID);
                cmd.Parameters.AddWithValue("@CategoriaMueble", Cat.CatMueble);
                cmd.Parameters.AddWithValue("@MuebleID", Cat.MuebleID);
                
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
        public Boolean EditarCategoriaMueble(CategoriaMueble Cat)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaCategoriaMueble", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CategoriaMuebleID", Cat.CategoriaMuebleID);
                cmd.Parameters.AddWithValue("@CategoriaMueble", Cat.CatMueble);
                cmd.Parameters.AddWithValue("@MuebleID", Cat.MuebleID);
            
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

        
        public List<CategoriaMueble> Buscar(string id)
        {
            SqlCommand cmd = null;
            List<CategoriaMueble> lista = new List<CategoriaMueble>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spBuscarCategoriaMueble", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CategoriaMuebleID", id);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    CategoriaMueble Cat = new CategoriaMueble();
                    Cat.CategoriaMuebleID = Convert.ToInt32(dr["CategoriaMuebleID"]);
                    Cat.CatMueble = dr["CategoriaMueble"].ToString();
                    Cat.MuebleID = Convert.ToInt32(dr["MuebleID"]);

                    lista.Add(Cat);
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


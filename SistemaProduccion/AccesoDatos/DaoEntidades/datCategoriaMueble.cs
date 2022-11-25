using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public List<entCliente.Cliente> ListarCliente()
        {
            SqlCommand cmd = null;
            List<entCliente.Cliente> lista = new List<entCliente.Cliente>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCliente.Cliente Cli = new entCliente.Cliente();
                    Cli.idCliente = Convert.ToInt32(dr["idCliente"]);
                    Cli.nombCliente = dr["nombCliente"].ToString();
                    Cli.apelCliente = dr["apelCliente"].ToString();
                    Cli.direcCliente = dr["direcCliente"].ToString();
                    Cli.celular = dr["celular"].ToString();
                    Cli.dni = dr["dni"].ToString();
                    Cli.estCliente = Convert.ToBoolean(dr["estCliente"]);
                    Cli.fecRegCliente = Convert.ToDateTime(dr["fecRegCliente"]);

                    lista.Add(Cli);
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
        public Boolean InsertarCliente(entCliente.Cliente Cli)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombCliente", Cli.nombCliente);
                cmd.Parameters.AddWithValue("@apelCliente", Cli.apelCliente);
                cmd.Parameters.AddWithValue("@direcCliente", Cli.direcCliente);
                cmd.Parameters.AddWithValue("@celular", Cli.celular);
                cmd.Parameters.AddWithValue("@dni", Cli.dni);
                cmd.Parameters.AddWithValue("@estCliente", Cli.estCliente);
                cmd.Parameters.AddWithValue("@fecRegCliente", Cli.fecRegCliente);
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
        public Boolean EditarCliente(entCliente.Cliente Cli)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCliente", Cli.idCliente);
                cmd.Parameters.AddWithValue("@nombCliente", Cli.nombCliente);
                cmd.Parameters.AddWithValue("@apelCliente", Cli.apelCliente);
                cmd.Parameters.AddWithValue("@direcCliente", Cli.direcCliente);
                cmd.Parameters.AddWithValue("@celular", Cli.celular);
                cmd.Parameters.AddWithValue("@dni", Cli.dni);
                cmd.Parameters.AddWithValue("@estCliente", Cli.estCliente);
                cmd.Parameters.AddWithValue("@fecRegCliente", Cli.fecRegCliente);
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

        public Boolean DeshabilitarCliente(entCliente.Cliente Cli)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCliente", Cli.idCliente);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    delete = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return delete;
        }
        public List<Cliente> Buscar(string dni)
        {
            SqlCommand cmd = null;
            List<Cliente> lista = new List<Cliente>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spBuscarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@dni", dni);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCliente.Cliente Cli = new entCliente.Cliente();
                    Cli.idCliente = Convert.ToInt32(dr["idCliente"]);
                    Cli.nombCliente = dr["nombCliente"].ToString();
                    Cli.apelCliente = dr["apelCliente"].ToString();
                    Cli.direcCliente = dr["direcCliente"].ToString();
                    Cli.celular = dr["celular"].ToString();
                    Cli.dni = dr["dni"].ToString();
                    Cli.estCliente = Convert.ToBoolean(dr["estCliente"]);
                    Cli.fecRegCliente = Convert.ToDateTime(dr["fecRegCliente"]);

                    lista.Add(Cli);
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
}

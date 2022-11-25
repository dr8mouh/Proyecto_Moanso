using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entCategoriaMueble;
using AccesoDatos.DaoEntidades;

namespace LogicaNegocio
{
    public class logCategoriaMueble
    {
        private static readonly logCategoriaMueble _instancia = new logCategoriaMueble();

        public static logCategoriaMueble Instancia
        {
            get
            {
                return logCategoriaMueble._instancia;
            }
        }
        public List<CategoriaMueble> ListarCategoriaMueble()
        {
            return datCategoriaMueble.Instancia.ListarCategoriaMueble();
        }
        public void InsertarCategoriaMueble(CategoriaMueble Cat)
        {
            datCategoriaMueble.Instancia.InsertarCategoriaMueble(Cat);
        }
        public void EditaCateoriaMueble(CategoriaMueble Cat)
        {
            datCategoriaMueble.Instancia.EditarCategoriaMueble(Cat);
        }
        
        public List<CategoriaMueble> Buscar(string id)
        {
            return datCategoriaMueble.Instancia.Buscar(id);
        }

    }

}

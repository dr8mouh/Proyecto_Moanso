using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entMueble;
using AccesoDatos.DaoEntidades;

namespace LogicaNegocio
{
    public class logMueble
    {
        private static readonly logMueble _instancia = new logMueble();

        public static logMueble Instancia
        {
            get
            {
                return logMueble._instancia;
            }
        }
        public List<Mueble> ListarMueble()
        {
            return datMueble.Instancia.ListarMueble();
        }
        public void InsertarMueble(Mueble Mu)
        {
            datMueble.Instancia.InsertarMueble(Mu);
        }
        public void EditaMueble(Mueble Mu)
        {
            datMueble.Instancia.EditarMueble(Mu);
        }

        public List<Mueble> Buscar(string id)
        {
            return datMueble.Instancia.Buscar(id);
        }
    }
}

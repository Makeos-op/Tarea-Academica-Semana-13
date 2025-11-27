using Dato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
     public class NHistorialEmpleos
    {
        private DHistorialHistorialEmpleos dhistorialempleos = new DHistorialHistorialEmpleos();
        public string RegistrarEmpleo(HistorialEmpleos historialempleos)
        {
            return dhistorialempleos.RegistrarEmpleo(historialempleos);
        }

        public string Modificar(HistorialEmpleos historialempleos)
        {
            return dhistorialempleos.Modificar(historialempleos);
        }
        public string Eliminar(int codigo)
        {
            return dhistorialempleos.Eliminar(codigo);
        }
        public List<HistorialEmpleos> ListarTodo()
        {
            return dhistorialempleos.ListarTodo();
        }
    }
}

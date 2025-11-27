using Dato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NEmpleos
    {
        private DEmpleos dempleos = new DEmpleos();
        public string RegistrarEmpleo(Empleos empleos)
        {
            return dempleos.RegistrarEmpleo(empleos);
        }

        public string Modificar(Empleos empleos)
        {
            return dempleos.Modificar(empleos);
        }
        public string Eliminar(int codigo)
        {
            return dempleos.Eliminar(codigo);
        }
        public List<Empleos> ListarTodo()
        {
            return dempleos.ListarTodo();
        }
    }
}

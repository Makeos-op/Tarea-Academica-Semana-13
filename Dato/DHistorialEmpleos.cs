using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dato
{
    public class DHistorialHistorialEmpleos
    {
        private string EjecutarFuncion(Func<BDEFEntities,string> funcion) //Recibe una funcion llamada funcion que reciba objeto BDEFEntities y retorne un string
        {
            try
            {
                using (var context = new BDEFEntities()) // Crea una instancia del contexto de la base de datos
                {
                    return funcion(context); // Ejecuta la funcion pasada como parametro con el contexto y retorna su resultado
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string RegistrarEmpleo(HistorialEmpleos historialEmpleos) 
        {
            return EjecutarFuncion(instrucciones => // Llama a EjecutarFuncion pasando una funcion lambda que registra un empleo
            {
                instrucciones.HistorialEmpleos.Add(historialEmpleos); // Agrega el objeto historialEmpleos al conjunto HistorialEmpleos del contexto
                instrucciones.SaveChanges(); // Guarda los cambios en la base de datos
                return "Empleo registrado correctamente."; // Retorna un mensaje de exito
            });
        }

        public string Modificar(HistorialEmpleos historialEmpleos)
        {
            return EjecutarFuncion(instrucciones =>
            {
                HistorialEmpleos empleotemp = instrucciones.HistorialEmpleos.Find(historialEmpleos.Codigo_empleado); // Busca el empleo por su Id
                empleotemp.Fecha_inicio = historialEmpleos.Fecha_inicio;
                empleotemp.Fecha_fin = historialEmpleos.Fecha_fin;
                empleotemp.Codigo_empleado = historialEmpleos.Codigo_empleado;
                empleotemp.Codigo_empleo = historialEmpleos.Codigo_empleo;
                instrucciones.SaveChanges(); // Guarda los cambios en la base de datos
                return "Empleo modificado correctamente."; // Retorna un mensaje de exito
            });
        }
        public string Eliminar(int codigo)
        {
            return EjecutarFuncion(instrucciones =>
            {
                HistorialEmpleos empleotemp = instrucciones.HistorialEmpleos.Find(codigo); // Busca el empleo por su Id
                instrucciones.HistorialEmpleos.Remove(empleotemp);// Actualiza el nombre del empleo
                instrucciones.SaveChanges(); // Guarda los cambios en la base de datos
                return "Empleo eliminado correctamente."; // Retorna un mensaje de exito
            });
        }
        public List<HistorialEmpleos> ListarTodo(int empleocodigo)
        {
            List<HistorialEmpleos> listaHistorialEmpleos = new List<HistorialEmpleos>();
            try
            {
                using (var context = new BDEFEntities()) // Crea una instancia del contexto de la base de datos
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    listaHistorialEmpleos = context.HistorialEmpleos.Where(i=>i.Codigo_empleo.Equals(empleocodigo)).ToList(); // Ejecuta la funcion pasada como parametro con el contexto y retorna su resultado
                }
                return listaHistorialEmpleos;
            }
            catch (Exception)
            {
                return listaHistorialEmpleos;
            }
        }
    }
}

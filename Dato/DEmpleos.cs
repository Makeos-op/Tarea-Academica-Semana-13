using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dato
{
    public class DEmpleos
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
        public string RegistrarEmpleo(Empleos empleos) 
        {
            return EjecutarFuncion(instrucciones => // Llama a EjecutarFuncion pasando una funcion lambda que registra un empleo
            {
                instrucciones.Empleos.Add(empleos); // Agrega el objeto empleos al conjunto Empleos del contexto
                instrucciones.SaveChanges(); // Guarda los cambios en la base de datos
                return "Empleo registrado correctamente."; // Retorna un mensaje de exito
            });
        }

        public string Modificar(Empleos empleos)
        {
            return EjecutarFuncion(instrucciones =>
            {
                Empleos empleotemp = instrucciones.Empleos.Find(empleos.Codigo); // Busca el empleo por su Id
                empleotemp.Nombre_empleo = empleos.Nombre_empleo; // Actualiza el nombre del empleo
                empleotemp.Salario_minimo = empleos.Salario_minimo;
                empleotemp.Salario_maximo = empleos.Salario_maximo;
                instrucciones.SaveChanges(); // Guarda los cambios en la base de datos
                return "Empleo modificado correctamente."; // Retorna un mensaje de exito
            });
        }
        public string Eliminar(int codigo)
        {
            return EjecutarFuncion(instrucciones =>
            {
                Empleos empleotemp = instrucciones.Empleos.Find(codigo); // Busca el empleo por su Id
                instrucciones.Empleos.Remove(empleotemp);// Actualiza el nombre del empleo
                instrucciones.SaveChanges(); // Guarda los cambios en la base de datos
                return "Empleo eliminado correctamente."; // Retorna un mensaje de exito
            });
        }
        public List<Empleos> ListarTodo()
        {
            List<Empleos> listaEmpleos = new List<Empleos>();
            try
            {
                using (var context = new BDEFEntities()) // Crea una instancia del contexto de la base de datos
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    listaEmpleos = context.Empleos.ToList(); // Ejecuta la funcion pasada como parametro con el contexto y retorna su resultado
                }
                return listaEmpleos;
            }
            catch (Exception)
            {
                return listaEmpleos;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    // Clase que representa una tarea de mantenimiento
    public class TareaMantenimiento : ITarea
    {
        public string Nombre { get; set; }
        private string estado;

        public string Estado
        {
            get { return estado; }
        }

        public TareaMantenimiento(string nombre)
        {
            Nombre = nombre;
            estado = "Pendiente";
        }

        public void IniciarTarea()
        {
            estado = "En Progreso";
            Console.WriteLine($"La tarea de mantenimiento '{Nombre}' ha sido iniciada.");
        }

        public void CompletarTarea()
        {
            estado = "Completada";
            Console.WriteLine($"La tarea de mantenimiento '{Nombre}' ha sido completada.");
        }

        public void GenerarReporte()
        {
            Console.WriteLine($"Reporte de la tarea de mantenimiento '{Nombre}': Estado - {estado}.");
        }
    }
}

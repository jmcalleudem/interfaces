using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    // Clase que representa una tarea administrativa
    public class TareaAdministrativa : ITarea
    {
        public string Nombre { get; set; }
        private string estado;

        public string Estado
        {
            get { return estado; }
        }

        public TareaAdministrativa(string nombre)
        {
            Nombre = nombre;
            estado = "Pendiente";
        }

        public void IniciarTarea()
        {
            estado = "En Progreso";
            Console.WriteLine($"La tarea administrativa '{Nombre}' ha sido iniciada.");
        }

        public void CompletarTarea()
        {
            estado = "Completada";
            Console.WriteLine($"La tarea administrativa '{Nombre}' ha sido completada.");
        }

        public void GenerarReporte()
        {
            Console.WriteLine($"Reporte de la tarea administrativa '{Nombre}': Estado - {estado}.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    // Clase que gestiona las tareas
    public class GestorTareas
    {
        private List<ITarea> tareas;

        public GestorTareas()
        {
            tareas = new List<ITarea>();
        }

        public void AgregarTarea(ITarea tarea)
        {
            if (tarea != null)
                tareas.Add(tarea);
            else
                throw new ArgumentNullException("La tarea no puede ser nula.");
        }

        public void IniciarTodasLasTareas()
        {
            foreach (var tarea in tareas)
            {
                if (tarea.Estado == "Pendiente")
                    tarea.IniciarTarea();
            }
        }

        public void CompletarTodasLasTareas()
        {
            foreach (var tarea in tareas)
            {
                if (tarea.Estado == "En Progreso")
                    tarea.CompletarTarea();
            }
        }

        public void GenerarReporteGeneral()
        {
            foreach (var tarea in tareas)
            {
                tarea.GenerarReporte();
            }
        }

        public List<ITarea> BuscarTareasPorEstado(string estado)
        {
            return tareas.Where(t => t.Estado == estado).ToList();
        }

        public void ListarTareas()
        {
            foreach (var tarea in tareas)
            {
                Console.WriteLine($"Tarea: {tarea.Nombre}, Estado: {tarea.Estado}");
            }
        }
    }
}

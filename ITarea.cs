using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    // Interfaz para definir el comportamiento de las tareas
    public interface ITarea
    {
        string Nombre { get; set; }
        string Estado { get; }
        void IniciarTarea();
        void CompletarTarea();
        void GenerarReporte();
    }
}

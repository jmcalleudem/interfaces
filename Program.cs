using interfaces;

class Program
{
    static void Main()
    {
        // Crear instancias de diferentes tareas
        TareaLimpieza limpieza = new TareaLimpieza("Limpiar cocina");
        TareaMantenimiento mantenimiento = new TareaMantenimiento("Reparar aire acondicionado");
        TareaAdministrativa administrativa = new TareaAdministrativa("Actualizar base de datos");

        // Crear instancia del gestor de tareas
        GestorTareas gestor = new GestorTareas();

        // Agregar tareas al gestor
        gestor.AgregarTarea(limpieza);
        gestor.AgregarTarea(mantenimiento);
        gestor.AgregarTarea(administrativa);

        // Iniciar todas las tareas pendientes
        Console.WriteLine("Iniciando todas las tareas pendientes:");
        gestor.IniciarTodasLasTareas();

        // Listar todas las tareas
        Console.WriteLine("\nListando todas las tareas:");
        gestor.ListarTareas();

        // Completar todas las tareas en progreso
        Console.WriteLine("\nCompletando todas las tareas en progreso:");
        gestor.CompletarTodasLasTareas();

        // Generar reporte general de todas las tareas
        Console.WriteLine("\nGenerando reporte general de todas las tareas:");
        gestor.GenerarReporteGeneral();

        // Buscar y listar tareas completadas
        Console.WriteLine("\nBuscando y listando tareas completadas:");
        var tareasCompletadas = gestor.BuscarTareasPorEstado("Completada");
        foreach (var tarea in tareasCompletadas)
        {
            Console.WriteLine($"Tarea: {tarea.Nombre}, Estado: {tarea.Estado}");
        }
    }
}
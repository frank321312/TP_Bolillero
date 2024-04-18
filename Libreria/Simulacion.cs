namespace Libreria;

public class Simulacion
{
    public long SimularSinHilos(Bolillero bolillero, List<int> jugada, int cantidad)
        => bolillero.JugarNVeces(jugada, cantidad);
    public long SimularConHilos(Bolillero bolillero, List<int> jugada, int cantidad, int hilos)
    {
        Task<long>[] tareas = new Task<long>[hilos];
        int result = cantidad / hilos;
        if (cantidad % hilos != 0)
        {
            
        }
        for (long i = 0; i < hilos; i++)
        {
            Bolillero clon = (Bolillero)bolillero.Clone();
            tareas[i] = Task.Run(() => clon.JugarNVeces(jugada, result));
        }
        
        Task.WaitAll(tareas);

        return tareas.Sum(t => t.Result);
    }
}
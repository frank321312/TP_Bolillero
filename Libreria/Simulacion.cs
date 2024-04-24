namespace Libreria;

public class Simulacion
{
    public long SimularSinHilos(Bolillero bolillero, List<int> jugada, int cantidad)
        => bolillero.JugarNVeces(jugada, cantidad);
    public long SimularConHilos(Bolillero bolillero, List<int> jugada, int cantidad, int hilos)
    {
        Task<long>[] tareas = new Task<long>[hilos];
        int result = cantidad / hilos;
        int res = cantidad % hilos;

        Bolillero clonAfuera = (Bolillero)bolillero.Clone();
        tareas[0] = Task.Run(() => clonAfuera.JugarNVeces(jugada, result + res));

        for (long i = 1; i < hilos; i++)
        {
            Bolillero clon = (Bolillero)bolillero.Clone();
                tareas[i] = Task.Run(() => clon.JugarNVeces(jugada, result));
        }
        
        Task.WaitAll(tareas);

        return tareas.Sum(t => t.Result);
    }
    public async Task<long> SimularConHilosAsync(Bolillero bolillero, List<int> jugada, int cantidad, int hilos)
    {
        Task<long>[] tareas = new Task<long>[hilos];
        long result = cantidad / hilos;
        long res = cantidad % hilos;

        Bolillero clonAfuera = (Bolillero)bolillero.Clone();
        tareas[0] = Task.Run(() => clonAfuera.JugarNVeces(jugada, result + res));
        
        for (long i = 1; i < hilos; i++)
        {
            Bolillero clon = (Bolillero)bolillero.Clone();
                tareas[i] = Task.Run(() => clon.JugarNVeces(jugada, result));
        }

        await Task.WhenAll(tareas);
        
        return tareas.Sum(t => t.Result);
    }
}
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

        tareas[0] = GenerarTaskSimulacion(bolillero, jugada, result + res);

        for (long i = 1; i < hilos; i++)
            tareas[i] = GenerarTaskSimulacion(bolillero, jugada, result);

        Task.WaitAll(tareas);

        return tareas.Sum(t => t.Result);
    }
    public async Task<long> SimularConHilosAsync(Bolillero bolillero, List<int> jugada, int cantidad, int hilos)
    {
        Task<long>[] tareas = new Task<long>[hilos];
        long result = cantidad / hilos;
        long res = cantidad % hilos;

        tareas[0] = GenerarTaskSimulacion(bolillero, jugada, result + res);

        for (long i = 1; i < hilos; i++)
            tareas[i] = GenerarTaskSimulacion(bolillero, jugada, result);        

        await Task.WhenAll(tareas);
        
        return tareas.Sum(t => t.Result);
    }

    private Task<long> GenerarTaskSimulacion(Bolillero bolillero, List<int> jugada, long cantidad)
    {
        var clon = (Bolillero)bolillero.Clone();
        return Task.Run(() => clon.JugarNVeces(jugada, cantidad));
    }
}
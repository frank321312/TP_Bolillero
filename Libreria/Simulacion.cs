namespace Libreria;

public class Simulacion
{
    public long SimularSinHilos(Bolillero bolillero, List<int> jugada, int cantidad)
        => bolillero.JugarNVeces(jugada, cantidad);
    public long SimularConHilos(Bolillero bolillero, List<int> jugada, int cantidad, int hilos)
    {
        long ganaNVeces = 0;
        Task[] tareas = new Task[hilos];
        for (int i = 0; i < hilos; i++)
        {
            tareas[i] = Task.Run(() => {
                Bolillero clonarBolillero = (Bolillero)bolillero.Clone();
                ganaNVeces += clonarBolillero.JugarNVeces(jugada, 1);
            });
        }

        for (int i = 0; i < cantidad; i++)
        {
        }
            Task.WaitAll(tareas);

        return ganaNVeces;
    }
}

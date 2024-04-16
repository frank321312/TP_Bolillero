namespace Libreria;

public class Simulacion
{
    public long SimularSinHilos(Bolillero bolillero, List<int> jugada, int cantidad)
        => bolillero.JugarNVeces(jugada, cantidad);
    public long SimularConHilos(Bolillero bolillero, List<int> jugada, int cantidad, int hilos)
    {
        long ganaNVeces = 0;
        Task[] tareas = new Task[hilos];
        double result = cantidad / hilos;
        for (int i = 0; i < hilos; i++)
        {
            Bolillero clonarBolillero = (Bolillero)bolillero.Clone();
            tareas[i] = Task.Run(() => {
                for (int index = 0; index < result; index++)
                {
                    ganaNVeces += clonarBolillero.JugarNVeces(jugada, 1);                    
                }
            });
        }
        
        Task.WaitAll(tareas);

        return ganaNVeces;
    }
}

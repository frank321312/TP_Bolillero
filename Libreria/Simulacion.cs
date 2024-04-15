namespace Libreria;

public class Simulacion 
{
    public long SimularSinHilos(Bolillero bolillero, List<int> jugada, int cantidad)
    {
        long ganaNVeces = 0;
        for (var i = 0; i < cantidad; i++)
        {
            bolillero.ReingresarBolillas();
            if (bolillero.Jugada(jugada))
            {
                ganaNVeces++;
            }
        }
        return ganaNVeces;
    }
    public long SimularConHilos(Bolillero bolillero, List<int> jugada, int cantidad)
    {
        long ganaNVeces = 0;
        for (int i = 0; i < cantidad; i++)
        {
            Task tarea = Task.Run(() => {
                Bolillero clonarBolillero = (Bolillero)bolillero.Clone();
                
                if (clonarBolillero.Jugada(jugada))
                {
                    ganaNVeces++;
                }
            });

            tarea.Wait();
        }

        return ganaNVeces;
    }
}

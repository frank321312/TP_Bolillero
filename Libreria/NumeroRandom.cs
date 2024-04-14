namespace Libreria;

public class NumeroRandom : IAleatorio
{
    public int GenerarNumeroAleatorio(Bolillero bolillero) 
    {
        int numero = new Random().Next(0, bolillero.bolillas.Count);
        return bolillero.bolillas[numero];
    }
}

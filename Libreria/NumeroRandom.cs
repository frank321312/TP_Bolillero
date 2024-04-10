namespace Libreria;

public class NumeroRandom : IAleatorio
{
    public int GenerarNumeroAleatorio(int cantidad) => new Random().Next(0, cantidad);
}

namespace Libreria;

public class DevolverPrimerNumero : IAleatorio
{
    public int GenerarNumeroAleatorio(Bolillero bolillero) => bolillero.bolillas[0];
}

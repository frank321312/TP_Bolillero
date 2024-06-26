namespace Libreria;

public class Bolillero
{
    public List<int> bolillas { get; set; } = new List<int>();
    public List<int> bolillasAfuera { get; set; } = new List<int>();
    public IAleatorio _aleatorio;
    public Bolillero(int cantidad) : this(cantidad, new NumeroRandom()) {}
    public Bolillero(int cantidad, IAleatorio aleatorio)
    {
        for (var i = 0; i < cantidad; i++) { bolillas.Add(i); } 
        _aleatorio = aleatorio;
    }
    public bool Jugada(List<int> jugadas)
    {
        foreach (var item in jugadas)
        {
            if (item != SacarBolilla()) 
            {
                return false;
            }
        }
        return true;
    }
    public int JugarNVeces(List<int> jugadas, int cantidad)
    {
        int ganaNVeces = 0;
        for (var i = 0; i < cantidad; i++)
        {
            ReingresarBolillas();
            if (Jugada(jugadas)) 
            {
                ganaNVeces++;
            }
        }
        return ganaNVeces;
    }
    public int SacarBolilla()
    {
        int numero = _aleatorio.GenerarNumeroAleatorio(this);
        bolillasAfuera.Add(numero);
        bolillas.Remove(numero);
        return numero;
    }
    public void ReingresarBolillas()
    {
        bolillas.AddRange(bolillasAfuera);
        bolillas.Sort();
        bolillasAfuera.Clear();
    }
}

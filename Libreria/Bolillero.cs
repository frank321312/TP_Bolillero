namespace Libreria;

public class Bolillero
{
    public List<int> bolillas = new List<int>();
    public List<int> bolillasAfuera = new List<int>();
    public IAleatorio _aleatorio;
    public int almacenarNumbero { get; set; }
    public Bolillero(int cantidad)
    {
        for (int i = 0; i < cantidad; i++)
        {
            bolillas.Add(i);
        }
        _aleatorio = new NumeroRandom();
        almacenarNumbero = _aleatorio.GenerarNumeroAleatorio(cantidad);
    }
    public void SacarUnaBolilla(int jugada)
    {
        if(bolillas[almacenarNumbero] == jugada)
        {
            bolillasAfuera.Add(almacenarNumbero);
            bolillas.Remove(almacenarNumbero);
            almacenarNumbero = _aleatorio.GenerarNumeroAleatorio(bolillas.Count);
        }
        else 
        {
            bolillasAfuera.Add(almacenarNumbero);
            bolillas.Remove(almacenarNumbero);
            almacenarNumbero = _aleatorio.GenerarNumeroAleatorio(bolillas.Count);
        }
    }
    public void SacarVariasBolillas(List<int> jugadas)
    {
        foreach (var item in jugadas)
        {
            if (item == bolillas[item])
            {
                System.Console.WriteLine("Le atinaste crack");
            }
            else
            {
                System.Console.WriteLine("Malardo"); 
            }
        }
    }
}

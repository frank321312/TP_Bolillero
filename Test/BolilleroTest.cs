namespace Test;
using Xunit;
using Libreria;

public class BolilleroTest
{
    public Bolillero bolilleroTest { get; set; }
    public BolilleroTest()
    {
        bolilleroTest = new Bolillero(10, new DevolverPrimerNumero());
    }

    [Fact]
    public void UnidadTest()
    {
        Assert.Equal(10, bolilleroTest.bolillas.Count);
    }

    [Fact]
    public void SacarBolilla()
    {
        Assert.Equal(0, bolilleroTest.SacarBolilla());
        Assert.Equal(9, bolilleroTest.bolillas.Count);
        Assert.Equal(1, bolilleroTest.bolillasAfuera.Count);
    }

    [Fact]
    public void ReIngresar()
    {
        bolilleroTest.ReingresarBolillas();
        Assert.Equal(10, bolilleroTest.bolillas.Count);        
        Assert.Equal(0, bolilleroTest.bolillasAfuera.Count);
    }

    [Fact]
    public void JugarGana()
    {
        List<int> jugada = new List<int>() {0, 1, 2, 3};
        Assert.True(bolilleroTest.Jugada(jugada));
    }

    [Fact]
    public void JugarPierde()
    {
        List<int> jugada = new List<int>() {4, 2, 1};
        Assert.False(bolilleroTest.Jugada(jugada));
    }

    [Fact]
    public void GanarNVeces()
    {
        List<int> jugada = new List<int>() {0, 1};
        Assert.Equal(1, bolilleroTest.JugarNVeces(jugada, 1));
    }
}
using Libreria;

Bolillero bolillero = new Bolillero(10);
Bolillero bolillero2 = new Bolillero(10, new DevolverPrimerNumero());

List<int> jugadas = new List<int>() {0,2,1,2,3,4};
System.Console.WriteLine("Ganasta: "+bolillero2.JugarNVeces(jugadas, 3));
// bolillero2.JugarNVeces(jugadas, 2);
foreach (var item in bolillero2.bolillas)
{
    System.Console.WriteLine(item);
}
// bolillero2.ReingresarBolillas();
// foreach (var item in bolillero2.bolillas)
// {
//     System.Console.WriteLine(item);
// }


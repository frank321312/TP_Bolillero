using Libreria;

Bolillero bolillero = new Bolillero(10);
Simulacion simulacion = new Simulacion();

List<int> numeros = new List<int>() {0,1};    
// System.Console.WriteLine(simulacion.SimularSinHilos(bolillero, numeros, 10000));

// System.Console.WriteLine(simulacion.SimularConHilos(bolillero, numeros, 1000, 3));

System.Console.WriteLine(simulacion.SimularConHilosAsync(bolillero, numeros, 1000, 3).Result);

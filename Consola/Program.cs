using Libreria;

Bolillero bolillero = new Bolillero(10);
Simulacion simulacion = new Simulacion();

List<int> numeros = new List<int>() {0,1,2,3};    
// System.Console.WriteLine(simulacion.SimularSinHilos(bolillero, numeros, 10000));

System.Console.WriteLine(simulacion.SimularConHilos(bolillero, numeros, 20, 4));

// void Saludar()
// {
//     for (int i = 0; i < 500; i++)
//     {
//         System.Console.WriteLine($"Hola {i}");
//     }
// }

// Task tarea = Task.Run(() => Saludar());
// tarea.Wait();

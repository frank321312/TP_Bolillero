using Libreria;

Bolillero loquita = new Bolillero(10);

// foreach (var item in loquita.bolillas)
// {
//     System.Console.WriteLine(item);
// }
// var number = new Random().NextSingle() * 10;
// var rodondear = Math.Truncate(number);
List<int> lista = new List<int>() {2,5,1,7,9,3};

// while (rodondear != 7)
// {
//     number = new Random().NextSingle() * 10;
//     rodondear = Math.Truncate(number);
//     System.Console.WriteLine(rodondear);
// }
// System.Console.WriteLine("Numero: " + lista[Convert.ToInt32(rodondear)]);
// List<int> Sacar(List<int> lista)
// {
//     return lista;
// }
// System.Console.WriteLine(lista.Sum(x => x));

// int number = new Random().Next(0, lista.Count);
// while (number != 9)
// {
//     number = new Random().Next(0, lista.Count);
//     System.Console.WriteLine(number);
// }


// System.Console.WriteLine(lista[number]);
List<int> myList = new List<int>() {0,4,2};
// // loquita.GenerarNumeroAleatorio();
// loquita.SacarBolilla(myList);
// System.Console.WriteLine("Algo: "+ loquita.GenerarNumeroAleatorio());

// foreach (var item in loquita.bolillas)
// {
//     System.Console.WriteLine(item);
// }

// int numero = loquita.TestBolillaSacar(5);
// System.Console.WriteLine("Algo: "+ numero);

loquita.SacarVariasBolillas(myList);

// loquita.SacarUnaBolilla(loquita._aleatorio.numero);
// System.Console.WriteLine("Generar numero: "+loquita._aleatorio.numero);

// System.Console.WriteLine(loquita._aleatorio.GenerarNumeroAleatorio(6));

// System.Console.WriteLine(loquita.TestNumero);

// System.Console.WriteLine(myList.Exists(x => x == 5));
// var random = new Random().Next(0, 10);
// while (myList.Count < 10)
// {
//     random = new Random().Next(0, 10);
//     if (!(myList.Exists(x => x == random)))
//     {
//         myList.Add(random);
//     }
// }
// System.Console.WriteLine("Aqui comienza");
// foreach (var item in myList)
// {
//     System.Console.WriteLine(item);
// }

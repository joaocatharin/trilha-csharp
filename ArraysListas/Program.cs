// See https://aka.ms/new-console-template for more information







// ARRAYS

// int [] arrayInteiros = new int[4]; // Ou eu posso passar os valores diretamente, conforme abaixo:

// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;
// arrayInteiros[3] = 34;

// Console.WriteLine("Percorrendo o Array com FOR");

// for(int contador = 0; contador < arrayInteiros.Length; contador++) 
// {
//     Console.WriteLine($"Posição Nº {contador} - {arrayInteiros[contador]}");
// }

// Console.WriteLine("Percorrendo o Array com FOREACH");

// foreach(int valor in arrayInteiros) // FOREACH (para cada)
// {
//     Console.WriteLine(valor);
// }

// // QUANDO QUERO REDIMENSIONAR O TAMANHO DO MEU ARRAY

// //int [] arrayInteiros = new int[4]; // Ou eu posso passar os valores diretamente, conforme abaixo:

// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;
// arrayInteiros[3] = 34;

// Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2); // Estou dobrando a capacidade do array

// Console.WriteLine("Percorrendo o Array com FOR");
// for(int contador = 0; contador < arrayInteiros.Length; contador++) 
// {
//     Console.WriteLine($"Posição Nº {contador} - {arrayInteiros[contador]}");
// }

// COPIANDO OS VALORES ANTIGOS DO ARRAY PARA UM NOVO

// int [] arrayInteirosDobrados = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrados, arrayInteiros.Length);
// Console.WriteLine(arrayInteirosDobrados);








// LISTAS

// List<string> listaString = new List<string>();

// listaString.Add("SP");
// listaString.Add("BA");
// listaString.Add("MG");
// listaString.Add("RJ");


// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// listaString.Add("SC");

// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// listaString.Remove("MG");

// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");



// Console.WriteLine("Percorrendo a lista com FOR");
// for (int contador = 0; contador < listaString.Count; contador++)
// {
//     Console.WriteLine($"Posição Nº {contador} - {listaString[contador]}");
// }

// Console.WriteLine("Percorrendo a lista com FOREACH");
// int contadorForeach = 0;
// foreach (string item in listaString)
// {
//     Console.WriteLine($"Posição Nº {contadorForeach} - {item}");
//     contadorForeach++;
// }
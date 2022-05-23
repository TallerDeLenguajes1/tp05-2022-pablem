// See https://aka.ms/new-console-template for more information

//0.- Hola mundo
Console.WriteLine("Hello World!");

//1.- Construir un programa que permita invertir Número de N cifras. 
//    Si el número es menor o igual a cero evitar esta conversión
// Console.WriteLine("Ingrese un número: ");
// string texto = Console.ReadLine();
// char[] arreglo = texto.ToCharArray(); //otro método?
// Array.Reverse(arreglo);
// texto = new string (arreglo);
// int numero =  Convert.ToInt32(texto); //Int32.Parse(texto)
// Console.WriteLine(numero);

// 4.- Dada una cadena de texto ingresada por el usuario, realice las siguientes tarea:
Console.WriteLine("Ingrese una una frase:");
string cadena = Console.ReadLine();
// ● Obtener algunas letras que forman parte de una cadena
char c1 = cadena[0];
char c5 = cadena[4];
Console.WriteLine("\nLetras 1 y 5: " + c1 + c5);
// ● Obtener la longitud de la cadena y muestre por pantalla
Console.WriteLine("\nLongitud: " + cadena.Length);
// ● Concatenar (Unir) dos cadenas distintas
string cadena2 = " y otra cadena";
Console.WriteLine("\nConcatenada: " + cadena + cadena2);
// ● Extraer una subcadena
Console.WriteLine("\nSubcadena: " + cadena.Substring(1,3));
// ● Utilizando la calculadora creada anteriormente realizar las operaciones de dos
// números y mostrar por pantalla en texto el resultado.
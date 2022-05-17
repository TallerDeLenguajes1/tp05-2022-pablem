// See https://aka.ms/new-console-template for more information

//0.- Hola mundo
Console.WriteLine("Hello World!");

//1.- Construir un programa que permita invertir Número de N cifras. 
//    Si el número es menor o igual a cero evitar esta conversión
Console.WriteLine("Ingrese un número: ");
string texto = Console.ReadLine();
char[] arreglo = texto.ToCharArray(); //otro método?
Array.Reverse(arreglo);
texto = new string (arreglo);
int numero =  Convert.ToInt32(texto); //Int32.Parse(texto)
Console.WriteLine(numero);


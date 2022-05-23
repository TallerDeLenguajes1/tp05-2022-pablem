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
Console.WriteLine("\nIngrese una una frase:");
string cadena = Console.ReadLine();
// ● Obtener algunas letras que forman parte de una cadena
char c1 = cadena[0];
char c5 = cadena[4];
Console.WriteLine("\n1.- Letras 1 y 5: " + c1 + c5);
// ● Obtener la longitud de la cadena y muestre por pantalla
Console.WriteLine("\n2.- Longitud: " + cadena.Length);
// ● Concatenar (Unir) dos cadenas distintas
string cadena2 = " y otra cadena";
Console.WriteLine("\n3.- Concatenada: " + cadena + cadena2);
// ● Extraer una subcadena
Console.WriteLine("\n4.- Subcadena: " + cadena.Substring(1,3));
// ● Utilizando la calculadora creada anteriormente realizar las operaciones de dos
// números y mostrar por pantalla en texto el resultado.
// int op;
// double a, b;
//     do {
//         Console.WriteLine("\n5.- Ingrese el código de la operación: ");
//         op = Convert.ToInt16(Console.ReadLine());
//     } while (op==0 || op>4);
//     Console.WriteLine("Ingrese el primer número: ");
//     a = Convert.ToDouble(Console.ReadLine());
//     Console.WriteLine("Ingrese el segundo número: ");
//     b = Convert.ToDouble(Console.ReadLine());
//     Console.WriteLine("El resultado de " + calculadora(op,a,b));
// ● Recorrer la cadena de texto con un ciclo Foreach e ir mostrando elemento por
// elemento en pantalla
Console.WriteLine("\n6.- Bucle foreach: ");
foreach (var i in cadena) {
    Console.Write(i + " ");
}
// ● Buscar la ocurrencia de una palabra determinada en la cadena ingresada
// ● Convierta la cadena a Mayúsculas y luego minúsculas
// ● Ingrese una nueva cadena y luego compare los valores de ambas.
// ● Ingrese una cadena separada por caracteres que usted determine y muestre por
// pantalla los resultados (Revisar el comportamiento de split())
// ● Siguiendo con el ejemplo de la calculadora (ejercicio 2) ingrese una ecuación
// simple como cadena de caracteres y que el sistema lo resuelva. Por ej. ingrese
// por pantalla “582+2” y que le devuelva la suma de 582 con 2








string calculadora(int op, double a, double b)
{
    switch (op) {
        case 1: return a + " + " + b + " es " + (a+b);
        case 2: return a + " - " + b + " es " + (a-b);
        case 3: return a + " * " + b + " es " + (a*b);
        case 4: 
            if(b!=0) {
                return a + " / " + b + " es " + (a/b);
            } else {
                return a + " / " + b + " es infinito.";
            }
        default: 
            return "la operación es no valído.";
    }
}
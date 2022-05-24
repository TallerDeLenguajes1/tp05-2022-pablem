// See https://aka.ms/new-console-template for more information

//0.- Hola mundo
Console.WriteLine("Hello World!");

//1.- Construir un programa que permita invertir Número de N cifras. 
Console.WriteLine("Ingrese un número: ");
string texto = Console.ReadLine();
char[] arreglo = texto.ToCharArray(); //otro método?
Array.Reverse(arreglo);
texto = new string (arreglo);
int numero =  Convert.ToInt32(texto); //Int32.Parse(texto)
Console.WriteLine(numero);

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
int op;
double a, b;
    do {
        Console.WriteLine("\n5.- Calculadora. Ingrese el código de la operación: ");
        op = Convert.ToInt16(Console.ReadLine());
    } while (op==0 || op>4);
    Console.WriteLine("Ingrese el primer número: ");
    a = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Ingrese el segundo número: ");
    b = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("El resultado de " + calculadora(op,a,b));
// ● Recorrer la cadena de texto con un ciclo Foreach e ir mostrando elemento por
// elemento en pantalla
Console.WriteLine("\n6.- Bucle foreach: ");
foreach (var i in cadena) {
    Console.Write(i + " ");
}
// ● Buscar la ocurrencia de una palabra determinada en la cadena ingresada
Console.WriteLine("\n\n7.- Contiene la cadena 'ola'?: " + cadena.Contains("ola")); //sobrecargar con reglas de comparación
// ● Convierta la cadena a Mayúsculas y luego minúsculas
Console.WriteLine("\n8.- Convierte a mayúscula: " + cadena.ToUpper()); //Cultureinfo
Console.WriteLine("\n8.- Convierte a minúscula: " + cadena.ToLower());
// ● Ingrese una nueva cadena y luego compare los valores de ambas.
Console.WriteLine("\n9.- Comparar cadenas.");
Console.WriteLine("Cadena 1: ");
cadena = Console.ReadLine();
Console.WriteLine("Cadena 2: ");
cadena2 = Console.ReadLine();
Console.WriteLine("\n9.- Relación: " + String.Compare(cadena,cadena2,true)); //,Cultureinfo
// ● Ingrese una cadena separada por caracteres que usted determine y muestre por
// pantalla los resultados (Revisar el comportamiento de split())
Console.WriteLine("\n10.- Separar cadena: ");
cadena = Console.ReadLine();
string[] vector = cadena.Split(' ');//({' ',',','.',';','\t'})
foreach (var i in vector) {
    Console.WriteLine(i);
}
// ● Ingrese una ecuación simple como cadena de caracteres y que el sistema lo resuelva.
Console.WriteLine("\n11.- Calculadora. Ingrese la operación: ");
cadena = Console.ReadLine();
Console.WriteLine("El resultado de " + calcV2(cadena));







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

string calcV2(string operacion)
{
    char[] delimitadores = { '+', '-', '*','.', '/', ':' };
    char op = operacion[operacion.IndexOfAny(delimitadores)];
    string[] operandos = operacion.Split(delimitadores);
    double a = Convert.ToDouble(operandos[0]);
    double b = Convert.ToDouble(operandos[1]);
    switch (op) {
        case '+': return a + " + " + b + " es " + (a+b);
        case '-': return a + " - " + b + " es " + (a-b);
        case '*':
        case '.': return a + " * " + b + " es " + (a*b);
        case '/':
        case ':': 
            if(b!=0) {
                return a + " / " + b + " es " + (a/b);
            } else {
                return a + " / " + b + " es infinito.";
            }
        default: 
            return "la operación es no valído.";
    }
}
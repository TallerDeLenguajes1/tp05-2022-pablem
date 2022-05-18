// See https://aka.ms/new-console-template for more information

//0.- Hola mundo
// Console.WriteLine("Hello World!");

//1.- Construir un programa que permita invertir Número de N cifras. 
//    Si el número es menor o igual a cero evitar esta conversión
// Console.WriteLine("Ingrese un número: ");
// string texto = Console.ReadLine();
// char[] arreglo = texto.ToCharArray(); //otro método?
// Array.Reverse(arreglo);
// texto = new string (arreglo);
// int numero =  Convert.ToInt32(texto); //Int32.Parse(texto)
// Console.WriteLine(numero);

//2.- Ingrese al branch CalculadoraV1 y construya un programa que sea una
//calculadora que permita al usuario realizar las 4 operaciones básicas (Sumar, Restar,
//Multiplicar y Dividir) a partir de un menú para seleccionar la opción a elegir y luego que
//le pida dos números y que devuelva el resultado de la operación seleccionada.
//Además una vez que termine de realizar la operación que le pregunte si desea realizar
//otro cálculo.

//System.Math.Pow(a,2);
int op;
double n1,n2=0,resultado;
bool ban = true;

while(ban) {
    Console.WriteLine("Ingrese el código de la operación: ");
    op = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Ingrese el número: ");
    n1 = Convert.ToDouble(Console.ReadLine());
    if(op <= 4) {
        Console.WriteLine("Ingrese el segundo número: ");
        n2 = Convert.ToDouble(Console.ReadLine());
    }
    resultado = calculadora(n1,n2,op);
    Console.WriteLine("El resultado es: " + resultado);
    Console.WriteLine("\n¿Desea realizar otra operación?(0/1)");
    ban = Convert.ToBoolean(Convert.ToInt16(Console.ReadLine()));
}

Console.WriteLine("\nExtra: Ingrese dos números: ");
n1 = Convert.ToDouble(Console.ReadLine());
n2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("El máximo es: " + Math.Max(n1,n2));
Console.WriteLine("El mínimo es: " + Math.Min(n1,n2));

double calculadora(double a, double b, int op)
{
    switch (op) {
        case 1: return a+b;
        case 2: return a-b;
        case 3: return a*b;
        case 4: 
            if(b!=0) {
                return a/b;
            } else {
                Console.WriteLine("(división por cero)");
                return double.NaN;
            }
        case 5: return Math.Abs(a);
        case 6: return Math.Pow(a,2);
        case 7: return Math.Sqrt(a);
        case 8: return Math.Sin(a);
        case 9: return Math.Cos(a);
        case 10: return Math.Ceiling(a);
        default: 
            Console.WriteLine("Código no válido."); 
            return double.NaN;
    }
}

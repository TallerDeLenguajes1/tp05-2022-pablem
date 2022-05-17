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

//2.- Ingrese al branch CalculadoraV1 y construya un programa que sea una
//calculadora que permita al usuario realizar las 4 operaciones básicas (Sumar, Restar,
//Multiplicar y Dividir) a partir de un menú para seleccionar la opción a elegir y luego que
//le pida dos números y que devuelva el resultado de la operación seleccionada.
//Además una vez que termine de realizar la operación que le pregunte si desea realizar
//otro cálculo.

//System.Math.Pow(a,2);
double resultado;
bool ban = true;

while(ban) {
    Console.WriteLine("Ingrese un número: ");
    string n1 = Console.ReadLine();
    Console.WriteLine("Ingrese otro número: ");
    string n2 = Console.ReadLine();
    Console.WriteLine("Ingrese el número de la operación: ");
    string op = Console.ReadLine();

    

}
double calculadora(string cadenaA, string cadenaB, string cadenaOp)
{
    double a = Convert.ToDouble(cadenaA);
    double b = Convert.ToDouble(cadenaB);
    int op = Convert.ToInt16(cadenaOp);
    
    switch (op) {
        case 2: return a-b;
        case 3: return a*b;
        case 4: if(b!=0) {
                    return a/b;
                } else {
                    Console.WriteLine("(división por cero)");
                    return 9999;
                }
        default: return a+b;
    }
}

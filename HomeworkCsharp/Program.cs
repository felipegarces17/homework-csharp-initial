// Autor: Pastor Felipe Garces Zapata (CC 1128441184)- felipegarces17
// Curso: Optativa 1 - Uniendo backend y frontend
// ITM - 2026
// Descripción: 15 ejercicios iniciales de programación en C#


// ============================================
// EJERCICIO 1 - Positive Power
// ============================================
Console.WriteLine("=== Ejercicio 1: Positive Power ===");
Console.Write("Ingresa un número: ");
int numero1 = int.Parse(Console.ReadLine()!);

if (numero1 > 0)
{
    Console.WriteLine("Resultado: " + (numero1 * numero1));
}
else if (numero1 < 0)
{
    Console.WriteLine("Resultado: Número negativo.");
}
else
{
    Console.WriteLine("Resultado: 0");
}


// ============================================
// EJERCICIO 2 - Double or Triple
// ============================================
Console.WriteLine("\n=== Ejercicio 2: Double or Triple ===");
Console.Write("Ingresa el primer número: ");
int numero2a = int.Parse(Console.ReadLine()!);
Console.Write("Ingresa el segundo número: ");
int numero2b = int.Parse(Console.ReadLine()!);

if (numero2a > numero2b)
{
    Console.WriteLine("Resultado: " + (numero2a * 2));
}
else
{
    Console.WriteLine("Resultado: " + (numero2b * 3));
}



// ============================================
// EJERCICIO 3 - Root or Square
// ============================================
Console.WriteLine("\n=== Ejercicio 3: Root or Square ===");
Console.Write("Ingresa un número: ");
int numero3 = int.Parse(Console.ReadLine()!);

if (numero3 > 0)
{
    Console.WriteLine("Resultado: " + Math.Sqrt(numero3));
}
else if (numero3 < 0)
{
    Console.WriteLine("Resultado: " + (numero3 * numero3));
}
else
{
    Console.WriteLine("Resultado: 0");
}



// ============================================
// EJERCICIO 4 - Circle Perimeter
// ============================================
Console.WriteLine("\n=== Ejercicio 4: Circle Perimeter ===");
Console.Write("Ingresa el radio del círculo: ");
double radio = double.Parse(Console.ReadLine()!);

double perimetro = 2 * Math.PI * radio;
Console.WriteLine("Resultado: " + Math.Round(perimetro, 2));



// ============================================
// EJERCICIO 5 - Midweek Day
// ============================================
Console.WriteLine("\n=== Ejercicio 5: Midweek Day ===");
Console.Write("Ingresa un número del 1 al 7: ");
int dia = int.Parse(Console.ReadLine()!);

switch (dia)
{
    case 1:
        Console.WriteLine("Resultado: Lunes");
        break;
    case 2:
        Console.WriteLine("Resultado: Martes");
        break;
    case 3:
        Console.WriteLine("Resultado: Miércoles");
        break;
    case 4:
        Console.WriteLine("Resultado: Jueves");
        break;
    case 5:
        Console.WriteLine("Resultado: Viernes");
        break;
    default:
        Console.WriteLine("Resultado: Número fuera del rango laboral.");
        break;
}



// ============================================
// EJERCICIO 6 - Tax Calculator
// ============================================
Console.WriteLine("\n=== Ejercicio 6: Tax Calculator ===");
Console.Write("Ingresa tu salario anual: ");
double salario = double.Parse(Console.ReadLine()!);

if (salario > 12000)
{
    double excedente = salario - 12000;
    double impuesto = excedente * 0.15;
    Console.WriteLine("Resultado: " + impuesto);
}
else
{
    Console.WriteLine("Resultado: No debe impuestos.");
}



// ============================================
// EJERCICIO 7 - Remainder Finder
// ============================================
Console.WriteLine("\n=== Ejercicio 7: Remainder Finder ===");
Console.Write("Ingresa el primer número: ");
int numero7a = int.Parse(Console.ReadLine()!);
Console.Write("Ingresa el segundo número: ");
int numero7b = int.Parse(Console.ReadLine()!);

Console.WriteLine("Resultado: " + (numero7a % numero7b));



// ============================================
// EJERCICIO 8 - Sum of Evens
// ============================================
Console.WriteLine("\n=== Ejercicio 8: Sum of Evens ===");
int suma = 0;

for (int i = 1; i <= 50; i++)
{
    if (i % 2 == 0)
    {
        suma = suma + i;
    }
}

Console.WriteLine("Resultado: " + suma);



// ============================================
// EJERCICIO 9 - Fraction Difference
// ============================================
Console.WriteLine("\n=== Ejercicio 9: Fraction Difference ===");
Console.Write("Numerador de la primera fracción: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.Write("Denominador de la primera fracción: ");
int den1 = int.Parse(Console.ReadLine()!);
Console.Write("Numerador de la segunda fracción: ");
int num2 = int.Parse(Console.ReadLine()!);
Console.Write("Denominador de la segunda fracción: ");
int den2 = int.Parse(Console.ReadLine()!);

int numResultado = (num1 * den2) - (num2 * den1);
int denResultado = den1 * den2;
int mcd = Math.Abs(numResultado);

for (int i = 1; i <= Math.Abs(numResultado) && i <= denResultado; i++)
{
    if (numResultado % i == 0 && denResultado % i == 0)
    {
        mcd = i;
    }
}

if (numResultado == 0)
{
    Console.WriteLine("Resultado: 0");
}
else
{
    Console.WriteLine("Resultado: " + (numResultado / mcd) + "/" + (denResultado / mcd));
}



// ============================================
// EJERCICIO 10 - String Length
// ============================================
Console.WriteLine("\n=== Ejercicio 10: String Length ===");
Console.Write("Ingresa una palabra: ");
string palabra = Console.ReadLine()!;

Console.WriteLine("Resultado: " + palabra.Length);



// ============================================
// EJERCICIO 11 - Average of Four
// ============================================
Console.WriteLine("\n=== Ejercicio 11: Average of Four ===");
Console.Write("Ingresa el primer número: ");
double num11a = double.Parse(Console.ReadLine()!);
Console.Write("Ingresa el segundo número: ");
double num11b = double.Parse(Console.ReadLine()!);
Console.Write("Ingresa el tercer número: ");
double num11c = double.Parse(Console.ReadLine()!);
Console.Write("Ingresa el cuarto número: ");
double num11d = double.Parse(Console.ReadLine()!);

double promedio = (num11a + num11b + num11c + num11d) / 4;
Console.WriteLine("Resultado: " + promedio);



// ============================================
// EJERCICIO 12 - Smallest of Five
// ============================================
Console.WriteLine("\n=== Ejercicio 12: Smallest of Five ===");
Console.Write("Ingresa el primer número: ");
double num12a = double.Parse(Console.ReadLine()!);
Console.Write("Ingresa el segundo número: ");
double num12b = double.Parse(Console.ReadLine()!);
Console.Write("Ingresa el tercer número: ");
double num12c = double.Parse(Console.ReadLine()!);
Console.Write("Ingresa el cuarto número: ");
double num12d = double.Parse(Console.ReadLine()!);
Console.Write("Ingresa el quinto número: ");
double num12e = double.Parse(Console.ReadLine()!);

double menor = num12a;
if (num12b < menor) menor = num12b;
if (num12c < menor) menor = num12c;
if (num12d < menor) menor = num12d;
if (num12e < menor) menor = num12e;

Console.WriteLine("Resultado: " + menor);



// ============================================
// EJERCICIO 13 - Vowel Counter
// ============================================
Console.WriteLine("\n=== Ejercicio 13: Vowel Counter ===");
Console.Write("Ingresa una palabra: ");
string palabra13 = Console.ReadLine()!.ToLower();

int contadorVocales = 0;
foreach (char letra in palabra13)
{
    if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
    {
        contadorVocales++;
    }
}

Console.WriteLine("Resultado: " + contadorVocales);



// ============================================
// EJERCICIO 14 - Factorial Finder
// ============================================
Console.WriteLine("\n=== Ejercicio 14: Factorial Finder ===");
Console.Write("Ingresa un número: ");
int numero14 = int.Parse(Console.ReadLine()!);

long factorial = 1;
for (int i = 1; i <= numero14; i++)
{
    factorial = factorial * i;
}

Console.WriteLine("Resultado: " + factorial);



// ============================================
// EJERCICIO 15 - InRange Validator
// ============================================
Console.WriteLine("\n=== Ejercicio 15: InRange Validator ===");
Console.Write("Ingresa un número: ");
int numero15 = int.Parse(Console.ReadLine()!);

if (numero15 >= 10 && numero15 <= 20)
{
    Console.WriteLine("Resultado: Está en el rango.");
}
else
{
    Console.WriteLine("Resultado: Fuera del rango.");
}
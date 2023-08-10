//// See https://aka.ms/new-console-template for more information
//int a= 42;
//int b= 119;
//int c = a + b;

//Console.WriteLine(c);
//Console.WriteLine();

// Declaración de variables y luego inicializarlas a cero.
float num1 = 0; float num2 = 0;

// Mostrar título como la aplicación de calculadora de consola C#.
Console.WriteLine("Calculadora en modo consola en C#\r");
Console.WriteLine("---------------------------------------\n");

// Pedir al usuario que escriba el primer número.
Console.WriteLine("Escriba un número y luego presione Entrar");
num1 = Convert.ToInt32(Console.ReadLine());

// Pedir al usuario que escriba el segundo número.
Console.WriteLine("Escriba el otro número y luego presione Entrar");
num2 = Convert.ToInt32(Console.ReadLine());

// Pedir al usuario que elija una opción..
Console.WriteLine("Elija una opción de la siguiente lista:");
Console.WriteLine("\ts - Suma");
Console.WriteLine("\tr - Resta");
Console.WriteLine("\tm - Multiplicacion");
Console.WriteLine("\td - Division");
Console.WriteLine("\t¿Qué opción desea realizar?");

// Use una declaración de switch para hacer los cálculos.
switch (Console.ReadLine())
{
    case "s":
        Console.WriteLine($"El resultado de tu operación es: {num1} + {num2} = " + (num1 +
        num2));
        break;
    case "r":
        Console.WriteLine($"El resultado de tu operación es: {num1} - {num2} = " + (num1 -
        num2));
        break;
    case "m":
        Console.WriteLine($"El resultado de tu operación es: {num1} * {num2} = " + (num1 *
        num2));
        break;
    case "d":
        while (num2 == 0)
        {
            Console.WriteLine("Introduzca un divisor distinto de cero: ");
            num2 = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine($"El resultado de tu operación es: {num1} / {num2} = " + (num1 /
        num2));
        break;

}
// Espere a que el usuario responda antes de cerrar.
Console.Write("Presione cualquier tecla para cerrar la aplicación de la consola Calculadora...");
Console.ReadKey();

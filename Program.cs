using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese un número entero positivo:");

        // Leer el número ingresado por el usuario
        int numero;
        while (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0)
        {
            Console.WriteLine("Por favor, ingrese un número entero positivo:");
        }

        // Variable para almacenar la suma
        int suma = 0;

        // Bucle for para calcular la suma de los números desde 1 hasta el número ingresado
        for (int i = 1; i <= numero; i++)
        {
            suma += i; // Sumar el número actual a la suma total
        }

        // Mostrar el resultado
        Console.WriteLine($"La suma de todos los números enteros positivos desde 1 hasta {numero} es: {suma}");

        // Esperar a que el usuario presione una tecla
        Console.WriteLine("Presiona cualquier tecla para continuar...");
        Console.ReadKey();
    }
}
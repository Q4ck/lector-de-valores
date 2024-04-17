using System;

static class Program
{
    static void Main(string[] args)
    {
        string? myString = null; // Inicializamos a null para evitar advertencias adicionales

        while (string.IsNullOrWhiteSpace(myString))
        {
            Console.WriteLine("Por favor ingrese un valor:");
            myString = Console.ReadLine();
        }

        // Aquí, myString contiene un valor válido
        Console.WriteLine("El valor ingresado es: " + myString);

    Console.WriteLine("Presione Enter para salir...");
        Console.Read();
    }
}


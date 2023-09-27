using System;

class ejercicio3
{
    static void Main()
    {
        int n = 20;  // Número de dígitos
        int suma = (1 + 1) + (2 + 2) + (3 * 3) + (18 * 18);

        for (int operacion = 1; operacion <= n; operacion++)
        {
            int cuadrado = operacion * operacion; suma += cuadrado;
        }

        Console.WriteLine($"La suma acumulada de los cuadrados de los primeros {n} números es: {suma}");
    }
}

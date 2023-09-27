using System;

class ejercicio1
{
    static void Main()
    {
        double pi = Math.PI;

        // Truncar el valor de PI
        double pi_Truncado = Math.Truncate(pi);
        Console.WriteLine($"Valor de PI truncado: " + pi_Truncado);

        // Redondear hacia arriba
        double pi_Redondeado_Arriba = Math.Ceiling(pi);
        Console.WriteLine($"Valor de PI redondeado hacia arriba: " + pi_Redondeado_Arriba);

        // Redondear hacia abajo
        double pi_Redondeado_Abajo = Math.Floor(pi);
        Console.WriteLine($"Valor de PI redondeado hacia abajo: " + pi_Redondeado_Abajo);
    }
}





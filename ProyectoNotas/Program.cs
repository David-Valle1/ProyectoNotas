// See https://aka.ms/new-console-template for more information
using System;

class Notas
{
    static void Main(string[] agrs)
    {
        Console.WriteLine("Siatema de Calculo de notas");
        Console.WriteLine("Favor ingresa tu nombre");
        string Nombre = Console.ReadLine();
        Console.WriteLine("Ingresa la primer Nota Parcial");
        int Nota1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingresa la segunda Nota Parcial");
        int Nota2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingresa la tercer Nota Parcial");
        int Nota3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingresa la cuarta Nota Parcial");
        int Nota4 = Convert.ToInt32(Console.ReadLine());
        int Promedio = (Nota1 + Nota2 + Nota3 + Nota4) / 4;
        Console.WriteLine($"El promedio de las notas es: {Promedio:F2}");
        if (Promedio < 70)
        {
            Console.WriteLine("Usted esta reprovado");
            Console.ReadKey();
        }
        else if (Promedio >= 70 & Promedio < 80)
        {
            Console.WriteLine("Usted se encuentra en la categotia Bueno");
            Console.ReadKey();
        }
        else if (Promedio >= 80 & Promedio < 90)
        {
            Console.WriteLine("Usted se encuentra en la categoria Muy Bueno");
            Console.ReadKey();
        }
        else if (Promedio > 90)
        {
            Console.WriteLine("Usted es Sobresaliente");
            Console.ReadKey();
        }

    }
}
using System;

namespace A133590.Ejercicio35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 35");
            Console.WriteLine("Programa que recibe ingresos hasta que el mismo sea un número válido.");
            double ingreso;
            Console.Write("Por favor, ingrese un número: ");
            while( !Double.TryParse(Console.ReadLine(), out ingreso) )
            {
                Console.Write("Ingreso inválido, intente nuevamente: ");
            }

            Console.WriteLine("Presione cualquier tecla para continuar..");
            Console.ReadKey();
        }
    }
}

using System;

namespace Guia_Practica_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, edades;
            int menores = 0, mayores = 0;
            Console.WriteLine("Ingrese la cantidad de personas: ");
            num = int.Parse(Console.ReadLine());
            int[] Cantidad = new int[num];
            for (int i = 0; i < Cantidad.Length; i++)
            {
                Console.WriteLine("Ingrese la edad de la persona #{0}: ", i + 1);
                edades = int.Parse(Console.ReadLine());
                if (edades >= 18)
                {
                    mayores++;
                }
                else
                {
                    menores++;
                }
            }
            Console.Clear();
            Console.WriteLine("Cantidad de mayores: {0}", mayores);
            Console.WriteLine("Cantidad de menores: {0}", menores);
            Console.ReadKey();
        }
    }
}

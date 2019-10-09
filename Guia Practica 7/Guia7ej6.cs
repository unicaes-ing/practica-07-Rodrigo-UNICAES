using System;
using System.Collections.Generic;
using System.Text;

namespace Guia_Practica_7
{
    class Guia7ej6
    {
        public static Random n;

        public static int[,] nums;

        public static void CapturaDatos()
        {
            n = new Random();
            nums = new int[10, 10];
            for (int a = 0; a < nums.GetLength(0); a++)
            {
                for (int b = 0; b < nums.GetLength(1); b++)
                {
                    nums[a, b] = n.Next(10, 99);
                }
            }
            Console.WriteLine("La matriz se genero exitosamente :)");
            Console.WriteLine("Presione una tecla para regresar al menu.");
            Console.ReadLine();
        }

        public static void VerDatos()
        {
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<");
            for (int a = 0; a < nums.GetLength(0); a++)
            {
                Console.WriteLine("/");
                for (int b = 0; b < nums.GetLength(1); b++)
                {
                    if (nums[a, b] == 0)
                    {
                        Console.WriteLine("00");
                    }
                    else
                    {
                        if ((nums[a, b] != 0) && (nums[a, b] % 2 == 0))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        Console.WriteLine(nums[a, b]);
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("/");
                }
                if (a < 9)
                {
                    Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>");
                }
                Console.WriteLine("<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>");
                Console.WriteLine("Presione una tecla para regresar al menu: ");
                Console.ReadLine();
            }
        }

        static void Main(string[] args)
        {
            int opc = 0;
            nums = new int[6, 6];
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Hacer matriz");
                Console.WriteLine("[2] Ver matriz");
                Console.WriteLine("[3] Salir");
                opc = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        CapturaDatos();
                        break;
                    case 2:
                        VerDatos();
                        break;
                }
            } while (opc != 3);
        }
    }
}

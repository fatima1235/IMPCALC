using System;
using System.Collections.Generic;
using System.Text;
namespace Calculadora
{
    class Program
    {
        static Operaciones opera = new Operaciones();
        static menu m = new menu();
        static void Main(string[] args)
        {
            int opciones = 0;
            while (opciones != 5)
            {
                opciones = m.ListaMenu();
                if (opciones == 1)
                {
                    Console.WriteLine(opera.Resultado('i'));
                }
                else if (opciones == 2)
                {
                    Console.WriteLine(opera.Resultado('s'));
                }
                else if (opciones == 3)
                {
                    Console.WriteLine(opera.Resultado('b'));
                }
                else if (opciones == 4)
                {
                    Console.WriteLine(opera.Resultado('a'));
                }
                else if (opciones == 5)
                {
                    Console.Clear();
                }
            }
            Console.ReadKey();
        }
    }
} 

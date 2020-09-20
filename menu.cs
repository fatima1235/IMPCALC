using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    class menu
    {

        private int op = 0;
        public int ListaMenu()
        {
            Console.WriteLine("Bienvenido a ImpCalc. Seleccione la opción que desee.");
            Console.WriteLine("1.- Calcular IVA");
            Console.WriteLine("2.- Calcular ISR");
            Console.WriteLine("3.- Calcular Bono 14");
            Console.WriteLine("4.- Calcular Aguinaldo");
            Console.WriteLine("5.- Salir");
            Console.Write("Ingrese el numero de la opcion que desee: ");
            op = int.Parse(Console.ReadLine());
            return op;
        }
    }
}

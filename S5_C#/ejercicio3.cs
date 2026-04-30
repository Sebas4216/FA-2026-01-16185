using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5_C_
{
    internal class ejercicio3
    {
        static void Main(string[] args)
        {
            double Resultado;
            Console.WriteLine("------------------- SISTEMA DE CONVERSION DE MONEDA ------------\n");

            Console.WriteLine("Ingrese el monto en soles: ");
            double soles = double.Parse(Console.ReadLine());

            Console.WriteLine("***** MENU DE OPCIONES ******\n");
            Console.WriteLine("[1]. Dolares ");
            Console.WriteLine("[2]. Euros ");
            Console.WriteLine("*****************************\n");

            Console.WriteLine("Ingrese una opcion");
            int opc = int.Parse(Console.ReadLine());

            switch(opc)
            {
                case 1:
                    
                    Resultado = soles / 3.75;
                    Console.WriteLine("\nDolares: "+Math.Round(Resultado,2));
                    break;
                case 2:
                    Resultado = soles / 4.20;
                    Console.WriteLine("\nDolares: " + Math.Round(Resultado,2));
                    break;
                default: Console.WriteLine("\n Opcion incorrecta "); break;
            }
            Console.ReadKey();
        }
    }
}

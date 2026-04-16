using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE3_C
{
    internal class ejer3
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese numero 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese numero 2: ");
            int num2 = int.Parse(Console.ReadLine()); 

            Console.WriteLine("\nSuma: "+(num1+num2));
            Console.WriteLine("Resta: "+(num1-num2));
            Console.WriteLine("Multiplicacion: " + (num1 * num2));
            Console.WriteLine("Division: " + (num1 / num2));

            Console.ReadKey();  

        }
    }
}

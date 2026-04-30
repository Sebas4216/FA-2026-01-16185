using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5_C_
{
    internal class ejercicio1
    {
        static void Main(string[] args)
        {
            Console.Write("Edad: ");
            int ed = int.Parse(Console.ReadLine());

            if (ed < 18) Console.WriteLine("Menor de edad");
            else if (ed < 19) Console.WriteLine("");

        }
    }
}

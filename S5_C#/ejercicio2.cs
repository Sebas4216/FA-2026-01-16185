using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace S5_C_
{
    internal class ejercicio2
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Año: ");
            int an= int.Parse(Console.ReadLine());

            if ((an % 4 == 0 && an % 100 !=0 ) || an % 400 == 0 )
            {
                Console.WriteLine("el año es bisiesto");
            }
            else
            {
                Console.WriteLine("El año no es bisiesto");
            }
            if (an % 2 == 0)
            {
                Console.WriteLine("par");
            }
            else
            {
                Console.WriteLine("impar");
            }
        }
    }
}

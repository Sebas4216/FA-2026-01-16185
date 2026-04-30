using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace S5_C_
{
    internal class ejercicio4
    {
        static void Main (string[] args)
        {
            double Resultado=0, Base, Altura, radio;
            Console.WriteLine("------------------- SISTEMA DE CALCULO DE AREA ------------\n");

            Console.WriteLine("***** MENU DE OPCIONES ******\n");
            Console.WriteLine("[1]. CUADRADO ");
            Console.WriteLine("[2]. RECTANGULO ");
            Console.WriteLine("[3]. TRIANGULO ");
            Console.WriteLine("[4]. CIRCULO ");
            Console.WriteLine("*****************************\n");

            Console.Write("ingrese una opcion: ");
            int opc = int.Parse(Console.ReadLine());

            Console.Clear();
           
            switch (opc)
            {
                case 1:
                    double lado;
                    Console.WriteLine("Ingrese el lado del cuadrado: ");
                    lado = double.Parse(Console.ReadLine());
                    Resultado = (lado * lado);
                    break;
                case 2:
                    Console.WriteLine("Ingrese la altura: ");
                    Altura = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la base: ");
                    Base = double.Parse(Console.ReadLine());

                    Resultado = Base * Altura;
                    break;
                case 3:
                    Console.WriteLine("Ingrese la altura: ");
                    Altura = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la base: ");
                    Base = double.Parse(Console.ReadLine());

                    Resultado = (Altura * Base)/2;
                    break;
                case 4:
                    Console.WriteLine("Ingrese el radio: ");
                    radio = double.Parse(Console.ReadLine());
                    Resultado = Math.PI * Math.Pow(radio,2);
                    break;
                default: Console.WriteLine("ERROR DE TECLA"); break;

            }
            Console.WriteLine("El Area es: " + Resultado);
        }
    }
}

using System;

namespace SE3_C
{
    internal class ejer1
    {
        static void Main(string[] args)
        {
            string nombre, carrera;

            Console.Write("Ingresa tu nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Ingresa tu carrera: ");
            carrera = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
            Console.WriteLine("{0}, Bienvenido al curso de Fundamentos de Algoritmos de la carrera {1}", nombre, carrera);
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
            Console.ReadKey();
        }
    }
}

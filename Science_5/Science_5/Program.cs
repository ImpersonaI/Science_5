using System;

namespace Science_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Численные методы в научных расчетах. Лабораторная работа номер 5");
            Iteraxmethod iteraxmethod = new Iteraxmethod();
            iteraxmethod.dointexmethod();
            Zeidel zeidel = new Zeidel();
            zeidel.DoZeidel();

            Console.ReadKey();
        }
    }
}

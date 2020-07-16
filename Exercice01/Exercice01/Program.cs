using System;
using System.Globalization;

namespace Exercice01 {
    class Program {
        static void Main(string[] args) {
            /* EXERCICE 1
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = num1 + num2;
            Console.WriteLine($"SOMA = {num3}");

            EXERCICE 2
            double pi = 3.14159;
            double r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = pi * Math.Pow(r,2);
            Console.WriteLine($"AREA={area.ToString("F4", CultureInfo.InvariantCulture)}");
            
             EXERCICE 3
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            int dif = num1 * num2 - num3 * num4;
            Console.WriteLine($"DIFERENCA = {dif}");
             EXERCICE 4
            */
            int numE = int.Parse(Console.ReadLine());
            int numH = int.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            float salary = numH * hours;
            Console.WriteLine($"NUMBER = {numE}\nSALARY = U$ {salary.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}

using System;
using System.Globalization;
using System.Linq;

namespace Exercice02 {
    class Program {
        static void Main(string[] args) {
            /*EXERCICE 1
            int num = int.Parse(Console.ReadLine());
            if(num >= 0)
                Console.WriteLine("NAO NEGATIVO");
            else
                Console.WriteLine("NEGATIVO");
            
             EXERCICE 2
            int num = int.Parse(Console.ReadLine());
            if(num % 2 == 0)
                Console.WriteLine("PAR");
            else
                Console.WriteLine("IMPAR");
            
             EXERCICE 3
            string[] vet = Console.ReadLine().Split(' ');
            int num1 = int.Parse(vet[0]);
            int num2 = int.Parse(vet[1]);

            if(num1 % num2 == 0 || num2 % num1 == 0)
                Console.WriteLine("Sao Multiplos");
            else
                Console.WriteLine("Nao sao Multiplos");
             
            EXERCICE 4
            string[] vet = Console.ReadLine().Split(' ');
            int init = int.Parse(vet[0]);
            int end = int.Parse(vet[1]);
            int total;
            if (init < end)
                total = end - init;
            else
                total = 24 - init + end;
            Console.WriteLine($"O JOGO DUROU {total} HORA(S)");

            EXERCICE 5 
            string[] vet = Console.ReadLine().Split(' ');
            int cod = int.Parse(vet[0]);
            int qnt = int.Parse(vet[1]);
            double total;
            if (cod == 1)
                total = qnt * 4.00;
            else if (cod == 2)
                total = qnt * 4.50;
            else if (cod == 3)
                total = qnt * 5.00;
            else if (cod == 4)
                total = qnt * 2.00;
            else
                total = qnt * 1.50;
            Console.WriteLine($"Total: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");

            EXERCICE 6
            double num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if(num >= 0 && num <=25)
                Console.WriteLine("Intervalo [0,25]");
            else if (num > 25 && num <= 50)
                Console.WriteLine("Intervalo (25,50]");
            else if (num > 50 && num <= 75)
                Console.WriteLine("Intervalo (50,75]");
            else if (num > 75 && num <= 100)
                Console.WriteLine("Intervalo (75,100]");
            else
                Console.WriteLine("Fora do intervalo");
              EXERCICE 7
            string[] v = Console.ReadLine().Split(' ');
            float v1 = float.Parse(v[0], CultureInfo.InvariantCulture);
            float v2 = float.Parse(v[1], CultureInfo.InvariantCulture);

            if(v1 == 0.0 && v2 == 0.0)
                Console.WriteLine("Origem");
            else if(v1 >= 0.0 && v2 >= 0.0)
                Console.WriteLine("Q1");
            else if (v1 <= 0.0 && v2 >= 0.0)
                Console.WriteLine("Q2");
            else if (v1 <= 0.0 && v2 <= 0.0)
                Console.WriteLine("Q3");
            else if (v1 >= 0.0 && v2 <= 0.0)
                Console.WriteLine("Q4");

            EXERCICE 8
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double total = 0.00;
            double ant = 0.00;

            if(value >= 0.00 && value <= 2000.00) {
                Console.WriteLine("Isento");
            }
            else if (value > 2000.01 && value <= 3000.00) {
                total = (value - 2000.00) * 0.08;
                Console.WriteLine($"R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else if (value >= 3000.01 && value <= 4500.00) {
                total = (value - 3000.0) * 0.18 + 1000.0 * 0.08;
                Console.WriteLine($"R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else {
                total = (value - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
                Console.WriteLine($"R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            */
        }
    }
}

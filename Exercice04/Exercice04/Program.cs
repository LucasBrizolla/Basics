using System;
using System.Globalization;

namespace Exercice04 {
    class Program {
        static void Main(string[] args) {
            /*EXERCICE 01
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++) {
                if (i % 2 != 0)
                    Console.WriteLine(i);
            }
              EXERCICE 02
            int qnt = int.Parse(Console.ReadLine());
            int n_in = 0;
            int n_out = 0;

            for(int i = 0;i < qnt; i++) {
                int num = int.Parse(Console.ReadLine());
                if (num >= 10 && num <= 20)
                    n_in += 1;
                else
                    n_out += 1;
            }
            Console.WriteLine($"{n_in} in\n{n_out} out");
            EXERCICE 03
            int qnt = int.Parse(Console.ReadLine());
            for (int i = 0; i < qnt; i++) {
                string[] line = Console.ReadLine().Split(' ');
                double a = double.Parse(line[0], CultureInfo.InvariantCulture);
                double b = double.Parse(line[1], CultureInfo.InvariantCulture);
                double c = double.Parse(line[2], CultureInfo.InvariantCulture);

                double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
            EXERCICE 04
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {

                string[] line = Console.ReadLine().Split(' ');
                int x = int.Parse(line[0]);
                int y = int.Parse(line[1]);

                if (y == 0) {
                    Console.WriteLine("divisao impossivel");
                }
                else {
                    double div = (double)x / y;
                    Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture);
                }
            }
            EXERCICE 05
            int n = int.Parse(Console.ReadLine());

            int fat = 1;
            for (int i = 1; i <= n; i++) {
                fat = fat * i;
            }

            Console.WriteLine(fat);
            EXERCICE 06
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                if (n % i == 0) {
                    Console.WriteLine(i);
                }
            }
            EXERCICE 07
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {

                int primeiro = i;
                int segundo = i * i;
                int terceiro = i * i * i;
                Console.WriteLine($"{primeiro} {segundo} {terceiro}");
            }
            */
        }
    }
}

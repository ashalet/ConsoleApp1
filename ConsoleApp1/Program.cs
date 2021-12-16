using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int[,] mass = new int[n, m];

            for (int  i = 0;  i < n;  i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mass[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int summ = 0;
            for (int v = n-1; v >= 0; v--)
            {
                for (int b = 0; b < m; b++)
                {
                    summ += mass[v, b];
                }
            }
            Console.WriteLine($"Ответ равен: {summ}");
            Console.ReadLine();

        }
    }
}

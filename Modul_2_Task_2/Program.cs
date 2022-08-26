using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Задание 2
Дан двумерный массив размерностью 5×5, заполненный случайными числами из диапазона от –100 до 100. 
Определить сумму элементов массива, расположенных между минимальным и максимальным элементами.
.*/

namespace Modul_2_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 5;
            int[,] twoDArray = new int[size, size];
            Random random = new Random();

            for (int i = 0; i < twoDArray.GetLength(0); i++)
            {
                for (int j = 0; j < twoDArray.GetLength(1); j++)
                {
                    twoDArray[i, j] = random.Next(-100, 100);
                    if (twoDArray[i, j] > 0 )
                    {
                        Console.Write($" {twoDArray[i, j]} ");
                    }
                    else
                    {
                        Console.Write($"{twoDArray[i, j]} ");
                    }
                }
                Console.WriteLine();
            }

            var buf = twoDArray.Cast<int>().Select(c => c).ToArray();
            int minInd = Array.IndexOf(buf, buf.Min());
            Console.WriteLine($"MinInd = {minInd}");
            
            int maxInd = Array.IndexOf(buf, buf.Max());
            Console.WriteLine($"MaxInd = {maxInd}");
            Console.WriteLine();
            foreach (var item in buf)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            int sum = 0;
            if (minInd > maxInd)
            {
                int tmp = minInd;
                minInd = maxInd;
                maxInd = tmp;
            }
            for (int i = minInd; i < maxInd; i++)
            {
                sum += buf[i];
            }
            Console.WriteLine($"Сумма = {sum}");
        }
    }
}

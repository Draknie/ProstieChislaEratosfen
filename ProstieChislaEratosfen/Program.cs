using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, j;
            int count = 0;
            Console.Write("Число: ");
            n = int.Parse(Console.ReadLine());

            int[] a = new int[n];
            var timer1 = new Stopwatch();
            var timer2 = new Stopwatch();

            timer1.Start();
            for (i = 0; i < n; i++)
            {
                a[i] = 1;
            }
            for (i = 2; i < n; i++)
            {
                if (a[i] == 1)
                {
                    for (j = i; j < n; j += i)
                    {
                        a[j] = 0;
                    }
                    a[i] = 1;
                }
            }
            timer1.Stop();

            timer2.Start();
            for (i = 2; i < n; i++)
            {
                if (a[i] == 1)
                {
                    Console.WriteLine(i);
                    count++;
                }
            }
            timer2.Stop();

            Console.WriteLine("Затрачено на обработку: {0}мс\nЗатрачено на вывод: {1}мс", timer1.ElapsedMilliseconds, timer2.ElapsedMilliseconds);
            Console.WriteLine("Количество простых чисел: " + count);
            Console.ReadKey();
        }
    }
}
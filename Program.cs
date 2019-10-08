﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;



namespace Massive_sort_and_binary_search
{
    class Program
    {
        static void Main(string[] args)
        {
            int s, high = 10, low = 0;
            //Регулировка массива:
            Console.WriteLine("Введите количество ячеек массива:");
            Console.Write("_");
            high = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[high];
            
            
            //Заполнение массива и ввод искомого:
            Console.WriteLine("Введите искомое число:");
            Console.Write("_");
            s = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Заполните массив:");

            for (int i = 0; i < high; i++)
            {
                Console.Write("_");
                a[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            
            //Сортировка массива и его вывод:
            Array.Sort(a);

            Console.WriteLine("Отсортированный:");

            for (int i = 0; i < high; i++)
            {
                Console.WriteLine("[{0}] = {1}", i, a[i]);
                Thread.Sleep(100);
            }

            // Сам поиск:
            while (a[(high-low)/2]!=s)
            {
                if (a[(high - low) / 2] > s)
                {
                    high = (high - low) / 2;
                }
                else if (a[(high - low) / 2] < s)
                {
                    low = (high - low) / 2;
                }
                else
                {
                    break;
                }
            }

            high = (high - low) / 2;

            Console.WriteLine("Индекс искомого = "+high);



            Thread.Sleep(100);
            Console.ReadKey();
        }
    }
}
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
        {   //Задача 1.
            //Console.Write("Введите размерность массива: n=");
            //int n = int.Parse(Console.ReadLine());
            //int[] omas = new int[8];
            //for (int i = 0; i < 8; i++)
            //{
            //    Console.Write($"omas[{i}]=");
            //    omas[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < 8; i++)
            //{
            //    Console.WriteLine($"omas[{i}]={omas[i]}");
            //}

            //Задача 2.
            //double[] omas = new double[6] { -2.8, 4.08, 22, -1.1, 7.9, 5 };
            //for (int i = 0; i < omas.Length; i++)
            //{
            //    if (omas[i] > 0)
            //    {
            //        Console.WriteLine(omas[i]);
            //    }
            //}

            //Задача 3.
            //int[] omas = new int[6] { -7, 10, 5, 16, -4, 18 };
            //int n = omas.Length;
            //int c = n / 2;
            //int t;
            //for (int i = 0; i < c; i++)
            //{
            //    t = omas[i];
            //    omas[i] = omas[n - i - 1];
            //    omas[n - i - 1] = t;
            //}
            //foreach (int i in omas)
            //{
            //    Console.WriteLine($"{i}\t");
            //}

            //Задача 4
            Random random = new Random();
            int x = random.Next(163, 190);
            int[] omas = new int[x];
            for (int i = 0; i < x; i++)
            {
                omas[i] = random.Next(163, 190);
            }
            foreach (int elem in omas) 
             {
                Console.WriteLine("{0}", elem);
            }






            Console.ReadKey();

        }
    }
}

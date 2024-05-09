using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите n для вычисления n!:");
            int n =Convert.ToInt32(Console.ReadLine());
            SumAync(n);
            Console.ReadKey();
        }

        static void Sum(int n)
        {
            int factorial = 1;
            for (int i = 1; i < n; i++)
            {
                factorial *= i;
                Thread.Sleep(100);
            }
            Console.WriteLine($"n! = {factorial}") ;
        }

        static async void SumAync (int n)
        {
            await Task.Run(() => Sum(n));
        }
    }
}

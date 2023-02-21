using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadachaZaIzpitvane21._2._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("Enter numbers: ");
            double[] Array = Console.ReadLine().Split().Select(double.Parse).ToArray();         
            Console.WriteLine($"All elements are: {AllNums(Array)}");
            Console.WriteLine();
            Console.WriteLine($"The average is: {AverageNums(Array)}");
            Console.WriteLine();
            Console.WriteLine($"The count of the 0 is {CountZero(Array)}");
            AllElementWrite(Array);
            Console.WriteLine();
        }   
        static void AllElementWrite(double[] array)
        {
            for (int i = 0; i < array.Length;i ++)
            {
                Console.WriteLine($"The number {array[i]} is in the intex {i} ");
            }
            Console.WriteLine();
        }

       

        static object CountZero(double[] array)
        {
            byte CountZero = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    CountZero++;
                }

            }
            return CountZero;
        }

        static object AllNums(double[] array)
        {
            int i;
            for (i = 0; i <= array.Length; i++)
            {
            }
            return i-1;
        }

        private static object AverageNums(double[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum / array.Length;
        }
    }
}

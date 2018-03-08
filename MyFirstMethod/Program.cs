using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMethod
{
    class MyClass
    {
        /// <summary>
        /// Counts from 0 to 10
        /// </summary>
        static void CountTo10()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
        /// <summary>
        /// Counts from 0 to the number from the argument
        /// </summary>
        /// <param name="n"></param>
        static void CountToN(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i);
            }
        }
        /// <summary>
        /// Counts from the first argument to the second argument in ints
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        static void CountToN(int n1, int n2)
        {

            for (int i = n1; i < n2; i++)
            {
                Console.WriteLine(i);
            }
        }
        static int[] Reverse(int[] a)
        {
            int[] tmp = new int[a.Length];
            tmp = a;
            int tmpC = 0;
            for (int i = a.Length; i > 0; i--)
            {
                a[tmpC] = tmp[i - 1];
                tmpC++;
            }

            return a;
        }
        /// <summary>
        /// Prints all numbers in an array
        /// </summary>
        /// <param name="a"></param>
        static void PrintNumbers(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"Valor da posição {i + 1} do array:{a[i]}");
            }
        }
        /// <summary>
        /// The main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[] a = new int[4];
            a.Initialize();
            a[0] = 10;
            a[1] = 2;
            a[2] = 3;
            a[3] = 4;
            PrintNumbers(a);
            Reverse(a);
            PrintNumbers(a);


        }
    }
}

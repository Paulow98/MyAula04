using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMethod
{
    class Program
    {
        static void CountTo10()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void CountToN(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            Program.CountTo10();
            Program.CountTo10();
        }
    }
}

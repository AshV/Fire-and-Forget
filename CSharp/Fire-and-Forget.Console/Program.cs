using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace Fire_and_Forget.Console
{
    public class Program
    {
        static int a, b;
        public static void Add(int x, int y)
        {
            int z = x + y;
            Thread.Sleep(5000);
            WriteLine("Add Result {0}", z);
        }
        static void Main(string[] args)
        {
            WriteLine("Enter first value for addition");
            a = Convert.ToInt32(ReadLine());
            WriteLine("Enter first value for addition");
            b = Convert.ToInt32(ReadLine());
            Task.Run(() => Add(a, b));
            WriteLine("I'm next to Add");
            ReadKey();
        }
    }
}
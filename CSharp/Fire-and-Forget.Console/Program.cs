using System;
using System.Collections.Generic;
using System.IO;
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
        public static void BG()
        {
            Thread.Sleep(5000);
File.Create("File.txt");
        }
        static void Main(string[] args)
        {
            Task.Run(() =>BG());
            WriteLine("After Background Task");
            ReadKey();
        }
    }
}
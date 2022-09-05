using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMouse
{
    class Program
    {
        //Credits To For Main Project https://github.com/Sadmeme/rzctl
        //Credits For wrapper yully1337 on uc
        static void Main(string[] args)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Title = "Mouse Wrapper : Yully";

                Console.WriteLine();
                Console.WriteLine();

                Razor.LoadMouseDriver();

                Console.ReadLine();

                Console.Clear();

                MouseMoveEvent:

                Console.Clear();

                Console.WriteLine();

                string X;
                string Y;

                Console.Clear();

                Console.WriteLine();
                Console.WriteLine();

                Console.Write("    Input X: "); X = Console.ReadLine();

                Console.Clear();

                Console.WriteLine();
                Console.WriteLine();

                Console.Write("    Input Y: "); Y = Console.ReadLine();

                Razor.MouseMove(Convert.ToInt32(X), Convert.ToInt32(Y));

                goto MouseMoveEvent;
            }
            catch(Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine($"    Exception Thrown : {ex.Message}");
                Console.WriteLine();

            }
        }
    }
}

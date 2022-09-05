using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RazorMouse
{
    class Razor
    {
        enum DriverErrorCallback
        {
            Error = 1,
            Success = 2
        }
        enum MouseErrorCallback
        {
            Success = 1,
        }
        [DllImport("razor.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int InitMouse();

        [DllImport("razor.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int MoveMouse(int x, int y, bool from_start_point);
        public static void LoadMouseDriver()
        {
            Console.WriteLine($"    Callback -> {InitMouse()}");

            switch(InitMouse())
            {
                case (int)DriverErrorCallback.Success:
                    Console.WriteLine("    Sucessfully Loaded Driver!");
                    break;
                case (int)DriverErrorCallback.Error:
                    Console.WriteLine("    Failed To Load Mouse Driver!");
                    break;
            }
        }

        public static void MouseMove(int x, int y)
        {
            if (MoveMouse(x, y, false) == (int)MouseErrorCallback.Success)
            {
                Console.WriteLine("    Moved Mouse Sucessfully!");
            }
            else { Console.WriteLine("    Failed To Move Mouse"); }
        }
    }
}

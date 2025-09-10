using System;
using System.Runtime.InteropServices.Marshalling;

namespace Pich_Milioner
{
    internal class Program
    {
        static void Main()
        {
            MainMenu MN = new MainMenu();
            (int x, int y) = Console.GetCursorPosition();


            MN.StartScreen();
            switch (MN.option)
            {
                case 1:
                    Console.WriteLine("hold on");
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Magnezium Dev");
                    break;
                case 3:
                    Console.WriteLine("hold on");
                    break;
                case 4:
                    Console.WriteLine("hold on");
                    break;
            }
        }
    }


}
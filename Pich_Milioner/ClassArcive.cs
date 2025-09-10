using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
namespace Pich_Milioner
{
    public class MainMenu
    {
        public int option = 1;
        private void Title1()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(@"            


         ╔═══════════════════════════════════════╗
         ║ КТО ХОЧЕТ СТАТЬ МИЛИОНЕРОЙ??          ║
         ╚═══════════════════════════════════════╝");
            Console.WriteLine("\n");

        }

        private void Title2()
        {
            (int x, int y) = Console.GetCursorPosition();
            ConsoleKeyInfo key;
            option = 1;
            bool isSelected = false;
            string color = "-> \u001b[30m\u001b[48;5;88m";

            Console.ForegroundColor = ConsoleColor.Red;
            while (!isSelected)
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine($"         ╔══════════════════════════════════════╗");
                Console.WriteLine($"         ║                                      ║");
                Console.WriteLine($"         ║ {(option == 1 ? color :"   ")}1. Новая игра  \u001b[31m\u001b[40m                   ║");
                Console.WriteLine($"         ║                                      ║");
                Console.WriteLine($"         ║ {(option == 2 ? color :"   ")}2. Разработчик \u001b[31m\u001b[40m                   ║");
                Console.WriteLine($"         ║                                      ║");
                Console.WriteLine($"         ║ {(option == 3 ? color :"   ")}3. Донат       \u001b[31m\u001b[40m                   ║");
                Console.WriteLine($"         ║                                      ║");
                Console.WriteLine($"         ║                                      ║");
                Console.WriteLine($"         ╠══════════════════════════════════════╣");
                Console.WriteLine($"         ║                                      ║");
                Console.WriteLine($"         ║ {(option == 4 ? color : "   ")}3. Выйти       \u001b[31m\u001b[40m                   ║");
                Console.WriteLine($"         ║                                      ║");
                Console.WriteLine($"         ╚══════════════════════════════════════╝\n");

                key = Console.ReadKey(true);


                switch (key.Key)
                {
                    case ConsoleKey.DownArrow:
                        option = (option == 4 ? 1 : option + 1);
                        break;
                    case ConsoleKey.UpArrow:
                        option = (option == 1 ? 1 : option - 1);
                        break;
                    case ConsoleKey.Enter:
                        isSelected = true;
                        break;
                    default:
                        Console.WriteLine("           !!! ONLY ARROWS / ENTER !!!");
                        Console.SetCursorPosition(11, 22);
                        System.Threading.Thread.Sleep(1600);
                        Console.WriteLine("                            ");
                        Console.SetCursorPosition(x,y);
                        break;


                }

            }
            
        }

        public void StartScreen()
        {
            Title1();
            Title2();
        }

    }

    public class GameMEnu : MainMenu
    {

    }
}



using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace Pich_Milioner
{
    internal class Qestoins
    {
        public string[] ans1 = ["telegram", "max     ", "Whatsap ", "Discord "];
        Sounds sounds = new Sounds();
        public void qestions(int optoins)
        {
            switch (optoins) 
            {
                case 1:
                    Console.WriteLine("     какой месенджер официально ворует ваши данные? \n");

                    break;
            }

        }

        public void answers(int option)
        {
            
        }

        public void AnswersTab(string[] ans)
        {
            (int x, int y) = Console.GetCursorPosition();
            ConsoleKeyInfo key;
            int option = 1;
            bool isSelected = false;
            string color = "-> \u001b[30m\u001b[48;5;88m";

            Console.ForegroundColor = ConsoleColor.Red;
            while (!isSelected)
            {

                Console.SetCursorPosition(x, y);
                Console.WriteLine($"         ╔═══════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine($"         ║                                                                           ");
                Console.WriteLine($"         ║ {(option == 1 ? color : "   ")}   1 {ans[0]}  \u001b[31m\u001b[40m              {(option == 3 ? color : "   ")}   3 {ans[2]}   \u001b[31m\u001b[40m                            ");
                Console.WriteLine($"         ║                                                                           ");
                Console.WriteLine($"         ║ {(option == 2 ? color : "   ")}   2 {ans[1]}  \u001b[31m\u001b[40m              {(option == 4 ? color : "   ")}   4 {ans[3]}   \u001b[31m\u001b[40m                            ");
                Console.WriteLine($"         ║                                                                           ");
                Console.WriteLine($"         ╚═══════════════════════════════════════════════════════════════════════════╝\n");

                key = Console.ReadKey(true);


                switch (key.Key)
                {
                    case ConsoleKey.DownArrow:
                        option = (option == 4 ? 1 : option + 1);
                        sounds.swich();
                        break;
                    case ConsoleKey.RightArrow:
                        option = (option == 1 ? 3 : option);
                        option = (option == 2 ? 4 : option);
                        sounds.swich();
                        break;
                    case ConsoleKey.LeftArrow:
                        option = (option == 3 ? 1 : option);
                        option = (option == 4 ? 2 : option);
                        sounds.swich();
                        break;
                    case ConsoleKey.UpArrow:
                        option = (option == 1 ? 4 : option - 1);
                        sounds.swich();
                        break;
                    case ConsoleKey.Enter:
                        sounds.chose();

                        isSelected = true;
                        break;
                    default:
                        Console.WriteLine("           !!! ONLY ARROWS / ENTER !!!");
                        Console.SetCursorPosition(5, 19);
                        sounds.Error();

                        Console.WriteLine("                                  ");
                        Console.SetCursorPosition(x, y);
                        break;


                }

            }

        }
    }
}

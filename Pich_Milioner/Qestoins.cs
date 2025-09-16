using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Pich_Milioner
{
    internal class Qestoins
    {
        public int option = 1;
        public int CountsPoints = 0;
        public string[] ans1 = ["telegram         ", "max              ", "Whatsap          ", "Discord          "];
        public short truAnsv1 = 2;
        public string[] ans2 = ["Марк Цукерберг   ", "Билл Гейтс       ", "Павел Дуров      ", "Стив Джобс       "];
        public short truAnsv2 = 1;
        public string[] ans3 = ["10               ", "11               ", "12               ", "0                "];
        public short truAnsv3 = 3;
        public string[] ans4 = ["Пики             ", "Черви            ", "Бубны            ", "Трефы            "];
        public short truAnsv4 = 3;
        Sounds sounds = new Sounds();
        public void qestions(int optoins)
        {
            switch (optoins) 
            {
                case 1:
                    Console.WriteLine("     какой месенджер официально ворует ваши данные? \n");
                    break;
                case 2:
                    Console.WriteLine("     Кто является официальным создателем Facebook? \u001b[38;5;236m *(запрещенная в Российсой Федерации организация)");
                    break ;
                case 3:
                    Console.WriteLine("     Сколько баллов нужно поставить за эту контрольную? ");
                    break;
                case 4:
                    Console.WriteLine("     какую карту я зашадал ? ");
                    break;
            }

        }

        public void AnswersTab(string[] ans)
        {
            
            (int x, int y) = Console.GetCursorPosition();
            ConsoleKeyInfo key;

            bool isSelected = false;
            string color = "-> \u001b[30m\u001b[48;5;31m";
            string timeLen = "█████████████████████████████████████████████████████████████████████████████";
            int len = 0;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            while (!isSelected && len != timeLen.Length)
            {
                
                
                Console.SetCursorPosition(x, y);
                Console.WriteLine($"    ╔═══════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine($"    ║                                                                           ║");
                Console.WriteLine($"    ║ {(option == 1 ? color : "   ")}   1 {ans[0]}\u001b[31m\u001b[40m       {(option == 3 ? color : "   ")}   3 {ans[2]} \u001b[31m\u001b[40m                ║");
                Console.WriteLine($"    ║                                                                           ║");
                Console.WriteLine($"    ║ {(option == 2 ? color : "   ")}   2 {ans[1]}\u001b[31m\u001b[40m       {(option == 4 ? color : "   ")}   4 {ans[3]} \u001b[31m\u001b[40m                ║");
                Console.WriteLine($"    ║                                                                           ║");
                Console.WriteLine($"    ╚═══════════════════════════════════════════════════════════════════════════╝");
                (int X, int Y) = Console.GetCursorPosition();
                if (len != timeLen.Length)
                {
                    if (len < timeLen.Length) len++;
                    Console.SetCursorPosition(X, Y);
                    Console.WriteLine($"    {timeLen = timeLen.Remove(timeLen.Length - len, 1) + ' '}");
                    System.Threading.Thread.Sleep(250);
                    Console.SetCursorPosition(X, Y);
                }

                if (Console.KeyAvailable)
                {
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
}

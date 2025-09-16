using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
namespace Pich_Milioner
{

    public class MainMenu
    {
        Sprites sprites = new Sprites();
        Sounds sounds = new Sounds();

        public int option = 1;

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
                Console.WriteLine($"         ║ {(option == 1 ? color : "   ")}   Новая игра  \u001b[31m\u001b[40m                   ║");
                Console.WriteLine($"         ║                                      ║");
                Console.WriteLine($"         ║ {(option == 2 ? color : "   ")}   Разработчик \u001b[31m\u001b[40m                   ║");
                Console.WriteLine($"         ║                                      ║");
                Console.WriteLine($"         ║ {(option == 3 ? color : "   ")}   Донат       \u001b[31m\u001b[40m                   ║");
                Console.WriteLine($"         ║                                      ║");
                Console.WriteLine($"         ║                                      ║");
                Console.WriteLine($"         ╠══════════════════════════════════════╣");
                Console.WriteLine($"         ║   стрелочки чтобы управлять          ║");
                Console.WriteLine($"         ║ {(option == 4 ? color : "   ")}   Выйти       \u001b[31m\u001b[40m                   ║");
                Console.WriteLine($"         ║                                      ║");
                Console.WriteLine($"         ╚══════════════════════════════════════╝\n");

                key = Console.ReadKey(true);


                switch (key.Key)
                {
                    case ConsoleKey.DownArrow:
                        option = (option == 4 ? 1 : option + 1);
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
                        Console.SetCursorPosition(10, 21);
                        sounds.Error();

                        Console.WriteLine("                            ");
                        Console.SetCursorPosition(x, y);
                        break;


                }

            }

        }

        public void StartScreen()
        {
            sprites.Title1();
            Title2();
        }

    }

    public class GameMEnu : MainMenu
    {
        Sprites SPR = new Sprites();
        public int Second_option = 0;


        private void gameMenu()
        {
            Sounds sounds = new Sounds();
            (int x, int y) = Console.GetCursorPosition();
            ConsoleKeyInfo key;
            Second_option = 1;
            bool isSelected = false;
            string color = "-> \u001b[30m\u001b[48;5;88m";

            Console.ForegroundColor = ConsoleColor.Red;
            while (!isSelected)
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine($"         ╔════════════════════════════╗");
                Console.WriteLine($"         ║                            ║");
                Console.WriteLine($"         ║ {(Second_option == 1 ? color : "   ")}  Начать  \u001b[31m\u001b[40m              ║");
                Console.WriteLine($"         ║                            ║");
                Console.WriteLine($"         ║ {(Second_option == 2 ? color : "   ")}  правила \u001b[31m\u001b[40m              ║");
                Console.WriteLine($"         ║                            ║");
                Console.WriteLine($"         ║   \u001b[38;5;213m * Желательно прочитать \u001b[31m\u001b[40m ║");
                Console.WriteLine($"         ║                            ║");
                Console.WriteLine($"         ║                            ║");
                Console.WriteLine($"         ╠════════════════════════════╣");
                Console.WriteLine($"         ║                            ║");
                Console.WriteLine($"         ║ {(Second_option == 3 ? color : "   ")}  назад       \u001b[31m\u001b[40m          ║");
                Console.WriteLine($"         ║                            ║");
                Console.WriteLine($"         ╚════════════════════════════╝\n");

                key = Console.ReadKey(true);


                switch (key.Key)
                {
                    case ConsoleKey.DownArrow:
                        Second_option = (Second_option == 3 ? 1 : Second_option + 1);
                        sounds.swich();
                        break;
                    case ConsoleKey.UpArrow:
                        Second_option = (Second_option == 1 ? 3 : Second_option - 1);
                        sounds.swich();
                        break;
                    case ConsoleKey.Enter:
                        sounds.chose();
                        isSelected = true;
                        break;
                    default:
                        Console.WriteLine("           !!! ONLY ARROWS / ENTER !!!");
                        Console.SetCursorPosition(10, 22);
                        sounds.Error();

                        Console.WriteLine("                                         ");
                        Console.SetCursorPosition(x, y);
                        break;


                }

            }

        }
        public void GmStartScreen()
        {
            SPR.GmTitle1();
            gameMenu();
            Console.WriteLine("управление стрелосками");
        }

    }

    public class Menu_tools
    {

        Sounds sounds = new Sounds();
        ConsoleKeyInfo key;
        public void back_button(int x, int y)
        {
            bool is_pressed = true;
            (int X, int Y) = Console.GetCursorPosition();
            Console.WriteLine("\u001b[38;5;11m  -> Ecs to back ");
            while (is_pressed)
            {
                key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.Escape:
                        Console.WriteLine();
                        is_pressed = false;
                        sounds.chose();
                        break;
                    default:
                        Console.WriteLine("\n           !!! ONLY Ecs !!!");
                        Console.SetCursorPosition(x, y);
                        sounds.Error();

                        Console.WriteLine("                            ");
                        Console.SetCursorPosition(X, Y);
                        is_pressed = true;
                        break;
                }
            }
        }

        public bool Timer()
        {
            return false;
        }


    }

    public class Page_G
    {

        Sounds sounds = new Sounds();

        public int option = 1;
        public int minOpt = 1;
        public int maxOpt = 19;
        public void Page_1()
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
                Console.WriteLine($"         ║ {(option == 1 ? color : "   ")}   1 вопрос  \u001b[31m\u001b[40m  30 000             ║"); 
                Console.WriteLine($"         ║ {(option == 2 ? color : "   ")}   2 вопрос  \u001b[31m\u001b[40m  30 000             ║");
                Console.WriteLine($"         ║ {(option == 3 ? color : "   ")}   3 вопрос  \u001b[31m\u001b[40m  30 000             ║");
                Console.WriteLine($"         ║ {(option == 4 ? color : "   ")}   4 вопрос  \u001b[31m\u001b[40m  40 000             ║");
                Console.WriteLine($"         ║ {(option == 5 ? color : "   ")}   5 вопрос  \u001b[31m\u001b[40m  40 000             ║");
                Console.WriteLine($"         ║ {(option == 6 ? color : "   ")}   6 вопрос  \u001b[31m\u001b[40m  40 000             ║");
                Console.WriteLine($"         ║ {(option == 7 ? color : "   ")}   7 вопрос  \u001b[31m\u001b[40m  50 000             ║");
                Console.WriteLine($"         ║ {(option == 8 ? color : "   ")}   8 вопрос  \u001b[31m\u001b[40m  50 000             ║");
                Console.WriteLine($"         ║ {(option == 9 ? color : "   ")}   9 вопрос  \u001b[31m\u001b[40m  50 000             ║");
                Console.WriteLine($"         ║ {(option == 10 ? color : "   ")}  10 вопрос  \u001b[31m\u001b[40m 60 000              ║");
                Console.WriteLine($"         ║ {(option == 11 ? color : "   ")}  11 вопрос  \u001b[31m\u001b[40m 60 000              ║");
                Console.WriteLine($"         ║ {(option == 12 ? color : "   ")}  12 вопрос  \u001b[31m\u001b[40m 60 000              ║");
                Console.WriteLine($"         ║ {(option == 13 ? color : "   ")}  13 вопрос  \u001b[31m\u001b[40m 70 000              ║");
                Console.WriteLine($"         ║ {(option == 14 ? color : "   ")}  14 вопрос  \u001b[31m\u001b[40m 70 000              ║");
                Console.WriteLine($"         ║ {(option == 15 ? color : "   ")}  15 вопрос  \u001b[31m\u001b[40m 70 000              ║");
                Console.WriteLine($"         ║ {(option == 16 ? color : "   ")}  16 вопрос  \u001b[31m\u001b[40m 100 000             ║");
                Console.WriteLine($"         ║ {(option == 17 ? color : "   ")}  17 вопрос  \u001b[31m\u001b[40m 100 000             ║");
                Console.WriteLine($"         ║ {(option == 18 ? color : "   ")}  18 вопрос  \u001b[31m\u001b[40m 100 000             ║");
                Console.WriteLine($"         ║                                      ║");
                Console.WriteLine($"         ║                                      ║");
                Console.WriteLine($"         ╠══════════════════════════════════════╣");
                Console.WriteLine($"         ║                                      ║");
                Console.WriteLine($"         ║ {(option == 19? color : "   ")}  Я наигрался       \u001b[31m\u001b[40m              ║");
                Console.WriteLine($"         ╚══════════════════════════════════════╝\n");

                key = Console.ReadKey(true);


                switch (key.Key)
                {
                    case ConsoleKey.DownArrow:
                        option = (option == maxOpt ? minOpt : option + 1);
                        sounds.Fast_switch();
                        break;
                    case ConsoleKey.UpArrow:
                        option = (option == minOpt ? maxOpt : option - 1);
                        sounds.Fast_switch();
                        break;
                    case ConsoleKey.Enter:
                        sounds.chose();

                        isSelected = true;
                        break;
                    default:
                        Console.WriteLine("           !!! ONLY ARROWS / ENTER !!!");
                        Console.SetCursorPosition(x, y);
                        sounds.Error();

                        Console.WriteLine("                            ");
                        Console.SetCursorPosition(x, y);
                        break;


                }
            }
        }
    }


}



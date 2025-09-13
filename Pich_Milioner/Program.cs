using System;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Principal;
using static System.Net.Mime.MediaTypeNames;
namespace Pich_Milioner
{
    internal class Program
    {
        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Qestoins qestoins = new Qestoins();
            Page_G page_G = new Page_G();
            GameMEnu GM = new GameMEnu();
            MainMenu MN = new MainMenu();
            Sounds sounds = new Sounds();
            Menu_tools menu_Tools = new Menu_tools();
            Sprites sprites = new Sprites();
            (int x, int y) = Console.GetCursorPosition();
            bool gang = true;
        exit_plae:
            Console.Clear();
            MN.StartScreen();
            switch (MN.option)
            {
                case 1:
                    Console.Clear();  
                    GM.GmStartScreen();
                    break;
                case 2:
                    Console.Clear();
                    sprites.DevNAme();
                    menu_Tools.back_button(1, 27);
                    goto exit_plae;

                case 3:
                    Console.Clear();

                    sprites.Donate_screen();
                    menu_Tools.back_button(1, 1);
                    goto exit_plae;
                case 4:
                    Console.Clear();
                    gang = false;
                    break;

            }
            if (GM.Second_option == 2)
            {
                sprites.Rules();
                Console.ReadKey();
                sounds.chose();
                Console.Clear();
                GM.GmStartScreen();
            }
            while (gang)
            {
                switch (GM.Second_option)
                {
                    case 1:
                        Console.Clear();
                        //sprites.QestionsTitle();
                        page_G.Page_1();
                        switch (page_G.option)
                        {
                            case 1:
                                Console.Clear();
                                sprites.QestionsTitle();
                                qestoins.qestions(1);
                                qestoins.AnswersTab(qestoins.ans1);
                                Console.ReadKey();
                                
                                break;
                            case 2:
                                break;
                        }
                        break;
                    case 3:
                        goto exit_plae;

                }
            }

        }
    }


}
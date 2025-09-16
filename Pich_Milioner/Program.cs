using System;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using static System.Net.Mime.MediaTypeNames;
namespace Pich_Milioner
{
    internal class Program
    {

        static void Main()
        {
            int CounstPoints = 0;
            Console.BackgroundColor = ConsoleColor.Black;
            Qestoins qestoins = new Qestoins();
            Page_G page_G = new Page_G();
            GameMEnu GM = new GameMEnu();
            MainMenu MN = new MainMenu();
            Sounds sounds = new Sounds();
            Menu_tools menu_Tools = new Menu_tools();
            Program prg = new Program();

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
                        Console.WriteLine($"\n         всего у вас {CounstPoints}  очьков ");
                        page_G.Page_1();

                        switch (page_G.option)
                        {
                            case 1:
                                Console.Clear();
                                sprites.QestionsTitle();
                                qestoins.qestions(1);
                                qestoins.AnswersTab(qestoins.ans1);
                                menu_Tools.Timer();
                                if (qestoins.option == qestoins.truAnsv1)
                                {
                                    page_G.minOpt = 2;
                                    CounstPoints += 30000;
                                }
;
                                break;
                            case 2:
                                Console.Clear();
                                sprites.QestionsTitle();
                                qestoins.qestions(2);
                                qestoins.AnswersTab(qestoins.ans2);
                                menu_Tools.Timer();
                                if (qestoins.option == qestoins.truAnsv2)
                                {
                                    page_G.minOpt = 3;
                                    CounstPoints += 30000;
                                }
                                break;
                            case 3:
                                Console.Clear();
                                sprites.QestionsTitle();
                                qestoins.qestions(3);
                                qestoins.AnswersTab(qestoins.ans3);
                                menu_Tools.Timer();
                                if (qestoins.option == qestoins.truAnsv3)
                                {
                                    page_G.minOpt = 4;
                                    CounstPoints += 30000;
                                }
                                break;
                            case 4:
                                Console.Clear();
                                sprites.QestionsTitle();
                                qestoins.qestions(4);
                                qestoins.AnswersTab(qestoins.ans4);
                                menu_Tools.Timer();
                                if (qestoins.option == qestoins.truAnsv4)
                                {
                                    page_G.minOpt = 5;
                                    CounstPoints +=40000;
                                }
;
                                ;
                                break;
                            case 5:
                                Console.Clear();
                                sprites.QestionsTitle();
                                qestoins.qestions(5);
                                qestoins.AnswersTab(qestoins.ans5);
                                menu_Tools.Timer();
                                if (qestoins.option == qestoins.truAnsv5)
                                {
                                    page_G.minOpt = 6;
                                    CounstPoints += 40000;
                                }
                                break;
                            case 6:
                                Console.Clear();
                                sprites.QestionsTitle();
                                qestoins.qestions(6);
                                qestoins.AnswersTab(qestoins.ans6);
                                menu_Tools.Timer();
                                if (qestoins.option == qestoins.truAnsv6)
                                {
                                    page_G.minOpt = 7;
                                    CounstPoints += 40000;
                                }
                                break;
                            case 19:
                                Console.Clear();
                                gang = false;
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
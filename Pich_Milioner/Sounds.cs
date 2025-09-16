using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pich_Milioner
{

   public class Sounds
   {
       public void Error()
       {
           Console.Beep(150, 1300);
       }
       public void chose()
       {
           Console.Beep(390, 110);
           Console.Beep(250, 130);

       }

       public void swich()
       {
           Console.Beep(190, 50);
       }
        public void Fast_switch()
        {
            Console.Beep(300, 50);
        }
   }

}

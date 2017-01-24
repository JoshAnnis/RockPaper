using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaper
{
    class AI : Player
    {
        public override string Compinput()

        {
            Random rnd = new Random();
            int number = rnd.Next(0, 5);
            if (number == 1)
            {
                Console.WriteLine("the computer choose Rock");
               return("R");
               

            }

            else if (number == 2)
            {
                Console.WriteLine("The computer choose Paper");
                return("P");
             

            }

            else if (number == 3)
            {
                Console.WriteLine("The computer choose Sicssors");
                return ("S");
                

            }



            else if (number == 4)
            {
                Console.WriteLine("The computer choose Lizard");
                return ("L");
                
               

            }



            else

            {
                Console.WriteLine("The computer choose Spock");
                return ("SP");
                

            }



        }
    }
}

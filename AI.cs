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

               return("Rock");
               

            }

            else if (number == 2)
            {

                return("Paper");
             

            }

            else if (number == 3)
            {

                return("Scissors");
                

            }



            else if (number == 4)
            {

                return("Lizard");
                
               

            }



            else

            {

               return("Spock");
                

            }



        }
    }
}

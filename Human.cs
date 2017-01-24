using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaper
{
    class Human : Player
    {   

        public override string Getchoice()
        {
            
            Console.WriteLine("Players choose your weapon R(ock) P(aper) S(cissors) L(izard) or  SP(ock) ");

            string Choice = Console.ReadLine();




            if (Choice == "R")
            {

                return ("Rock");

            }

            else if (Choice == "S")

            {

                return ("S");

            }

            else if (Choice == "P")
            {

                return(" P");
            }
            
            else if (Choice == "L")

            {

                return ("");

            }

            else if (Choice == "SP")

            {

                return ("SP");

            }

            else

            {

                return ("Please make a choice");
                


            }

        }




        





}
}

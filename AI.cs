using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaper
{
    class AI : Player
    {
        public override void Compinput()

        {
            Random rnd = new Random();
            int number = rnd.Next(0, 6);
            if (number == 1)
            {

                Console.WriteLine("the computer choose Rock");
                Console.ReadLine();

            }

            else if (number == 2)
            {

                Console.WriteLine("the computer choose Paper");
                Console.ReadLine();

            }

            else if (number == 3)
            {

                Console.WriteLine("the computer choose Scissors");
                Console.ReadLine();

            }



            else if (number == 4)
            {

                Console.WriteLine("the computer choose Lizard");
                Console.ReadLine();

            }



            else

            {

                Console.WriteLine("the computer choose Spock");
                Console.ReadLine();

            }



        }
    }
}

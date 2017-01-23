using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaper
{
    class Player
    {
        Random rnd = new Random();
        public void OnePlayer()
        {

            Console.WriteLine(" welcome Player chooose your weapon either R(ock) P(aper) S(cissors) L(izard) or SP(ock)");

            string Choice = Console.ReadLine();

            if (Choice == "R")
            {
                Console.WriteLine("You choose Rock");
            }
            else if (Choice == "S")
            {
                Console.WriteLine("You choose Scissors");
            }
            else if (Choice == "P")
            {
                Console.WriteLine("You choose Paper");

            }
            else if (Choice == "L")
            {
                Console.WriteLine("You choose Lizard");
            }
            else if (Choice == "SP")
            {
                Console.WriteLine("You choose Spock");
            }


        }

        public void GetCompChoice()
        {
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



        public void TwoPlayers()
        {
            Human1();
            Human2();



        }

        public string Human1()
        {
            Console.WriteLine("Player One choose your weapon R(ock) P(aper) S(cissors) L(izard) or  SP(ock) ");
            string Choice = Console.ReadLine();

            if (Choice == "R")
            {
                return ("Rock");
            }
            else if (Choice == "S")
            {
                return ("Scissors");
            }
            else if (Choice == "P")
            {
                return ("Paper");

            }
            else if (Choice == "L")
            {
                return ("Lizard");
            }
            else if (Choice == "SP")
            {
                return ("Spock");
            }
            else
            {
                return ("Error please make a choice");
            }
        }

        public string Human2()
        {
            Console.WriteLine("Player Two choose your weapon R(ock) P(aper) S(cissors) L(izard) or  SP(ock) ");
            string Choice = Console.ReadLine();

            if (Choice == "R")
            {
                return ("Rock");
            }
            else if (Choice == "S")
            {
                return ("Scissors");
            }
            else if (Choice == "P")
            {
                return ("Paper");

            }
            else if (Choice == "L")
            {
                return ("Lizard");
            }
            else if (Choice == "SP")
            {
                return ("Spock");
            }
            else
            {
                return ("Error please make a choice");
            }





        }







    }

}
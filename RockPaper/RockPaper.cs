using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace RockPaper

{

    class RockPaper



    {

        Random rnd = new Random();

        

        public void StartGame()
                   {

            Console.WriteLine("Welcome to Rock-Paper-Scissor-Lizard-Spock ");

            Console.WriteLine("How many players? '1' or '2'?");

            string GameMode = Console.ReadLine();

            switch (GameMode)

            {

                case "1":

                    Console.WriteLine("One player");

                    OnePlayer();

                    GetCompChoice("Choice");

                    break;

                case "2":

                    Console.WriteLine("Two players");

                    TwoPlayers();

                    break;

            }

        }



        public void OnePlayer()

        {

            Console.WriteLine(" welcome Player chooose your weapon either R(ock) P(aper) S(cissors) L(izard) SP(ock)");

            String Choice = Console.ReadLine();



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
                Console.WriteLine("You choose paper");

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

        private void GetCompChoice(string Choice)
        {
            int number = rnd.Next(1, 6);
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



        











        public void GetWinner(string PlayerOne, string computerInput)

        {

            if (PlayerOne == ("R") && computerInput == ("S"))
            { 
                Console.WriteLine("Player One wins");
                Console.ReadLine();
            }
            else if (PlayerOne== "P")
            { 
                Console.WriteLine("Player One wins");
                Console.ReadLine();
            }










            }






        private void TwoPlayers()

        {



        }





    }
}
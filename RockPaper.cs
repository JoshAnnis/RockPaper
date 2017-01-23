using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace RockPaper

{

    class RockPaper
    {
        Player player = new Player();



        string Human1;
        string Human2;


        public void StartGame()

        {

            Console.WriteLine("Welcome to Rock-Paper-Scissor-Lizard-Spock ");

            Console.WriteLine("How many players? '1' or '2'?");

            string GameMode = Console.ReadLine();

            switch (GameMode)

            {

                case "1":

                    Console.WriteLine("One player");
                    player.OnePlayer();
                    player.GetCompChoice();



                    break;

                case "2":

                    Console.WriteLine("Two players");
                    player.TwoPlayers();

                    GetWinner(Human1, Human2);
                    break;

            }


        }
        public void GetWinner(string Human1, string Human2)

        {

            if ((Human1 == "R") && (Human2 == "S") || (Human2 == "L"))
            {
                Console.WriteLine("PlayerOne Wins");
                Console.ReadLine();
            }
            else if ((Human1 == "P") && (Human2 == "R") || (Human2 == "SP"))
            {
                Console.WriteLine("PlayerOne Wins");
                Console.ReadLine();
            }
            else if ((Human1 == "S") && (Human2 == "P") || (Human2 == "L"))
            {
                Console.WriteLine("PlayerOne Wins");
                Console.ReadLine();
            }
            else if ((Human1 == "L") && (Human2 == "P") || (Human2 == "SP"))
            {
                Console.WriteLine("PlayerOne Wins");
                Console.ReadLine();
            }
            else if ((Human1 == "S") && (Human2 == "SP") || (Human2 == "R"))
            {
                Console.WriteLine("PlayerOne Wins");
                Console.ReadLine();
            }
            else if (Human1 == Human2)
            {
                Console.WriteLine("You Both Lose because a draw is not a win for either");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Player One loses to Player Two superior battle skillz");
                Console.ReadLine();
            }





        }



        public void GetWinnerChoice(string OnePlayer, string GetCompChoice)

        {

            if ((OnePlayer == "R") && (GetCompChoice == "S") || (GetCompChoice == "L"))
            {
                Console.WriteLine("PlayerOne Wins");
                Console.ReadLine();
            }
            else if ((OnePlayer == "P") && (GetCompChoice == "R") || (GetCompChoice == "SP"))
            {
                Console.WriteLine("PlayerOne Wins");
                Console.ReadLine();
            }
            else if ((OnePlayer == "S") && (GetCompChoice == "P") || (GetCompChoice == "L"))
            {
                Console.WriteLine("PlayerOne Wins");
                Console.ReadLine();
            }
            else if ((OnePlayer == "L") && (GetCompChoice == "P") || (GetCompChoice == "SP"))
            {
                Console.WriteLine("PlayerOne Wins");
                Console.ReadLine();
            }
            else if ((OnePlayer == "S") && (GetCompChoice == "SP") || (GetCompChoice == "R"))
            {
                Console.WriteLine("PlayerOne Wins");
                Console.ReadLine();
            }
            else if (OnePlayer == GetCompChoice)
            {
                Console.WriteLine("You Both Lose because a draw is not a win for either");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Player One loses to Player Two superior battle skillz");
                Console.ReadLine();
            }

        }


















    }
}
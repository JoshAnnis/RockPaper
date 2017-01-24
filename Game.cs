using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace RockPaper

{

    class Game
    {
        string Player1choice;
        string Player2choice;
        public int Player1Score = 0;
        public int Player2Score = 0;
        public int CompScore = 0;
        Player playerone;
        Player playertwo;
       


        public void StartGame()

        {

            Console.WriteLine("Welcome to Rock-Paper-Scissor-Lizard-Spock ");

            Console.WriteLine("How many players? '1' or '2'?");

            string GameMode = Console.ReadLine();

            switch (GameMode)

            {

                case "1":

                    Console.WriteLine("One player vs AI");
                    playerone = new Human();
                    playertwo = new AI();
                    Player1choice = playerone.Getchoice();
                    Player2choice= playertwo.Compinput();
                    GetWinner();
                    getScore();
                  
                    break;

                case "2":

                    Console.WriteLine("Two players");
                    playerone = new Human();
                    playertwo = new Human();
                    Player1choice = playerone.Getchoice();
                    Player2choice = playertwo.Getchoice();
                    GetWinner();
                    getScore();
                  
                    break;
            }


        }      
            public void GetWinner()
        {
            if ((Player1choice == "R") && (Player2choice == "S") || (Player2choice == "L"))
            {

                Console.WriteLine("PlayerOne Wins");
                Console.ReadLine();
                Player1Score++;

            }

            else if ((Player1choice == "P") && (Player2choice == "R") || (Player2choice == "SP"))

            {

                Console.WriteLine("PlayerOne Wins");
                Console.ReadLine();
                Player1Score++;

            }

            else if ((Player1choice == "S") && (Player2choice == "P") || (Player2choice == "L"))

            {
                
                Console.WriteLine("PlayerOne Wins");
                Console.ReadLine();
                Player1Score++;

            }

            else if ((Player1choice == "L") && (Player2choice == "P") || (Player2choice == "SP"))

            {

                Console.WriteLine("PlayerOne Wins");
                Console.ReadLine();
                Player1Score++;

            }

            else if ((Player1choice == "SP") && (Player2choice == "S") || (Player2choice == "R"))

            {

                Console.WriteLine("PlayerOne Wins");
                Console.ReadLine();
                Player1Score++;

            }

            else if (Player1choice == Player2choice)

            {

                Console.WriteLine("Its a draw");
                Console.ReadLine();
                

            }

            else

            {

                Console.WriteLine("Player two wins this round ");
                Console.ReadLine();
                Player2Score ++;


            }
        }
        


        public void getScore()
        {
            if (Player1Score == 2)
            {
                Console.WriteLine("Player One wins the game");
            }
            else if (Player2Score== 2)
            {
                Console.WriteLine("Player two wins the game");
                Console.WriteLine("Would you like to play again? yes or 'no'");
                string GameOver = Console.ReadLine();
                 if(GameOver == "yes")
               {
                   StartGame();
                }
                 else
                    {

                }
            }
            else
            {
                StartGame();
            }







        }
            
    }
}
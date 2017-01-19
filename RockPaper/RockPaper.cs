using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaper
{
    class RockPaper
        
    {
        Random random = new Random();
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
                    GetCompChoice();
                    break;
                case "2":
                    Console.WriteLine("Two players");
                    TwoPlayers();
                    break;
            }
        }

        public string OnePlayer()
        {
            Console.WriteLine(" welcome Player chooose your weapon either R(ock) P(aper) S(cissors) L(izard) SP(ock)");
            String Choice = Console.ReadLine();

            if (Choice == "R")
            {
                return "R";
            }

            else if (Choice == "S")
            {
                return "S";
            }

            else if (Choice == "P")
            {
                return "p";
            }
            else if (Choice == "L")
            {
                return "L";
            }
            else  
                return "SP";
        }
        private string GetCompChoice()
          {
            int number = random.Next(1,5);
             if(number == 1 )
            {
                return "R";
            }
           else if (number == 2)
            {
                return "P";
            }
           else if (number == 3)
            {
                return "S";
            }
          else  if (number == 4)
            {
                return "L";
            }
          else 
            {
                return "SP";
            }
        }


        private string LetterToWords(string Choice)
        {
            if (Choice == "R")
            {
                return "Rock";
            }
            else if (Choice == "P")
            {
                return "Paper";
            }
            else if (Choice == "S")
            {
                return "Scissors";
            }
            else if (Choice == "L")
            {
                return "Lizard";
            }
           else 
            {
                return "Spock";
            }
        }




             private void GetWinner(string humanInput, string computerInput)
                {
                    if (humanInput == ("R") && computerInput== ("S"))
            {
                var Winner = humanInput;
            }




                  }

        

        private void TwoPlayers()
            {

            }


        }

    
























}




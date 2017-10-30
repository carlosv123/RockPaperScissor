using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
     public class Game
    {
        List<Player> players = new List<Player>();

        public Game()
        {
            
        }
        
        public void playerInfo()
        {
            Player player = new Player();
            Console.WriteLine("Enter your name");
            player.Name = Console.ReadLine();
            player.score = 0;
            players.Add(player);

        }

        public void ChooseNumberOfPlayers()
        {
            Console.WriteLine("Choose the amount of players");
            string Players = Console.ReadLine();

            if (Players == "1")
            {
                Console.WriteLine("1 player mode");
                Console.WriteLine("Enter your name");
                playerInfo();
                Computer computer = new Computer();
                players.Add(computer);
                Console.WriteLine("We have all players set. Welcome to rock,paper,scissor,lizard,spok. winner 2 best out of 3.");
                Console.ReadLine();
                startGame();

            }
            else if (Players == "2")
            {
                Console.WriteLine("enter player 1 name");
                playerInfo();
                Console.WriteLine("enter player 2 name");
                playerInfo();
                Console.WriteLine("We have all players set. Welcome to rock,paper,scissor,lizard,spok. winner 2 best out of 3.");
                Console.ReadLine();
                startGame();

            }
            else
            {
                Console.WriteLine("you only have 2 choices. Please try again");
                ChooseNumberOfPlayers();
            }
        }
           
        public void startGame()
        {
            if(players[0].score == 2)
            {
                Console.WriteLine(players[0].Name + "winner");
                Console.ReadLine();

            }
            else if(players[1].score == 2)
            {
                Console.WriteLine(players[1].Name + "winner");
            }
            else
            {
                string playerOne = players[0].playerChoice();
                string playerTwo;

                if (players[1].computerMode = true)
                {
                    playerTwo = players[1].playerChoice();
                    Console.WriteLine("computer has made its choice");
                }
                else
                {
                    playerTwo = players[1].playerChoice();

                }
               GetOutCome(playerOne, playerTwo);
            }
        }

        public void GetOutCome(string playerOne, string playerTwo)
        {
            Console.WriteLine("choices have been made");
            Console.ReadLine();
        
            switch (playerOne)
            {
                case "Rock":

                    rock(playerTwo);

                    break;

                case "Paper":

                    paper(playerTwo);

                    break;

                case "Scissors":

                    scissor(playerTwo);

                    break;

                case "Lizard":

                    lizard(playerTwo);

                    break;

                case "Spock":

                    spock(playerTwo);

                    break;

                default:

                    break;

            }
        }

        public void rock(string playerTwo)
        {
            if (playerTwo == "Rock")
            {

                Console.WriteLine("It is a tie!  Both players choose Rock.");
                GetTie();
            }
            else if (playerTwo == "Lizard" || playerTwo == "Scissors")
            { 
                Console.WriteLine(players[0].Name + " won! Rock beats " + playerTwo + ". Sorry " + players[1].Name);
                UpdatePlayerOne();
            }
            else
            {
                Console.WriteLine(players[0].Name + " Lost! Rock does not beat " + playerTwo + ". YAA!! For " + players[1].Name);
                UpdateplayerTwo();

            }
        }
        public void paper(string playerTwo)
        {
           if(playerTwo == "scissor")
            {
                Console.WriteLine("it is a tie! both players choose scissors");
                GetTie();
            }
           else if(playerTwo == "Lizard" || playerTwo == "Scissors")
            {
                Console.WriteLine(players[0].Name + " won! Paper beats " + playerTwo + ".  Sorry " + players[1].Name);
                UpdatePlayerOne();
            }
            else
            {
                Console.WriteLine(players[0].Name + " Lost! Paper does not beat " + playerTwo + ". YAA!!! for " + players[1].Name);
                UpdateplayerTwo();
            }
        }  
        public void scissor(string playerTwo)
        {
            if (playerTwo == "Scissors")
            {
                Console.WriteLine("It is a TIE!  You both choose Scissors.");
                GetTie();
            }
            else if (playerTwo == "Paper" || playerTwo == "Lizard")
            {
                Console.WriteLine(players[0].Name + " won! Scissors beats " + playerTwo + ". Sorry " + players[1].Name);
                UpdatePlayerOne();
            }
            else
            {
                Console.WriteLine(players[0].Name + " Lost! Scissors does not beat " + playerTwo + ". YAA!!! For " + players[1].Name);
                UpdateplayerTwo();
            }
        }
        public void lizard(string playerTwo)
        {
            {
                if (playerTwo == "Lizard")
                {
                    Console.WriteLine("It is a TIE!  You both choose Lizard.");
                    GetTie();
                }
                else if (playerTwo == "Paper" || playerTwo == "Spock")
                {
                    Console.WriteLine(players[0].Name + " won! Lizard beats " + playerTwo + ". Sorry " + players[1].Name);
                    UpdatePlayerOne();
                }
                else
                {
                    Console.WriteLine(players[0].Name + " Lost! Lizard does not beat " + playerTwo + ". YAA!!! For " + players[1].Name);
                    UpdateplayerTwo();
                }

            }
        }
        public void spock(string playerTwo)
        {
            {
                if (playerTwo == "Spock")
                {
                    Console.WriteLine("It is a TIE!  You both choose Spock.");
                    GetTie();
                }
                else if (playerTwo == "Rock" || playerTwo == "Scissors")
                {
                    Console.WriteLine(players[0].Name + " won! Rock beats " + playerTwo + ". Sorry " + players[1].Name);
                    UpdatePlayerOne();
                }
                else
                {
                    Console.WriteLine(players[0].Name + " Lost! Spock does not beat " + playerTwo + ". YAA!!! For " + players[1].Name);
                    UpdateplayerTwo();
                }

            }
        }
        public void GetTie()
        {
            ScoreSheet();
            Console.ReadLine();
            startGame();
        }
        public void UpdatePlayerOne()
        {
            players[0].score += 1;
            ScoreSheet();
            Console.ReadLine();
            startGame();
        }
        public void UpdateplayerTwo()
        {
            players[1].score += 1;
            ScoreSheet();
            Console.ReadLine();
            startGame();
        }
       public void ScoreSheet()
        {
            Console.WriteLine(players[0].Name + ":" + players[0].score + "to" + players[1].Name + ":" + players[1].score);
        }
       
           
           
            

            
        
        
    }
}

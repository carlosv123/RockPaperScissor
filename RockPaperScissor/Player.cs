using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    public class Player
    {
        
        public string Name;
        public int score;
        public bool computerMode;
        

        public Player()
        {

        }
       
        public virtual string playerChoice()
        {
            Console.WriteLine("Please choose your hand");
            Console.WriteLine("Choose a number \n 1: Lizard \n 2: Spock \n 3: Rock \n 4: Scissors \n 5: Paper \n");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    choice = "Lizard";
                     return choice;
                case "2":
                    choice = "Spock";
                    return choice;
                case "3":
                    choice = "Rock";
                    return choice;
                case "4":
                    choice = "Scissors";
                    return choice;
                case "5":
                    choice = "Paper";
                    return choice;
                default:
                    Console.WriteLine("Invalid Choice");
                    choice = this.playerChoice();
                    return choice;
            }

        }
        

    }
}

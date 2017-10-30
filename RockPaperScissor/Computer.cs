using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
   public class Computer : Player 
    {
        public Computer()
        {
            this.Name = "Player AI";
            this.score = 0;
            this.computerMode = true;
        }
        public override string playerChoice()
        {
            string choice = "";

            Random random = new Random();

            choice = random.Next(1, 6).ToString();

            choice = GetChoice(choice);
            return choice;
        }

        public string GetChoice( string number)
        {
            string choice = number;

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
                    return choice;
            }
        }

    }
}

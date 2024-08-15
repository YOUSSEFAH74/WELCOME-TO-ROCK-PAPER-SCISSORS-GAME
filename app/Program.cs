using System;
using System.Linq;
namespace app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("WELCOME TO ROCK , PAPER , SCISSORS GAME.....");
            Random randon = new Random();
            bool playAgin = true;
            string player;
            string computer;
            string ans;
            while (playAgin) 
            {
                player = "";
                computer = "";
                ans = "";
                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.Write("Enter Rock , Paper , Scissors: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();  
                }
                int rand = randon.Next(1 , 4);
                switch (rand)
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break; 
                    case 3:
                        computer = "SCISSORS";
                        break;
                }

                Console.WriteLine("*****************************");
                Console.WriteLine("Palyer: " +  player);
                Console.WriteLine("*****************************");
                Console.WriteLine("Computer: " + computer);
                Console.WriteLine("*****************************");

                switch (player)
                {
                    case "ROCK":

                        if(computer == "ROCK")
                        {
                            Console.WriteLine("It's a Draw!!");
                            Console.WriteLine("*****************************");
                        }


                        else if (computer == "PAPER")
                        {
                             Console.WriteLine("You Lose!");
                             Console.WriteLine("*****************************");
                        }


                        else
                        {
                             Console.WriteLine("You Win!");
                             Console.WriteLine("*****************************");
                        }
                        break;

                    case "PAPER":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You win!!");
                            Console.WriteLine("*****************************");

                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("It's a Draw!!");
                            Console.WriteLine("*****************************");
                        }


                        else
                        {
                            Console.WriteLine("You Lose!");
                            Console.WriteLine("*****************************");
                        }

                        break;

                    case "SCISSORS":

                        if (computer == "ROCK")
                        {
                             Console.WriteLine("You lose!!");
                             Console.WriteLine("*****************************");
                        }


                        else if (computer == "PAPER")
                        {
                             Console.WriteLine("you win!!");
                             Console.WriteLine("*****************************");

                        }


                        else
                        {
                            Console.WriteLine("It's a Draw!!");
                            Console.WriteLine("*****************************");
                        }

                        break;
                }

                Console.Write("Play Agin BRO ?! (Y/N) ");
                ans = Console.ReadLine();
                ans = ans.ToUpper();

                if (ans == "Y")
                    playAgin = true;
                else
                    playAgin = false;

            }

        }
    }
}

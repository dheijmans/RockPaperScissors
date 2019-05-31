using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int playerScore = 0;
                int cpuScore = 0;
                Random random = new Random();
                string playerInput;
                int cpuInput;
                bool invalidInput;
                while (playerScore < 3 && cpuScore < 3)
                {
                    invalidInput = false;
                    Console.Clear();
                    Frame.Title();
                    Frame.Scores(playerScore, cpuScore);
                    cpuInput = random.Next(1, 4);
                    Console.SetCursorPosition(0, 7);
                    Console.Write("Rock, paper or scissors: ");
                    playerInput = Console.ReadLine().ToLower();
                    Console.WriteLine();
                    if (playerInput == "rock")
                    {
                        switch (cpuInput)
                        {
                            case 1:
                                Results.RockRock();
                                break;
                            case 2:
                                Results.RockPaper();
                                cpuScore++;
                                break;
                            case 3:
                                Results.RockScissors();
                                playerScore++;
                                break;
                        }
                    }
                    else if (playerInput == "paper")
                    {
                        switch (cpuInput)
                        {
                            case 1:
                                Results.PaperRock();
                                playerScore++;
                                break;
                            case 2:
                                Results.PaperPaper();
                                break;
                            case 3:
                                Results.PaperScissors();
                                cpuScore++;
                                break;
                        }
                    }
                    else if (playerInput == "scissors")
                    {
                        switch (cpuInput)
                        {
                            case 1:
                                Results.ScissorsRock();
                                cpuScore++;
                                break;
                            case 2:
                                Results.ScissorsPaper();
                                playerScore++;
                                break;
                            case 3:
                                Results.ScissorsScissors();
                                break;
                        }
                    }
                    else
                    {
                        Results.InvalidInput();
                        invalidInput = true;
                    }
                    Frame.Scores(playerScore, cpuScore);
                    if (invalidInput)
                    {
                        Console.SetCursorPosition(0, 10);                       
                    }
                    else
                    {
                        Console.SetCursorPosition(0, 17);
                    }
                    Console.WriteLine();
                    Console.Write("Press 'ENTER' to continue ");
                    Console.ReadLine();
                }
                Console.Clear();
                Frame.Title();
                if (playerScore > cpuScore)
                {
                    Frame.BuildWin();
                }
                else
                {
                    Frame.BuildLose();
                }
                Console.ResetColor();
                Console.SetCursorPosition(36, 13);
                Console.Write("Press 'ENTER' to play again ");
                Console.ReadLine();
            }
        }
    }
}

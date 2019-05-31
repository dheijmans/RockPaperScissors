using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Frame
    {
        internal static void Title()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(@"   __               _        ___                            __        _                             
  /__\  ___    ___ | | __   / _ \ __ _  _ __    ___  _ __  / _\  ___ (_) ___  ___   ___   _ __  ___ 
 / \// / _ \  / __|| |/ /  / /_)// _` || '_ \  / _ \| '__| \ \  / __|| |/ __|/ __| / _ \ | '__|/ __|
/ _  \| (_) || (__ |   <  / ___/| (_| || |_) ||  __/| |    _\ \| (__ | |\__ \\__ \| (_) || |   \__ \
\/ \_/ \___/  \___||_|\_\ \/     \__,_|| .__/  \___||_|    \__/ \___||_||___/|___/ \___/ |_|   |___/
                                       |_| 
");
            Console.ResetColor();
        }

        internal static void Scores(int playerScore, int cpuScore)
        {
            Console.SetCursorPosition(56, 7);
            Console.WriteLine("┌────────────┐");
            Console.SetCursorPosition(56, 8);
            Console.WriteLine("│   Scores   │");
            Console.SetCursorPosition(56, 9);
            Console.WriteLine("│   You:     │");
            Console.SetCursorPosition(56, 10);
            Console.WriteLine("│   CPU:     │");
            Console.SetCursorPosition(56, 11);
            Console.WriteLine("└────────────┘");
            Console.SetCursorPosition(65, 9);
            Console.WriteLine(playerScore);
            Console.SetCursorPosition(65, 10);
            Console.WriteLine(cpuScore);
        }

        internal static void BuildWin()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(41, 9);
            Console.WriteLine("YOU WON THE GAME!");
        }

        internal static void BuildLose()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(41, 9);
            Console.WriteLine("YOU LOST THE GAME!");
        }
    }
}

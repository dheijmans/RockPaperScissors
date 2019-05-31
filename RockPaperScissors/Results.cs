using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Results
    {
        internal static void RockRock()
        {
            Console.WriteLine(@"    _______                          _______    
---'   ____)                        (____   '---
      (_____)                      (_____)      
      (_____)          vs          (_____)      
      (____)                        (____)      
---.__(___)                          (___)__.---
");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("TIE!");
            Console.ResetColor();
        }

        internal static void RockPaper()
        {
            Console.WriteLine(@"    _______                           _______    
---'   ____)                     ____(____   '---
      (_____)                   (______          
      (_____)        vs        (_______          
      (____)                    (_______         
---.__(___)                       (__________.---
");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("YOU LOSE!");
            Console.ResetColor();
        }

        internal static void RockScissors()
        {
            Console.WriteLine(@"    _______                           _______    
---'   ____)                     ____(____   '---
      (_____)                   (______          
      (_____)        vs        (__________       
      (____)                         (____)      
---.__(___)                           (___)__.---
");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("YOU WIN!");
            Console.ResetColor();
        }

        internal static void PaperRock()
        {
            Console.WriteLine(@"    _______                           _______    
---'   ____)____                     (____   '---
          ______)                   (_____)      
          _______)        vs        (_____)      
        _______)                     (____)      
---.__________)                       (___)__.---
");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("YOU WIN!");
            Console.ResetColor();
        }

        internal static void PaperPaper()
        {
            Console.WriteLine(@"    _______                          _______    
---'   ____)____                ____(____   '---
          ______)              (______          
          _______)     vs     (_______          
         _______)              (_______         
---.__________)                  (__________.---
");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("TIE!");
            Console.ResetColor();
        }

        internal static void PaperScissors()
        {
            Console.WriteLine(@"    _______                          _______    
---'   ____)____                ____(____   '---
          ______)              (______          
          _______)     vs     (__________       
         _______)                   (____)      
---.__________)                      (___)__.---
");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("YOU LOSE!");
            Console.ResetColor();
            
        }

        internal static void ScissorsRock()
        {
            Console.WriteLine(@"    _______                           _______    
---'   ____)____                     (____   '---
          ______)                   (_____)      
       __________)        vs        (_____)      
      (____)                         (____)      
---.__(___)                           (___)__.---
");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("YOU LOSE!");
            Console.ResetColor();
        }

        internal static void ScissorsPaper()
        {
            Console.WriteLine(@"    _______                          _______    
---'   ____)____                ____(____   '---
          ______)              (______          
       __________)     vs     (_______          
      (____)                   (_______         
---.__(___)                      (__________.---
");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("YOU WIN!");
            Console.ResetColor();
        }

        internal static void ScissorsScissors()
        {
            Console.WriteLine(@"    _______                          _______    
---'   ____)____                ____(____   '---
          ______)              (______          
       __________)     vs     (__________       
      (____)                        (____)      
---.__(___)                          (___)__.---
");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("TIE");
            Console.ResetColor();
        }

        internal static void InvalidInput()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Invalid Input!");
            Console.ResetColor();
        }
    }
}

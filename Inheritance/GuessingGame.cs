using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Inheritance
{
    public class GuessingGame
    {
        private List<string> clues;
        private Animal correctAnimal;

        public GuessingGame(Animal animal)
        {
            correctAnimal = animal;
            clues = correctAnimal.GetClues();
        }

        public void StartGame()
        {
            Console.Write("Welcome to the Animal Guessing Game!");
            Console.ReadLine();
            Console.Write("I'll give you some clues, and you'll guess the animal.");
            Console.ReadLine();
            Console.Write("First clue! ");

            for (int i = 0; i < clues.Count; i++)
            {
                Console.WriteLine($"This animal {clues[i]}");
                var userAnswer = Console.ReadLine();

                if (userAnswer.Equals(correctAnimal.Name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"That's correct! It's a {correctAnimal.Name}! This animal...");
                    foreach (string clue in clues)
                    {
                        Console.WriteLine($"-{clue}");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry, not quite! Next hint:");
                }
            }
            Console.WriteLine($"Sorry, that's all the hints. It was a {correctAnimal.Name}. This animal...");
            foreach (string clue in clues)
                    {
                        Console.WriteLine($"-{clue}");
                    }
        }
    }
}
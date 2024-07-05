using System;
using System.Collections.Generic;
using System.IO.Compression;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class

            var penguin = new Bird()
            {
                Name = "Penguin",
                Size = "large",
                Habitat = "in Antarctica",
                Call = "'honk honk'",
                CanFly = false,
                IsPet = false,
                IsMigratory = false,
                Color = "black and white",
                Beak = "long and straight"
            };

            var parrot = new Bird()
            {
                Name = "Parrot",
                Size = "medium-sized",
                Habitat = "in the rainforest",
                Call = "'SQUAWK hello SQUAWK'",
                CanFly = true,
                IsPet = true,
                IsMigratory = false,
                Color = "red, yellow, blue and/or green",
                Beak = "short, thick, and curved"
            };

            var rattlesnake = new Reptile()
            {
                Name = "Rattlesnake",
                Size = "long",
                Habitat = "in the desert",
                Legs = 0,
                IsVenomous = true,
                Scales = "rough scales",
                ActiveTime = "day",
                SpecialThings = "Its tail can make a sound as a warning"
            };

            var turtle = new Reptile()
            {
                Name = "turtle",
                Size = "medium-sized",
                Habitat = "near water",
                Legs = 4,
                IsVenomous = false,
                Scales = "a tough and thick shell",
                ActiveTime = "day",
                SpecialThings = "goes through a sort of hibernation in the winter",
            };


            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
             List<GuessingGame> games = new List<GuessingGame>();

             games.Add(new GuessingGame(parrot));

             games.Add(new GuessingGame(turtle));

             games.Add(new GuessingGame(penguin));

             games.Add(new GuessingGame(rattlesnake));

             string userInput;
             
             foreach (GuessingGame game in games)
             {
                game.StartGame();
                Console.WriteLine("Nice job! Would you like to play another round?");
                userInput = Console.ReadLine();
                if (userInput.ToLower() == "no")
                {
                    Console.WriteLine("Ok, bye!");
                    break;
                }
             }
        }
    }
}

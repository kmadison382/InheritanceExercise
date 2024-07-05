using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
            Legs = 2;
            IsWarmBlooded = true;
            HasWings = true;
        }

        public bool CanFly {get; set;}
        public bool IsPet {get; set;}
        public bool IsMigratory {get; set;}
        public string Color {get; set;}
        public string Beak {get; set;}

        public override List<string> GetClues()
        {
            var clues = base.GetClues();
            clues.Add($"is {Color}");
            clues.Add($"{(CanFly ? "can fly" : "cannot fly")}");
            clues.Add($"{(IsPet ? "can be" : "isn't usually")} a pet.");
            clues.Add($"is {(IsMigratory ? "" : "not")} migratory.");
            clues.Add($"has a {Beak} beak.");
            return clues;
        }
    }
}
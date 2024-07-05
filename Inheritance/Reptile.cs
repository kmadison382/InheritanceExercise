using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
            IsWarmBlooded = false;
            HasWings = false;
            Call = "'hissssss'";
        }

        public bool IsVenomous {get; set;}
        public string Scales {get; set;}
        public bool Tail {get; set;}
        public string ActiveTime {get; set;}
        public string SpecialThings {get; set;}

        public override List<string> GetClues()
        {
            var clues = base.GetClues();
            clues.Add($"{(Tail ? "has" : "doesn't have")} a tail.");
            clues.Add($"is {(IsVenomous ? "" : "not")} venomous.");
            clues.Add($"has {Scales}.");
            clues.Add($"is active during the {ActiveTime}.");
            clues.Add(SpecialThings);
            return clues;
        }
    }    
}
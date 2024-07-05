using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Animal
    {
        public string Name {get; set;}
        public int Legs {get; set;}
        public bool IsWarmBlooded {get; set;}
        public bool HasWings {get; set;}
        public string Call {get; set;}
        public string Size {get; set;}
        public string Habitat {get; set;}
        

        public void GetCall()
        {
            Console.WriteLine(Call);
        }
        public virtual List<string> GetClues()
        {
            List<string> clues = new List<string>()
            {
                $"is {(IsWarmBlooded ? "warm-" : "cold-")}blooded.",
                $"is {Size}.",
                $"{(HasWings ? "has" : "doesn't have")} wings.",
                $"lives {Habitat}",
                $"has {Legs} legs.",
                $"says {Call}."
            };
            return clues;
        }
    }
}
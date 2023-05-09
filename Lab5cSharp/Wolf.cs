using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5cSharp
{
    public class Wolf : Animal
    {
        public string Breed { get; set; }
        public string NaturalHabitat { get; set; }

        public Wolf(double weight, int age, string dailyMaintenanceCost, string breed, string naturalHabitat)
            : base(weight, age, dailyMaintenanceCost)
        {
            Breed = breed;
            NaturalHabitat = naturalHabitat;
        }

        public override string GetInfo()
        {
            return $"Wolf Parametr:\n Breed: {Breed},\n Natural Habitat: {NaturalHabitat},\n {base.GetInfo()}";
        }
    }
}

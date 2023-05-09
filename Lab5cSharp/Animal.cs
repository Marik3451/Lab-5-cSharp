using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5cSharp
{
    public class Animal
    {
        public double Weight { get; set; }
        public int Age { get; set; }
        public string  DailyMaintenanceCost { get; set; }

        public Animal(double weight, int age, string dailyMaintenanceCost)
        {
            Weight = weight;
            Age = age;
            DailyMaintenanceCost = dailyMaintenanceCost;
        }

        public virtual string GetInfo()
        {
            return $"Weight: {Weight} kg,\n Age: {Age} years,\n Daily Maintenance Cost: {DailyMaintenanceCost:C}"+"k";
        }
    }
}

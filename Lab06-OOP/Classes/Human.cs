using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_OOP.Classes
{
    public class Human : Mammal
    {
        public string DrivesCar()
        {
            return "Vroom Vroom";
        }

        public override bool SleepIsTrue { get => true; }
        public string WearsClothes()
        {
            return "Looking Pretty Fly";
        }

        public override string Eat()
        {
            return "Lets go drink water so we are not hungry and save money to buy bitcoin.";
        }
    }
}

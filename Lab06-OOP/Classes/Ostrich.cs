using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_OOP.Classes
{
    public class Ostrich : Bird
    {
        public override string HowManyEggsDoTheyLay()
        {
            return "Ostriches lay 1 every other day!";
        }
        public override bool CanFly => false;
        public override bool SleepIsTrue { get => true; }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_OOP.Classes
{
    public class SeaTurtle : Reptile
    {
        public override string SkinType { get => "Shell"; }
      
        public override bool SleepIsTrue { get => true; }

        public override string HowManyEggsDoTheyLay()
        {
            return "Sea Turtles lay 110 at a time!";
        }

        


        public bool CanSwim => true;

        
    }
}

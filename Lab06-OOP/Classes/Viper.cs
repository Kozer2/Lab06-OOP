using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_OOP.Classes
{
    public class Viper : Reptile
    {
        public override string HowManyEggsDoTheyLay()
        {
            return "Vipers give live birth!";
        }
        public override bool SleepIsTrue { get => true; }

     
    }

   
}

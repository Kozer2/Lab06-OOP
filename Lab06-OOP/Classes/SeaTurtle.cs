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
        

        public bool CanSwim => true;

        
    }
}

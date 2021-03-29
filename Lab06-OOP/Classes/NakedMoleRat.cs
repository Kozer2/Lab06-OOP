using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_OOP.Classes
{
    public class NakedMoleRat : Mammal
    {
        public override bool SleepIsTrue { get => true; }

        public override string SkinType { get => "Naked"; }

        public override string CanTalk()
        {
            return "Work for the queen!";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_OOP.Classes
{
    public abstract class Animal
    {
        public abstract string SkinType {get; }
        public abstract bool SleepIsTrue { get; }
        public virtual string Eat()
        {
            return "Eat the Food!";
        }

    }
}

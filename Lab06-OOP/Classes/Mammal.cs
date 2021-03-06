using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_OOP.Classes
{
    public abstract class Mammal : Animal
    {
        public virtual bool LiveBirth => true;

        public new string AreTheyWarmOrColdBlooded { get => "Warm Blooded"; }

        public override string SkinType { get => "Hairy"; }



        public virtual string CanTalk()
        {
            return "Mating Noises";
        }

    }
}

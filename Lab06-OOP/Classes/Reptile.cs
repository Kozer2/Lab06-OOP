using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_OOP.Classes
{
    public abstract class Reptile : Animal, ILaysEggs
    {
        public virtual bool WalksOnGround => true;

        /*public virtual bool LaysEggs => true;*/

        public override string SkinType { get => "Scales"; }

        public virtual string HowManyEggsDoTheyLay()
        {
            return "Reptiles lay 5!";
        }

        public new string AreTheyWarmOrColdBlooded { get => "Cold Blooded"; }

        public virtual string IsColdBlooded()
        {
            return "Where's the sun? I am cold!";
        }

    }
}

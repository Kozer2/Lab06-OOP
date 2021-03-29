using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_OOP.Classes
{
    public abstract class Reptile : Animal
    {
        public virtual bool WalksOnGround => true;

        public virtual bool LaysEggs => true;

        public override string SkinType { get => "Scales"; }

        public virtual string IsColdBlooded()
        {
            return "Where's the sun? I am cold!";
        }

    }
}

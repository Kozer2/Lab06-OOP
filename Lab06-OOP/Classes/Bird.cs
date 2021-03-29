using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_OOP.Classes
{
    public abstract class Bird : Animal
    {
        public virtual bool CanFly => true;

        public override string SkinType { get => "Feathers"; }

        public virtual bool LaysEggs => true;

        public virtual string BuildNest()
        {
            return "Collecting sticks for nest";
        }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_OOP.Classes
{
    public interface ILaysEggs
    { 
        public virtual bool LaysEggs => true;

        public virtual string HowManyEggsDoTheyLay()
        {
            return "They lay eggs!";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExamples.AnimalSimulator
{
    public class Animal
    {
        public virtual string Speak()
        {
            return "Animal is Speaking...";
        }

        public virtual string Move() 
        {
            return "Animal is moving...";
        }

        public string Eat()
        {
            return "Animal is eating...";
        }
    }
}

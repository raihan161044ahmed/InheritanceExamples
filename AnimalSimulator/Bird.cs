using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExamples.AnimalSimulator
{
    public  class Bird :Animal
    {
        public virtual string Speak()
        {
            return "Bird is Speaking";
        }
        public virtual string Fly()
        {
            return "Bird is Flying";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExamples.AnimalSimulator
{
    public class Eagle : Bird
    {
        public override string Speak()
        {
            return "Eagle..";
        }

        public virtual string Fly()
        {
            return "Eagle is flying..";
        }
    }
}

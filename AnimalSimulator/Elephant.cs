using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExamples.AnimalSimulator
{
    public class Elephant : Animal
    {
        public override string Speak()
        {
            return "Elephant";
        }

        public override string Move()
        {
            return "Elephant is moving";
        }
    }
}

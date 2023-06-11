using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExamples
{
    public class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Add(int x, int y, int z)
        {
            return x + y+z;
        }
    }
}

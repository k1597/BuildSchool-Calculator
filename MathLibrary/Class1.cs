using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class number
    {
        public double x
        { get; set; }
        public double y
        { get; set; }

        public double plus()
        {
            return x + y;
        }
        public double sub()
        {
            return x - y;
        }
        public double mult()
        {
            return x * y;
        }
        public double division()
        {
            return x / y;
        }
    }
}

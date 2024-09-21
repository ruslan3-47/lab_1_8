using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_8
{
    abstract class Klass
    {
        public abstract double Resh(Func<double,double>f,double lowerbound,double upperbound, int n);
    }
}

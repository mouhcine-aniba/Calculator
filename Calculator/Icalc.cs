using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal interface Icalc
    {
        double addition(double a,double b);
        double addition(List<double> vals);

        double Substraction(double a, double b);
        double Multiplication(double a, double b);
        double Division(double a, double b);
        double SquareRoot(double a, double b);

    }
}

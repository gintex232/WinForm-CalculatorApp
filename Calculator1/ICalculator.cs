using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator1
{
    public interface ICalculator
    {
        double Addition(double num1, double num2);
        double Subtraction (double num1, double num2);
        double Multiplication (double num1, double num2);
        double Divide (double num1, double num2);

    }
}

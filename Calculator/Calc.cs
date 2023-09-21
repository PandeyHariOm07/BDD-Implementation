using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calc
    {
        public int AddNumber(int num1,int num2)
        {
            return num1 + num2;
        }
        public int Subtract(int num1,int num2)
        {
            return num1 - num2;
        }
        public int divide(int num1,int num2)
        {
            if (num1 == 0 || num2 == 0) return 0;
            return num1 / num2;
        }
    }
}

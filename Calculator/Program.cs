using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            int res = calc.Add(calc.Mul(2, 4), calc.Sub(10, 8));

            Console.WriteLine("8 + 2 = " + res);
        }
    }
}

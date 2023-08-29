using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;

namespace Project_16._7._1_
{
    public class Calculator
    {
        public int Additional(int a, int b)
        {
            return a + b;
        }

        public int Subtraction(int a, int b)
        {
            return a - b;
        }

        public int Miltiplication(int a, int b)
        {
            return a * b;
        }

        public int Division(int a, int b)
        {
            return a / b;
        }
    }
}

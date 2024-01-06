using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console6
{
    public class Program
    {
         public static void Main(string[] args)
        { 
            //Instantiate Mathops
            Operation mathOps = new Operation();
            int firstInterger = 5;
            int secondInterger = 10;
            mathOps.MathOps(firstInterger, secondInterger);
            mathOps.MathOps(num1: 7, num2: 15);
        }

    }
}

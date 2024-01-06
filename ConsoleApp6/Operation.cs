using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    //Create a class
    public class Operation
    {
        //create a void method within the class

        public void MathOps(int num1, int num2)
        { 

        //Perform math operation on the first integer

        num1 = num1* 2;

        Console.WriteLine($"The result of the operation on the first integer is:{num1}");
        Console.WriteLine($"The second integer is {num2}");
        Console.ReadLine();
        }

    }
}

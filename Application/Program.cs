using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonMethods;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber first = new ComplexNumber(3,5);
            ComplexNumber second = new ComplexNumber(-7, 10);
            ComplexNumber resultant = MathLibrary.ComplexAddition(first, second);
            Console.WriteLine("The first complex number is: "+first+"\nThe second complex number is: "+second+"\nThe resultant compex number is "+ resultant);
            Console.Read();
        }
    }
}

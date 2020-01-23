using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// This namespace consists of all required class libraries which are commonly  used in programming. For example it contins MathLibrary which consists of methods to do basic arithmetic operations
/// </summary>
namespace CommonMethods
{
  /// <summary>
  /// This libray is used to find the methods related to mathe,arithmetical operations like addition,multiplication and complex addition etc...s 
  /// </summary>
    public class MathLibrary
    {
        /// <summary>
        /// This method is used to divide two int type number.The first argument is divident and the second parameter is divisor.
        /// </summary>
        /// <param name="a">This should be an integer</param>
        /// <param name="b">This should be an integer</param>
        /// <returns>This method returns an integer</returns>
        /// <exception cref="System.DivideByZeroException"></exception>
        public static int Division(int a, int b)
        {
            if (b == 0)
            {
                throw new System.DivideByZeroException();
            }
            return a / b;
        }
        /// <summary>
        /// This method is used to add two int type numbers.
        /// </summary>
        /// <param name="a">This should be an integer</param>
        /// <param name="b">This should be an integer</param>
        /// <returns>This method returns an integer</returns>
        /// <exception cref="System.OverflowException"></exception>
        public static int Addition(int a, int b)
        {
            long IntermediateResult = (long)a + (long)b;
            if (IntermediateResult > int.MaxValue || IntermediateResult < int.MinValue)
                throw new System.OverflowException("The result is overflowing the int type");
            return a + b;
        }
        /// <summary>
        /// This method is used to do substraction operation betweem two int types.
        /// Second parameter is substracted from first parameter
        /// </summary>
        /// <param name="a">This should be an integer</param>
        /// <param name="b">This should be an integer</param>
        /// <returns>This method returns an int type</returns>
        /// <exception cref="System.OverflowException"></exception>

        public static int Substraction(int a, int b)
        {
            long IntermediateResult = (long)a - (long)b;
            if (IntermediateResult > int.MaxValue || IntermediateResult < int.MinValue)
                throw new System.OverflowException();
            return a - b;
        }
        /// <summary>
        /// This method is used to multiply two int types
        /// </summary>
        /// <param name="a">This should be of type integer</param>
        /// <param name="b">This should be of type integer</param>
        /// <returns>This method will return an integer type</returns>
        /// <exception cref="System.OverflowException"></exception>
        public static int Multiplication(int a, int b)
        {
            long IntermediateResult = (long)a * b;
            if (IntermediateResult > int.MaxValue || IntermediateResult < int.MinValue)
                throw new System.OverflowException("The result is overflowing the integer type");
            return a - b;

        }
        ///<summary>
        ///This is a method used to add two complex numbers. 
        ///It only accepts integer types for real and imaginary parts of the complex numbers
        ///</summary>
        ///<param name="firstNum">This should be of the type CommomnMethods.ComplexNumber</param>
        ///<param name="secondNum">This should be of the type CommomnMethods.ComplexNumber</param>
        ///<returns>This method will return a CommonMethods.ComplexNumber</returns>
        ///<see cref="CommonMethods.ComplexNumber"></see>
        ///<exception cref="System.OverflowException">This exception is raised if either real part or imaginary part of resultant complexnumber overflows the integer type</exception>
        ///<example>
        ///<code>
        ///ComplexNumber firstComplexNumber=new ComplexNumber(2,7);
        ///ComplexNumber secondComplexNumber=new ComplexNumber(4,6);
        ///ComplexNumber resultantComplexNumber=MathLibrary.Addition(fistComplexNumber,secondcomplexNumber);
        ///Console.WriteLine(resultantComplexNumber.ToString());
        ///</code>
        ///</example>
        public static ComplexNumber ComplexAddition(ComplexNumber firstNum, ComplexNumber secondNum)
        {
            return new ComplexNumber(MathLibrary.Addition(firstNum.getReal(),secondNum.getReal()),MathLibrary.Addition(firstNum.getImaginary(),secondNum.getImaginary()));
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch04Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            //string comparison;
            //Console.WriteLine("enter a number:");
            //double var1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("enter another number:");
            //double var2 = Convert.ToDouble(Console.ReadLine());
            //if (var1 < var2)
            //    comparison = "less than";
            //else
            //{
            //    if (var1 == var2)
            //        comparison = "equal to";
            //    else
            //        comparison = "greater than";
            //}
            //Console.WriteLine("the first number is {0} the second number.",
            //                  comparison);
            //Console.ReadKey();



            String comparsion;
            Console.WriteLine("Please Enter a number:");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Enter other number:");
            double number2 = Convert.ToDouble(Console.ReadLine());


            // if -else(2022-0104)
            #region
            //if (number1>number2)
            //{
            //    comparsion = "greater than";
            //}
            //else
            //{
            //    if (number1 < number2)

            //        comparsion = "less than";
            //    else
            //        comparsion = "equal to";

            //}
            //Console.WriteLine("the number1 is {0} number2", comparsion);
            // if -else(2022-0103)
            #endregion

            // if -else if(2022-0104)
            if (number1 > number2)
            {

                comparsion = "greater than";
            }

            else if (number1 < number2)
            {
                comparsion = "less than";

            }
            else
            {
                comparsion = "equal to";
            }

            Console.WriteLine("the number1 is {0} number2", comparsion);











        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch04Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance, interestRate, targetBalance;
            Console.WriteLine("What is your current balance?");
            balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your current annual interest rate (in %)?");
            interestRate = 1 + Convert.ToDouble(Console.ReadLine()) / 100.0;
            Console.WriteLine("What balance would you like to have?");
            targetBalance = Convert.ToDouble(Console.ReadLine());
            int totalYears = 0;
            do
            {
                balance *= interestRate;
                ++totalYears;
            }
            while (balance < targetBalance);
            Console.WriteLine("In {0} year{1} you'll have a balance of {2}.",
                              totalYears, totalYears == 1 ? "" : "s", balance);
            Console.ReadKey();


            //(switch-case-break;2022-0104);
            #region
            //const string my_Favorite_Fruit = "apple";
            //const string he_Favorite_Fruit = "banana";
            //const string she_Favorite_Fruit = "orange";

            //Console.WriteLine("Please Enter Your Favorite Fruit:");
            //string fruit = Convert.ToString(Console.ReadLine());

            //switch(fruit.ToLower())
            //{
            //    case my_Favorite_Fruit:
            //        Console.WriteLine("I like it too!!!");
            //        break;
            //    case he_Favorite_Fruit:
            //        Console.WriteLine("He likes it too!!!");
            //        break;
            //    case she_Favorite_Fruit:
            //        Console.WriteLine("She likes it too!!!");
            //        break;

            //}

            //Console.WriteLine("Hello {0},Good morning!!!",fruit);
            //Console.ReadKey();
            #endregion

            //(for循环，1-100加法，1-15乘法总和)；
            #region
            //int multiplication = 1;
            //int sum = 0;
            //for (int i=1; i<101; i++)
            //{

            //sum += i;       
            ////multiplication *=  i;
            ////Console.WriteLine(multiplication);
            //Console.WriteLine(sum);
            ////Console.ReadKey();
            //}
            #endregion

            //(do-while循环);
            #region
            //int i = 1;
            //do
            //{
            //    Console.WriteLine("{0}", i++);
            //}
            //while (i <= 10);
            #endregion

            //(While循环，2022-0104);
            #region
            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("{0}", i++);
            //}
            #endregion

            //(for循环，2022-0104）；
            #region
            //int i;
            //for(i=1; i<=10;i++)
            //{
            //    Console.WriteLine("{0}",i);
            //}
            #endregion









        }
    }
}

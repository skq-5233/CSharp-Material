using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] friendNames = { "Robert Barwell", "Mike Parry",
            //                         "Jeremy Beacock" };
            //int i;
            //Console.WriteLine("Here are {0} of my friends:",
            //                  friendNames.Length);


            //foreach循环(2022-0107)；
            //foreach(string friendName in friendNames)
            //{
            //    Console.WriteLine(friendName);
            //}
            //for (i = 0; i < friendNames.Length; i++)
            //{
            //    Console.WriteLine(friendNames[i]);
            //}
            //Console.ReadKey();



            //数组使用(20220-0107)；
            //string[] workDays = { "Monday", "Tuesday", "Wednesday ", "Thursday", "Friday", "Saturday", "Sunday" };
            //int j;
            //Console.WriteLine("There are {0} days in a week", workDays.Length);

            //foreach循环(只读操作，不改变数组的数值大小，2022-0107)；
            //foreach(string workDay in workDays)
            //{
            //    Console.WriteLine(workDay);
            //}

            //for (j = 0; j < workDays.Length; j++)
            //{
            //    Console.WriteLine("The index of {0} is {1}", j, workDays[j]);
            //}
            //Console.ReadKey();

            //foreach 循环（2022-0111）；
            //string[] workMonths = { "January", "February", "March" , "April" , " May", "June", "July", "August", "September" , "October" , "November", "December" };
            //Console.WriteLine("There are {0} months in a year",workMonths.Length);
            //foreach(string workMonth in workMonths)
            //{
            //    Console.WriteLine(workMonth);
            //}
            //Console.ReadKey();

            //多维数组（2022-0111）；
            //double[,] hillhight = { { 1, 2, 3, 4 }, { 2, 3, 4, 5 }, { 3, 4, 5, 6 } };//与上述数组大小一样，也是3行四列；
            //foreach(double height in hillhight)
            //{
            //    Console.WriteLine("{0}",height);
            //}

            //但不能采用这种方式为各字符赋值，若要获取可写char数组，使用数组变量ToCharArray()命令；
            //string myString = "A string";
            //char[] myChars = myString.ToCharArray();
            //此时，即可处理char数组，也可在foreach循环中使用字符串，
            //foreach (char character in myString)
            //{
            //    Console.WriteLine("{0}", character);
            //}
            //Console.ReadKey();

            //还可使用myString.Length获取元素个数，
            //string myString = Console.ReadLine();
            //Console.WriteLine("You typed{0} characters.", myString.Length);

            //<string>.ToLower；字符串转换成小写；
            //<string>.ToUpper；字符串转换成大写；
            Console.WriteLine("请输入单词:");
            string userResponse = Console.ReadLine();
            if (userResponse.ToLower() == "yes")
            {
                //Act on response.
            }
            userResponse = userResponse.ToLower();
            //userResponse.ToLower();
            Console.WriteLine("转化后的小写单词是：{0}", userResponse);
            Console.ReadKey();
        }
    }
}

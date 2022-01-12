using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber, secondNumber;
            string userName;
            Console.WriteLine("Enter your name:");
            userName = Console.ReadLine();
            Console.WriteLine("Welcome {0}!", userName);
            Console.WriteLine("Now give me a number:");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Now give me another number:");
            secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The sum of {0} and {1} is {2}.", firstNumber,
                        secondNumber, firstNumber + secondNumber);
            Console.WriteLine("The result of subtracting {0} from {1} is {2}.",
                        secondNumber, firstNumber, firstNumber - secondNumber);
            Console.WriteLine("The product of {0} and {1} is {2}.", firstNumber,
                        secondNumber, firstNumber * secondNumber);
            Console.WriteLine("The result of dividing {0} by {1} is {2}.",
                        firstNumber, secondNumber, firstNumber / secondNumber);
            Console.WriteLine("The remainder after dividing {0} by {1} is {2}.",
                        firstNumber, secondNumber, firstNumber % secondNumber);
            Console.ReadKey();

            //关系、逻辑运算符；
            Console.WriteLine("Hello C# World!");//打印Hello C# World!;
            Console.ReadKey();
            Console.WriteLine("请输入你的语文成绩：");
            //string str_chinese = Console.ReadLine();
            //int chinese = Convert.ToInt32(str_chinese);//将字符串str_chinese转化为整型chinese(int32);
            double chinese = Convert.ToDouble(Console.ReadLine());//结果同上两行代码一样；
            //double chinese = Convert.ToDouble(str_chinese);//将字符串str_chinese转化为双精度浮点型chinese(double);
            Console.WriteLine("请输入你的数学成绩：");
            string str_math = Console.ReadLine();
            //int math = Convert.ToInt32(str_math);//将字符串str_math转化为整型math(int32);
            double math = Convert.ToDouble(str_math);//将字符串str_math转化为双精度浮点型math(double);
            Console.WriteLine("请输入你的英语成绩：");
            string str_english = Console.ReadLine();
            //int english = Convert.ToInt32(str_english);//将字符串str_english转化为整型english(int32);
            double english = Convert.ToDouble(str_english);//将字符串str_english转化为双精度浮点型english(double);
            double sum = chinese + math + english;
            double avg = sum / 3;
            Console.WriteLine("你的三大科总成绩是{0}，平均成绩是{1}", sum, avg);
            Console.ReadKey();
            bool b = chinese > 90 && math > 90 && english > 90;//逻辑与（bool类型）；
            Console.WriteLine(b);
            Console.ReadKey();
            bool b1 = chinese > 90 || math > 90 || english > 90;//逻辑或（bool类型）；
            Console.WriteLine(b1);
            Console.ReadKey();
            bool b2 = chinese != 90;//逻辑非（bool类型）；
            Console.WriteLine(b2);
            //add(2021-1222)

            //add算数运算符(2021-1223)
            double chinese1, math1;
            string name;
            Console.WriteLine("请输入你的名字：");
            name = Console.ReadLine();
            Console.WriteLine("你好！{0}，欢迎你！！！", name);
            Console.WriteLine("请输入你的语文成绩：");
            chinese1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入你的数学成绩：");
            math1 = Convert.ToDouble(Console.ReadLine());
            double sum1 = chinese + math;
            Console.WriteLine("你的考试总成绩为：{0}", sum1);
            double sub = Math.Abs(chinese - math);
            double avg1 = sum / 2;
            Console.WriteLine("你的语文、数学平均成绩为{0}", avg1);
            Console.WriteLine("你的语文、数学成绩差值为：{0}", sub);
            double product = chinese * math;
            Console.WriteLine("你的语文、数学成绩乘积值为:{0}", product);
            double divide = chinese / math;
            Console.WriteLine("你的语文成绩是数学成绩的{0}倍", divide);
            double divide1 = chinese % math;
            Console.WriteLine("你的语文成绩除数学成绩的余数为{0}", divide1);
            Console.ReadKey();
            //add(2021-1223)

            //判断年份是否为闰年(2021-1223)；
            //int year;
            Console.WriteLine("请输入要判断的年份：");
            int year = Convert.ToInt32(Console.ReadLine());
            bool b3 = (year % 400) == 0 || (year % 4 == 0 && year % 100 != 0);//逻辑与的优先级妖高于逻辑或；
            Console.WriteLine(b3);
            //使用 if esle判断语句；
            if (b3 == true)
            {
                Console.WriteLine("{0}是闰年", year);
            }
            else
            {
                Console.WriteLine("{0}是平年", year);
            }

            Console.ReadKey();
            //add(2021-1223)
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "This is a test.";
            //char[] separator = {' '};
            //string[] myWords;
            //myWords = myString.Split(separator);//通过''及Split分割字符串；
            //foreach (string word in myWords)
            //{
            //    Console.WriteLine("{0}", word);
            //}
            //Console.ReadKey();

            //string str;
            //Console.WriteLine("请输入任意字符串：");
            //str = Convert.ToString(Console.ReadLine());//接收用户输入的字符串
            ////char[] thechar = str.ToCharArray();//将字符串转换成数组
            //Console.WriteLine("你一共输入了{0}个字符", str.Length);//.Length表示该数组或字符串中的字符总数

            //Console.WriteLine("顺序是:");
            //int j = 1;
            //for (int i = 0; i < str.Length; i++)//注意i不能<=str.Length,如果str是5个字符的话,i就会试图访问下标为5的字符,而字符的下标是从0开始的.
            //{
            //    Console.WriteLine("第{0}个是{1}", j, str[i]);
            //    j++;
            //}

            //Console.WriteLine("逆顺是:");
            //int x = str.Length;
            ////for (int k = str.Length; k => 0; k--)//错误的表达方法
            //for (int k = str.Length - 1; k >= 0; k--)
            //{
            //    Console.WriteLine("第{0}个字符是{1}", x, str[k]);
            //    x--;
            //}

            //Console.WriteLine("Enter a string:");
            //string myString = Console.ReadLine();
            //string reversedString = "";
            //for(int index = myString.Length-1; index>=0; index--)
            //{
            //    reversedString += myString[index];
            //}
            //Console.WriteLine("Reversd:{0}", reversedString);
            //Console.ReadKey();


            //字符串逆序打印（2022-0112）；
            //Console.WriteLine("Enter a number or string");
            //string myString = Console.ReadLine();
            //string reversedString = "";
            //for (int index = myString.Length - 1; index >= 0; index--)
            //{
            //    reversedString += myString[index];
            //}
            //Console.WriteLine("逆序打印结果是：{0}", reversedString);
            //Console.ReadKey();


            //字符串替换(Replace,2022-0112)；
            //case1:
            //Console.WriteLine("Enter a string:");
            //string myString = Console.ReadLine();
            //myString = myString.Replace("no", "yes");
            //Console.WriteLine("转换后的字符串是{0}", myString);
            //Console.ReadKey();

            //case2(给字符串加双引号):
            Console.WriteLine("Enter a string:");
            string myString = Console.ReadLine();
            myString = "\"" + myString.Replace(" ", "\" \"")+ "\"";
            Console.WriteLine("转换后的字符串是{0}", myString);
            Console.ReadKey();





        }
    }
}

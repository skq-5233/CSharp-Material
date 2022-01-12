using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05Ex03
{
    enum orientation : byte
    {
        north = 1,
        south = 2,
        east = 3,
        west = 4
    }

    struct route
    {
        public orientation direction;
        public double distance;
    }

    class Program
    {
        static void Main(string[] args)
        {
            //route myRoute;
            //int myDirection = -1;
            //double myDistance;
            //Console.WriteLine("1) North\n2) South\n3) East\n4) West");
            //do
            //{
            //    Console.WriteLine("Select a direction:");
            //    myDirection = Convert.ToInt32(Console.ReadLine());
            //}
            //while ((myDirection < 1) || (myDirection > 4));
            //Console.WriteLine("Input a distance:");
            //myDistance = Convert.ToDouble(Console.ReadLine());
            //myRoute.direction = (orientation)myDirection;
            //myRoute.distance = myDistance;
            //Console.WriteLine("myRoute specifies a direction of {0} and a " +
            //   "distance of {1}", myRoute.direction, myRoute.distance);
            //Console.ReadKey();

            //(数组使用,2022-0107--start);
            string [] friendNames = { "jack", "black", "michael" };
            int i;
            Console.WriteLine("Here are {0} of my friends:",friendNames.Length);
            for (i = 0; i < friendNames.Length; i++) 
            {

                Console.WriteLine("Name with index of {0}: {1}",i, friendNames[i]);
            }
            Console.ReadKey();
            //(数组使用,2022-0107--end);
        }
    }
}
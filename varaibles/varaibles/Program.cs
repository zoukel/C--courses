using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace varaibles
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int x;

            int y;

            int a;

            x = 10;

            y = x * 2;

            a = y + x;

            Console.WriteLine(a);
            Console.ReadKey();*/

            /*Console.WriteLine("what is your name ?");
            Console.Write("Enter Your First Name :");
            string MyFirstName;
            MyFirstName = Console.ReadLine();
            Console.Write("Enter Your LastName :");
            string MyLastName;
            MyLastName = Console.ReadLine();
            Console.Write("Enter Your Age :");
            int Age;
            Age = int.parse(Console.ReadLine());
            Console.WriteLine("Hello" + " " + MyFirstName + " " + MyLastName "Your Age " + Age);
            Console.WriteLine("you Wellcom");
            Console.ReadKey();
            */

            Console.Write("Enter First Number :");

            int myFirstNumber = int.Parse (Console.ReadLine());

            Console.Write("Enter second Number :");

            int mySecondNumber = int.Parse(Console.ReadLine());

            int sum = myFirstNumber + mySecondNumber;

            int sum1 = myFirstNumber * mySecondNumber;

            int sum2 = myFirstNumber - mySecondNumber;

            int sum3 = myFirstNumber / mySecondNumber;

            Console.WriteLine("the Summation Is :" + sum);
            Console.WriteLine("the Summation Is :" + sum1);
            Console.WriteLine("the Summation Is :" + sum2);
            Console.WriteLine("the Summation Is :" + sum3);


            Console.ReadKey();







        }
    }
}

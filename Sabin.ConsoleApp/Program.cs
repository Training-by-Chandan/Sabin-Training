using System;

namespace Sabin.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var res = "n";
            do
            {
                //CastingExample();

                //Test();

                //LoopingStatementExamples();

                //CheckEvenOrOdd();

                ControlStatmentExample();

                Console.WriteLine("Do you want to continue more(Y/N)?");
                res = Console.ReadLine();
            } while (res.ToLower() == "y");

            Console.ReadLine();
        }

        private static void ControlStatmentExample()
        {
            Console.WriteLine("Enter the day Number");
            var choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Result from If then Else Case");
            var day = "";

            if (choice == 1)
                day = "Sunday";
            else if (choice == 2)
                day = "Monday";
            else if (choice == 3)
                day = "Tuesday";
            else if (choice == 4)
                day = "Wednesday";
            else if (choice == 5)
                day = "Thursday";
            else if (choice == 6)
                day = "Friday";
            else if (choice == 7)
                day = "Saturday";
            else
                day = "Not a Valid Day";

            var type = "";
            if (choice == 1 || choice == 7)
            {
                type = "Weekends";
            }
            else if (choice == 2 || choice == 3 || choice == 4 || choice == 5 || choice == 6)
            {
                type = "Weekdays";
            }
            else
            {
                type = "not a valid type";
            }

            var daynew = choice == 1 ? "Sunday" : choice == 2 ? "Monday" : choice == 3 ? "Tuesday" : choice == 4 ? "Wednesday" : choice == 5 ? "Thurday" : choice == 6 ? "Friday" : choice == 7 ? "Saturday" : "Not a valid day";

            Console.WriteLine("Day = " + day);
            Console.WriteLine("Type = " + type);

            Console.WriteLine("Result from Switch Case");
            var sw_day = "";
            var sw_type = "";

            switch (choice)
            {
                case 1:
                    sw_day = "Sunday";
                    break;

                case 2:
                    sw_day = "Monday";
                    break;

                case 3:
                    sw_day = "Tuesday";
                    break;

                case 4:
                    sw_day = "Wednesday";
                    break;

                case 5:
                    sw_day = "Thursday";
                    break;

                case 6:
                    sw_day = "Friday";
                    break;

                case 7:
                    sw_day = "Saturday";
                    break;

                default:
                    sw_day = "Not a valid day";
                    break;
            }

            switch (choice)
            {
                case 1:
                case 7:
                    sw_type = "Weekend";
                    break;

                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    sw_type = "Weekdays";
                    break;

                default:
                    sw_type = "Not a valid type";
                    break;
            }

            Console.WriteLine("Day = " + sw_day);
            Console.WriteLine("Type = " + sw_type);
        }

        private static void CheckEvenOrOdd()
        {
            //program for checking even or odd
            Console.WriteLine("Enter a number");
            var num = Convert.ToInt32(Console.ReadLine());

            var display = num % 2 == 0 ? "Even Number" : "Odd Number";

            //if (num%2==0)
            //{
            //    display = "Even Number";
            //}
            //else
            //{
            //    display = "Odd Number";
            //}

            Console.WriteLine("The Number you provided is " + display);
        }

        private static void LoopingStatementExamples()
        {
            //for (int i = 0; i < 10; i++)
            //{
            //    var message = "The number i has value " + i;
            //    Console.WriteLine(message);
            //}

            int[] intarr = new int[] { 1, 2, 5, 4, 3, 6, 9, 8, 7, 10, 11, 12, 1, 2, 5, 4, 3, 6, 9, 8, 7, 10, 11, 12, 1, 2, 5, 4, 3, 6, 9, 8, 7, 10, 11, 12, 1, 2, 5, 4, 3, 6, 9, 8, 7, 10, 11, 12, 1, 2, 5, 4, 3, 6, 9, 8, 7, 101, 111, 12, 1, 2, 5, 4, 3, 6, 9, 8, 7, 10, 11, 12, 1, 2, 5, 4, 3, 6, 9, 8, 7, 10, 11, 12, 1, 2, 5, 4, 3, 6, 9, 8, 7, 10, 11, 12 };

            for (int i = 0; i < intarr.Length; i++)
            {
                if (i % 5 == 0)
                {
                    continue;
                }

                if (intarr[i] >= 100)
                {
                    break;
                }

                Console.WriteLine("item in " + i + " index = " + intarr[i]);
            }

            foreach (var i in intarr)
            {
                Console.WriteLine("Items => " + i);
            }

            ////infiinte loop that breaks on only Yes
            //while (true)
            //{
            //    Console.WriteLine("I am in infinite loop");
            //    var result = Console.ReadLine();
            //    if (result == "Yes")
            //    {
            //        break;
            //    }
            //}
        }

        private static int i = 10; //variable
        private const float pi = 3.1415f; //constant

        private static void CastingExample()
        {
            Console.WriteLine("I am from casting");
            //implicit casting
            char c = 'c';
            int i = c;
            short sh = 20;
            i = sh;
            long l = i;
            float f = l;
            double d = f;

            //explicit casting
            double d1 = 10.02d;
            float f1 = (float)d1;
            long l1 = (long)f1;
            int i1 = (int)l1;
            char c1 = (char)i1;

            string s1 = c1.ToString();
            s1 = "1234";

            int i2 = Convert.ToInt32(s1);

            var val = 1.2d;

            var a = 10;
            var b = "";

            object a1 = 10;
            object b1 = "";

            object o = 1;
            //var obj = (string)o;

            //array
            var intarr = new int[2];
            intarr[0] = 10;
            intarr[1] = 20;
            //intarr[2] = 30; //it will surely give error
        }

        private static void Test()
        {
            char ch = 'C';
            string s = "this is me";
            int i = 1;
            decimal d = 1.2m;
            double dbl = 1.2d;
            float f = 1.2f;
            bool b = false;

            Console.WriteLine("I am from Test Function");
        }
    }
}
using System;
using System.Text;

namespace Sabin.ConsoleApp
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var res = "n";
            do
            {
                //StringConcatenationExample();

                //ClassExample();

                ClassExampleV2();

                Console.WriteLine("Want to continue more (y/n)?");
                res = Console.ReadLine();
            } while (res.ToLower() == "y");
            Console.ReadLine();
        }

        private static void ClassExampleV2()
        {
            StudentMarks sabin = new StudentMarks();
            StudentMarks sm = new StudentMarks("Chandan", "Gupta");

            sabin.FirstName = " ";//set
            sabin.LastName = "";//set
            var name = sabin.FirstName;

            Console.WriteLine($"Full Name  => {sabin.FullName}");
            Console.WriteLine($"Initials  => {sabin.Initials}");

            StudentAlternative sabin1 = new StudentAlternative();
            sabin1.FirstName = "Sabin";//set
            sabin1.LastName = "Bhusal";//set

            Console.WriteLine($"Full Name  => {sabin1.FullName}");
            Console.WriteLine($"Initials  => {sabin1.Initials}");
        }

        private static void ClassExample()
        {
            //object are instance of class
            //after instansiation of class, object are born/created
            StudentMarks s1 = new StudentMarks();
            StudentMarks s2 = new StudentMarks();
            StudentMarks s3 = new StudentMarks();
            HondaUnicorn150CC sabinkobike = new HondaUnicorn150CC();
            sabinkobike.OwnerName = "Sabin";
            sabinkobike.Color = "Black";
            HondaUnicorn150CC chandankobike = new HondaUnicorn150CC();
            chandankobike.OwnerName = "Chandan";
            chandankobike.Color = "Grey";

            sabinkobike.Start();
            chandankobike.Start();

            sabinkobike.GetInfo();
            chandankobike.GetInfo();
        }

        private static void StringConcatenationExample()
        {
            //basic concatenation
            string s1 = "Hello!";
            string s2 = "World";
            string s3 = s1 + " " + s2;

            //string formatting
            string s4 = "{0} {1} ({0},{1})";
            string s5 = string.Format(s4, "Sabin", "Bhusal"); //Sabin Bhusal (Sabin,Bhusal)

            Console.WriteLine("With String format Method");
            Console.WriteLine("Enter your name:");
            var name = Console.ReadLine();
            var ran = new Random();
            var number = ran.Next(10000, 99999);
            string template = "Hi {0}, Your OTP is {1}.";
            string message = string.Format(template, name, number);
            Console.WriteLine(message);
            Console.WriteLine("------------------------------------");

            //string interpolation
            Console.WriteLine("With String Interpolation Method");
            Console.WriteLine("Enter your name:");
            name = Console.ReadLine();
            ran = new Random();
            number = ran.Next(10000, 99999);
            string s6 = $"Hi {name}, Your OTP is {number}";
            Console.WriteLine(s6);

            //string builder
            var sb = new StringBuilder();
            sb.AppendLine("Hi,");
            sb.AppendLine("The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. ");
            sb.AppendLine("The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. ");

            sb.AppendLine("The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. ");
            var result = sb.ToString();
            Console.WriteLine(result);
        }
    }
}
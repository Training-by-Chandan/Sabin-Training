using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sabin.ConsoleApp
{
    public class StudentMarks
    {
        //constructor is a special function with no return type and has the same name as of class
        //it is called only once in object's life span
        //we can have multiple constructors
        //if there is more than 1 constructor, then it is Constructor Overloading

        //signature functionname+no parameters
        public StudentMarks()
        {
            Console.WriteLine("A new object is created");
        }

        public StudentMarks(string firstname)
        {
        }

        public StudentMarks(string firstname, string lastname)
        {
            _firstName = firstname;
            _lastName = lastname;
        }

        private int Add(int i)
        {
            i++;
            return i;
        }

        private int Add(int i, int j)
        {
            return i + j;
        }

        public int Add(int i, int j, int k)
        {
            return i + j + k;
        }

        private string _firstName;

        public string FirstName
        {
            get
            {
                return _firstName + ".";
            }
            set
            {
                if (value == "")
                {
                    value = "Default";
                }

                _firstName = value;
            }
        }

        private string _lastName;

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (value == "")
                {
                    value = "Default";
                }
                _lastName = value;
            }
        }

        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        public string Initials
        {
            get { return FirstName.Substring(0, 1) + LastName.Substring(0, 1); }
        }

        ~StudentMarks()
        {
        }
    }

    public class StudentAlternative
    {
        public string FirstName;
        public string LastName;
        public string FullName;
        public string Initials;
    }

    public class HondaUnicorn150CC
    {
        public HondaUnicorn150CC()
        {
        }

        public string OwnerName = "";
        public string Color = "";

        public void Start()
        {
            Console.WriteLine($"{OwnerName} ko Bike started by kick method");
        }

        public void Start(int i)
        {
            Console.WriteLine($"{OwnerName} ko Bike started by self-start method");
        }

        public void Start(string x)
        {
            Console.WriteLine($"{OwnerName} ko Bike started by self-start method");
        }

        public void GetInfo()
        {
            Console.WriteLine($"Owner = {OwnerName}");
            Console.WriteLine($"Color = {Color}");
        }
    }

    public class Human
    {
        public Human()
        {
            Console.WriteLine("Baby is crying");
        }

        public Human(int i)
        {
            Console.WriteLine("Baby is laughing");
        }

        public Human(int i, int j)
        {
            Console.WriteLine("Baby is walking");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sabin.ConsoleApp
{
    public class Human
    {
        //variables
        private int Eyes = 2;

        private int Ears = 2;
        public string Names;

        //properties
        public string FName { get; set; }

        public string LName { get; set; }

        public string Full_Name
        {
            get { return FName + " " + LName; }
        }

        private string fullname;

        public string FullName
        {
            get { return fullname; }
            set { fullname = value; }
        }

        //constructor : Special functions that runs only once in its lifetime (When the object is created)

        //functions / Methods / Actions : can be called anytime and manytime
        public void GetInfo()
        {
            Console.WriteLine("Details of " + FName);
            Console.WriteLine("Number of Eyes = " + Eyes);
            Console.WriteLine("Number of Ears = " + Ears);
            Console.WriteLine("=======================================");
        }

        public void LooseEyes()
        {
            Eyes = Eyes - 1;
        }

        //destructor
    }
}
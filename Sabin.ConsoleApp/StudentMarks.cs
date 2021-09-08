using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sabin.ConsoleApp
{
    public class StudentMarks
    {
    }

    public class HondaUnicorn150CC
    {
        public string OwnerName = "";
        public string Color = "";

        public void Start()
        {
            Console.WriteLine($"{OwnerName} ko Bike started");
        }

        public void GetInfo()
        {
            Console.WriteLine($"Owner = {OwnerName}");
            Console.WriteLine($"Color = {Color}");
        }
    }
}
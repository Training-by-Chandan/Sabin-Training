namespace Sabin.ConsoleApp
{
    public class StudentsMarks
    {
        private int low = 0;
        private int high = 100;
        private int pass = 32;

        public string Name { get; set; }

        //marks should be between higher and lower limit
        private double math;

        public double Math
        {
            get
            {
                return math;
            }
            set
            {
                if (value < 0)
                {
                    math = 0;
                }
                else if (value > 100)
                {
                    math = 100;
                }
                else
                {
                    math = value;
                }
            }
        }

        private double science;

        public double Science
        {
            get { return science; }
            set
            {
                if (value > 100)
                {
                    science = 100;
                }
                else if (value < 0)
                {
                    science = 0;
                }
                else
                {
                    science = value;
                }
            }
        }

        public double Total
        {
            get { return Math + Science; }
        }

        public double Percentage
        {
            get
            {
                return (Total / 2) * (100 / 100);
            }
        }

        public string Division
        {
            get
            {
                var percent = Percentage;
                if (percent > 80)
                {
                    return "Distinction";
                }
                else if (percent > 60)
                {
                    return "First Division";
                }
                else if (percent > 45)
                {
                    return "Second Division";
                }
                else if (percent > 32)
                {
                    return "Third Division";
                }
                else
                {
                    return "Fail";
                }
            }
        }
    }
}
using System;

namespace Date_of_Birth
{

    class Person
    {
    
        public string LastName { get; set; }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string SuffixName { get; set; }
        public string Month { get; set; }
        public int Day { get; set; }
        public int Year { get; set; }

        public void student (string fname, string lastname, string mname, string sname, string fullname)
        {
            this.FirstName = fname;
            this.LastName = lastname;
            this.SuffixName = sname;
            this.MiddleName = mname;

            fullname = (lastname + fname + mname + mname);
        }
        public void birthday (string month, int day, int year)
        {
            this.Month = month;
            this.Day = day;
            this.Year = year;

            if (Year > 1920 || Year <= 2020)
            {
                Console.WriteLine("Year: " + Year);
            }
            else
                Console.WriteLine("Invalid");
        }

    }


    }
    class Program
    {
        static void Main(string[] args)
        {
        
            
        }
    }


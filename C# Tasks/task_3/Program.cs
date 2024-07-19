using System;

namespace task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            employee[] Emparr =
            {
                new employee(123, "ahmed", Gender.Male, new Hiring_date(2024,7,15)),
                new employee(124, "mohamed", Gender.Male, new Hiring_date(2024,6,15)),
                new employee(125, "omnia", Gender.Female, new Hiring_date(2024,4,15))
            };
            foreach(var emp in Emparr)
            {
                Console.WriteLine(emp);
            }
        }
    }
    struct employee
    {
        private int ID;
        private string Name;
        private Gender Gend;
        private Hiring_date Hiring;
        public employee(int  ID, string Name, Gender Gend, Hiring_date Hiring)
        {
            this.ID = ID;
            this.Name = Name;
            this.Gend = Gend;
            this.Hiring = Hiring;            
        }
        public int id
        {
            get
            {
                return ID;    
            }
            set {
                this.ID = value;
            }
        }
        public string name
        {
            get
            {
                return Name;
            }
            set
            {
              this.Name = value;
            }
        }
        public Gender gend
        {
            get
            {
                return Gend;
            }
            set
            {
                this.Gend = value;
            }
        }
        public Hiring_date hiring
        {
            get { 
            return Hiring;
            }
            set
            {
                this.Hiring = value;
            }
        }
        public override string ToString()
        {
            return $"emp_name: {name}\n" +
                   $"emp_id: {id}\n" +
                   $"emp_gender: {Gend}\n" +
                   $"{Hiring.Year}/{Hiring.Month}/{Hiring.Day}\n";
        }
    }
    enum Gender
    {
        Male,
        Female
    }
    struct Hiring_date
    {
        private int year;
        private int month;
        private int day;
        public Hiring_date(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }
        public int Year
        {
            get => year;
            set
            {
                this.year = value;
            }
        }
        public int Month
        {
            get => month;
            set
            {
                this.month = value;
            }
        }
        public int Day
        {
            get => day;
            set
            {
                this.day = value;
            }
        }
        public override string ToString()
        {
            return $"{year}/{month}/{day}";
        }
    }

}

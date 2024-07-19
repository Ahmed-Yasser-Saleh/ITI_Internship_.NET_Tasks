using System;

namespace task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            employee[] Emparr =
            {
                new HR(123, "ahmed", Gender.Male, new Hiring_date(2024,7,15)),
                new HR(124, "mohamed", Gender.Male, new Hiring_date(2024,6,15)),
                new Developer(125, "omnia", Gender.Female, new Hiring_date(2024,4,15),"c#")
            };
         //   Emparr[0].name = "saleh";
            foreach(var emp in Emparr)
            {
                Console.WriteLine(emp);
            }
        }
    }
    class employee
    {
        private int ID;
        private string Name;
        private Gender Gend;
        private Hiring_date Hiring;
        public employee(int ID, string Name, Gender Gend, Hiring_date Hiring)
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
            set
            {
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
            get
            {
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
    class Hiring_date
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
    class HR : employee
    {
        private const string jobtitle = "HR";
        public HR(int ID, string Name, Gender Gend, Hiring_date Hiring):base(ID, Name, Gend, Hiring)
        {

        }
        public Hiring_date Hire()
        {
            return hiring;
        }
        public override string ToString()
        {
            return $"jobtitle: {jobtitle}\n" + base.ToString();
        }
    }
    class Developer : employee
    {
        private const string jobtitle = "Developer";
        private string program;
        public string programming
        {
            get
            {
                return program;
            }
            set
            {
                program = value;
            }
        }
        public Developer(int ID, string Name, Gender Gend, Hiring_date Hiring, string program) : base(ID, Name, Gend, Hiring)
        {
            this.program = program; 
        }
        public void develop()
        {
            Console.WriteLine(program);
        }
        public override string ToString()
        {
            return $"jobtitle: {jobtitle}\n" + $"Develop: {program}\n" + base.ToString();
        }
    }
}

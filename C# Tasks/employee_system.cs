using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            manager[] emp = {

                new manager("ahmed", "manager", 123, 50),
               /* new manager("mhmd","manager", 124, 176),
                new manager("saleh","manager", 125, 176),
                new manager("omnia","manager", 126, 176),*/
            };
            maintenance[] empm = {

                //new maintenance("ahmed", "maintenance", 123, 176),
                new maintenance("mhmd","maintenance", 124, 176),
                /*new maintenance("saleh","maintenance", 125, 176),
                new maintenance("omnia","maintenance", 126, 176),*/
            };

            sales[] emps = {

               /* new sales("ahmed", "sales", 123, 176),
                new sales("mhmd","sales", 124, 176),
                new sales("saleh","sales", 125, 176),*/
                new sales("omnia","sales", 126, 181),
            };
            emps[0].bonus = 50;
            developer[] empd = {

               /* new developer("ahmed", "developer", 123, 176),
                new developer("mhmd","developer", 124, 176),*/
                new developer("saleh","developer", 125, 180),
               // new developer("omnia","developer", 126, 176),
            };
            empd[0].taskcompleted_t = true;
            Console.WriteLine(emps[0]);
            /* foreach (var i in empd)
             {
                 if (i.get_net_salary() != 0)
                 {
                     Console.Write($" for emplyee {i.name} who is {i.jobTitle} the net salary is ");
                     Console.WriteLine(i.get_net_salary());
                 }
                 else
                 {
                     Console.WriteLine("sorry,you must work more hours!!");
                 }
             }*/

        }

    }



    abstract class Employee
    {
        const int requiredHours = 176;
        private double wg;
        public Employee(string name, string jobTitle, int id, float loggedHours)
        {
            this.name = name;
            this.id = id;
            this.loggedHours = loggedHours;
            this.jobTitle = jobTitle;
        }
        public string name { get; private set; }
        public string jobTitle { get; private set; }
        protected int id { get; set; }
        protected double wage
        {
            get
            {
                if (jobTitle == "manager") this.wg = 10;
                else if (jobTitle == "maintenance") this.wg = 9;
                else if (jobTitle == "sales") this.wg = 8;
                else if (jobTitle == "developer") this.wg = 14;
                else {/*NOTHING*/}
                return wg;
            }
        }
        protected double loggedHours { get; set; }
        protected double overtime
        {
            get
            {
                if (loggedHours >= requiredHours)
                    return loggedHours - requiredHours;
                else
                {
                    return 0;
                }
            }
        }
        public double get_basic_salary()
        {
            if (loggedHours >= requiredHours)
                return loggedHours * wage;
            else
                return 0;
        }
        public double get_extraWork_salary() => overtime * wage * 1.25;

    }
    class manager : Employee
    {
        const double allowance_rate = 0.02;
        private double allowance = 0;
        public manager(string name, string jobTitle, int id, float loggedHours) : base(name, jobTitle, id, loggedHours)
        {

        }
        public double get_net_salary()
        {
            if (get_basic_salary() != 0)
            {
                allowance = (get_basic_salary() + get_extraWork_salary()) * allowance_rate;
                return Math.Round(get_basic_salary() + allowance + get_extraWork_salary(), 2);
            }
            else
            {
                return 0;
            }
        }
        public override string ToString()
        {
            return $"jobtitle: {jobTitle}\n" +
                $"name: {name}\nid: {id}\nloggedhours: {loggedHours}\nwage: {wage}\nbasesalary: {get_basic_salary()}\n" +
                $"extraworksalary: {get_extraWork_salary()}\n" +
                $"bonus: {(get_basic_salary() + get_extraWork_salary()) * allowance_rate}\n" +
                $"netsalary: {get_net_salary()}";
        }
    }
    class maintenance : Employee
    {
        const double Hardship = 100;
        public maintenance(string name, string jobTitle, int id, float loggedHours) : base(name, jobTitle, id, loggedHours)
        {

        }
        public double get_net_salary()
        {
            if (get_basic_salary() != 0)
                return Math.Round(get_basic_salary() + Hardship + get_extraWork_salary(), 2);
            else
            {
                return 0;
            }
        }
        public override string ToString()
        {
            return $"jobtitle: {jobTitle}\n" +
                $"name: {name}\nid: {id}\nloggedhours: {loggedHours}\nwage: {wage}\nbasesalary: {get_basic_salary()}\n" +
                $"extraworksalary: {get_extraWork_salary()}\n" +
                $"bonus: {Hardship}\n" +
                $"netsalary: {get_net_salary()}";
        }
    }
    class sales : Employee
    {
        private double bons;
        public sales(string name, string jobTitle, int id, float loggedHours) : base(name, jobTitle, id, loggedHours)
        {

        }
        public double bonus
        {
            get
            {
                return bons;
            }
            set
            {
                this.bons = value;
            }

        }
        public double get_net_salary()
        {
            if (get_basic_salary() != 0)
                return Math.Round(get_basic_salary() + bonus + get_extraWork_salary(), 2);
            else
            {
                return 0;
            }
        }
        public override string ToString()
        {
            return $"jobtitle: {jobTitle}\n" +
                $"name: {name}\nid: {id}\nloggedhours: {loggedHours}\nwage: {wage}\nbasesalary: {get_basic_salary()}\n" +
                $"extraworksalary: {get_extraWork_salary()}\n" +
                $"bonus: {bons}\n" +
                $"netsalary: {get_net_salary()}";
        }
    }
    class developer : Employee
    {
        const double bonus_rate = 0.03;
        private bool taskcompleted = true;
        private double bonus_dev = 0;
        public developer(string name, string jobTitle, int id, float loggedHours) : base(name, jobTitle, id, loggedHours)
        {

        }
        public bool taskcompleted_t
        {
            get
            {
                return this.taskcompleted;
            }
            set
            {
                this.taskcompleted = value;
            }
        }
        public double get_net_salary()
        {
            if (get_basic_salary() != 0)
            {
                if (this.taskcompleted != false)
                {
                    bonus_dev = (bonus_rate) * (get_basic_salary() + get_extraWork_salary());
                }
                else {/*NOTHING*/}
                return Math.Round(get_basic_salary() + bonus_dev + get_extraWork_salary(), 2);
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            if (this.taskcompleted)
            {
                return $"jobtitle: {jobTitle}\n" +
                    $"name: {name}\nid: {id}\nloggedhours: {loggedHours}\nwage: {wage}\nbasesalary: {get_basic_salary()}\n" +
                    $"extraworksalary: {get_extraWork_salary()}\n" +
                    $"bonus: {((get_basic_salary() + get_extraWork_salary()) * (bonus_rate))}\n" +
                    $"netsalary: {get_net_salary()}";
            }
            else
            {
                return $"jobtitle: {jobTitle}\n" +
                       $"name: {name}\nid: {id}\nloggedhours: {loggedHours}\nwage: {wage}\nbasesalary: {get_basic_salary()}\n" +
                       $"extraworksalary: {get_extraWork_salary()}\n" +
                       $"bonus: 0\n" +
                       $"netsalary: {get_net_salary()}";
            }
        }
    }
}


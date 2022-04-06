using System;

namespace EmployeeManagement
{
    interface IPrintable
    {
        void PrintDetails();
    }
    class Employee : IPrintable
    {
        protected string f_Name, l_Name, designation;
        protected float netSalary, grossSalary;

        protected Employee()
        {
            this.f_Name = "";
            this.l_Name = "";
            this.designation = "";
            this.netSalary = 0.0F;
            this.grossSalary = 0.0F;
        }

        protected Employee(string fName, string lName, string designation, float salary)
        {
            this.f_Name = fName;
            this.l_Name = lName;
            this.designation = designation;
            this.netSalary = salary;
        }

        public virtual void CalculateSalary()
        {
           
        }

        public void PrintDetails()
        {
            Console.WriteLine("EMPLOYEE DETAILS:\n");
            Console.WriteLine("Name: {0} {1}", this.f_Name, this.l_Name);
            Console.WriteLine("Designation: {0}", this.designation);
            Console.WriteLine("Net Salary: {0}", this.netSalary);
            Console.WriteLine("Gross Salary: {0}\n", this.grossSalary);
        }
    }

    class Manager : Employee
    {
        private float petrolAllowance, foodAllowance, otherAllowance;

        public Manager(string fName, string lName, string designation, float salary) : base(fName, lName, designation, salary)
        {
            this.petrolAllowance = 0.08F;
            this.foodAllowance = 0.13F;
            this.otherAllowance = 0.03F;
        }

        public override void CalculateSalary()
        {
            grossSalary = (1 + petrolAllowance + foodAllowance + otherAllowance) * netSalary;
        }
    }

    class MarketingExecutive : Employee
    {
        private float kilometerTravel, tourAllowance;
        private int telephoneAllowance;

        public MarketingExecutive(string fName, string lName, string designation, float salary, float kilometers) : base(fName, lName, designation, salary)
        {
            this.kilometerTravel = kilometers;
            tourAllowance = 5 * this.kilometerTravel;
            telephoneAllowance = 1000;
        }

        public override void CalculateSalary()
        {
            grossSalary = netSalary + kilometerTravel + tourAllowance + telephoneAllowance;
        }
    }

    class EmployeeMgmtMain
    {
        static void Main(string[] args)
        {
            Employee obj;
            obj = new Manager("ABC", "Kapoor", "Manager", 65000);
            obj.CalculateSalary();
            obj.PrintDetails();

            obj = new MarketingExecutive("XYZ", "Jain", "Marketing Executive", 55000, 10);
            obj.CalculateSalary();
            obj.PrintDetails();
        }
    }

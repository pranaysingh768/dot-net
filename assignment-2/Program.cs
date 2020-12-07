using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {



            Employee e1 = new Manager();
            Employee e2 = new Manager();

            Manager m1 = new GeneralManager();
            Manager m2 = new GeneralManager();

            Employee c1 = new CEO();
            Employee c2 = new CEO();

            e1.display();
            e2.display();
            Console.WriteLine("-----------------");
            m1.display();
            m2.display();
            Console.WriteLine("------------------");
            c1.display();
            c2.display();
        }
    }


    public abstract class Employee
    {
        private static int incrementEmpNo=0;

        private string name;

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        private int empNo;

        public int EmpNo
        {
            get { return empNo; }
            private set { empNo = value; }
        }

        private short deptNo;

        public short DeptNo
        {
            set { deptNo = value; }
            get { return deptNo; }
        }
        public decimal basic;

        public abstract decimal Basic
        {
            set;
            get;
        }

       

        public Employee()
        {

        }

        public Employee(string name="pranay",short deptNo=10)
        {
            EmpNo = ++incrementEmpNo;
            Name = name;
            DeptNo = deptNo;
           
        }

        public abstract decimal calcNetSalary();

        //public abstract void display();

        public  virtual void  display()
        {
           
           
        }
        public  void print()
        {
            Console.WriteLine("Emp Id :" + EmpNo);
            Console.WriteLine("Name :" + Name);

            Console.WriteLine("Dept No :" + DeptNo);

        }
    }

    public class Manager : Employee
    {
        private string designation;

        public string Designation
        {
            set;
            get;
        }

        

        public Manager():base("ram",10)
        {

            Designation = "mgr";
            Basic = 0;
        }

        public Manager(string designation="manager", string name = "pranay", short deptNo = 10):base(name,deptNo)
        {
            this.designation = designation;
            /*Console.WriteLine("Enter Basic sall ");
            string b = Console.ReadLine();
            Basic = int.Parse(b);*/

        }

       

        public override decimal Basic { 
            get { return basic; }
            set
            {
                if (basic == 0)
                    basic = 4000;

                else
                    basic = value;
            }
        }

        public override decimal calcNetSalary()
        {
            return this.basic + (this.basic * 20);
        }

        public override void display()
        {

            this.print();
            Console.WriteLine("Designation :" + Designation);
            Console.WriteLine("Basic salary :" + Basic);
            Console.WriteLine("Net Salary :" + calcNetSalary());
        }
    }

    public class GeneralManager : Manager
    {
        private string perks;


        public GeneralManager():base("gmgr","sham",20)
        {
            this.perks = "ppp";
            Basic = 0;
        }

        public GeneralManager(string perks,string designation = "manager", string name = "pranay", short deptNo = 10) : base(designation,name, deptNo)
        {
            this.perks = perks;
            Console.WriteLine("Enter Basic sall ");
            string b = Console.ReadLine();
            Basic = int.Parse(b);

        }

        public override decimal Basic
        {
            get { return basic; }
            set {
                if (basic == 0)
                    basic = 5000;

                else
                    basic = value;
            }
        }

        public override decimal calcNetSalary()
        {
            return this.basic + (this.basic * 25);
        }

        public override void display()
        {

            this.print();
            Console.WriteLine("Perks :" + this.perks);
            Console.WriteLine("Designation :" + Designation);
            Console.WriteLine("Basic salary :" + Basic);
            Console.WriteLine("Net Salary :" + calcNetSalary());
           
        }
    }


    public class CEO : Employee
    {
       


        public CEO() : base("ram", 10)
        {
            Basic = 0;
        }

        public CEO(string name = "pranay", short deptNo = 10) : base( name, deptNo)
        {
           
            Console.WriteLine("Enter Basic sall ");
            string b = Console.ReadLine();
            Basic = int.Parse(b);

        }

        public override decimal Basic
        {
            get { return basic; }
            set
            {
                if (basic == 0)
                    basic = 6000;

                else
                    basic = value;
            }
        }

        public override sealed decimal calcNetSalary()
        {
            return this.basic + (this.basic * 30);
        }

        public override void display()
        {
            this.print();
            Console.WriteLine("Basic salary :" + Basic);
            Console.WriteLine("Net Salary :" + calcNetSalary());
        }
    }
}

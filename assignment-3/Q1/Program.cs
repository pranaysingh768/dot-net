using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] arr = new Employee[3];

            for(int i = 0; i < arr.Length; i++)
            {
                arr[i]= new Employee();
                arr[i].input();
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("------------------------------");

            double max = arr[0].Salary;
            int j=-1;
            for(int i = 0; i < arr.Length; i++)
            {
                if (max <= arr[i].Salary)
                {
                    max = arr[i].Salary;
                    j = i;
                }
            }

            Console.WriteLine("Max Salary emp::");
            Console.WriteLine("Emp No :: "+arr[j].EmpNo);
            Console.WriteLine("Emp Name :: " + arr[j].Name);
            Console.WriteLine("Emp Salary :: " + arr[j].Salary);

            Console.WriteLine();
            Console.WriteLine("------------------------------");

            Console.Write("Enter Emp No to search Employee:: ");
            int search = int.Parse(Console.ReadLine());
            bool flag=true;
            for(int i = 0; i < arr.Length; i++)
            {
                if(search == arr[i].EmpNo)
                {
                    flag = false;
                    Console.WriteLine("Emp No :: " + arr[i].EmpNo);
                    Console.WriteLine("Emp Name :: " + arr[i].Name);
                    Console.WriteLine("Emp Salary :: " + arr[i].Salary);
                }
            }
            if (flag)
            {
                Console.WriteLine("Entered EmpNo not found!!!");
            }
            Console.WriteLine();
        }
    }

    public class Employee
    {
        private int empNo;

        public int EmpNo
        {
            get { return empNo; }
        }
        private string name;

        public string Name
        {
            get { return name; }
        }
        private double salary;

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public Employee()
        {

        }

        public Employee(int empNo,string name,double salary)
        {
            this.empNo = empNo;
            this.name = name;
            this.salary = salary;
        }

        public void input()
        {
            Console.Write("Enter Emp No :: ");
            this.empNo = int.Parse(Console.ReadLine());

            Console.Write("Enter Emp Name :: ");
            this.name = Console.ReadLine();

            Console.Write("Enter Emp Salary :: ");
            this.salary = double.Parse(Console.ReadLine());
        }

        public void displayMaxSalary()
        {

        }
    }
}

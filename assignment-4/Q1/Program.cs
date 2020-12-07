using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Q1
{
   class Program
    {
        static void Main()
        {
           
            SortedList<int, Employee> sl = new SortedList<int, Employee>();

            for(int i=1; ;i++)
            {
                Console.Write("You want to enter inputs(Yes/No)::");
                string input = Console.ReadLine();
                if (input.ToLower() == "yes")
                {
                    Employee e = new Employee();
                    e.Inputfun();
                    sl.Add(i, e);
                    
                    continue;

                }
                else
                {

                    break;
                }


            }
            int max = 0;
            int j = 0;
             foreach(KeyValuePair<int,Employee> kp in sl)
             {
                
                if (max < kp.Value.Basic)
                {
                    max = kp.Value.Basic;
                    j = kp.Key;
                    
                }
                 
             }
            Console.WriteLine("======================");
            Console.WriteLine("Emp detail of highest salary");
            Console.WriteLine(sl[j].EmpNo);
            Console.WriteLine(sl[j].Name);
            Console.WriteLine(sl[j].Basic);


            Console.WriteLine("======================");
            Console.WriteLine("Enter emp no to search");
            int ser = int.Parse(Console.ReadLine());
            foreach (KeyValuePair<int, Employee> kp in sl)
            {

                if (ser == kp.Value.EmpNo)
                {
                    Console.WriteLine(kp.Value.EmpNo);
                    Console.WriteLine(kp.Value.Name);
                    Console.WriteLine(kp.Value.Basic);
                }

            }

        }
    }


    public class Employee
    {
        private static int empNoAuto=0;
        private int empNo;
        public int EmpNo
        {
            get { return empNo; }
            set { empNo = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int basic;

        public int Basic
        {
            get { return basic; }
            set { basic = value; }
        }

        public Employee()
        {
            EmpNo = ++empNoAuto;
        }

        public void Inputfun()
        {
           

            Console.Write("Enter Emp Name :: ");
            Name = Console.ReadLine();

            Console.Write("Enter Emp Basic :: ");
            Basic = int.Parse(Console.ReadLine());
        }

        public void display()
        {
            Console.WriteLine("Emp No :: " + EmpNo);
            Console.WriteLine("Name :: "+Name);
            Console.WriteLine("Basic :: "+Basic);
            
        }

    }


   
   
}

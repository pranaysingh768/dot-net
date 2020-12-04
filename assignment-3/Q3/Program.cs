using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] std = new Student[5];

            for(int i = 0; i < std.Length; i++)
            {
                Console.Write("Enter Name :: ");
                string name = Console.ReadLine();
                Console.Write("Enter Marks :: ");
                int marks = int.Parse(Console.ReadLine());

                Student s = new Student(name, marks);
                std[i] = s;
            }

            for(int i = 0; i < std.Length; i++)
            {
                Console.WriteLine(std[i].RollNo);
                Console.WriteLine(std[i].Name);
                Console.WriteLine(std[i].Marks);
                Console.WriteLine();
            }
           
        }
    }

    public struct Student
    {

        private static int roll=0;

        private string name;

        public string Name
        {
            set
            {
                /*if(value.Length > 0)
                {
                    name = value;
                }
                else
                {
                    name = "invalid name";
                }*/

                name = value;
            }

            get
            {
                return name;
            }
        }

        private int rollNo;

        public int RollNo
        {
            set
            {
                rollNo = value;
            }
            get
            {
                return rollNo;
            }
        }

        private decimal marks;

        public decimal Marks
        {
            set
            {
                if(marks < 0)
                {
                    marks = 0;
                }
                else
                {
                    marks = value;
                }
            }
            get { return marks; }
        }
        public Student(string name,decimal marks)
        {
            this.name = name;
            //Name = name;
            this.marks = marks;
           // Marks = marks;
            this.rollNo = ++roll;
        }
            

    }
}

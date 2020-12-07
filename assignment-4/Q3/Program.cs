public namespace Q3{

	class Program{
		
		static void Main()
        {
            List<Employee> emp = new List<Employee>();
            Employee e1 = new Employee(1, "pranay");
            Employee e2 = new Employee(2, "sham");

            emp.Add(e1);
            emp.Add(e2);

            Employee[] err = emp.ToArray();
            foreach(Employee e in err)
            {
                Console.WriteLine(e.EmpNo);
                Console.WriteLine(e.Name);
            }

        }
		
	}
	
	
	  public class Employee
    {
        public int EmpNo
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public Employee(int EmpNo = 1,string Name = "Pranay")
        {
            this.EmpNo = EmpNo;
            this.Name = Name;
        }
       
    }


}    



	

      

    


  
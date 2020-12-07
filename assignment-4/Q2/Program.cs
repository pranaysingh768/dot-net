 public namespace Q2{
	 
	class Program{
		
		static void Main()
        {
            Employee[] emp = new Employee[2];

            emp[0] = new Employee(1, "pranay");
            emp[1] = new Employee(2, "ram");

            List<Employee> el = emp.ToList<Employee>();

            foreach(Employee e in el)
            {
                Console.WriteLine(e.EmpNo);
                Console.WriteLine(e.Name);
            }
        }
		
		
	}


	
    public class Employee
    {
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

        public Employee(int empNo=1,string name="pranay")
        {
            this.EmpNo = empNo;
            this.Name = name;
        }
    }
	
	 
	 
	 
 }
   
   
   
   
    

 

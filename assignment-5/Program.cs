namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {


            //decimal SimpleInterest(decimal P, decimal N, decimal R) -> returns calculated SimpleInterest
            Func<decimal, decimal, decimal, decimal> SimpleInterest = (P, N, R) =>
               {
                   return (P * N * R) / 100;
               };
            Console.WriteLine(SimpleInterest(1000,4,2));



            //bool IsGreater(int a, int b) -> returns true if a is > b
            Func<int, int,bool> IsGreater = (a, b) =>
            {
                if (a > b)
                    return true;
                else
                    return false;
               
            };
           
            Console.WriteLine(IsGreater(1,2));

       
            //decimal GetBasic(Employee e) -> returns the Basic salary of the employee
            Func<Employee, decimal> GetBasic = (e) => { return e.Basic; };

            Console.WriteLine(GetBasic(new Employee("ram", 5000)));

            //bool IsEven(int num) -> returns true if the number is an even number
            Predicate<int> IsEven = (num) => { return num % 2 == 0; };
            Console.WriteLine(IsEven(10));

            // 5. bool IsGreaterThan10000(Employee e) -> returns true if the Basic Salary is > 10000
            Predicate<Employee> IsGreaterThan10000 = (e) => { return e.Basic > 10000; };
            Console.WriteLine(IsGreaterThan10000(new Employee("ram", 50000)));


        }


    }

    public class Employee
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private decimal basic;

        public decimal Basic
        {
            get { return basic; }
            set { basic = value; }
        }

        public Employee(string name="pranay",decimal basic=2000)
        {
            Name = name;
            Basic = basic;
        }


    }
}

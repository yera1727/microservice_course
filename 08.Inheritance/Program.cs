namespace _08.Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee person = new Employee("Xerox", "Carl");
            person.Print();
            person.PrintEmployee();
            Employee employee = new Employee("Apple", "Bob");
            employee.Print();
            employee.PrintEmployee();
        }
    }

    class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }
        public void Print()
        {
            Console.WriteLine(Name);
        }
    }

    class Employee : Person
    {
        public string Company { get; set; }
        public Employee (string company, string name) : base(name)
        {
            Company = company;
        }

        public void PrintEmployee()
        {
            Console.WriteLine($"{Company}, {Name}");
        }
    }
}
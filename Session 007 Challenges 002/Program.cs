namespace Session_007_Challenges_002
{

    class Person
    {
        public Person(string name, int age, string address, string nationality)
        {
            Name = name;
            Age = age;
            Address = address;
            Nationality = nationality;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Nationality { get; set; }
    }

    class Student : Person
    {
        public int StudyLevel { get; set; }
        public string Specilallization { get; set; }
        public double GPA { get; set; }

        public Student(string name, int age, string address, string nationality,int studyLevel,string specilallization, double gPA) 
            : base(name, age, address, nationality)
        {
            this.StudyLevel = studyLevel;
            this.Specilallization = specilallization;
            this.GPA = gPA;
        }
    }

    class Employee : Person
    {
        public double Salary { get; set; }
        public string Rank { get; set; }
        public string Job { get; set; }

        public Employee(string name, int age, string address, string nationality,double salary,string rank,string job) 
            : base(name, age, address, nationality)
        {
            this.Salary = salary;
            this.Rank = rank;
            this.Job = job;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Hussien",30,"KH","Sudaness");
            Student student = new Student("Hussien",30,"KH","Sudaness",6, "specilallization", 80.5);
            Employee employee = new Employee("Hussien",30,"KH","Sudaness",10000,"rank","HR");

            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
            Console.WriteLine(person.Address);
            Console.WriteLine(person.Nationality);
            Console.WriteLine("------------------------------");
            Console.WriteLine(student.StudyLevel);
            Console.WriteLine(student.GPA);
            Console.WriteLine(student.Specilallization);
            Console.WriteLine("------------------------------");
            Console.WriteLine(employee.Salary);
            Console.WriteLine(employee.Rank);
            Console.WriteLine(employee.Job);
        }
    }
}

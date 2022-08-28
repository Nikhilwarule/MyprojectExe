using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace MyprojectExe
{
    public class Employee1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string City { get; set; }
        public override string ToString()
        {
            return $"{Id} {Name} {Salary} {City} ";
        }
    }
    class Empbylambda
    {
        static void Main(string[] args)
        {
            List<Employee1> ep = new List<Employee1>()
            {
              new Employee1 { Id = 1, Name = "Nikhil", Salary = 30799, City = "Pune" },
              new Employee1 { Id = 2, Name = "Rohan", Salary = 43699, City = "Mumbai" },
              new Employee1{ Id = 3, Name = "Ram", Salary = 34799, City = "Nashik" },
              new Employee1 { Id = 4, Name = "Raj", Salary = 45799, City = "Thane" },
              new Employee1 { Id = 5, Name = "Abhi", Salary = 238799, City = "Aurangabad" },
              new Employee1 { Id = 6, Name = "Param", Salary = 53299, City = "Nagar" },
              new Employee1 { Id = 7, Name = "Shubham", Salary = 23999, City = "Akola" },
              new Employee1 { Id = 8, Name = "Aditya", Salary = 42799, City = "Solapur" },
              new Employee1 { Id = 9, Name = "Sandip", Salary = 51799, City = "Jalgaon" },
              new Employee1 { Id = 10, Name = "Rohit", Salary = 19299, City = "Amrawati" },
            };
            //1.display all employee
            var result1 = ep.ToList();
            //2.display employee with ascending order name
            var result2 = ep.OrderBy(p => p.Name).ToList();
            //3.display employee whose salary>25000
            var result3 = ep.Where(p => p.Salary > 25000).ToList();
            //4.display employee pune city
            var result4 = ep.Where(p => p.City == "pune").ToList();
            //5.employee discending order salary
            var result5 = ep.OrderByDescending(p => p.Salary).ToList();
            //6.employee whose name start with p
            var result6 = ep.Where(p => p.Name.StartsWith("p")).ToList();
            //7.display employee salary>25000 and from mumbai
            var result7 = ep.Where(p => p.Salary > 25000 && p.City == "mumbai").ToList();

            foreach (Employee1 input in result7)
            {
                Console.WriteLine(input);
            }


        }
    }
}

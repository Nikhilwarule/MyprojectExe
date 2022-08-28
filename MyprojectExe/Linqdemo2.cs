using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace MyprojectExe
{
    public class Employee
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
    class Linqdemo2
    {
        static void Main(string[] args)
        {
            List<Employee> emp = new List<Employee>()
            {
              new Employee { Id = 1, Name = "Nikhil", Salary = 30799, City = "Pune" },
              new Employee { Id = 2, Name = "Rohan", Salary = 43699, City = "Mumbai" },
              new Employee { Id = 3, Name = "Ram", Salary = 34799, City = "Nashik" },
              new Employee { Id = 4, Name = "Raj", Salary = 45799, City = "Thane" },
              new Employee { Id = 5, Name = "Abhi", Salary = 238799, City = "Aurangabad" },
              new Employee { Id = 6, Name = "Param", Salary = 53299, City = "Nagar" },
              new Employee { Id = 7, Name = "Shubham", Salary = 23999, City = "Akola" },
              new Employee { Id = 8, Name = "Aditya", Salary = 42799, City = "Solapur" },
              new Employee { Id = 9, Name = "Sandip", Salary = 51799, City = "Jalgaon" },
              new Employee { Id = 10, Name = "Rohit", Salary = 19299, City = "Amrawati" },
            };

            //1. display all employees
            var result1 = from e in emp
                          select e;
            //2. display employee with ascending order by name
            var result2 = from e in emp
                          orderby e.Name
                          select e;

            //3.display employee whose salary is > 25000
            var result3 = from e in emp
                          where e.Salary > 25000
                          select e;

            //4. display employee whos from 'Pune' City
            var result4 = from e in emp
                          where e.City.Contains("Pune")
                          select e;

            //5. display employee with descending order by salary
            var result5 = from e in emp
                          orderby e.Salary descending
                          select e;

            // 6.display employee whose name start with 'P'
            var result6 = from e in emp
                          where e.Name.StartsWith("P")
                          select e;

            //7.display employee whose salary is > 25000 & emp is from 'Mumbai' city
            var result7 = from e in emp
                          where e.Salary > 25000 && e.City.Contains("Mumbai")
                          select e;

            foreach (Employee data in result3)
            {
                Console.WriteLine(data);
            }



        }
    }
}

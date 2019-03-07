using System;
using System.Collections.Generic;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Employee1 = new Employee("Bob", "Sagget", "Man of the House", new DateTime(2017, 1, 18));
            Employee Employee2 = new Employee("Hank", "Hill", "Propaininator", new DateTime(2017, 1, 18));
            Employee Employee3 = new Employee("Finn", "Human", "Adventurer", new DateTime(2017, 1, 18));

            List<Employee> CurrentEmployees = new List<Employee>();
            CurrentEmployees.Add(Employee1);
            CurrentEmployees.Add(Employee2);
            CurrentEmployees.Add(Employee3);

            Company Amazon = new Company("Amazon", CurrentEmployees, new DateTime(2017, 1, 18));

            foreach(Employee employee in Amazon.Employees){
            Console.WriteLine($"{employee.FirstName} {employee.LastName} works for {Amazon.CompanyName} as {employee.Title} since {employee.StartDate}.");
        }
        }
    }
    public class Employee
    {
         public Employee(string firstName, string lastName,string title,DateTime dateStarted){
            FirstName = firstName;
            LastName = lastName;
            Title = title;
            StartDate = dateStarted;
        }
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Title {get; set;}
        public DateTime StartDate {get; set;}
        }
    public class Company
    {
        public Company(string name, List<Employee> TheEmployees,DateTime dateFounded){
            CompanyName = name;
            Employees = TheEmployees;
            DateFounded = dateFounded;
        }
        public DateTime DateFounded {get; set;}
        public string CompanyName {get; set;}
        public List<Employee> Employees {get; set;}
        }
    }


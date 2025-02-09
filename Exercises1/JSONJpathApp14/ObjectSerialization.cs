using JSONJpathApp14.Task2Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONJpathApp14
{
    internal class ObjectSerialization
    {
        public void ObjectSerializationAndDeserialization()
        {

            // Step 2: Create a list of employees
            List<Employee> employees = new List<Employee>
        {
            new Employee
            {
                Id = 1,
                Name = "Alice",
                Employer = new Company
                {
                    Name = "TechCorp",
                    Location = new Address { Street = "123 Main St", City = "New York" }
                },
                Skills = new List<string> { "C#", "SQL", "Azure" }
            },
            new Employee
            {
                Id = 2,
                Name = "Bob",
                Employer = new Company
                {
                    Name = "Innovate Ltd",
                    Location = new Address { Street = "456 Market St", City = "San Francisco" }
                },
                Skills = new List<string> { "Java", "AWS", "Docker" }
            },
            new Employee
            {
                Id = 3,
                Name = "Charlie",
                Employer = new Company
                {
                    Name = "TechCorp",
                    Location = new Address { Street = "123 Main St", City = "New York" }
                },
                Skills = new List<string> { "Python", "Machine Learning", "Kubernetes" }
            }
        };

            // Step 3: Serialize employees into JSON
            string json = JsonConvert.SerializeObject(employees, Formatting.Indented);
            Console.WriteLine("Serialized JSON:\n" + json);

            // Step 4: Deserialize JSON back into a list of employees
            List<Employee> deserializedEmployees = JsonConvert.DeserializeObject<List<Employee>>(json);

            // Step 5: Print employee details
            Console.WriteLine("\nDeserialized Employees:");
            foreach (var emp in deserializedEmployees)
            {
                Console.WriteLine($"\nName: {emp.Name}");
                Console.WriteLine($"Company: {emp.Employer.Name}");
                Console.WriteLine($"Address: {emp.Employer.Location.Street}, {emp.Employer.Location.City}");
                Console.WriteLine("Skills: " + string.Join(", ", emp.Skills));
            }

            // Bonus: Filter employees whose company is in "New York"
            Console.WriteLine("\nEmployees working in New York:");
            var employeesInNY = deserializedEmployees.Where(e => e.Employer.Location.City == "New York");

            foreach (var emp in employeesInNY)
            {
                Console.WriteLine($"- {emp.Name} ({emp.Employer.Name})");
            }
        }
    }
}

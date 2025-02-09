using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace JSONJpathApp14
{
    public class ParseAndExtractData
    {
        public void ParseAndExtract()
        {
            string json = @"
            {
                ""departments"": [
                    {
                        ""name"": ""Engineering"",
                        ""employees"": [
                            { ""name"": ""Alice"", ""age"": 30, ""skills"": [""C#"", ""SQL""] },
                            { ""name"": ""Bob"", ""age"": 35, ""skills"": [""Java"", ""AWS""] }
                        ]
                    },
                    {
                        ""name"": ""HR"",
                        ""employees"": [
                            { ""name"": ""Charlie"", ""age"": 28, ""skills"": [""Recruitment"", ""Communication""] },
                            { ""name"": ""Diana"", ""age"": 32, ""skills"": [""Onboarding"", ""Training""] }
                        ]
                    }
                ]
            }";

            // 1. Parse the JSON string
            JObject data = JObject.Parse(json);

            /* 2. Use JPath to:
                 ●	Extract the names of all employees in the "Engineering" department.
                 ●	Extract all unique skills across all employees.
                 ●	Find employees older than 30 and print their department names along with their names. */


            // 1. Extract the names of all employees in the "Engineering" department.
            List<JToken> engineeringEmployees = data.SelectTokens("$.departments[?(@.name == 'Engineering')].employees[*].name").ToList();
            Console.WriteLine("Engineering Employees: ");

            foreach (var name in engineeringEmployees)
            {
                Console.WriteLine(name);
            }


            // 2. Extract all unique skills across all employees.
            var allSkills = data.SelectTokens("$.departments[*].employees[*].skills[*]")
                                .Select(s => s.ToString()).Distinct().ToList();
            Console.WriteLine("Unique Skills: " + string.Join(", ", allSkills));


            // 3. Find employees older than 30 and print their department names along with their names.
            var employeesAbove30 = data.SelectTokens("$.departments[*]")
                .SelectMany(dept => dept["employees"]
                    .Where(emp => (int)emp["age"] > 30)
                    .Select(emp => new
                    {
                        Departament = dept["name"].ToString(),
                        EmployeeName = emp["name"].ToString()
                    }))
                .ToList();

            Console.WriteLine("Employees older than 30:");
            foreach (var emp in employeesAbove30)
            {
                Console.WriteLine($"Department: {emp.Departament}, Employee: {emp.EmployeeName}");
            }

        }
    }
}

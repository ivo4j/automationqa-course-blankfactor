using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONJpathApp14.Task2Classes
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Company Employer { get; set; }
        public List<string> Skills { get; set; }

    }
}

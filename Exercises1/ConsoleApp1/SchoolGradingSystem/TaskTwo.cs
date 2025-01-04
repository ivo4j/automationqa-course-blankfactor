using EncapsulationAbstractionApp9.SchoolGradingSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationAbstractionApp9.SchoolGradingSystem
{
    internal class TaskTwo
    {
        public void TaskTwoStart()
        {
            // Create instances of Assignment and Exam
            IGradeCalculator assignment = new Assignment(100, 85);
            IGradeCalculator exam = new Exam(100, 92);

            // Store them in a list of IGradeCalculator
            List<IGradeCalculator> gradeCalculators = new List<IGradeCalculator> { assignment, exam };

            // Display the grade percentage for each item
            foreach (var gradeCalculator in gradeCalculators)
            {
                Console.WriteLine($"{gradeCalculator.GetType().Name} Grade: {gradeCalculator.CalculateGrade():F2}%");
            }
        }
    }
}

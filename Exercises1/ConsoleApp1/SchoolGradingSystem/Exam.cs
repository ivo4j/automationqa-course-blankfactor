using EncapsulationAbstractionApp9.SchoolGradingSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationAbstractionApp9.SchoolGradingSystem
{
    internal class Exam : IGradeCalculator
    {
        // Properties
        public double MaxMarks { get; set; }
        public double MarksObtained { get; set; }

        // Constructor
        public Exam(double maxMarks, double marksObtained)
        {
            MaxMarks = maxMarks;
            MarksObtained = marksObtained;
        }

        // Implementation of CalculateGrade
        public double CalculateGrade()
        {
            return (MarksObtained / MaxMarks) * 100;
        }
    }
}

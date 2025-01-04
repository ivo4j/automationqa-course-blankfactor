using EncapsulationAbstractionApp9.SchoolGradingSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationAbstractionApp9.SchoolGradingSystem
{
    internal class Assignment : IGradeCalculator
    {
        // Properties
        public double MaxScore { get; set; }
        public double ScoreAchieved { get; set; }

        // Constructor
        public Assignment(double maxScore, double scoreAchieved)
        {
            MaxScore = maxScore;
            ScoreAchieved = scoreAchieved;
        }

        // Implementation of CalculateGrade
        public double CalculateGrade()
        {
            return (ScoreAchieved / MaxScore) * 100;
        }
    }
}

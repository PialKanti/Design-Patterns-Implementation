using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.Models
{
    public class BeginnerJavaCourse : Course
    {
        public BeginnerJavaCourse()
        {
            Name = "Java";
            DifficultyLevel = Enums.CourseDifficulty.Beginner;
        }
    }
}

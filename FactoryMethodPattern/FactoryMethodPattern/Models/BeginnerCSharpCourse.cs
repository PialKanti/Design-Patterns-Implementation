using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.Models
{
    public class BeginnerCSharpCourse : Course
    {
        public BeginnerCSharpCourse()
        {
            Name = "C#";
            DifficultyLevel = Enums.CourseDifficulty.Beginner;
        }
    }
}

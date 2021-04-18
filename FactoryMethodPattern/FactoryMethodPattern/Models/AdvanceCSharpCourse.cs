using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.Models
{
    public class AdvanceCSharpCourse : Course
    {
        public AdvanceCSharpCourse()
        {
            Name = "C#";
            DifficultyLevel = Enums.CourseDifficulty.Advance;
        }
    }
}

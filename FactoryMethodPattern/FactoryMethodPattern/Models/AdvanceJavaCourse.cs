using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.Models
{
    public class AdvanceJavaCourse : Course
    {
        public AdvanceJavaCourse()
        {
            Name = "Java";
            DifficultyLevel = Enums.CourseDifficulty.Advance;
        }
    }
}

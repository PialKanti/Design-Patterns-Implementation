using FactoryMethodPattern.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.Models
{
    public abstract class Course
    {
        public string Name;
        public int DurationInHours;
        public CourseDifficulty DifficultyLevel;

        public void CreateCourseMaterials()
        {
            DurationInHours = new Random().Next(1, 20);

            Console.WriteLine($"{DifficultyLevel} {Name} course material is created.");
            Console.WriteLine($"Total duration = {DurationInHours} {(DurationInHours > 1 ? "hours" : "hour")}.");
        }
    }
}

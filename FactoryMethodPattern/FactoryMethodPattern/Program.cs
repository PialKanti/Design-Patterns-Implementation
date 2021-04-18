using System;

namespace FactoryMethodPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Testing Beginner course factory
            BeginnerCourseFactory beginnerCourseFactory = new BeginnerCourseFactory();
            beginnerCourseFactory?.CreateCourse(Enums.CourseName.Java);

            Console.WriteLine();

            //Testing Advance course factory
            AdvanceCourseFactory advanceCourseFactory = new AdvanceCourseFactory();
            advanceCourseFactory?.CreateCourse(Enums.CourseName.CSharp);
        }
    }
}

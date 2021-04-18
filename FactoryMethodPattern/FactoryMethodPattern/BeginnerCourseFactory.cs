using FactoryMethodPattern.Enums;
using FactoryMethodPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public class BeginnerCourseFactory : CourseFactory
    {
        public override Course GetCourse(CourseName courseName)
        {
            switch(courseName)
            {
                case CourseName.CSharp:
                    return new BeginnerCSharpCourse();
                case CourseName.Java:
                    return new BeginnerJavaCourse();
                default:
                    return null;
            }
        }
    }
}

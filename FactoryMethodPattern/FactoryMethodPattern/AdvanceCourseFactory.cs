using FactoryMethodPattern.Enums;
using FactoryMethodPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public class AdvanceCourseFactory : CourseFactory
    {
        public override Course GetCourse(CourseName courseName)
        {
            switch (courseName)
            {
                case CourseName.CSharp:
                    return new AdvanceCSharpCourse();
                case CourseName.Java:
                    return new AdvanceJavaCourse();
                default:
                    return null;
            }
        }
    }
}

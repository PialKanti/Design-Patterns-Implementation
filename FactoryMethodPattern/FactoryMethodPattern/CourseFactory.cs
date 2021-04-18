using FactoryMethodPattern.Enums;
using FactoryMethodPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public abstract class CourseFactory
    {
        public Course CreateCourse(CourseName courseName)
        {
            Course course = GetCourse(courseName);
            course.CreateCourseMaterials();
            return course;
        }

        public abstract Course GetCourse(CourseName courseName);
    }
}

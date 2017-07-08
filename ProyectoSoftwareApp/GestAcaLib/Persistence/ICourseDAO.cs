using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestAcaLib.Entities;

namespace GestAcaLib.Persistence
{
    public interface ICourseDAO
    {

        ICollection<Course> findAllCourses();

        void addCourse(Course off);

        Course findCourseByID(int id);
        void removeCourse(Course co);
    }
}

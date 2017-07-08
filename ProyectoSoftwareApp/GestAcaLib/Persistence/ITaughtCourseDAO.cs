using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestAcaLib.Entities;

namespace GestAcaLib.Persistence
{
    public interface ITaughtCourseDAO
    {
        ICollection<TaughtCourse> findAllTaughtCourses();
        void addTaughtCourse(TaughtCourse tc);
        void removeTaughtCourse(TaughtCourse tc);
        TaughtCourse findTaughtCourseById(int id);
        //void addCourse(TaughtCourse tau);
    }
}

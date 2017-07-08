using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestAcaLib.Entities;

namespace GestAcaLib.Persistence
{
    public class CourseDAOImp : ICourseDAO
    {
        private GestAcaDAL dbcontext;

        public CourseDAOImp(GestAcaDAL dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        //CRUD COURSE Operations

        public ICollection<Course> findAllCourses()
        {
            try
            {
                return dbcontext.courses.ToList<Course>();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
                return null;
            }
        }
        public Course findCourseByID(int id)
        {
            try
            {
                return dbcontext.courses.Where(p => p.Id == id).FirstOrDefault<Course>();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
                return null;
            }
        }

        public void addCourse(Course course)
        {
            try
            {
                dbcontext.courses.Add(course);
                dbcontext.SaveChanges();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
            }
        }
        public void removeCourse(Course course)
        {
            try
            {
                dbcontext.courses.Remove(course);
                dbcontext.SaveChanges();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestAcaLib.Entities;

namespace GestAcaLib.Persistence
{
    public class TaughtCourseDAOImp: ITaughtCourseDAO
    {
        private GestAcaDAL dbcontext;
        public TaughtCourseDAOImp(GestAcaDAL dbcontext)
        {
            this.dbcontext = dbcontext;
        }
        public void addTaughtCourse(TaughtCourse tc)
        {
            try
            {
                dbcontext.taughtcourses.Add(tc);
                dbcontext.SaveChanges();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
            }
        }
        public void removeTaughtCourse(TaughtCourse tc)
        {
            try
            {
                dbcontext.taughtcourses.Remove(tc);
                dbcontext.SaveChanges();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
            }
        }
        public TaughtCourse findTaughtCourseById(int id)
        {
            try
            {
                return dbcontext.taughtcourses.Where(taughtcourses => taughtcourses.Id == id).FirstOrDefault<TaughtCourse>();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
                return null;
            }
        }
        public ICollection<TaughtCourse> findAllTaughtCourses()

        {
            try
            {
                return dbcontext.taughtcourses.ToList<TaughtCourse>();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
                return null;
            }
        }
        /*public void addCourse(TaughtCourse tau)
        {
            try
            {
                dbcontext.taughtcourses.Add(tau);
                dbcontext.SaveChanges();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
            }
        }*/
    }
}

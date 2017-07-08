using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GestAcaLib.Entities;

namespace GestAcaLib.Persistence
{
    public class EnrollmentDAOImp : IEnrollmentDAO
    {

        private GestAcaDAL dbcontext;

        public EnrollmentDAOImp(GestAcaDAL dbcontext)
        {
            this.dbcontext = dbcontext;

        }
        //CRUD Enrollment Operations

        public ICollection<Enrollment> findAllEnrollments()
        {
            try
            {
                return dbcontext.enrollments.ToList<Enrollment>();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
                return null;
            }
        }

        public void addEnrollment(Enrollment en)
        {
            try
            {
                dbcontext.enrollments.Add(en);
                dbcontext.SaveChanges();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
            }
        }

        public Enrollment findEnrollmentByID(int id)
        {
            try
            {
                return dbcontext.enrollments.Where(p => p.Id == id).FirstOrDefault<Enrollment>();
            }
            catch(Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
                return null;
            }
        }


        public void removeEnrollment(Enrollment enrollment)
        {
            try
            {
                dbcontext.enrollments.Remove(enrollment);
                dbcontext.SaveChanges();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
            }
        }

    }
}

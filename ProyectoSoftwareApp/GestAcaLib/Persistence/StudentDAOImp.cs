using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestAcaLib.Entities;
namespace GestAcaLib.Persistence
{
    public class StudentDAOImp : IStudentDAO
    {
        private GestAcaDAL dbcontext;

        public StudentDAOImp(GestAcaDAL dbcontext)
        {
            this.dbcontext = dbcontext;
        }
        public void addStudent(Student student)
        {
            try
            {
                dbcontext.students.Add(student);
                dbcontext.SaveChanges();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
            }
        }


        public ICollection<Student> findAllStudents()
        {
            try
            {
                return dbcontext.students.ToList<Student>();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
                return null;
            }
        }
        public Student findStudentById(string id)
        {
            try
            {
                return dbcontext.students.Where(student => student.Id == id).FirstOrDefault<Student>();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
                return null;
            }
        }

        public void removeStudent(Student student)
        {
            try
            {
                dbcontext.students.Remove(student);
                dbcontext.SaveChanges();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestAcaLib.Entities;
namespace GestAcaLib.Persistence
{
    public class TeacherDAOImp : ITeacherDAO
    {
        private GestAcaDAL dbcontext;

        public TeacherDAOImp(GestAcaDAL dbcontext)
        {
            this.dbcontext = dbcontext;
        }
        public void addTeacher(Teacher teacher)
        {
            try
            {
                dbcontext.teachers.Add(teacher);
                dbcontext.SaveChanges();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
            }
        }


        public ICollection<Teacher> findAllTeachers()
        {
            try
            {
                return dbcontext.teachers.ToList<Teacher>();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
                return null;
            }
        }
        public Teacher findTeacherById(string id)
        {
            try
            {
                return dbcontext.teachers.Where(teacher => teacher.Id == id).FirstOrDefault<Teacher>();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
                return null;
            }
        }

        public void removeTeacher(Teacher teacher)
        {
            try
            {
                dbcontext.teachers.Remove(teacher);
                dbcontext.SaveChanges();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
            }
        }

    }
}

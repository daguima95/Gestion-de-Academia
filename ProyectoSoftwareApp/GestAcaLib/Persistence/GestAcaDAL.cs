using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using GestAcaLib.Entities;

namespace GestAcaLib.Persistence
{
    public class GestAcaDAL : DbContext
    {


        public DbSet<Absence> absences { get; set; }
        public DbSet<Course> courses { get; set; }
        public DbSet<Enrollment> enrollments { get; set; }
        public DbSet<Office> offices { get; set; }
        public DbSet<Person> persons { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<TaughtCourse> taughtcourses { get; set; }
        public DbSet<Teacher> teachers { get; set; }


        public IOfficeDAO officeDAO
        {
            get;
        }
        public IEnrollmentDAO enrollmentDAO
        {
            get;
        }
        public IAbsenceDAO absenceDAO
        {
            get;
        }
        public ICourseDAO courseDAO
        {
            get;
        }
        public ITeacherDAO teacherDAO
        {
            get;
        }
        public IStudentDAO studentDAO
        {
            get;
        }
        public IPersonDAO personDAO
        {
            get;
        }
        public ITaughtCourseDAO taughtcourseDAO
        {
            get;
        }


        private GestAcaDAL() : base("DBConnectionString")
        {
            officeDAO = new OfficeDAOImp(this);
            enrollmentDAO = new EnrollmentDAOImp(this);
            courseDAO = new CourseDAOImp(this);
            studentDAO = new StudentDAOImp(this);
            personDAO = new PersonDAOImp(this);
            absenceDAO = new AbsenceDAOImp(this);
            teacherDAO = new TeacherDAOImp(this);
            taughtcourseDAO = new TaughtCourseDAOImp(this);
            

            Database.Initialize(true);

        }

        // DAL Implements Singleton Pattern
        private static GestAcaDAL instance = null;
        public static GestAcaDAL getGestAcaDAL()
        {
            if (instance == null)
                instance = new GestAcaDAL();
            return instance;
        }


        public void RemoveAllData()
        {
            try
            {
                absences.RemoveRange(absences);
                courses.RemoveRange(courses);
                enrollments.RemoveRange(enrollments);
                offices.RemoveRange(offices);
                persons.RemoveRange(persons);
                students.RemoveRange(students);
                taughtcourses.RemoveRange(taughtcourses);
                teachers.RemoveRange(teachers);

                SaveChanges();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
            }
        }

        public void Save()
        {
            try
            {
                this.SaveChanges();

            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
            }


        }

    }

}

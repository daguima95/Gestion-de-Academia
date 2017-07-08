using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GestAcaLib.Entities;
using GestAcaLib.Persistence;

namespace GestAcaLib.BusinessLogic
{
    public class BusinessController
    {
        private GestAcaDAL dal;
        private BusinessController()
        {           
           dal = GestAcaDAL.getGestAcaDAL();

        }

        // Singleton pattern
        private static BusinessController instance = null;
        public static BusinessController getBusinessController()
        {
            if (instance == null)
                instance = new BusinessController();
            return instance;
        }

        public void removeAllData()
        {
            dal.RemoveAllData();
        }


        //course
        public void addCourse(Course co)
        {
            if (dal.courseDAO.findCourseByID(co.Id) == null)
                dal.courseDAO.addCourse(co);
            else throw new BusinessLogicException("Este curso ya existe.");
        }


        public Course findCourseByID(int cId)
        {
     
            return dal.courseDAO.findCourseByID(cId);
        }


        public ICollection<Course> findAllCourses()
        {
            
            return dal.courseDAO.findAllCourses();
        }


        //teacher
        public Teacher findTeacherByID(string teacherId)
        {
            return dal.teacherDAO.findTeacherById(teacherId);
        }

        public Student findStudentByID(string StudentId)
        {
            return dal.studentDAO.findStudentById(StudentId);
        }

      
        public void addStudent(Student est)
        {
            if (dal.studentDAO.findStudentById(est.Id) == null)
                dal.studentDAO.addStudent(est);
            else throw new BusinessLogicException("Este estudiante ya existe.");
        }
        public void addTeacher(Teacher tea)
        {
            if (dal.teacherDAO.findTeacherById(tea.Id) == null)
                dal.teacherDAO.addTeacher(tea);
            else throw new BusinessLogicException("Este profesor ya existe.");
        }

        public void addTaughtCourse(TaughtCourse tau)
        {
            if(dal.taughtcourseDAO.findTaughtCourseById(tau.Id) == null)
            {
               dal.taughtcourseDAO.addTaughtCourse(tau);
            }
            else throw new BusinessLogicException("Este curso ya existe.");
        }
        public void assignTeacherToTaughtCourse(string teacherId, int taughtCourseId)
        {
            Teacher teacher = dal.teacherDAO.findTeacherById(teacherId);
            TaughtCourse taughtCourse = dal.taughtcourseDAO.findTaughtCourseById(taughtCourseId);

            if (teacher==null) {
                throw new BusinessLogicException("Este Profesor no existe");
            }

            if (taughtCourse == null)
            {
                throw new BusinessLogicException("Este Grupo no existe");
            }

            foreach (TaughtCourse tc in teacher.TaughtCourses)
            {
                if ( tc.TeachingDay == taughtCourse.TeachingDay && (

                        (taughtCourse.StartDateTime == tc.StartDateTime || taughtCourse.EndTime == tc.EndTime) ||
                        (taughtCourse.StartDateTime < tc.StartDateTime && taughtCourse.EndTime > tc.StartDateTime) ||
                        (taughtCourse.StartDateTime < tc.EndTime       && taughtCourse.EndTime > tc.EndTime) ||
                        (taughtCourse.StartDateTime > tc.StartDateTime && taughtCourse.EndTime < tc.EndTime) || 
                        (taughtCourse.StartDateTime < tc.StartDateTime && taughtCourse.EndTime > tc.EndTime) 

                                                                    )
                    )
                {
                    throw new BusinessLogicException("El Profesor ya tiene este horario ocupado o ya esta impartiendo este curso");
                }
            }
            teacher.TaughtCourses.Add(taughtCourse);
            taughtCourse.Teacher = teacher;
            dal.SaveChanges();
        }


        public ICollection<TaughtCourse> findTaughtCoursesByCourseID(int courseId)
        {

            return dal.courseDAO.findCourseByID(courseId).TaughtCourses;

        }

        public TaughtCourse findTaughtCourseById(int taughtCourseId)
        {

            return dal.taughtcourseDAO.findTaughtCourseById(taughtCourseId);

        }
        public ICollection<Teacher> findAllTeachers()
        {
            return dal.teacherDAO.findAllTeachers();
        }

        public ICollection<TaughtCourse> findAllTaughtCourses()
        {
            return dal.taughtcourseDAO.findAllTaughtCourses();
        }

        //enrollment

        public Enrollment findEnrollmentByID(int Id)
        {
            return dal.enrollmentDAO.findEnrollmentByID(Id);
        }
        public void addEnrollment(Enrollment enrollment)
        {
            TaughtCourse tc = dal.taughtcourseDAO.findTaughtCourseById(enrollment.TaughtCourse.Id);
            if (tc == null) { throw new BusinessLogicException("TaughtCourse no existe"); }
            Student est = dal.studentDAO.findStudentById(enrollment.Student.Id);
            if (est == null) { throw new BusinessLogicException("Estudiante no existe"); }
            foreach (Enrollment en in tc.Enrollments) {
                Student est2 = dal.studentDAO.findStudentById(en.Student.Id);
                if (est2 == est) {
                    throw new BusinessLogicException("Estudiante ya en el curso");
                }
            }          
            if (dal.enrollmentDAO.findEnrollmentByID(enrollment.Id) == null)
            dal.enrollmentDAO.addEnrollment(enrollment);     
            else
                throw new BusinessLogicException("Enrollment ya existe");
        }

        //absence
        public Absence findAbsenceById(int Id)
        {
            return dal.absenceDAO.findAbsenceById(Id);
        }
        public void addAbsence(Absence absence)
        {
            if (dal.absenceDAO.findAbsenceById(absence.Id) == null)
                dal.absenceDAO.addAbsence(absence);
            else throw new BusinessLogicException("Absence already added");
        }
        public ICollection<Office> findAllOffices()
        {

            return dal.officeDAO.findAllOffices();
        }
        public Office findOfficeById(int Id) {
            return dal.officeDAO.findOfficeById(Id);
        }
        public void assignOfficeToTaughtCourse(int officeId, int taughtCourseId) {
            Office office;
            TaughtCourse tc;
            if (dal.officeDAO.findOfficeById(officeId) == null)
            {
                office = dal.officeDAO.findOfficeById(officeId);
            }
            else throw new BusinessLogicException("El office no existe");
            if (dal.taughtcourseDAO.findTaughtCourseById(taughtCourseId) == null)
            {
                tc = dal.taughtcourseDAO.findTaughtCourseById(taughtCourseId);
            }
            else throw new BusinessLogicException("El curso impartido ya existe");
            foreach (TaughtCourse ta in office.TaughtCourses)
            {
                if (ta.Id == taughtCourseId) {
                    throw new BusinessLogicException("este curso impartido ya esta assignado a la clase");
                }
            
            }
            office.TaughtCourses.Add(tc);
        }
        public void assignStudentToTaughtCourse(string studentId, Enrollment enrollment)
        {
            Student student = dal.studentDAO.findStudentById(studentId);
            //TaughtCourse taughtCourse = dal.taughtcourseDAO.findTaughtCourseById(taughtCourseId);
           // Enrollment enrollment = dal.enrollmentDAO.findEnrollmentByID(enrollmentId);

            if (student == null)
            {
                throw new BusinessLogicException("Este Alumno no existe");
            }



            student.Enrollments.Add(enrollment);
            enrollment.Student = student;
            dal.SaveChanges();
        }
    }
}
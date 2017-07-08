using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestAcaLib.Entities;
namespace GestAcaLib.Persistence
{
    public interface IStudentDAO
    {
        ICollection<Student> findAllStudents();
        void addStudent(Student student);
        Student findStudentById(string id);
        void removeStudent(Student student);
    }
}

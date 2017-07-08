using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestAcaLib.Entities;

namespace GestAcaLib.Persistence
{
    public interface ITeacherDAO
    {
        ICollection<Teacher> findAllTeachers();
        void addTeacher(Teacher teacher);
        Teacher findTeacherById(string id);
        void removeTeacher(Teacher teacher);
    }
}

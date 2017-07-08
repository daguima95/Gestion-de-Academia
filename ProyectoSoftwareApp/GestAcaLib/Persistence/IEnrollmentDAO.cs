using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GestAcaLib.Entities;

namespace GestAcaLib.Persistence
{
    public interface IEnrollmentDAO
    {

        ICollection<Enrollment> findAllEnrollments();

        void addEnrollment(Enrollment en);

        Enrollment findEnrollmentByID(int id);

        void removeEnrollment(Enrollment en);
    }
}
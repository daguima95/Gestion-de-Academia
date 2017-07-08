using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestAcaLib.Entities
{
    public partial class Enrollment
    {
        public Enrollment() {
            Absences = new List<Absence>();
        }
        public Enrollment(int id, DateTime enrollmentDate,DateTime cancellationDate,Boolean uniquePayment,Student student,TaughtCourse tc) {
            this.CancellationDate = cancellationDate;
            this.EnrollmentDate = enrollmentDate;
            this.Id = id;
            this.UniquePayment = uniquePayment;
            this.Student = student;
            this.TaughtCourse = tc;
            Absences = new List<Absence>();
        }
    }
}

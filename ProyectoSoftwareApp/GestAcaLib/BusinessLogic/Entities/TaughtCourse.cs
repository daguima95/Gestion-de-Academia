using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestAcaLib.Entities
{
    public partial class TaughtCourse
    {
        public TaughtCourse()
        {
            Enrollments = new List<Enrollment>();
        }
        public TaughtCourse(int id, DateTime startDateTime, DateTime endTime, String teachingDay, int quota, int sessionDuration, int totalPrice, Course course)
        {
            this.Course = course;
            this.EndTime = endTime;
            this.Id = id;
            this.Quota = quota;  
            this.SessionDuration = sessionDuration;
            this.StartDateTime = startDateTime;
            this.TeachingDay = teachingDay;
            this.TotalPrice = totalPrice;
            Enrollments = new List<Enrollment>();

        }
    }
}

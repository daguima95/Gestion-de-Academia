using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestAcaLib.Entities
{
    public partial class Office
    {
        public Office()
        {
            TaughtCourses = new List<TaughtCourse>();
        }
        public Office(int id, int maxCapacity, String name)
        {
            this.Id = id;
            this.MaxCapacity = maxCapacity;
            this.Name = name;
            TaughtCourses = new List<TaughtCourse>();
        }
    }
}

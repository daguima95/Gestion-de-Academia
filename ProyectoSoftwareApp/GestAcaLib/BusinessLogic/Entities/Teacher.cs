using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestAcaLib.Entities
{
    public partial class Teacher : Person
    {

        public Teacher() : base()
        {
            TaughtCourses = new List<TaughtCourse>();
        }



        public Teacher(string id, string name, string address, int ZipCode, String Ssn) : base(id, name, address, ZipCode)
        {
            this.Ssn = Ssn;
            TaughtCourses = new List<TaughtCourse>();
            this.Address = address;
            this.Name = name;
            this.Id = id;
            this.ZipCode = ZipCode;
        }

    }
}

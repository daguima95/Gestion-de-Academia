using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestAcaLib.Entities
{
    public partial class Student : Person
    {
        public Student() : base()
        {
            Enrollments = new List<Enrollment>();
        }

        public Student(String id, String name, String address, int zipCode, String IBAN) : base(id, name, address, zipCode)
        {
            this.Address = address;
            this.Name = name;
            this.Id = id;
            this.ZipCode = ZipCode;
            this.IBAN = IBAN;
            Enrollments = new List<Enrollment>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestAcaLib.Entities
{
    public partial class Person
    {
        public Person()
        {

        }
        public Person(string id, string name, string address, int ZipCode)
        {
            this.Address = address;
            this.Name = name;
            this.Id = id;
            this.ZipCode = ZipCode;
        }
    }
}

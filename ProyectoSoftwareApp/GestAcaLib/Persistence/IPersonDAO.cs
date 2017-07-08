using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestAcaLib.Entities;

namespace GestAcaLib.Persistence
{
    public interface IPersonDAO
    {
        ICollection<Person> findAllPersons();
        void addPerson(Person person);
        Person findPersonById(string id);
        void removePerson(Person person);
    }
}

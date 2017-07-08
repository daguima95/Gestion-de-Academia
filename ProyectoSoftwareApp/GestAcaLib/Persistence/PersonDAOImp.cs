using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestAcaLib.Entities;

namespace GestAcaLib.Persistence
{
    public class PersonDAOImp : IPersonDAO
    {
        private GestAcaDAL dbcontext;

        public PersonDAOImp(GestAcaDAL dbcontext) {
            this.dbcontext = dbcontext;
        }
        public void addPerson(Person person)
        {
            try
            {
                dbcontext.persons.Add(person);
                dbcontext.SaveChanges();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
            }
        }


        public ICollection<Person> findAllPersons()
        {
            try
            {
                return dbcontext.persons.ToList<Person>();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
                return null;
            }
        }
        public Person findPersonById(string id)
        {
            try
            {
                return dbcontext.persons.Where(person => person.Id == id).FirstOrDefault<Person>();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
                return null;
            }
        }

        public void removePerson(Person person)
        {
            try
            {
                dbcontext.persons.Remove(person);
                dbcontext.SaveChanges();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
            }
        }

    }
}

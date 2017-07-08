using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestAcaLib.Entities;

namespace GestAcaLib.Persistence
{
    public class AbsenceDAOImp : IAbsenceDAO
    {

        private GestAcaDAL dbcontext;

        public AbsenceDAOImp(GestAcaDAL dbcontext)
        {
            this.dbcontext = dbcontext;

        }
        //CRUD ABSENCE Operations

        public ICollection<Absence> findAllAbsences()
        {
            try
            {
                return dbcontext.absences.ToList<Absence>();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
                return null;
            }
        }

        public void addAbsence(Absence abs)
        {
            try
            {
                dbcontext.absences.Add(abs);
                dbcontext.SaveChanges();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
            }
        }

        public Absence findAbsenceById(int id)
        {
            try
            {
                return dbcontext.absences.Where(p => p.Id == id).FirstOrDefault<Absence>();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
                return null;
            }
        }
        public void removeAbsence(Absence absence)
        {
            try
            {
                dbcontext.absences.Remove(absence);
                dbcontext.SaveChanges();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
            }
        }
    }
}

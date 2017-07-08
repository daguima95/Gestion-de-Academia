using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestAcaLib.Entities;

namespace GestAcaLib.Persistence
{
    public class OfficeDAOImp : IOfficeDAO
    {

    private GestAcaDAL dbcontext;

    public OfficeDAOImp(GestAcaDAL dbcontext)
    {
        this.dbcontext = dbcontext;

    }

    //CRUD OFFICE Operations

    public ICollection<Office> findAllOffices()
    {
        try
        {
            return dbcontext.offices.ToList<Office>();
        }
        catch (Exception e)
        {
            System.Diagnostics.Debug.WriteLine(e.ToString());
            return null;
        }
    }

    public void addOffice(Office off)
    {
        try
        {
            dbcontext.offices.Add(off);
            dbcontext.SaveChanges();
        }
        catch (Exception e)
        {
            System.Diagnostics.Debug.WriteLine(e.ToString());
        }
    }



        public void removeOffice(Office off)
        {
            try
            {
                dbcontext.offices.Remove(off);
                dbcontext.SaveChanges();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
            }
        }



        public Office findOfficeById(int id)
        {
            try
            {
                return dbcontext.offices.Where(office => office.Id == id).FirstOrDefault<Office>();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
                return null;
            }
        }

    }


    
}

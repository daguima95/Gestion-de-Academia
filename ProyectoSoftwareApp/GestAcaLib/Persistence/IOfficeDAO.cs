using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GestAcaLib.Entities;

namespace GestAcaLib.Persistence
{
    public interface IOfficeDAO
    {

        ICollection<Office> findAllOffices();

        void addOffice(Office off);
        void removeOffice(Office off);
        Office findOfficeById(int id);
    }
}

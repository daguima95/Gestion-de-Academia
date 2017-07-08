using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestAcaLib.Entities;

namespace GestAcaLib.Persistence
{
    public interface IAbsenceDAO
    {

        ICollection<Absence> findAllAbsences();

        void addAbsence(Absence off);
        Absence findAbsenceById(int id);
        void removeAbsence(Absence ab);
    }
}

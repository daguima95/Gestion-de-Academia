﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestAcaLib.Entities
{
    public partial class Absence
    {
        public Absence()
        {
        }
        public Absence(int Id, DateTime date)
        {
            this.Id = Id;
            this.Date = date;
        }
      
    }
}

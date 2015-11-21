﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace Core.Repositories
{
    public interface IVrstaPreprekeRepository : IRepository<VrstaPrepreke, int>
    {
        IEnumerable<VrstaPrepreke> GetVrste();
        VrstaPrepreke GetVrstuPrepreke(int VPID);
    }
}
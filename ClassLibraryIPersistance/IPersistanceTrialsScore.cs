﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryIPersistance
{
    public interface IPersistanceTrialsScore
    {
        bool Write(sTrialsScore _score, string _pathSave);
    }
}

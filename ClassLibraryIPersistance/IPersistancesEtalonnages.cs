using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryIPersistance
{
    public interface IPersistancesEtalonnages
    {
        sEtalonnages Read(int _age);
        bool Write(sEtalonnages _sEtalonnages, string _pathSave);
    }
}

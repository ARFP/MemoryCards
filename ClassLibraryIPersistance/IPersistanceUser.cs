using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryIPersistance
{
    public interface IPersistanceUser
    {
        bool Write(sUser _user, string _pathSave);
    }
}

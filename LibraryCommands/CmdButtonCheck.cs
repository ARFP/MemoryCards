using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryCommands
{
    public class CmdButtonCheck : RelayCommand
    {
        public CmdButtonCheck(Predicate<object> canExecute, Action<object> execute) : base(canExecute, execute) { }

    }
}

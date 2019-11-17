using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryMemento
{
    public static class Fabrique
    {
        
        public static TestImage FabriqueTestImage(User _user, int _nbrTrial, int _timer, bool _sound)
        {
           return new TestImage(_user, _nbrTrial, _timer, _sound);
        }

        public static TestColor FabriqueTestColor(User _user, int _nbrTrial, int _timer, bool _sound)
        {
            return new TestColor(_user, _nbrTrial, _timer, _sound);
        }

        public static TestAbstract FabriqueTestAbstract(User _user, int _nbrTrial, int _timer, bool _sound)
        {
            return new TestAbstract(_user, _nbrTrial, _timer, _sound);
        }

        public static TestNumber FabriqueTestNumber(User _user, int _nbrTrial, int _timer, bool _sound)
        {
            return new TestNumber(_user, _nbrTrial, _timer, _sound);
        }

        public static TestDigit FabriqueTestDigit(User _user, int _nbrTrial, int _timer, bool _sound)
        {
            return new TestDigit(_user, _nbrTrial, _timer, _sound);
        }

        public static TestSound FabriqueTestSound(User _user, int _nbrTrial, int _timer, bool _sound)
        {
            return new TestSound(_user, _nbrTrial, _timer, _sound);
        }

        public static TestWord FabriqueTestWord(User _user, int _nbrTrial, int _timer, bool _sound)
        {
            return new TestWord(_user, _nbrTrial, _timer, _sound);
        }
    }
}

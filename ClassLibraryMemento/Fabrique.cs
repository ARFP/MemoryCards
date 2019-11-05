using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryMemento
{
    public static class Fabrique
    {
        
        public static TestImage FabriqueTestImage(int _nbrTrial, int _timer, bool _sound)
        {
           return new TestImage(_nbrTrial, _timer, _sound);
        }

        public static TestColor FabriqueTestColor(int _nbrTrial, int _timer, bool _sound)
        {
            return new TestColor(_nbrTrial, _timer, _sound);
        }

        public static TestAbstract FabriqueTestAbstract(int _nbrTrial, int _timer, bool _sound)
        {
            return new TestAbstract(_nbrTrial, _timer, _sound);
        }

        public static TestNumber FabriqueTestNumber(int _nbrTrial, int _timer, bool _sound)
        {
            return new TestNumber(_nbrTrial, _timer, _sound);
        }

        public static TestDigit FabriqueTestDigit(int _nbrTrial, int _timer, bool _sound)
        {
            return new TestDigit(_nbrTrial, _timer, _sound);
        }

        public static TestSound FabriqueTestSound(int _nbrTrial, int _timer, bool _sound)
        {
            return new TestSound(_nbrTrial, _timer, _sound);
        }

        public static TestWord FabriqueTestWord(int _nbrTrial, int _timer, bool _sound)
        {
            return new TestWord(_nbrTrial, _timer, _sound);
        }
    }
}

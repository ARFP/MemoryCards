using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryMemento
{
    public class TestSound : Test
    {
        private List<object> listSounds = new List<object>() {
            "C:/Users/CRM/Documents/GitHub/WpfTTS/MemoryCards/Images/arship.png",
            "C:/Users/CRM/Documents/GitHub/WpfTTS/MemoryCards/Images/car.png",
            "C:/Users/CRM/Documents/GitHub/WpfTTS/MemoryCards/Images/clock.png",
            "C:/Users/CRM/Documents/GitHub/WpfTTS/MemoryCards/Images/computer.png",
            "C:/Users/CRM/Documents/GitHub/WpfTTS/MemoryCards/Images/cycle.png",
            "C:/Users/CRM/Documents/GitHub/WpfTTS/MemoryCards/Images/england.png",
            "C:/Users/CRM/Documents/GitHub/WpfTTS/MemoryCards/Images/flower.png",
            "C:/Users/CRM/Documents/GitHub/WpfTTS/MemoryCards/Images/girl.png",
            "C:/Users/CRM/Documents/GitHub/WpfTTS/MemoryCards/Images/house.png",
            "C:/Users/CRM/Documents/GitHub/WpfTTS/MemoryCards/Images/logo.png",
            "C:/Users/CRM/Documents/GitHub/WpfTTS/MemoryCards/Images/scissors.png",
            "C:/Users/CRM/Documents/GitHub/WpfTTS/MemoryCards/Images/black.png"
        };

        public TestSound(User _user, int _nbrTrials, int _timer, bool _sound) : base(_user, "Sons", _nbrTrials, _timer)
        {
            AddTrial(listSounds, _sound);
        }

    }
}

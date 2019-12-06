using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryCards
{
    internal class SearchResources : Properties.Resources
    {
        private static System.Globalization.CultureInfo resourceCulture = Culture;

        internal static System.IO.UnmanagedMemoryStream SoundValueOf(string _soundName) 
        {
            return ResourceManager.GetStream(_soundName, resourceCulture);
        }

        internal static System.Drawing.Bitmap ImageValueOf(string _imageName)
        {
            object obj = ResourceManager.GetObject(_imageName, resourceCulture);
            return ((System.Drawing.Bitmap)(obj));
        }
    }
}

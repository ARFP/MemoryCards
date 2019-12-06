using ClassLibraryMemento;
using ClassLibraryViewModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MemoryCards
{
    public class StatusToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is ViewModelCard vmc)
            {
                if(vmc.CurrentStatus == StatusCard.face)
                {
                    return new ImageBrush(Imaging.CreateBitmapSourceFromHBitmap(SearchResources.ImageValueOf(vmc.FaceImage).GetHbitmap(), IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions()));
                }
                else if(vmc.CurrentStatus == StatusCard.found)
                {
                    return new ImageBrush(Imaging.CreateBitmapSourceFromHBitmap(SearchResources.ImageValueOf("woodCheckBtn").GetHbitmap(), IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions()));
                }
                else
                {
                    return new ImageBrush(Imaging.CreateBitmapSourceFromHBitmap(SearchResources.ImageValueOf("wood").GetHbitmap(), IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions()));                  
                }
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

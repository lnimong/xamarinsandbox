using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace App.WP8.Converters
{
    public class CategoryIdImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var image = new BitmapImage();
            using (var m = new MemoryStream(GetImage((string)value)))
            {
                image.SetSource(m);
            }

            return image;
        }

        private static byte[] GetImage(string id)
        {
            switch ((string)id)
            {
                case "001":
                    return Resources.ImagesResources.i001;
                case "002":
                    return Resources.ImagesResources.i002;
                case "003":
                    return Resources.ImagesResources.i003;
                case "004":
                    return Resources.ImagesResources.i004;
                case "005":
                    return Resources.ImagesResources.i005;
                case "006":
                    return Resources.ImagesResources.i006;
                default:
                    return null;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}

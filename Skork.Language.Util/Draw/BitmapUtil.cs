using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Skork.Language.Util.Draw
{
    public class BitmapUtil
    {
        /// <summary>
        /// Converts a WritableBitmap instance into a BitmapImage.
        /// <para>Returns null if something exceptional occurs.</para>
        /// </summary>
        /// <param name="writableBitmap">The <see cref="WriteableBitmap"/> instance.</param>
        /// <returns></returns>
        public static BitmapImage ConvertWriteableBitmapToBitmapImage(WriteableBitmap writableBitmap)
        {
            BitmapImage bitmapImage = new BitmapImage();
            
            try
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    PngBitmapEncoder encoder = new PngBitmapEncoder();
                    encoder.Frames.Add(BitmapFrame.Create(writableBitmap));
                    encoder.Save(stream);
                    bitmapImage.BeginInit();
                    bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                    bitmapImage.StreamSource = stream;
                    bitmapImage.EndInit();
                    bitmapImage.Freeze();
                    return bitmapImage;
                }
            } catch
            {
                return null;
            }
        }
    }
}

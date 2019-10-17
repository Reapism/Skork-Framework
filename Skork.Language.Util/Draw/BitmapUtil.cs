using System.IO;
using System.Windows.Media.Imaging;

namespace Skork.Language.Util.Draw
{
    /// <summary>
    /// Contains utility functions for <see cref="BitmapImage"/>
    /// and <see cref="WriteableBitmap"/>.
    /// </summary>
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

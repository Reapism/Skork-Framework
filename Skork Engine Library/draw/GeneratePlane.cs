using System.IO;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Skork_Engine_Library.Draw {

    /// <summary>
    /// 
    /// </summary>
    public sealed class GeneratePlane {

        private static double DPI_X;
        private static double DPI_Y;

        static GeneratePlane() {
            DPI_X = 300;
            DPI_Y = 300;
        }

        /// <summary>
        /// Generates an image using the virtual <see cref="SkorkPlane"/> 
        /// and returns an <see cref="Image"/> containing it.
        /// </summary>
        /// <param name="plane">The <see cref="SkorkPlane"/> instance.</param>
        /// <returns></returns>
        public static void GenerateSingleGrid(SkorkPlane plane) {
            WriteableBitmap bitmap = BitmapFactory.New(plane.Width, plane.Height);

            int x = 0;
            for (int y = 0; y < plane.Height; y++) {
                bitmap.SetPixel(x, y, plane.ColorSecondary);

                for (x = 0; x < plane.Width; x++) {
                    bitmap.SetPixel(x, y, plane.ColorPrimary);
                }
            }

            plane.Image = ConvertWriteableBitmapToBitmapImage(bitmap);
        }

        public static void GenerateDoubleGrid(SkorkPlane plane) {
            WriteableBitmap bitmap = BitmapFactory.New(plane.Width, plane.Height);

            int x = 0;
            for (int y = 0; y < plane.Height; y++) {
                bitmap.SetPixel(x, y, plane.ColorSecondary);

                for (x = 0; x < plane.Width; x++) {
                    bitmap.SetPixel(x, y, plane.ColorPrimary);
                }
            }

            plane.Image = ConvertWriteableBitmapToBitmapImage(bitmap);

        }

        /// <summary>
        /// Converts a WritableBitmap instance into a BitmapImage.
        /// <para>Returns null if something exceptional occurs.</para>
        /// </summary>
        /// <param name="wbm">The <see cref="WriteableBitmap"/> instance.</param>
        /// <returns></returns>
        public static BitmapImage ConvertWriteableBitmapToBitmapImage(WriteableBitmap wbm) {
            BitmapImage bmImage = new BitmapImage();

            try {
                using (MemoryStream stream = new MemoryStream()) {
                    PngBitmapEncoder encoder = new PngBitmapEncoder();
                    encoder.Frames.Add(BitmapFrame.Create(wbm));
                    encoder.Save(stream);
                    bmImage.BeginInit();
                    bmImage.CacheOption = BitmapCacheOption.OnLoad;
                    bmImage.StreamSource = stream;
                    bmImage.EndInit();
                    bmImage.Freeze();
                    return bmImage;
                }
            } catch {
                return null;
            }
        }
    }
}

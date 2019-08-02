using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Skork_Engine_Library.draw {
    public sealed class GeneratePlane {

        private static double DPI_X;
        private static double DPI_Y;

        static GeneratePlane() {
            DPI_X = 300;
            DPI_Y = 300;
        }

        public static Image GenerateSingleGrid(DrawPlane plane) {
            WriteableBitmap bitmap = new WriteableBitmap(plane.Width, plane.Height, DPI_X, DPI_Y, PixelFormats.Indexed4, BitmapPalettes.WebPalette);

            byte[,] pixels = new byte[plane.Height, plane.Width];
            for (int i = 0; i < plane.Height; i++) {

                    for (int j = 0; j < plane.Width; j++) {

                    pixels[i, j] = 0;
                        if (j+1 < plane.Width) {

                        }
                    }
                }
            bitmap.Unlock();
            return null;
        }

        public static Image GenerateDoubleGrid(DrawPlane plane) {
            using (System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(plane.Width, plane.Height)) {
                for (int i = 0; i < plane.Height; i += 2) {

                    for (int j = 0; j < plane.Width; j += 2) {

                    }
                }
                return null;
            }
        }
    }
}

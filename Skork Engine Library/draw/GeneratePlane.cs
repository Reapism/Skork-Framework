using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Skork_Engine_Library.draw {
    public sealed class GeneratePlane {

        private static double DPI_X;
        private static double DPI_Y;

        static GeneratePlane() {
            DPI_X = 300;
            DPI_Y = 300;
        }

        public static Image GenerateSingleGrid(SkorkPlane plane) {
            WriteableBitmap bitmap = BitmapFactory.New(plane.Width, plane.Height);

            int x = 0;
            for (int y = 0; y < plane.Height; y++) {
                bitmap.SetPixel(x, y, plane.ColorSecondary);

                for (x = 0; x < plane.Width; x++) {
                    bitmap.SetPixel(x, y, plane.ColorPrimary);
                }
            }

            Image img = new Image {
                Source = bitmap
            };

            return img;
        }

        public static Image GenerateDoubleGrid(SkorkPlane plane) {
            WriteableBitmap bitmap = BitmapFactory.New(plane.Width, plane.Height);

            int x = 0;
            for (int y = 0; y < plane.Height; y++) {
                bitmap.SetPixel(x, y, plane.ColorSecondary);

                for (x = 0; x < plane.Width; x++) {
                    bitmap.SetPixel(x, y, plane.ColorPrimary);
                }
            }

            Image img = new Image {
                Source = bitmap
            };

            return img;

        }
    }
}

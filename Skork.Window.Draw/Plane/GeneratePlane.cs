using Skork.Language.Util.Draw;
using Skork.Window.Draw.Helpers;
using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Skork.Window.Draw.Plane
{
    /// <summary>
    /// Contains functions for generating images for the 
    /// <see cref="SkorkPlaneProperties"/>.
    /// </summary>
    public sealed class GeneratePlane
    {
        /// <summary>
        /// Generates an image using the virtual <see cref="SkorkPlane"/> 
        /// and returns an <see cref="Image"/> containing it.
        /// </summary>
        /// <param name="plane">The <see cref="SkorkPlane"/> instance.</param>
        /// <returns></returns>
        public static void GenerateSingleGrid(SkorkPlaneProperties planeProperties)
        {
            planeProperties = null;
            throw new NotImplementedException();
        }

        public static unsafe void GenerateDoubleGrid(SkorkPlaneProperties planeProperties)
        {
            WriteableBitmap writableBitmap = BitmapFactory.New(planeProperties.Width, planeProperties.Height);
            writableBitmap.Clear(planeProperties.ColorSecondary);

            Point pt1 = new Point(0, 0);
            Point pt2 = new Point(0, 0);
            Point offsetPoint = new Point(0, 4);

            int colorAsInt = planeProperties.ColorPrimary.A +
                planeProperties.ColorPrimary.R +
                planeProperties.ColorPrimary.G +
                planeProperties.ColorPrimary.B;

            int numberOfLines = planeProperties.Height / 2;

            using (BitmapContext context = writableBitmap.GetBitmapContext())
            {
                int* pixels = context.Pixels;

                for (int currentLine = 0; currentLine < numberOfLines; currentLine++)
                {
                    WriteableBitmapExtensions.DrawLine(context, planeProperties.Width, planeProperties.Height, (int)pt1.X, (int)pt1.Y, (int)pt2.X, (int)pt2.Y, colorAsInt);
                    CoordinateHelper.AdvanceLineVerticalCoordinates(ref pt1, ref pt2, offsetPoint);
                }

                planeProperties.Image = BitmapUtil.ConvertWriteableBitmapToBitmapImage(writableBitmap);
            }

        }


    }
}

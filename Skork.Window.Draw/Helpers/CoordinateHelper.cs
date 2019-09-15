using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Skork.Window.Draw.Helpers
{
    public static class CoordinateHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="point1">The first <see cref="Point"/>.</param>
        /// <param name="point2">The second <see cref="Point"/>.</param>
        /// <param name="offsetPt">The <see cref="Point"/> that offsets the two points.</param>
        public static void AdvanceLineVerticalCoordinates(ref Point point1, ref Point point2, Point offsetPt)
        {
            point1.Offset(offsetPt.X, offsetPt.Y);
            point2.Offset(offsetPt.X, offsetPt.Y);
        }
    }
}

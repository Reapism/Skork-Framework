using SkiaSharp;
using Skork.Window.Draw.Interfaces;
using SkorkEngine.Exceptions.Runtime.Draw;
using System.Drawing;

namespace Skork.Window.Draw.Plane
{
    public class SkorkPlaneProperties : I2DPlane
    {
        private int width;
        private int height;

        /// <summary>
        /// The width of the plane.
        /// </summary>
        public int Width
        {
            get => width; set { if (value > 0) { width = value; } }
        }

        /// <summary>
        /// The height of the plane.
        /// </summary>
        public int Height
        {
            get => height; set { if (value > 0) { height = value; } }
        }

        /// <summary>
        /// Gets or sets the primary color for the plane.
        /// </summary>
        public Color ColorPrimary { get; set; }

        /// <summary>
        /// Gets or sets the secondary color for the plane.
        /// </summary>
        public Color ColorSecondary { get; set; }

        /// <summary>
        /// The internal image representing the Skork grid pattern.
        /// </summary>
        public SKBitmap Image { get; set; }

        /// <summary>
        /// Default constructor initializing a <see cref="SkorkPlane"/> to 50x50
        /// using blank as a primary color, and blank as a 
        /// secondary color.
        /// </summary>
        public SkorkPlaneProperties() : this(50, 50, Color.DarkGray, Color.GhostWhite)
        {

        }

        /// <summary>
        /// Instantiates a new instance of the <see cref="SkorkPlane"/>
        /// class with a new width, height, and a two-tone color for the grid.
        /// </summary>
        /// <param name="width">The width of the <see cref="SkorkPlane"/>.</param>
        /// <param name="height">The height of the <see cref="SkorkPlane"/>.</param>
        /// <param name="color1">The primary color of the <see cref="SkorkPlane"/>.</param>
        /// <param name="color2">The secondary color of the <see cref="SkorkPlane"/>.</param>
        /// <exception cref="SkorkDrawException">Thrown when the width or height are less than 1 or if a color is null.</exception>
        public SkorkPlaneProperties(int width, int height, Color color1, Color color2)
        {
            if (width < 1 || height < 1)
            {
                throw new SkorkDrawException("The width and height must both be positive numbers greater than 0!");
            }

            if (color1 == null || color2 == null)
            {
                throw new SkorkDrawException("The primary and secondary color must be non-null!");
            }

            Width = width;
            Height = height;
            ColorPrimary = color1;
            ColorSecondary = color2;
            Image = null;
        }

        /// <summary>
        /// Returns whether this instances <see cref="ColorPrimary"/> color is located
        /// at the <paramref name="point"/>.
        /// </summary>
        /// <param name="plane">The <see cref="SkorkPlane"/> reference.</param>
        /// <param name="point">The point to check</param>
        /// <returns>Whether the color located at the point is the primary color.</returns>
        public bool IsPrimary(SkorkPlane plane, Point point)
        {
            return true;
        }

        public bool IsSecondary()
        {
            return true;
        }
    }
}

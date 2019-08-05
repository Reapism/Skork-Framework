using SkorkEngine.exception;
using System.Windows.Controls;
using System.Windows.Media;

namespace Skork_Engine_Library.draw {
    /// <summary>
    /// The <see cref="SkorkPlace"/> class.
    /// <para>Contains an instance of a plane
    /// and its properties.</para>
    /// </summary>
    public class SkorkPlace {

        private int width;
        private int height;

        /// <summary>
        /// Default constructor initializing a plane to 
        /// </summary>
        public SkorkPlace() : this(50, 50, Colors.DarkGray, Colors.GhostWhite) {

        }

        public SkorkPlace(int width, int height, Color color1, Color color2) {
            if (width < 1 || height < 1) {
                throw new SkorkDrawException("The width and height must both be positive numbers greater than 0!");
            }

            this.Width = width;
            this.Height = height;
            this.ColorPrimary = color1;
            this.ColorSecondary = color2;
        }

        /// <summary>
        /// The width of the plane.
        /// </summary>
        public int Width {
            get => this.width; set { if (value > 0) { this.width = value; } }
        }

        /// <summary>
        /// The height of the plane.
        /// </summary>
        public int Height {
            get => this.height; set { if (value > 0) { this.height = value; } }
        }

        /// <summary>
        /// Gets or sets the primary color for the plane.
        /// </summary>
        public Color ColorPrimary { get; set; }

        /// <summary>
        /// Gets or sets the secondary color for the plane.
        /// </summary>
        public Color ColorSecondary { get; set; }

        public static Image GeneratePlane(SkorkPlace plane) {
            using (System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(plane.Width, plane.Height)) {
                
            }


                return null;
        }


    }
}

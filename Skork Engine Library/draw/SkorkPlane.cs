using SkorkEngine.exception;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Skork_Engine_Library.draw {
    /// <summary>
    /// The <see cref="SkorkPlane"/> class.
    /// <para>Contains an instance of a plane
    /// and its properties.</para>
    /// </summary>
    public class SkorkPlane {

        private int width;
        private int height;

        /// <summary>
        /// Default constructor initializing a <see cref="SkorkPlane"/> to 50x50
        /// using blank as a primary color, and blank as a 
        /// secondary color.
        /// </summary>
        public SkorkPlane() : this(50, 50, Colors.DarkGray, Colors.GhostWhite) {

        }

        /// <summary>
        /// Instantiates a new instance of the <see cref="SkorkPlane"/>
        /// class with a new width, height, and a twotone color.
        /// </summary>
        /// <param name="width">The width of the <see cref="SkorkPlane"/>.</param>
        /// <param name="height">The height of the <see cref="SkorkPlane"/>.</param>
        /// <param name="color1">The primary color of the <see cref="SkorkPlane"/>.</param>
        /// <param name="color2">The secondary color of the <see cref="SkorkPlane"/>.</param>
        public SkorkPlane(int width, int height, Color color1, Color color2) {
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

        /// <summary>
        /// Generates a <see cref="SkorkPlane"/> and returns an
        /// Image containing it.
        /// </summary>
        /// <param name="plane"></param>
        /// <returns></returns>
        public static Image GeneratePlane(SkorkPlane plane) {
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

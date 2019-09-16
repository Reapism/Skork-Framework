namespace Skork_Engine_Library.Draw
{

    /// <summary>
    /// The <see cref="I2DPlane"/> interface.
    /// <para>An interface representing a 2D plane
    /// using Height and Width properties.</para>
    /// </summary>
    public interface I2DPlane
    {

        /// <summary>
        /// The height of the 2D plane.
        /// </summary>
        int Height { get; set; }

        /// <summary>
        /// The width of the 2D plane.
        /// </summary>
        int Width { get; set; }

    }
}

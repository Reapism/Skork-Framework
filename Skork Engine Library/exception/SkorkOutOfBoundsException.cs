using Skork_Engine_Library.Draw;

namespace SkorkEngine.Exceptions
{
    /// <summary>
    /// The <see cref="SkorkOutOfBoundsException"/> class.
    /// <para>Thrown when attempting to access a point that is
    /// out of bounds on a <see cref="SkorkPlane"/> instance.</para>
    /// </summary>
    public class SkorkOutOfBoundsException : SkorkException
    {

        /// <summary>
        /// Construct a throwable <see cref="SkorkOutOfBoundsException"/>.
        /// </summary>
        /// <param name="msg">The exception.</param>
        public SkorkOutOfBoundsException(string msg) : base(msg)
        {

        }

        /// <summary>
        /// Returns the exception message.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString();
        }
    }
}

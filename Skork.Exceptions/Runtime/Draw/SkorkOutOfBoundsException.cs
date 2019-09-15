using Skork.Exceptions;

namespace SkorkEngine.Exceptions.Runtime.Draw
{
    /// <summary>
    /// <para>Thrown when attempting to access a point that is
    /// out of bounds on a <see cref="SkorkPlane"/> instance.</para>
    /// <see cref="SkorkOutOfBoundsException"/> is derived from
    /// <see cref="SkorkException"/>.
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

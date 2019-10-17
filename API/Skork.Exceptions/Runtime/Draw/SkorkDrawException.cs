using Skork.Exceptions;

namespace SkorkEngine.Exceptions.Runtime.Draw
{
    /// <summary>
    /// <para>Thrown when an error occurs in drawing
    /// the grid.</para>
    /// <see cref="SkorkDrawException"/> is derived from
    /// <see cref="SkorkException"/>.
    /// </summary>
    public class SkorkDrawException : SkorkException
    {
        /// <summary>
        /// Construct a throwable <see cref="SkorkDrawException"/>.
        /// </summary>
        /// <param name="msg">The exception.</param>
        public SkorkDrawException(string msg) : base(msg)
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

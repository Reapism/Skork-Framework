using Skork.Exceptions;

namespace SkorkEngine.Exceptions.Runtime.Memory
{
    /// <summary>
    /// <para>Thrown when attempting to create memory more
    /// than the allocated amount of memory in this
    /// <see langword="SkorkEngine"/> instance.</para>
    /// <see cref="SkorkOutOfMemoryException"/> is derived from
    /// <see cref="SkorkException"/>.
    /// </summary>
    public class SkorkOutOfMemoryException : SkorkException
    {
        /// <summary>
        /// Construct a throwable <see cref="SkorkOutOfMemoryException"/>.
        /// </summary>
        /// <param name="msg">The exception.</param>
        public SkorkOutOfMemoryException(string msg) : base(msg)
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

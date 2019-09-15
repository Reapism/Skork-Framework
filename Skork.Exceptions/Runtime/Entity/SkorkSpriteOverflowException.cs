using Skork.Exceptions;

namespace SkorkEngine.Exceptions.Runtime.Entity
{
    /// <summary>
    /// <para>Thrown when attempting to create more than the
    /// maximum number of allowed sprites.</para>
    /// <see cref="SkorkSpriteOverflowException"/> is derived from
    /// <see cref="SkorkException"/>.
    /// </summary>
    public class SkorkSpriteOverflowException : SkorkException
    {
        /// <summary>
        /// Construct a throwable <see cref="SkorkSpriteOverflowException"/>.
        /// </summary>
        /// <param name="msg">The exception.</param>
        public SkorkSpriteOverflowException(string msg) : base(msg)
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

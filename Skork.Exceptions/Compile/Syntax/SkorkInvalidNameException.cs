using Skork.Exceptions;

namespace Skork.Exceptions.Compile.Syntax
{
    /// <summary>
    /// <para>Thrown when an invalid name for a variable
    /// or identifier is used.</para>
    /// <see cref="SkorkInvalidNameException"/> is derived from
    /// <see cref="SkorkException"/>.
    /// </summary>
    public class SkorkInvalidNameException : SkorkException
    {
        /// <summary>
        /// Construct a throwable <see cref="SkorkInvalidNameException"/>.
        /// </summary>
        /// <param name="msg">The exception.</param>
        public SkorkInvalidNameException(string msg) : base(msg)
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

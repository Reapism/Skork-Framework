using System;

namespace Skork.Exceptions
{
    /// <summary>
    /// The root exception class for the <see langword="SkorkEngine"/>.
    /// <para>All other Skork related exception classes are derived from 
    /// <see cref="SkorkException"/>.</para>
    /// <para><see cref="SkorkException"/> is derived from <see cref="Exception"/></para>
    /// </summary>
    public class SkorkException : Exception
    {
        private string exceptionMsg;

        /// <summary>
        /// Construct a throwable <see cref="SkorkException"/>.
        /// <para>The root level skork exception.</para>
        /// </summary>
        /// <param name="msg">The exception.</param>
        public SkorkException(string msg)
        {
            this.exceptionMsg = msg;
        }

        /// <summary>
        /// Returns the exception message.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.exceptionMsg;
        }
    }
}

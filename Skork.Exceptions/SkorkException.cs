using System;

namespace Skork.Exceptions
{
    /// <summary>
    /// The root exception class for all 
    /// <see langword="Skork Engine"/> exceptions.
    /// <para>
    /// Inherits from <see cref="Exception"/>.
    /// </para>
    /// </summary>
    public class SkorkException : Exception
    {
        private string _exceptionMsg;

        /// <summary>
        /// Contructs a <see cref="SkorkException"/>
        /// with the specified message.
        /// </summary>
        /// <param name="exceptionMsg"></param>
        public SkorkException(string exceptionMsg)
        {
            _exceptionMsg = exceptionMsg;
        }

        /// <summary>
        /// Returns the exception message.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return _exceptionMsg;
        }

    }
}

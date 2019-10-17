namespace Skork.Exceptions.Compile.Syntax
{
    /// <summary>
    /// <para>Thrown when a syntax error is catched
    /// during compilation.</para>
    /// <para>Contains the line, line number, and message
    /// where the exception occured.</para>
    /// <see cref="SkorkSyntaxException"/> is derived from
    /// <see cref="SkorkException"/>.
    /// </summary>
    public class SkorkSyntaxException : SkorkException
    {
        /// <summary>
        /// The line number associated with the syntax error.
        /// </summary>
        private int LineNumber { get; set; }

        /// <summary>
        /// The code line that contains the syntax error.
        /// </summary>
        private string Line { get; set; }

        /// <summary>
        /// Construct a throwable <see cref="SkorkSyntaxException"/>.
        /// </summary>
        /// <param name="lineNumber">The line number of the occuring syntax error.</param>
        /// <param name="line">The line that caused the exception</param>
        /// <param name="msg"></param>
        public SkorkSyntaxException(int lineNumber, string line, string msg) : base(msg)
        {
            LineNumber = lineNumber;
            Line = line;
        }

        /// <summary>
        /// Returns the exception message.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"A syntax error occurred on line: {LineNumber} \"{Line}\" Message: {base.ToString()}";
        }
    }
}

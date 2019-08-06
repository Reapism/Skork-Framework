namespace SkorkEngine.exception {
    /// <summary>
    /// The <see cref="SkorkSyntaxException"/> class.
    /// <para>Thrown when a syntax error is catched
    /// during compilation.</para>
    /// </summary>
    public class SkorkSyntaxException : SkorkException {

        /// <summary>
        /// Construct a throwable <see cref="SkorkSyntaxException"/>.
        /// </summary>
        /// <param name="linenum">The line number of the occuring syntax error.</param>
        /// <param name="line">The line that caused the exception</param>
        /// <param name="msg"></param>
        public SkorkSyntaxException(int linenum, string line, string msg) : base(msg) {

        }

        /// <summary>
        /// Returns the exception message.
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            return $"A syntax error occurred on line: {line}";
        }
    }
}

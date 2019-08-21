namespace SkorkEngine.Exception {
    /// <summary>
    /// The <see cref="SkorkInvalidNameException"/> class.
    /// <para>Thrown when an theres an invalid name for a variable
    /// or identifier.</para>
    /// </summary>
    public class SkorkInvalidNameException : SkorkException {

        /// <summary>
        /// Construct a throwable <see cref="SkorkInvalidNameException"/>.
        /// </summary>
        /// <param name="msg">The exception.</param>
        public SkorkInvalidNameException(string msg) : base(msg) {

        }

        /// <summary>
        /// Returns the exception message.
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            return base.ToString();
        }
    }
}

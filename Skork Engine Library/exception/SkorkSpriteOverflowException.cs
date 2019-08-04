namespace SkorkEngine.exception {
    /// <summary>
    /// The <see cref="SkorkSpriteOverflowException"/> class.
    /// <para>Thrown when attempting to create more than the
    /// maximun number of allowed sprites.S</para>
    /// </summary>
    public class SkorkSpriteOverflowException : SkorkException {

        /// <summary>
        /// Construct a throwable <see cref="SkorkSpriteOverflowException"/>.
        /// </summary>
        /// <param name="msg">The exception.</param>
        public SkorkSpriteOverflowException(string msg) : base(msg) {

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

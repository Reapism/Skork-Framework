namespace Skork_Engine_Library.util {

    /// <summary>
    /// <para>Adds a unique number to separate every
    /// variable/object created in skork.</para> Not
    /// a singleton because newer objects increment
    /// the id, and statics because when creating
    /// new objects of this class, we don't want to
    /// create more 'id's'.
    /// </summary>

    public class SkorkKeysID {

        // The unique id.
        private long id;
        private object type;

        /// <summary>
        /// Default constructor which increments
        /// id by 1.
        /// </summary>

        public SkorkKeysID() {
            if (this.id == 0) { this.id = 1; }
            this.id += 1;
        }

        /// <summary>
        /// Returns the current id.
        /// </summary>
        /// <returns></returns>

        public override string ToString() {
            return $"The id is { this.id.ToString()} of type {this.type.GetType().ToString() }";
        }
    }
}

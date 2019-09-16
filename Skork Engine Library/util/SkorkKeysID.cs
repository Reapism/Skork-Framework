namespace Skork_Engine_Library.Util
{

    /// <summary>
    /// <para>Adds a unique number to separate every
    /// variable/object created in skork.</para> Not
    /// a singleton because newer objects increment
    /// the id, and statics because when creating
    /// new objects of this class, we don't want to
    /// create more 'id's'.
    /// </summary>

    public class SkorkKeysID<T>
    {

        // The unique id.
        private long id;
        private T type;

        /// <summary>
        /// Default constructor which increments
        /// id by 1.
        /// </summary>

        public SkorkKeysID()
        {
            if (id == 0)
            { id = 1; }
            id += 1;
        }

        /// <summary>
        /// Gets the type.
        /// </summary>
        /// <typeparam name="T">Gets the type as an object.</typeparam>
        /// <returns></returns>
        public object GetType<T>()
        {
            return type.GetType();
        }

        /// <summary>
        /// Returns the current id.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"The id is { id.ToString()} of type {type.GetType().ToString() }";
        }
    }
}

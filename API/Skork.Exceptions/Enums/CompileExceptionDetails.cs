namespace Skork.Exceptions.Enums
{
    /// <summary>
    /// Contains all sorts of common exception details.
    /// </summary>
    public enum CompileExceptionDetails
    {
        /// <summary>
        /// An exception was thrown because an 
        /// existing type is in scope with the same
        /// name.
        /// </summary>
        EXISTING_TYPE,

        /// <summary>
        /// An exception was throw because a variable
        /// was created with an invalid name such as a
        /// keyword.
        /// <para>e.g.</para>
        /// </summary>
        INVALID_FIELD_NAME,

        /// <summary>
        /// An exception was thrown because a keyword
        /// was expected, and is invalid.
        /// </summary>
        INVALID_KEYWORD,
    }
}

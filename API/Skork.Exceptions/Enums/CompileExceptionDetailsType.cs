using System.ComponentModel;

namespace Skork.Exceptions.Enums
{
    /// <summary>
    /// Contains all sorts of common exception details.
    /// </summary>
    public enum CompileExceptionDetailsType
    {
        /// <summary>
        /// An exception was thrown because an 
        /// existing type is in scope with the same
        /// alias.
        /// <example>
        /// <code>
        /// <para>int i = 0;</para>
        /// if (true)
        /// {
        /// int i = 0;
        /// }
        /// </code>
        /// </example>
        /// </summary>

        [Description("An exception was thrown because an existing type is in scope with the same name.")]
        EXISTING_TYPE,

        /// <summary>
        /// An exception was throw because a variable
        /// was created with an invalid name such as a
        /// keyword.
        /// <example>
        /// <code>
        /// <para>int int = 0;</para>
        /// </code>
        /// </example>
        /// </summary>
        [Description("An exception was throw because a variable was created with an invalid name such as a keyword.")]
        INVALID_FIELD_NAME,

        /// <summary>
        /// An exception was thrown because a keyword
        /// was expected, and is invalid.
        /// </summary>
        [Description("An exception was thrown because a keyword was expected, and is invalid.")]
        INVALID_KEYWORD
    }
}

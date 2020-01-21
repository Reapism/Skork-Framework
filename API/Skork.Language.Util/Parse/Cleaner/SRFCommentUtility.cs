using System;

namespace Skork.Language.Util.Parse
{
    public static class SRFCommentUtility
    {
        /// <summary>
        /// Returns a substring containing the string until
        /// the beginning comment.
        /// </summary>
        /// <param name="codeLine">The line to check.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static string RemoveCommentsFromCodeLine(string codeLine)
        {
            if (codeLine == null)
                throw new ArgumentNullException("Argument cannot be null.");

             int commentIndex = codeLine.IndexOf("//");
            int newLineIndex = codeLine.IndexOf("\n");

            if (commentIndex != -1 && newLineIndex != -1)
                return codeLine.Substring(0, newLineIndex);

            if (commentIndex != -1)
                return codeLine.Substring(0, commentIndex);
        }
    }
}

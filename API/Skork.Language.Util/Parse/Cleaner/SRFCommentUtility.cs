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
        public static string RemoveCommentsFromCodeLine(string codeLine)
        {
            if (string.IsNullOrEmpty(codeLine))
                throw new ArgumentNullException("Argument cannot be null or empty.");

            int index = codeLine.IndexOf("//");

            if (index != -1)
            {
                return codeLine.Substring(0, index);
            }

            return codeLine;
        }
    }
}

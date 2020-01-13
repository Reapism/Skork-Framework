using Skork.Language.Util.Parse;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Skork.Language.Parse.Cleaner
{
    public static class SRFCodeCleaner
    {
        /// <summary>
        /// Cleans potential code lines by trimming leading, trailing, and multiple whitespaces.
        /// </summary>
        /// <param name="codeLines"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static IEnumerable<string> CleanPotentialCodeLines(IEnumerable<string> codeLines)
        {
            if (codeLines == null || !codeLines.Any())
                throw new ArgumentException("Argument cannot be null or empty.", nameof(codeLines));

            var codeQueue = new Queue<string>();

            foreach (var codeLine in codeLines)
            {
                var cleanedCodeLine = CleanPotentialCodeLine(codeLine);
                codeQueue.Enqueue(cleanedCodeLine);
            }

            return codeQueue;
        }

        /// <summary>
        /// Cleans a potential code line by trimming leading, trailing, and multiple whitespaces.
        /// </summary>
        /// <param name="codeLine"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static string CleanPotentialCodeLine(string codeLine)
        {
            var singleWhitespaceLine = SRFReplaceUtility.ReplaceMultipleWhitespacesWithSingleWhitespace(codeLine);
            var singleSpaceLine = SRFReplaceUtility.ReplaceMultipleWhitespacesWithSingleSpace(singleWhitespaceLine);
            var trimmedCodeStatementsEnumerable = SRFTrimUtility.TrimLeadingAndTrailingWhitespaces(singleSpaceLine);
            var removedCommentsLine = SRFCommentUtility.RemoveCommentsFromCodeLine(trimmedCodeStatementsEnumerable);

            return removedCommentsLine;
        }
    }
}

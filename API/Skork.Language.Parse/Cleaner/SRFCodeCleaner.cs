using Skork.Language.Util.Parse;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Skork.Language.Parse.Cleaner
{
    public static class SRFCodeCleaner
    {
        /// <summary>
        /// Cleans potential code lines by trimming leading and trailing whitespaces. 
        /// </summary>
        /// <param name="codeLines"></param>
        /// <returns></returns>
        public static IEnumerable<string> CleanPotentialCodeLines(IEnumerable<string> codeLines)
        {
            if (codeLines == null || !codeLines.Any())
                throw new ArgumentException("Argument cannot be null or empty.", nameof(codeLines));

            var codeQueue = new Queue<string>();

            foreach (var codeLine in codeLines)
            {
                var trimmedCodeStatementsEnumerable = SRFTrimUtility.TrimLeadingAndTrailingWhitespaces(codeLine);
                var singleWhitespaceLine = SRFReplaceUtility.ReplaceMultipleWhitespacesWithSingleSpace(trimmedCodeStatementsEnumerable);
                var removedCommentsLine = SRFCommentUtility.RemoveCommentsFromCodeLine(singleWhitespaceLine);
                codeQueue.Enqueue(removedCommentsLine);
            }

            return codeQueue;
        }
    }
}

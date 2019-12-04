using Skork.Language.Util.Parse;
using System.Collections.Generic;

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

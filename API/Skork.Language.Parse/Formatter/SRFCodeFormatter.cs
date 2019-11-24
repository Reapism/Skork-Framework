using Skork.Language.Util.Parse;
using System;
using System.Collections.Generic;

namespace Skork.Language.Parse.Formatter
{
    /// <summary>
    /// Responsible for replacing whitespaces delimited by a single backslash.
    /// </summary>
    public static class SRFCodeFormatter
    {
        /// <summary>
        /// Formats each potential code line into
        /// <see langword="SkorkReadableFormat"/> (SRF).
        /// </summary>
        /// <param name="codeLines"></param>
        /// <returns></returns>
        public static IEnumerable<string> SRFCodeFormatterFinal(IEnumerable<string> codeLines)
        {
            var codeQueue = new Queue<string>();

            foreach (var line in codeLines)
            {
                var srfFormattedLine = SRFReplaceUtility.ReplaceSpacesWithBackslashes(line);
                codeQueue.Enqueue(srfFormattedLine);
            }

            return codeQueue;
        }
    }
}

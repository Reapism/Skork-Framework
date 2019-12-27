using System;
using System.Collections.Generic;
using System.Linq;

namespace Skork.Language.Util.Parse
{
    public static class SRFTrimUtility
    {
        public static string TrimLeadingAndTrailingWhitespaces(string lineToTrim)
        {
            if (string.IsNullOrEmpty(lineToTrim))
                throw new ArgumentException("Argument cannot be null or empty!", nameof(lineToTrim));
            return lineToTrim.Trim(SRFIsStringIgnorableUtility.IgnorableCharacters);
        }

        public static IEnumerable<string> TrimLeadingAndTrailingWhitespaces(IEnumerable<string> linesToTrim)
        {
            if (linesToTrim == null || !linesToTrim.Any())
                throw new ArgumentException("Argument cannot be null or empty!", nameof(linesToTrim));

            var lineQueue = new Queue<string>();

            using (var sequenceEnum = linesToTrim.GetEnumerator())
            {
                while (sequenceEnum.MoveNext())
                {
                    var trimmedString = TrimLeadingAndTrailingWhitespaces(sequenceEnum.Current);

                    lineQueue.Enqueue(trimmedString);
                }
            }

            return lineQueue;
        }
    }
}

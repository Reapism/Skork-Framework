using System.Collections.Generic;

namespace Skork.Language.Util.Parse
{
    public static class SRFTrimUtility
    {
        public static string TrimLeadingAndTrailingWhitespaces(string lineToTrim)
        {
            return lineToTrim.Trim(SRFIsStringIgnorableUtility.IgnorableCharacters);
        }

        public static IEnumerable<string> TrimLeadingAndTrailingWhitespaces(IEnumerable<string> linesToTrim)
        {
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

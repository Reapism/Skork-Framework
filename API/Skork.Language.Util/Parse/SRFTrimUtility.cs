using System.Collections.Generic;

namespace Skork.Language.Util.Parse
{
    public static class SRFTrimUtility
    {

        public static Queue<string> TrimLeadingAndTrailingWhitespaces(IEnumerable<string> linesToTrim)
        {
            var lineQueue = new Queue<string>();

            using (var sequenceEnum = linesToTrim.GetEnumerator())
            {
                while (sequenceEnum.MoveNext())
                {
                    var trimmedString = sequenceEnum.Current.Trim(SRFIsStringIgnorableUtility.IgnorableCharacters);

                    lineQueue.Enqueue(trimmedString);
                }
            }

            return lineQueue;
        }
    }
}

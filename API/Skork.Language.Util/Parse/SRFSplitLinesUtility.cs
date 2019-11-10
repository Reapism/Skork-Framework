using System.Collections.Generic;

namespace Skork.Language.Util.Parse
{
    public static class SRFSplitLinesUtility
    {
        /// <summary>
        /// Returns a <see cref="Queue{T}"/> containing only
        /// new lines.
        /// </summary>
        /// <param name="linesToSplit">A collection of <see cref="IEnumerable{string}"/>
        /// to split.</param>
        /// <returns></returns>
        public static Queue<string> SplitLines(IEnumerable<string> linesToSplit)
        {
            var lineQueue = new Queue<string>();

            using (var sequenceEnum = linesToSplit.GetEnumerator())
            {
                while (sequenceEnum.MoveNext())
                {
                    if (SRFIsStringIgnorableUtility.IsStringIgnorable(sequenceEnum.Current))
                        continue;

                    lineQueue.Enqueue(sequenceEnum.Current);
                }
            }

            return lineQueue;
        }
    }
}

using System.Collections.Generic;
using System;
namespace Skork.Language.Util.Parse
{
    /// <summary>
    /// Contains functions that splits 
    /// </summary>
    public static class SRFSplitUtility
    {
        /// <summary>
        /// Returns a <see cref="Queue{T}"/>
        /// containing only new lines.
        /// </summary>
        /// <param name="linesToSplit">A collection of
        /// <see cref="IEnumerable{string}"/>
        /// to split.</param>
        /// <returns></returns>
        public static Queue<string> SplitIgnorableLines(IEnumerable<string> linesToSplit)
        {
            if (linesToSplit == null)
            {
                throw new ArgumentNullException("The argument cannot be null.");
            }

            var lineQueue = new Queue<string>();
            using (var sequenceEnum = linesToSplit.GetEnumerator())
            {
                while (sequenceEnum.MoveNext())
                {
                    if (!SRFIsStringIgnorableUtility.IsStringIgnorable(sequenceEnum.Current))
                    {
                        lineQueue.Enqueue(sequenceEnum.Current);
                    }
                }
            }
            return lineQueue;
        }
    }
}

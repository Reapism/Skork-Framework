using System;
using System.Collections.Generic;
using System.Linq;

namespace Skork.Language.Util.Parse
{
    /// <summary>
    /// Contains functions that splits 
    /// </summary>
    public static class SRFSplitUtility
    {
        public static string GetNonIgnorableLine(string lineToSplit)
        {
            if (string.IsNullOrEmpty(lineToSplit))
                throw new ArgumentNullException("The argument cannot be null or empty.");

            if (SRFIsStringIgnorableUtility.IsStringIgnorable(lineToSplit))
                return string.Empty;
            else
                return lineToSplit;
        }

        /// <summary>
        /// Returns a <see cref="IEnumerable{T}"/>
        /// containing only non ignorable lines.
        /// </summary>
        /// <param name="linesToSplit">A collection of
        /// <see cref="IEnumerable{string}"/>
        /// to split.</param>
        /// <returns></returns>
        public static IEnumerable<string> SplitIgnorableLines(IEnumerable<string> linesToSplit)
        {
            if (linesToSplit == null)
                throw new ArgumentNullException("The argument cannot be null.");

            var lineQueue = new Queue<string>();

            using (var sequenceEnum = linesToSplit.GetEnumerator())
            {
                while (sequenceEnum.MoveNext())
                {
                    if (GetNonIgnorableLine(sequenceEnum.Current).Any())
                    {
                        lineQueue.Enqueue(sequenceEnum.Current);
                    }
                }
                return lineQueue;
            }
        }
    }
}
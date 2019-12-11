using System;
using System.Collections.Generic;

namespace Skork.Language.Parse.Cleaner
{
    public static class SRFGetPotentialCodeLines
    {
        private static void ParseCodeLineAsCodeBlock(IEnumerable<string> originalCodeCollection, IEnumerable<string> codeLines)
        {

        }

        private static void ParseCodeLineAsCodeStatement(IEnumerable<string> originalCodeCollection, string codeLine)
        {

        }

        /// <summary>
        /// Takes in an <see cref="IEnumerable{T}"/> of strings
        /// and returns a <see cref="IEnumerable{T}"/> of strings
        /// that are split by semicolons.
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static IEnumerable<string> GetPotentialCodeStatements(IEnumerable<string> originalCodeCollection)
        {
            return GetPotentialCodeStatementsHelper(originalCodeCollection);
        }

        private static IEnumerable<string> GetPotentialCodeStatementsHelper(IEnumerable<string> originalCodeCollection)
        {
            var newCodeQueue = new Queue<string>();

            foreach (string s in originalCodeCollection)
            {
                if (IsCodeBlock(s))
                {
                    ParseCodeLineAsCodeBlock(originalCodeCollection, originalCodeCollection);
                }

                var index = s.IndexOf(';');
                var currentIndex = 0;
                var length = s.Length;
                while (index != -1)
                {
                    newCodeQueue.Enqueue(s.Substring(currentIndex, index - currentIndex));
                    currentIndex = ++index;
                    index = s.IndexOf(';', currentIndex);
                }
            }
            return newCodeQueue;
        }

        /// <summary>
        /// Determines whether a given line begins as a code
        /// statement or not.
        /// </summary>
        /// <param name="codeLine"></param>
        /// <returns></returns>
        private static bool IsCodeStatement(string codeLine)
        {
            int indexSemicolon = codeLine.IndexOf(';');

            return (indexSemicolon != -1) ? true : false;
        }

        /// <summary>
        /// Determines whether a given line begins as a code
        /// block or as a code statement.
        /// </summary>
        /// <param name="codeLine"></param>
        /// <returns></returns>
        private static bool IsCodeBlock(string codeLine)
        {
            int indexCodeBlock = codeLine.IndexOf('{');
            int indexCodeStatement = codeLine.IndexOf(';');

            if (indexCodeBlock != -1)
                return true;
            else if (indexCodeStatement != -1)
                return false;
            else 
                throw new ArgumentException("Code line doesn't ");
        }
    }
}

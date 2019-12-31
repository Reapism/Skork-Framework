using System;
using System.Collections.Generic;
using System.Text;

namespace Skork.Language.Parse.Cleaner
{
    public static class SRFGetPotentialCodeLines
    {
        private static string GetCodeBlock(ref IEnumerable<string> codeLines)
        {
            var codeBlockBuilder = new StringBuilder(codeLines.GetEnumerator().Current);

            while (codeLines.GetEnumerator().MoveNext() && !IsEndingCodeBlock(codeBlockBuilder.ToString()))
            {
                if (codeLines.GetEnumerator().MoveNext())
                    codeBlockBuilder.Append(codeLines.GetEnumerator().Current);
            }

            var codeBlock = codeBlockBuilder.ToString();

            return codeBlock;
        }

        private static IEnumerable<string> GetCodeStatements(string potentialCodeLine)
        {
            var codeStatementsQueue = new Queue<string>();
            var index = potentialCodeLine.IndexOf(';');
            var currentIndex = 0;
            while (index != -1)
            {
                var codeLineSubstring = GetCodeStatementSubstring(potentialCodeLine, currentIndex);
                codeStatementsQueue.Enqueue(codeLineSubstring);
                currentIndex = ++index;
                index = potentialCodeLine.IndexOf(';', currentIndex);
            }

            return codeStatementsQueue;
        }

        private static string GetCodeStatementSubstring(string potentialCodeLine, int currentIndex)
        {
            var index = potentialCodeLine.IndexOf(';', currentIndex);
            var substring = potentialCodeLine[currentIndex..index];

            return substring;
        }

        /// <summary>
        /// Takes in an <see cref="IEnumerable{T}"/> of strings
        /// and returns a <see cref="IEnumerable{T}"/> of strings
        /// that are split by semicolons.
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static IEnumerable<string> GetPotentialCodeStatements(IEnumerable<string> originalCodeCollection)
        {
            return GetPotentialCodeStatementsHelper(originalCodeCollection);
        }

        private static IEnumerable<string> GetPotentialCodeStatementsHelper(IEnumerable<string> originalCodeCollection)
        {
            var newCodeQueue = new Queue<string>();

            foreach (string potentialCodeLine in originalCodeCollection)
            {
                if (IsCodeBlock(potentialCodeLine))
                {
                    var codeBlock = GetCodeBlock(ref originalCodeCollection);
                    newCodeQueue.Enqueue(codeBlock);
                }

                var codeStatements = GetCodeStatements(potentialCodeLine);

                foreach (var codeLine in codeStatements)
                {
                    newCodeQueue.Enqueue(codeLine);
                }
            }
            return newCodeQueue;
        }

        /// <summary>
        /// Determines whether a given line contains a code
        /// block or as a code statement.
        /// </summary>
        /// <param name="codeLine"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        private static bool IsCodeBlock(string codeLine)
        {
            int indexCodeBlock = codeLine.IndexOf('{');
            int indexCodeStatement = codeLine.IndexOf(';');

            if (indexCodeBlock != -1)
                return true;
            else if (indexCodeStatement != -1)
                return false;
            else
                throw new ArgumentException("Code line doesn't contain neither a ; or {.");
        }

        private static bool IsEndingCodeBlock(string codeLine)
        {
            int indexEndingCodeBlock = codeLine.IndexOf('}');

            return (indexEndingCodeBlock != -1) ? true : false;
        }
    }
}
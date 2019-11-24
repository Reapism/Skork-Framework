using System.Collections.Generic;

namespace Skork.Language.Parse.Cleaner
{
    public static class SRFGetPotentialCodeLines
    {
        /// <summary>
        /// Takes in an <see cref="IEnumerable{T}"/> of strings
        /// and returns a <see cref="IEnumerable{T}"/> of strings
        /// that are split by semicolons.
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static IEnumerable<string> GetPotentialCodeStatements(IEnumerable<string> code)
        {
            var newCodeQueue = new Queue<string>();

            foreach (string s in code)
            {
                var index = s.IndexOf(';');
                var startIndex = 0;
                var length = s.Length;
                while (index != -1)
                {
                    newCodeQueue.Enqueue(s.Substring(startIndex, index - startIndex));
                    startIndex = ++index;
                    index = s.IndexOf(';', startIndex);
                }
            }
            return newCodeQueue;
        }

    }
}

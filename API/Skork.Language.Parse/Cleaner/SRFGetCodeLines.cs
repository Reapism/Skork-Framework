using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Skork.Language.Parse.Cleaner
{
    public static class SRFGetCodeLines
    {
        /// <summary>
        /// Takes in an <see cref="IEnumerable{T}"/> of strings
        /// and returns a <see cref="IEnumerable{T}"/> of strings
        /// that are split by semicolons.
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static IEnumerable<string> GetCodeLines(IEnumerable<string> code)
        {
            var newCodeQueue = new Queue<string>();

            foreach (string s in code)
            {
                var split = s.Split(';');
                foreach (string ss in split)
                    newCodeQueue.Enqueue(ss);
            }
            return newCodeQueue;
        }

    }
}

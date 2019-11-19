using System.Collections.Generic;
using System.Text;

namespace Skork.Language.Parse.Cleaner
{
    public static class SRFGetCodeLines
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static IEnumerable<string> GetCodeLines(IEnumerable<string> code)
        {
            var newCodeQueue = new Queue<string>();

            var lineBuilder = new StringBuilder(string.Empty);

            using (var enumerator = code.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    var index = enumerator.Current.IndexOf(';');
                    if (index != -1)
                    {
                        lineBuilder.Append(enumerator.Current.Substring(0, index));
                        newCodeQueue.Enqueue(lineBuilder.ToString());
                    }
                    else
                        lineBuilder.Append(enumerator.Current);
                }
            }

            return newCodeQueue;
        }
    }
}

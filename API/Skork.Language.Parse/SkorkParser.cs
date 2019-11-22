using Skork.Language.Parse.Cleaner;
using Skork.Language.Parse.Interfaces;
using Skork.Language.Util.Parse;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Skork.Language.Parse
{
    public class SkorkParser : ISkorkParser
    {
        public IEnumerable<string> PotentialCode { get; set; }

        /// <summary>
        /// Constructs a <see cref="SkorkParser"/> with a
        /// variable string array.
        /// <para>Internally, it's converted to a <see cref="List{T}"/>.</para>
        /// </summary>
        /// <param name="codeStrArr">Variable number of strings.</param>
        public SkorkParser(params string[] codeStrArr) :
            this(code: codeStrArr.ToList())
        { }

        /// <summary>
        /// Constructs a <see cref="SkorkParser"/> instance with
        /// an <see cref="IEnumerable{T}"/> potential code list.
        /// </summary>
        /// <param name="code"></param>
        public SkorkParser(IEnumerable<string> code)
        {
            PotentialCode = code ??
                throw new ArgumentNullException("The argument cannot be null!");
        }

        //TODO Use Skork.Language.Parse classes instead of calling each function in order this function is responsible for too many things.
        public IEnumerable<string> Parse()
        {
            var codeLines = SRFGetCodeLines.GetCodeLines(PotentialCode);
            
            var codeQueue = SRFSplitUtility.SplitIgnorableLines(codeLines);
            
            codeQueue = SRFTrimUtility.TrimLeadingAndTrailingWhitespaces(codeQueue);

            var srfCodeQueue = new Queue<string>();

            foreach (var line in codeQueue)
            {
                var singleWhitespaceLine = SRFReplaceUtility.ReplaceMultipleWhitespacesWithSingleWhitespace(line);
                var singleSpaceLine = SRFReplaceUtility.ReplaceMultipleWhitespacesWithSingleWhitespace(singleWhitespaceLine);
                var srfFormattedLine = SRFReplaceUtility.ReplaceSpacesWithBackslashes(singleSpaceLine);
                srfCodeQueue.Enqueue(srfFormattedLine);
            }

            return srfCodeQueue;
        }
    }
}

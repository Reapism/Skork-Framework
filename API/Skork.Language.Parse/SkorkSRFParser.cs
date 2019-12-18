using Skork.Language.Parse.Cleaner;
using Skork.Language.Parse.Formatter;
using Skork.Language.Parse.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Skork.Language.Parse
{
    public class SkorkSRFParser : ISkorkSRFParser
    {
        public IEnumerable<string> PotentialCode { get; set; }

        /// <summary>
        /// Constructs a <see cref="SkorkSRFParser"/> with a
        /// variable string array.
        /// <para>Internally, it's converted to a <see cref="List{T}"/>.</para>
        /// </summary>
        /// <param name="codeStrArr">Variable number of strings.</param>
        public SkorkSRFParser(params string[] codeStrArr) :
            this(code: codeStrArr.ToList() ?? new List<string>())
        { }

        /// <summary>
        /// Constructs a <see cref="SkorkSRFParser"/> instance with
        /// an <see cref="IEnumerable{T}"/> potential code list.
        /// </summary>
        /// <param name="code"></param>
        public SkorkSRFParser(IEnumerable<string> code)
        {
            if (code == null || !code.Any()) 
                throw new ArgumentNullException("The argument cannot be null or empty!");

            PotentialCode = code;
        }

        /// <summary>
        /// Returns potential skork code parsed into <see langword="SkorkReadableFormat"/>.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> Parse()
        {
            var potentialCodeStatementsEnumerable = SRFGetPotentialCodeLines.GetPotentialCodeStatements(PotentialCode);
            var cleanedPotentialCodeEnumerable = SRFCodeCleaner.CleanPotentialCodeLines(potentialCodeStatementsEnumerable);
            var srfCodeFormattedEnumerable = SRFCodeFormatter.SRFCodeFormatterFinal(cleanedPotentialCodeEnumerable);

            return srfCodeFormattedEnumerable;
        }
    }
}

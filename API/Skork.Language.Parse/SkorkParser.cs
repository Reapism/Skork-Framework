using Skork.Language.Parse.Interfaces;
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

        /// <summary>
        /// Parses the <see cref="PotentialCode"/> into
        /// <see langword="SkorkReadableFormat"/>.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> Parse()
        {
            // first split
            // trim
            // replace ??

        }
    }
}

using Skork.Language.Parse.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Skork.Language.Parse
{
    public class SkorkParser : ISkorkParser
    {
        public IEnumerable<string> PotentialCode { get; set; }

        public SkorkParser(params string[] codeStrArr) :
            this(code: codeStrArr.ToList())
        { }

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
            throw new NotImplementedException();
        }
    }
}

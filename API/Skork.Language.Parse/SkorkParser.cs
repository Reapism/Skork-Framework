using Skork.Language.Parse.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Skork.Language.Parse
{
    public class SkorkParser : ISkorkParser
    {
        public List<string> PotentialCode { get; set; }

        public SkorkParser(params string[] codeStrArr) :
            this(codeList: codeStrArr.ToList())
        { }

        public SkorkParser(List<string> codeList)
        {
            PotentialCode = codeList ??
                throw new ArgumentNullException("The argument cannot be null!");
        }

        /// <summary>
        /// Parses the <see cref="PotentialCode"/> into
        /// <see langword="SkorkReadableFormat"/>.
        /// </summary>
        /// <returns></returns>
        public List<string> Parse()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;

namespace Skork.Language.Util.Parse.Formatter
{
    public static class SRFOperatorUtility
    {
        /// <summary>
        /// A list of single character <see cref="char"/>[] array.
        /// </summary>
        public static Dictionary<string, string> OperatorDictionary { get; }

        /// <summary>
        /// The ignorable characters or whitespace characters 
        /// that are omitted from the code.
        /// </summary>
        public static char[] MultiCharacterOperators { get; }

        static SRFOperatorUtility()
        {
            OperatorDictionary = new Dictionary<string, string>();
        }

        public static bool IsOperatorContained(string codeLine)
        {
            throw new NotImplementedException();
            //return codeLine.IndexOf()
        }
    }
}

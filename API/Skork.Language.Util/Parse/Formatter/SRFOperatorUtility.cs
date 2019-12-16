using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

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
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = assembly.GetFile("Operators.txt");

            OperatorDictionary = new Dictionary<string, string>();
            using (var stream = assembly.GetManifestResourceStream(resourceName.Name))
            {
                using (var streamReader = new StreamReader(stream))
                {
                    var textFileString = streamReader.ReadToEnd();

                    var getLines = textFileString.Split('\n', StringSplitOptions.RemoveEmptyEntries);
                }
            }
        }

        public static bool IsOperatorContained(string codeLine)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Skork.Language.Util.Parse
{
    public static class SRFReplaceUtility
    {
        public static string ReplaceWhitespacesWithSingleSpaces(string strValue)
        {
            if (strValue == null)
            {
                throw new ArgumentNullException("Argument cannot be null.");
            }

            var index = 0;
            var strValueCharArray = strValue.ToCharArray();
            bool skip = false;
            char ch;

            for (int i = 0; i < strValue.Length; i++)
            {
                ch = strValueCharArray[i];
                if (strValueCharArray.Any(c => SRFIsStringIgnorableUtility.IgnorableCharacters.Contains(c)))
                {
                    if (skip) continue;
                    strValueCharArray[index++] = ch;
                    skip = true;
                }
                else
                {
                    skip = false;
                    strValueCharArray[index++] = ch;
                }

            }
            return strValueCharArray.ToString();

        }
    }
}


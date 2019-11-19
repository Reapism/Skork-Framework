using System;
using System.Text.RegularExpressions;

namespace Skork.Language.Util.Parse
{
    public static class SRFReplaceUtility
    {
        /// <summary>
        /// Replaces multiple whitespace character within 
        /// the inner part of a <see cref="string"/> and
        /// returns a new <see cref="string "/>.
        /// <para>Returns <see langword="null"/> if empty string is provided.</para>
        /// </summary>
        /// <param name="strValue"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="RegexMatchTimeoutException"></exception>
        public static string ReplaceMultipleWhitespacesWithSingleSpace(string strValue)
        {
            return Regex.Replace(strValue, @"(\s)\s+", "$1");
        }

        /// <summary>
        /// Returns a string that replaces whitespaces with a backslash.
        /// <para>E.g. "Hello World" -> "Hello\World"</para>
        /// </summary>
        /// <param name="strValue"></param>
        /// <returns></returns>
        public static string ReplaceSpacesWithBackslashes(string strValue)
        {
            return strValue.Replace(' ', '\\');
        }
    }
}


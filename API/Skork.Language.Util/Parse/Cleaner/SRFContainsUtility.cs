using System;
using System.Linq;

namespace Skork.Language.Util.Parse
{
    /// <summary>
    /// A utility class for <see cref="SRF"/>
    /// </summary>
    public static class SRFContainsUtility
    {
        /// <summary>
        /// Returns whether a given <see langword="char"/>
        /// appears in every index of a <see langword="string"/>.
        /// </summary>
        /// <param name="strValue">The string to check.</param>
        /// <param name="charValue">The character to check.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">Thrown if the 
        /// <paramref name="strValue"/> is null or empty!</exception>
        public static bool ContainsOnly(in string strValue, char charValue)
        {
            if (string.IsNullOrEmpty(strValue))
                throw new ArgumentNullException("String cannot be null or empty.");

            for (int i = 0; i < strValue.Length; i++)
            {
                if (strValue[i] != charValue)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Returns whether a set of characters only
        /// exists in each index of a <see langword="string"/>.
        /// </summary>
        /// <param name="strValue">The string to check.</param>
        /// <param name="charValue">The character to check.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">Thrown if the 
        /// <paramref name="strValue"/> is null or empty!</exception>
        public static bool ContainsOnlyChars(in string strValue, params char[] charValues)
        {
            if (string.IsNullOrEmpty(strValue))
                throw new ArgumentNullException("String cannot be null or empty.");

            for (int index = 0; index < strValue.Length; index++)
                if (!charValues.Contains(strValue[index]))
                    return false;
            return true;
        }

    }
}
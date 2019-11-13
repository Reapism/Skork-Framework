namespace Skork.Language.Util.Parse
{
    public class SRFIsStringIgnorableUtility
    {
        /// <summary>
        /// The ignorable characters or whitespace characters 
        /// that are omitted from the code.
        /// </summary>
        public static char[] IgnorableCharacters { get; }

        static SRFIsStringIgnorableUtility()
        {
            IgnorableCharacters = new char[] { ' ', '\f', '\n', '\r', '\t', '\v' };
        }

        /// <summary>
        /// Returns whether a given string should be ignored.
        /// <para>Whitespace, tabs, empty lines, whitespace lines are ignorable.</para>
        /// </summary>
        /// <returns></returns>
        public static bool IsStringIgnorable(string strValue)
        {
            return SRFContainsUtility.ContainsOnlyChars(strValue, IgnorableCharacters);
        }
    }
}

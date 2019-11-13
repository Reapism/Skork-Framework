using System;

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

            int current = 0;
            char[] output = new char[strValue.Length];
            bool skipped = false;

            foreach (char c in strValue.ToCharArray())
            {
                if (char.IsWhiteSpace(c))
                {
                    if (!skipped)
                    {
                        if (current > 0)
                            output[current++] = ' ';

                        skipped = true;
                    }
                }
                else
                {
                    skipped = false;
                    output[current++] = c;
                }
            }

            return new string(output, 0, current);
        }
    }
}


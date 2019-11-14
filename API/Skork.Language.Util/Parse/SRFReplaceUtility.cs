﻿using System;
using System.Text;

namespace Skork.Language.Util.Parse
{
    public static class SRFReplaceUtility
    {
        public static string ReplaceMultipleWhitespacesWithSingleSpace(string strValue)
        {
            if (strValue == null)
                throw new ArgumentNullException("Argument cannot be null.");

            StringBuilder stringBuilder = new StringBuilder(strValue.Length);
            for (int i = 0; i < strValue.Length; i++)
            {
                char c = strValue[i];
                if (i == 0 || !char.IsWhiteSpace(c) || (char.IsWhiteSpace(c) && !char.IsWhiteSpace(strValue[i - 1])))
                    stringBuilder.Append(c);
            }
            return stringBuilder.ToString();
        }
    }
}


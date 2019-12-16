namespace Skork.Language.Util.Parse
{
    public static class SRFCommentUtility
    {
        public static string RemoveCommentsFromCodeLine(string codeLine)
        {
            int index = codeLine.IndexOf("//");
            if (index != -1)
            {
                return codeLine.Substring(0, index);
            }
            return codeLine;
        }
    }
}

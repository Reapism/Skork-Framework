using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Skork_Engine_Library.Parse
{
    /// <summary>
    /// The <see cref="SkorkParser"/> class.
    /// 
    /// <para>Contains skork code in <see langword="SkorkReadableFormat"/>
    /// ready to be compiled.</para>
    /// 
    /// <para>Use: Instantiate a <see cref="SkorkParser"/> instance with
    /// your formatted or unformatted code in a <see cref="List{T}"/> object.
    /// </para>
    /// 
    /// <para>Finally, invoke the <see cref="Compile.SkorkCompile.CompileSkorkCode(SkorkParser)"/>
    /// function.</para>
    /// 
    /// </summary>
    public class SkorkParser
    {

        /// <summary>
        /// Gets the formatted code in a <see cref="List{T}"/>.
        /// <para>The code in this instance cannot be set once again.</para>
        /// <para>You must reinstantiate this instance or use another one in order
        /// to set the Code by invoking the constructor.</para>
        /// </summary>
        public List<string> Code { get; internal set; }

        /// <summary>
        /// Instantiates the <see cref="SkorkParser"/> instance with clean code lines.
        /// <para>Cleans the code whether it's needed or not and returns a new 
        /// reference to the clean code of type <see cref="List{T}"/>.
        /// <para>The attempt is to remove trailing spaces and new lines
        /// from the code and then putting each potentially valid code line
        /// on its own line.</para></para>
        /// </summary>
        /// <param name="code">The formatted/unformatted code lines in a <see cref="List{T}"/></param>
        public SkorkParser(ref List<string> code)
        {
            Code = CleanCode(ref code);
        }

        /// <summary>
        /// Cleans the code whether it's needed or not and returns a new 
        /// reference to the clean code of type <see cref="List{T}"/>.
        /// <para>The attempt is to remove trailing spaces and new lines
        /// from the code and then putting each potentially valid code line
        /// on its own line.</para>
        /// </summary>
        /// <param name="code">The code in the form of a <see cref="List{T}"/>.</param>
        /// <returns></returns>
        private List<string> CleanCode(ref List<string> code)
        {
            List<string> newCode = new List<string>();

            // finds trailing spaces and ignores them.
            foreach (string line in code)
            {
                int pos = line.IndexOf(' ');

                if (pos != -1)
                { // Checks if there is a space.
                    string subStr = line.Substring(pos, line.IndexOf(' ', pos));
                    newCode.Add(subStr);
                }
            }

            // combine mutliple lines into a single one terminating
            // into a semicolon.
            List<string> codeSplit = new List<string>();
            StringBuilder appendedLine = new StringBuilder(string.Empty);

            foreach (string s in newCode)
            {
                appendedLine.Append(s);

                if (appendedLine.ToString().Contains(";"))
                {
                    codeSplit.Add(appendedLine.ToString());
                    appendedLine.Clear();
                }
            }

            return codeSplit;
        }

        /// <summary> 
        /// Returns a substring from another string from char c1[in], to c2[ex].
        /// </summary>
        /// <param name="s">The string to read from.</param>
        /// <param name="c1">Inclusive begining character.</param>
        /// <param name="c2">Exclusive ending character.</param>
        /// <returns>The substring from c1(incl.) - c2(excl.), else; null</returns>
        private string ReadUntil(string s, char c1, char c2 = '\n')
        {
            return (s.Contains(c1) && s.Contains(c2)) ? s.Substring(s.IndexOf(c1),
                s.IndexOf(c2) - s.IndexOf(c1)) : null;
        }

        /// <summary> 
        /// Returns a substring from another string from string s1[in], to c2[ex].
        /// </summary>
        /// <param name="s">The string to read from.</param>
        /// <param name="s1">Inclusive begining string.</param>
        /// <param name="c2">Exclusive ending character.</param>
        /// <returns>The substring from c1(incl.) - c2(excl.), else; null</returns>
        private string ReadUntil(string s, string s1, char c2 = '\n')
        {
            return (s.Contains(s1) && s.Contains(c2)) ? s.Substring(s.IndexOf(s1),
                s.IndexOf(c2) - s.IndexOf(s1)) : null;
        }

        /// <summary> 
        /// Returns a substring from another string from string c1[in], to s2[ex].
        /// </summary>
        /// <param name="s">The string to read from.</param>
        /// <param name="c1">Inclusive begining character.</param>
        /// <param name="s2">Exclusive ending string.</param>
        /// <returns>The substring from c1(incl.) - c2(excl.), else; null</returns>
        private string ReadUntil(string s, char c1, string s2 = "\n")
        {
            return (s.Contains(c1) && s.Contains(s2)) ? s.Substring(s.IndexOf(c1),
                s.IndexOf(s2) - s.IndexOf(c1)) : null;
        }

        /// <summary> 
        /// Returns a substring from another string from string s1[in], to s2[ex].
        /// </summary>
        /// <param name="s">The string to read from.</param>
        /// <param name="s1">Inclusive begining string.</param>
        /// <param name="s2">Exclusive ending string.</param>
        /// <returns>The substring from s1(incl.) - s2(excl.), else; null</returns>
        private string ReadUntil(string s, string s1, string s2 = "\n")
        {
            return (s.Contains(s1) && s.Contains(s2)) ? s.Substring(s.IndexOf(s1),
                s.IndexOf(s2) - s.IndexOf(s1)) : null;
        }

        /// <summary>
        /// Reads between first occuring characters in a string
        /// </summary>
        /// <param name="s">The string.</param>
        /// <param name="c1">The first character to encounter</param>
        /// <param name="c2">The second character to encounter</param>
        /// <returns>The substring between the two characters</returns>
        private string ReadBetween(string s, char c1, char c2)
        {
            return (s.Contains(c1) && s.Contains(c2)) ? s.Substring(s.IndexOf(c1) + 1,
                s.IndexOf(c2) - s.IndexOf(c1) - 1) : null;
        }

        /// <summary>
        /// Gets a line from a string from beginning to a carriage-return (\n)
        /// </summary>
        /// <param name="s">The string.</param>
        /// <returns>Returns a substring from s where a new line is contained.</returns>
        private string GetLine(string s)
        {
            int i = s.LastIndexOf('\n');
            return (i != -1) ? s.Substring(0, i) : s + "\n";
        }

        /// <summary>
        /// Gets a line from a string from beginning to a specific last
        /// occuring character.
        /// If character is not found, returns a string
        /// </summary>
        /// <param name="s">The string.</param>
        /// <param name="c">The character to terminate the string.</param>
        /// <returns>Returns a substring from s where c is contained.</returns>
        private string SplitString(string s, char c)
        {
            int i = s.LastIndexOf(c);
            return (i != -1) ? s.Substring(0, i) : s + "\n";
        }

        /// <summary>
        /// Determines if the string contains only a specific character.
        /// </summary>
        /// <param name="s">The string to search.</param>
        /// <param name="c">The character to compare.</param>
        /// <returns>Returns true if the string contains only the character, false otherwise.</returns>
        private bool ContainsOnly(string s, char c)
        {
            if (s == null)
            { return false; }

            for (int i = 0; i < s.Length; i++)
            {
                if (s.ElementAt(i) != c)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Determines if a character appears in a string. 
        /// </summary>
        /// <param name="s">The string to search.</param>
        /// <param name="c">The character to compare.</param>
        /// <returns></returns>
        private bool DoesNotContain(string s, char c)
        {
            if (s == null)
            { return false; }

            for (int i = 0; i < s.Length; i++)
            {
                if (s.ElementAt<char>(i) == c)
                { return false; }
            }
            return true;
        }

        /// <summary>
        /// Separates a string into a collection.
        /// </summary>
        /// <param name="s">The string to get lines from.</param>
        /// <returns>A string collection of substrings.</returns>
        private List<string> GetLines(string s)
        {
            if (s == null)
            { return null; }

            List<string> sc = new List<string>();
            StringReader sr = new StringReader(s);

            string line;

            while (((line = sr.ReadLine()) != null))
            {
                if (line != string.Empty && !(ContainsOnly(line, ' ')))
                {
                    sc.Add(line);
                }
            }

            sr.Close();
            return sc;
        }

        /// <summary>
        /// Returns a string stating the instances hashcode.
        /// </summary>
        /// <returns>A string containing the hashcode of the instance.</returns>
        public override string ToString()
        {
            return $"The Util class object {GetHashCode()}";
        }
    }
}

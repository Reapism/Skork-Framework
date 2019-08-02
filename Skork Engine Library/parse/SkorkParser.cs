using SkorkEngine.exception;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;

namespace Skork_Engine_Library.parse {
    /// <summary>
    /// The <see cref="SkorkParser"/> class.
    /// 
    /// <para>Contains a lot of functions for
    /// parsing text into Skork format and other
    /// various helper functions.</para>
    /// </summary>
    public class SkorkParser {

        /// <summary>
        /// Invoke this method to parse potential Skork code
        /// into SkorkReadable format.
        /// 
        /// <para>Invoke the <see cref="CompileSkorkCode"/> function if you are
        /// attempting to compile.</para>
        /// </summary>
        /// <param name="code">The code in the form of a <see cref="List{T}"/>.</param>
        /// <returns></returns>
        private List<string> ParseCode(List<string> code) {
            code.TrimExcess();
            code = CleanCode(code);
            return ConsolidateCode(code);
        }

        /// <summary>
        /// Attempts to parse potential Skork code into it's native
        /// SkorkReadableFormat.
        /// 
        /// <para>Invoking this method will clean the code, format it for the compiler to understand,
        /// and attempt to compile.</para>
        /// 
        /// <para>Returns compilation notes using ints. 0 is successful.</para>
        /// </summary>
        /// <exception cref="SkorkInvalidNameException"></exception>
        /// <exception cref="SkorkException"></exception>
        /// <returns></returns>
        public int CompileSkorkCode(List<string> code) {
            List<string> compiledCode = ParseCode(code);
            compiledCode.TrimExcess();
            return 1;
        }

        /// <summary>
        /// Cleans the code whether it's needed or not and returns a new 
        /// reference to the clean code of type <see cref="List{T}"/>.
        /// </summary>
        /// <param name="code">The code in the form of a parameterized string array.</param>
        /// <returns></returns>
        private List<string> CleanCode(params string[] code) {
            List<string> newCode = new List<string>();

            foreach (string line in code) {
                int pos = line.IndexOf(' ');

                if (pos != -1) { // Checks if there is a space.
                    string subStr = line.Substring(pos, line.IndexOf(' ', pos));
                    newCode.Add(subStr);
                }
            }

            return newCode;
        }

        /// <summary>
        /// Cleans the code whether it's needed or not and returns a new 
        /// reference to the clean code of type <see cref="List{T}"/>.
        /// </summary>
        /// <param name="code">The code in the form of a <see cref="List{T}"/>.</param>
        /// <returns></returns>
        private List<string> CleanCode(List<string> code) {
            List<string> newCode = new List<string>();

            foreach (string line in code) {
                int pos = line.IndexOf(' ');

                if (pos != -1) { // Checks if there is a space.
                    string subStr = line.Substring(pos, line.IndexOf(' ', pos));
                    newCode.Add(subStr);
                }
            }

            return newCode;
        }

        /// <summary>
        /// Consolidates the code whether it's needed or not and returns a new 
        /// reference to the consolidated code of type <see cref="List{T}"/>.
        /// </summary>
        /// <param name="code"></param>
        private List<string> ConsolidateCode(List<string> code) {
            List<string> newCode = new List<string>();
            string multiLine = string.Empty; //represents a line concatonated from different lines.

            foreach (string line in code) {
                multiLine += line;

                if (multiLine.Contains(";")) {
                    newCode.Add(multiLine);
                    multiLine = string.Empty;
                }

            }
            return newCode;
        }

        /// <summary> 
        /// Returns a substring from another string from char c1[in], to c2[ex].
        /// </summary>
        /// <param name="s">The string to read from.</param>
        /// <param name="c1">Inclusive begining character.</param>
        /// <param name="c2">Exclusive ending character.</param>
        /// <returns>The substring from c1(incl.) - c2(excl.), else; null</returns>
        public string ReadUntil(string s, char c1, char c2 = '\n') {
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
        public string ReadUntil(string s, string s1, char c2 = '\n') {
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
        public string ReadUntil(string s, char c1, string s2 = "\n") {
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
        public string ReadUntil(string s, string s1, string s2 = "\n") {
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
        public string ReadBetween(string s, char c1, char c2) {
            return (s.Contains(c1) && s.Contains(c2)) ? s.Substring(s.IndexOf(c1) + 1,
                s.IndexOf(c2) - s.IndexOf(c1) - 1) : null;
        }

        /// <summary>
        /// Gets a line from a string from beginning to a carriage-return (\n)
        /// </summary>
        /// <param name="s">The string.</param>
        /// <returns>Returns a substring from s where a new line is contained.</returns>
        public string GetLine(string s) {
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
        public string SplitString(string s, char c) {
            int i = s.LastIndexOf(c);
            return (i != -1) ? s.Substring(0, i) : s + "\n";
        }

        /// <summary>
        /// Determines if the string contains only a specific character.
        /// </summary>
        /// <param name="s">The string to search.</param>
        /// <param name="c">The character to compare.</param>
        /// <returns>Returns true if the string contains only the character, false otherwise.</returns>
        public bool ContainsOnly(string s, char c) {
            if (s == null) { return false; }

            for (int i = 0; i < s.Length; i++) {
                if (s.ElementAt<char>(i) != c) {
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
        public bool DoesNotContain(string s, char c) {
            if (s == null) { return false; }

            for (int i = 0; i < s.Length; i++) {
                if (s.ElementAt<char>(i) == c) { return false; }
            }
            return true;
        }

        /// <summary>
        /// Separates a string into a collection.
        /// </summary>
        /// <param name="s">The string to get lines from.</param>
        /// <returns>A string collection of substrings.</returns>
        public List<string> GetLines(string s) {
            if (s == null) { return null; }

            List<string> sc = new List<string>();
            StringReader sr = new StringReader(s);

            string line;

            while (((line = sr.ReadLine()) != null)) {
                if (line != string.Empty && !(ContainsOnly(line, ' '))) {
                    sc.Add(line);
                }
            }

            sr.Close();
            return sc;
        }

        /// <summary>
        /// Return the contents of the entire file as a string.
        /// </summary>
        /// <param name="path">The path of the file to read from.</param>
        /// <returns>All the contents of the file as type string.</returns>
        public string ReadFile(string path) {
            string s;

            try {
                s = System.IO.File.ReadAllText(path);
                return s;
            } catch {
                return null;
            }
        }

        /// <summary>
        /// Gets a file online in a byte array.
        /// </summary>
        /// <param name="url">The url to download from.</param>
        /// <returns></returns>
        public byte[] GetOnlineFile(string url) {
            byte[] b;

            using (WebClient client = new WebClient()) {

                try {
                    b = client.DownloadData(url);
                    return b;
                } catch {
                    return null;
                }
            }
        }

        /// <summary>
        /// Returns a string from converting a byte array.
        /// </summary>
        /// <param name="arr">The byte array to convert.</param>
        /// <returns>Returns a string from a byte array.</returns>
        public string GetString(byte[] arr) {
            return System.Text.Encoding.ASCII.GetString(arr);
        }

        /// <summary>
        /// Returns a byte array from converting a string.
        /// </summary>
        /// <param name="s">The string to convert.</param>
        /// <returns>Returns a byte array from a string.</returns>
        public byte[] GetBytes(string s) {
            try {
                return System.Text.Encoding.ASCII.GetBytes(s);
            } catch {
                return null;
            }
        }

        /// <summary>
        /// Returns a string stating the instances hashcode.
        /// </summary>
        /// <returns>A string containing the hashcode of the instance.</returns>
        public override string ToString() {
            return $"The Util class object {GetHashCode()}";
        }
    }
}

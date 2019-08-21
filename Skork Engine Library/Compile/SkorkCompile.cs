using Skork_Engine_Library.Parse;
using SkorkEngine.Exception;
using System.Collections.Generic;

namespace Skork_Engine_Library.Compile {
    public class SkorkCompile {

        private SkorkParser parser;

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
        public int CompileSkorkCode() {
            List<string> compiledCode = new List<string>();
            int compileReturn;
            try {
                compileReturn = this.parser.CompileSkorkCode(compiledCode);
                return 0;
            } catch (SkorkInvalidNameException) {
                return 3;
            } catch (SkorkSyntaxException) {
                return 2;
            } catch (SkorkException) {
                return 1;
            }
        }


    }
}

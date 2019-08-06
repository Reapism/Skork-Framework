using Skork_Engine_Library.parse;
using SkorkEngine.exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skork_Engine_Library.Compile {
    class SkorkCompile {

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
            try {
                parser.CompileSkorkCode(compiledCode);
                return 0;
            } catch (SkorkInvalidNameException sine) {
                return 5;
            } catch (SkorkException se) {

            } catch (SkorkException se) {

            } catch (SkorkException se) {
                return 4;
            } catch () {

            }
            compiledCode.TrimExcess();
            return 1;
        }


    }
}

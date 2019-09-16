using Skork_Engine_Library.Parse;
using SkorkEngine.Exceptions;

namespace SkorkEngineAPI.Compile
{
    /// <summary>
    /// The <see cref="SkorkCompile"/> class.
    /// <para>This class uses a <see cref="SkorkParser"/> instance
    /// to compile Skork code.</para>
    /// </summary>
    public class SkorkCompile
    {

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
        /// <exception cref="SkorkSyntaxException"></exception>
        /// <exception cref="SkorkInvalidNameException"></exception>
        /// <exception cref="SkorkException"></exception>
        /// <returns></returns>
        public static int CompileSkorkCode(SkorkParser parser)
        {


            return 0;

        }


    }
}

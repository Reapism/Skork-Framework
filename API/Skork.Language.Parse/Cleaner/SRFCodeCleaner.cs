
using System.Collections.Generic;

namespace Skork.Language.Parse.Cleaner
{
    public class SRFCodeCleaner
    {
        private IEnumerable<string> _code;

        public SRFCodeCleaner(IEnumerable<string> code)
        {
            _code = code;
        }

        public IEnumerable<string> ParseCodeIntoSRF()
        {
            return ParseCodeIntoSRFHelper();
        }

        private IEnumerable<string> ParseCodeIntoSRFHelper()
        {
            var codeQueue = new Queue<string>();

            //codeQueue = SRFSplitUtility.SplitLines(_code);

            return codeQueue;
        }
    }
}

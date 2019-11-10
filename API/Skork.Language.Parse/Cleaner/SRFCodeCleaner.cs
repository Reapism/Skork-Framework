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
            TrimExtraLines();
            TrimSpaces();
            Cleaner();

            return _code;
        }

        private void TrimExtraLines()
        {

            var trimmedCode = new List<string>();

            foreach (var line in _code)
            {
                //   if (line.Contains())
            }


        }

        private void TrimSpaces()
        {

        }

        private void Cleaner()
        {

        }
    }
}

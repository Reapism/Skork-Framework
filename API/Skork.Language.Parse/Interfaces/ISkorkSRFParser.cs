using System.Collections.Generic;

namespace Skork.Language.Parse.Interfaces
{
    public interface ISkorkSRFParser
    {
        IEnumerable<string> PotentialCode { get; set; }

        IEnumerable<string> Parse();
    }
}
using System.Collections.Generic;

namespace Skork.Language.Parse.Interfaces
{
    public interface ISkorkParser
    {
        List<string> PotentialCode { get; set; }

        List<string> Parse();
    }
}
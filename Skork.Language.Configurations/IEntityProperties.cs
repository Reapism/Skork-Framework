using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skork.Language.Configurations
{
    public interface IEntityProperties
    {
        int ActiveEntityInstances { get; set; }

        int MaximumEntityInstances { get; set; }
    }
}

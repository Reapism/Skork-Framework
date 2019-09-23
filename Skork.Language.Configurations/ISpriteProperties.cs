using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skork.Language.Configurations
{
    public interface ISpriteProperties
    {
        int ActiveSpriteInstances { get; set; }

        int MaximumSpriteInstances { get; set; }

        int SpriteWidth { get; set; }

        int SpriteHeight { get; set; }
    }
}

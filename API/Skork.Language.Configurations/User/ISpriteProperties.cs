using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skork.Language.Configurations
{
    /// <summary>
    /// Represents generalized properties for a Sprite.
    /// </summary>
    public interface ISpriteProperties
    {
        /// <summary>
        /// Represents the number of active sprite entity instances in a given context.
        /// </summary>
        int ActiveSpriteInstances { get; set; }

        /// <summary>
        /// Represents the maximum number of active sprite entity instances in a given context.
        /// </summary>
        int MaximumSpriteInstances { get; set; }

        /// <summary>
        /// Represents the width of a sprite entity instance in a given context.
        /// </summary>
        int SpriteWidth { get; set; }

        /// <summary>
        /// Represents the height of a sprite entity instance in a given context.
        /// </summary>
        int SpriteHeight { get; set; }
    }
}

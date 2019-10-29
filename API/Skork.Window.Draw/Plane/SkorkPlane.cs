using Skork.Language.Configurations;
using Skork.Language.Entities.Template;
using System.Collections.Generic;
using System.Drawing;

namespace Skork.Window.Draw.Plane
{
    /// <summary>
    /// The <see cref="SkorkPlane"/> class.
    /// <para>Contains an instance of a plane
    /// and its properties.</para>
    /// </summary>
    public sealed class SkorkPlane
    {
        /// <summary>
        /// The properties of the plane.
        /// </summary>
        public SkorkPlaneProperties PlaneProperties { get; set; }

        public Queue<ISkorkEntity> ActiveEntities { get; private set; }

        public SkorkPlane()
        {
            PlaneProperties = new SkorkPlaneProperties
            {
                ColorPrimary = Color.Black,
                ColorSecondary = Color.White,
                Width = SkorkEntityProperties.Instance.SpriteWidth,
                Height = SkorkEntityProperties.Instance.SpriteHeight,
                Image = null
            };

            ActiveEntities = new Queue<ISkorkEntity>(SkorkEntityProperties.Instance.MaximumEntityInstances);
        }
    }
}

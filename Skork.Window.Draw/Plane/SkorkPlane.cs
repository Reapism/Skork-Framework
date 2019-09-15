using Skork.Language.Configurations;
using Skork.Language.Entities.Template;
using System.Collections.Generic;
using System.Windows.Media;

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
                ColorPrimary = Colors.Black,
                ColorSecondary = Colors.White,
                Width = SkorkProperties.SpriteWidth,
                Height = SkorkProperties.SpriteHeight,
                Image = null
            };

            ActiveEntities = new Queue<ISkorkEntity>(SkorkProperties.MaximumEntityInstances);           
        }



    }
}

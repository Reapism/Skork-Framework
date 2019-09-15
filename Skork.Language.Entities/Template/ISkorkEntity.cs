using System.Drawing;
using System.Windows;

namespace Skork.Language.Entities.Template {

    /// <summary>
    /// Fundamental properties for any <see cref="ISkorkEntity"/>.
    /// </summary>
    public interface ISkorkEntity {

        /// <summary>
        /// The name associated with this entity.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// The 2D position of the entity.
        /// </summary>
        Point Position { get; set; }
    }
}

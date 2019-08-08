using System.Windows;

namespace Skork_Engine_Library.Skork {

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

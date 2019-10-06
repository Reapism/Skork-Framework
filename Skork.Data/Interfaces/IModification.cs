using System;

namespace Skork.Data.Interfaces
{
    public interface IModification
    {
        /// <summary>
        /// The <see cref="DateTime"/> that was last
        /// modified by.
        /// </summary>
        DateTime DateModified { get; set; }

        /// <summary>
        /// The <see cref="DateTime"/> that was 
        /// created by.
        /// </summary>
        DateTime DateCreated { get; set; }

        /// <summary>
        /// Represents if a model has been modified.
        /// </summary>
        bool IsModified { get; set; }

    }
}

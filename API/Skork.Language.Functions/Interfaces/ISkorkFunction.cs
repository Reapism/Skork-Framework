/// <summary>
/// The <see cref="Skork_Engine_Library"/> project.
/// Created by Anthony Jaghab (c), all rights reserved.
/// </summary>
namespace Skork.Language.Functions.Interfaces
{
    public interface ISkorkFunction
    {
        /// <summary>
        /// Invoke optionally takes a parameter and returns
        /// an object.
        /// </summary>
        /// <param name="obj">An optional object parameter.</param>
        /// <returns></returns>
        object Invoke(object obj = null);
    }
}

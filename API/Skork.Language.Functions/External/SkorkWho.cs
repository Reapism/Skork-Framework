using Skork.Language.Entities.Template;
using Skork.Language.Functions.Interfaces;
using System.Threading.Tasks;

namespace Skork.Language.Functions.External
{
    /// <summary>
    /// The <see cref="SkorkWho"/> class.
    /// <para>When invoked on an <see cref="ISkorkEntity"/>, invokes the objects
    /// ToString() method and returns it.</para>
    /// </summary>
    public class SkorkWho : ISkorkFunction
    {
        /// <summary>
        /// If the incoming <paramref name="obj"/> is of 
        /// type <see cref="ISkorkEntity"/>, it will return
        /// the result of it's <see langword="object.ToString()"/>.
        /// </summary>
        /// <param name="obj">The object to get its string information.</param>
        /// <returns></returns>
        public object Invoke(object obj)
        {
            if (obj is ISkorkEntity)
            {
                return InvokeHelper(obj);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Helper function for <see cref="Invoke(object)"/>.
        /// </summary>
        /// <param name="obj">An optional object.</param>
        /// <returns></returns>
        private async Task<object> InvokeHelper(object obj)
        {
            return await Task.FromResult(obj.ToString());
        }
    }
}

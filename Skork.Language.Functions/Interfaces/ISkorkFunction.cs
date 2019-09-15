using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// The <see cref="Skork_Engine_Library"/> project.
/// Created by Anthony Jaghab (c), all rights reserved.
/// </summary>
namespace Skork_Engine_Library.Function {
    public interface ISkorkFunction {

        /// <summary>
        /// Invoke optionally takes a parameter and returns
        /// an object.
        /// </summary>
        /// <param name="obj">An optional object parameter.</param>
        /// <returns></returns>
        object Invoke(object obj = null);


    }
}

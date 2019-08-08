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
        /// 
        /// </summary>
        /// <param name="o">An optional object to pass.</param>
        void Invoke(object o = null);

        void InvokeHelper();


    }
}

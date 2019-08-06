using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skork_Engine_Library.Function {

    /// <summary>
    /// The <see cref="SkorkWho"/> class.
    /// <para></para>
    /// </summary>
    public class SkorkWho {



        public string InvokeWho(object o) {
            Task.Run(return o.ToString());
        }

    }
}

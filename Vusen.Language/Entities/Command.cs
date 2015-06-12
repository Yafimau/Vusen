using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vusen.Language.Entities
{
    using Vusen.Language.Entities.Commands;

    public abstract class Command
    {
        public abstract InvokeResult Invoke(InvokeContext context, params InvokeParameter[] parameters);
    }
}

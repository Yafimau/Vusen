using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vusen.Tasks
{
    public abstract class VusenTaskBase : IVusenTask
    {
        protected VusenTaskBase()
        {
            
        }

        public abstract void Run();
    }
}

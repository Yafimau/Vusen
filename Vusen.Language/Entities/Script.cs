using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vusen.Language.Entities
{
    public class Script
    {
        private Scope mainScope;

        private string code;

        public Script()
        {
            mainScope = new Scope();
        }

        public void Load(string code)
        {
            this.code = code;
        }

        public string GetCode()
        {
            return this.code;
        }
    }
}

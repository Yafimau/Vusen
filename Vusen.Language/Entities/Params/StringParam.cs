using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vusen.Language.Entities.Commands;

namespace Vusen.Language.Entities.Params
{
    public class StringParam : InvokeParameter
    {
        private readonly string _value;

        public StringParam(string value)
        {
            _value = value;
        }

        public string Value
        {
            get { return _value; }
        }
    }
}

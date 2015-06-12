using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vusen.Language.Entities.Commands
{
    public class InvokeResult
    {
        public enum ResultCode
        {
            OK = 0,
            MISSING_PARAMETER = 1,
        }

        private bool isSuccess;

        private ResultCode code;

        public InvokeResult()
        {
            
        }

        public bool IsSuccess
        {
            get
            {
                return this.isSuccess;
            }
        }

        public ResultCode Code
        {
            get
            {
                return this.code;
            }
        }

        public void SetError(ResultCode code)
        {
            this.isSuccess = false;
            this.code = code;
        }
    }
}

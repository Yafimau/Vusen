using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vusen.Language.Tests.Entities.Commands.Http
{
    using NUnit.Framework;

    using Vusen.Language.Entities.Commands;
    using Vusen.Language.Entities.Commands.Http;

    [TestFixture]
    public class GetTests
    {
        private Get getCommand;

        [SetUp]
        public void SetUp()
        {
            this.getCommand = new Get();
        }

        [Test]
        public void CheckInvokeResultNotNull()
        {
            var context = new InvokeContext();
            var result = this.getCommand.Invoke(context);

            Assert.IsNotNull(result);
        }

        [Test]
        public void CheckInvokeResultIsErrorOnRunWithoutParams()
        {
            var context = new InvokeContext();
            var result = this.getCommand.Invoke(context);

            Assert.IsFalse(result.IsSuccess);
            Assert.AreEqual(InvokeResult.ResultCode.MISSING_PARAMETER, result.Code);
        }
    }
}

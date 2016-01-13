using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vusen.Language.Entities.Params;
using Vusen.Language.Entities.Types;
using Vusen.Shared;

namespace Vusen.Language.Tests.Entities.Commands.Http
{
    using NUnit.Framework;

    using Vusen.Language.Entities.Commands;
    using Vusen.Language.Entities.Commands.Http;

    [TestFixture]
    public class GetTests
    {
        private Get _getCommand;
        private InvokeContext _invokeContext;
        private IServiceLocator _serviceLocator;

        [SetUp]
        public void SetUp()
        {
            _getCommand = new Get();
            _serviceLocator = new ServiceLocator();
            _invokeContext = new InvokeContext(_serviceLocator);
        }

        [Test]
        public void Get_command_downloads_content_using_httpClient_provided()
        {
            var urlParam = new StringParam("http://test.com");
            var result = _getCommand.Invoke(_invokeContext, urlParam);

            Assert.AreEqual("test content", (result.Result as HttpResult).Content);
        }

        [Test]
        public void CheckInvokeResultNotNull()
        {
            IServiceLocator serviceLocator = new ServiceLocator();

            var context = new InvokeContext(serviceLocator);
            var result = this._getCommand.Invoke(context);

            Assert.IsNotNull(result);
        }

        [Test]
        public void CheckInvokeResultIsErrorOnRunWithoutParams()
        {
            var result = this._getCommand.Invoke(_invokeContext);

            Assert.IsFalse(result.IsSuccess);
            Assert.AreEqual(InvokeResult.ResultCode.MISSING_PARAMETER, result.Code);
        }
    }
}

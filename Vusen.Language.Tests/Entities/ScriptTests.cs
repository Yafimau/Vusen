using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vusen.Language.Tests.Entities
{
    using NUnit.Framework;

    using Vusen.Language.Entities;

    [TestFixture]
    public class ScriptTests
    {

        [Test]
        public void LoadCodeReturnCode()
        {
            var script = new Script();
            script.Load("http.get(\"tut.by\");");

            var result = script.GetCode();

            Assert.AreEqual("http.get(\"tut.by\");", result);
        }

    }
}

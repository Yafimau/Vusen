using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Vusen.Tasks.Tests
{
    [TestFixture]
    public class ScriptRunnerTaskTests
    {

        [Test]
        public void Test()
        {
            var task = new ScriptRunnerTask("testTask");
            task.Run();

            

        }
    }
}

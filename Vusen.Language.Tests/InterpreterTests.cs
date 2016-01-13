// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InterpreterTests.cs" company="">
//   
// </copyright>
// <summary>
//   The interpreter tests.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using Moq;
using Vusen.Shared;

namespace Vusen.Language.Tests
{
    using NUnit.Framework;

    using Vusen.Language.Entities;

    /// <summary>
    /// The interpreter tests.
    /// </summary>
    [TestFixture]
    public class InterpreterTests
    {
        private Interpreter interpreter;

        [SetUp]
        public void SetUp()
        {
            var serviceLocatorMock = new Mock<IServiceLocator>();

            this.interpreter = new Interpreter(serviceLocatorMock.Object);
        }

        /// <summary>
        /// The run test.
        /// </summary>
        [Test]
        public void RunEmptyScript()
        {
            var script = new Script();

            var result = this.interpreter.Run(script);

            Assert.NotNull(result);
            Assert.AreEqual(ResultCode.Success, result.Code);
        }

        [Test]
        public void Interpreter_Run_with_simple_script_returns_success()
        {
            var script = new Script();
            script.Load("http.get(\"tut.by\");");

            var result = this.interpreter.Run(script);

            Assert.NotNull(result);
            Assert.AreEqual(ResultCode.Success, result.Code);
            Assert.AreEqual(ResultCode.Success, result.CompilerCheckCode);
        }
    }
}
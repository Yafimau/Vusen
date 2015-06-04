// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InterpreterTests.cs" company="">
//   
// </copyright>
// <summary>
//   The interpreter tests.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

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
            this.interpreter = new Interpreter();
        }

        /// <summary>
        /// The run test.
        /// </summary>
        [Test]
        public void RunTest()
        {
            var script = new Script();

            var result = this.interpreter.Run(script);

            Assert.NotNull(result);
        }
    }
}
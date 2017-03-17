using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RuleEngine.Person.Rules.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var rule = new FirstNameDoesNotStartWithCap();
            var result = rule.Execute();
            Assert.IsTrue(result.Count == 1);
        }
    }
}

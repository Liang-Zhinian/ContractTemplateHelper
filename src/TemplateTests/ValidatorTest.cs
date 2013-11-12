using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TemplateData;
using TemplateValidator;

namespace TemplateTests
{
    [TestClass]
    public class ValidatorTest
    {
        [TestMethod]
        public void TestGetTemplateTypes()
        {
            Assert.IsTrue(TemplateValidatorHelper.IsValidXslt("<html></html"));
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TemplateData;
using TemplateValidator;

namespace TemplateTests
{
    [TestClass]
    public class DataTest
    {
        [TestMethod]
        public void TestGetTemplateTypes()
        {
            Assert.IsTrue(TemplateValidatorHelper.IsValidXslt("<html></html"));
        }
    }
}

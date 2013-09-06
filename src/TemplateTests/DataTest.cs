using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TemplateData;

namespace TemplateTests
{
    [TestClass]
    public class DataTest
    {
        [TestMethod]
        public void TestGetTemplateTypes()
        {
            Assert.IsTrue(TemplateDataHelper.GetTemplateTypes().Length > 0);
        }

        [TestMethod]
        public void TestGetTemplates()
        {
            Assert.IsTrue(TemplateDataHelper.GetTemplates().Length > 0);
        }

        [TestMethod]
        public void TestUpdateTemplate()
        {
            var template = TemplateDataHelper.GetTemplates()[0];
            var updatedHtml = template.HtmlContent + ".";
            TemplateDataHelper.UpdateTemplate(template.ContractTemplateId, updatedHtml);

            var updatedTemplate = TemplateDataHelper.GetTemplateById(template.ContractTemplateId);
            var originalHtml = updatedTemplate.HtmlContent.Substring(0, updatedTemplate.HtmlContent.Length - 1);
            TemplateDataHelper.UpdateTemplate(template.ContractTemplateId, originalHtml);

            var originalTemplate = TemplateDataHelper.GetTemplateById(template.ContractTemplateId);
            
            Assert.AreEqual(template.HtmlContent, originalTemplate.HtmlContent);
            Assert.AreNotEqual(template.HtmlContent, updatedTemplate.HtmlContent);
        }
    }
}

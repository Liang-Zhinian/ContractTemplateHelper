using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateData
{
    public class TemplateDataHelper
    {
        public static ContractTemplateType[] GetTemplateTypes()
        {
            using (var db = new PricingPortalEntities())
            {
                var query = from b in db.ContractTemplateTypes
                            select b;

                return query.ToArray();
            }
        }

        public static ContractTemplate GetTemplateById(int id)
        {
            using (var db = new PricingPortalEntities())
            {
                var query = from b in db.ContractTemplates
                            where b.ContractTemplateId == id
                            select b;

                return query.First();
            }
        }

        public static ContractTemplate GetTemplateByNameAndType(int typeId, string name)
        {
            using (var db = new PricingPortalEntities())
            {
                var query = from b in db.ContractTemplates
                            where b.ContractTemplateTypeId == typeId && b.TemplateName == name
                            select b;

                return query.First();
            }
        }

        public static ContractTemplate[] GetTemplatesByType(int typeId)
        {
            using (var db = new PricingPortalEntities())
            {
                var query = from b in db.ContractTemplates
                            where b.ContractTemplateTypeId == typeId
                            select b;

                return query.ToArray();
            }
        }

        public static ContractTemplate[] GetTemplates()
        {
            using (var db = new PricingPortalEntities())
            {
                return db.ContractTemplates.ToArray();
            }
        }

        public static void CreateTemplatesType(string typeCode, string typeDesc)
        {
            using (var db = new PricingPortalEntities())
            {
                ContractTemplateType newType = new ContractTemplateType()
                {
                    TemplateTypeCode = typeCode,
                    Description = typeDesc
                };

                db.ContractTemplateTypes.Add(newType);
                db.SaveChanges();
            }
        }

        public static void CreateTemplate(string templateName, string templateHtml, int templateTypeId)
        {
            using (var db = new PricingPortalEntities())
            {
                ContractTemplate newTemplate = new ContractTemplate()
                {
                    CreateDate = DateTime.Now,
                    CreateUserId = 16,
                    EffectiveDate = DateTime.MinValue,
                    EndDate = DateTime.MaxValue,
                    TemplateName = templateName,
                    HtmlContent = templateHtml,
                    ContractTemplateTypeId = templateTypeId
                };

                db.ContractTemplates.Add(newTemplate);
                db.SaveChanges();
            }
        }

        public static void UpdateTemplate(int templateId, string templateHtml)
        {
            using (var db = new PricingPortalEntities())
            {
                ContractTemplate template = db.ContractTemplates.First(c => c.ContractTemplateId == templateId);

                template.HtmlContent = templateHtml;

                db.SaveChanges();
            }
        }
    }
}

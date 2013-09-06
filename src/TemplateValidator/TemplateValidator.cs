using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;
using WebSupergoo.ABCpdf9;

namespace TemplateValidator
{
    public class TemplateValidatorHelper
    {
        public static bool IsValidXslt(string xsl)
        {
            try
            {
                GetTransformedXslt(xsl);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public static byte[] GetPdfFromHtml(string html)
        {
            Doc thisDoc = new Doc();
            
            thisDoc.Rect.Height = 770;
            thisDoc.Rect.Bottom = 15;
            int pageId = thisDoc.AddImageHtml(html);
            while (thisDoc.Chainable(pageId))
            {
                thisDoc.Page = thisDoc.AddPage();
                pageId = thisDoc.AddImageToChain(pageId);
            }
            for (int i = 1; i <= thisDoc.PageCount; i++)
            {
                thisDoc.PageNumber = i;
                thisDoc.Flatten();
            }
            
            return thisDoc.GetData();
        }

        public static string GetTransformedXslt(string xsl)
        {
            StringWriter result = new StringWriter();
            ASCIIEncoding myEncoder = new ASCIIEncoding();
            byte[] bytes;
            MemoryStream output = new MemoryStream();

            //Get Template Text into XMLReader
            bytes = myEncoder.GetBytes(xsl);
            var xmlReaderSettings = new XmlReaderSettings();
            xmlReaderSettings.DtdProcessing = DtdProcessing.Parse;
            var xmlReader = XmlReader.Create(new MemoryStream(bytes), xmlReaderSettings);

            //perform XSL Transform
            XslCompiledTransform transform = new XslCompiledTransform();
            transform.Load(xmlReader);
            transform.Transform(new XPathDocument(new StringReader(SampleXml)), null, result);

            //build out response object
            string response = result.ToString();

            //clean up
            output.Dispose();
            xmlReader.Dispose();
            result.Dispose();

            return response;
        }

        private const string SampleXml = @"
<Offer>
  <Customer>
    <SnapShotCustomerId>1</SnapShotCustomerId>
    <SnapShotDateTime>2013-08-20T19:44:39.333</SnapShotDateTime>
    <LegalName>TACO BELL</LegalName>
    <Duns>007899233</Duns>
    <EstimatedStartDate>2014-01-01</EstimatedStartDate>
    <EstimatedTerm>5</EstimatedTerm>
    <EstimatedAnnualVolumeMWh>0.000000</EstimatedAnnualVolumeMWh>
    <IsKeyAccount>0</IsKeyAccount>
    <IsTaxExempt>0</IsTaxExempt>
    <CountryId>1</CountryId>
    <StateOrProvinceCode>TX</StateOrProvinceCode>
    <StateOrProvinceDesc>Texas</StateOrProvinceDesc>
    <IsActive>1</IsActive>
    <TaxPct>0.000000</TaxPct>
    <AddressLine1>1702 N COCKRELL HILL RD</AddressLine1>
    <City>DALLAS</City>
    <PostalCode>75211-1385</PostalCode>
    <ParentCustomerId>1</ParentCustomerId>
    <HedgeCustomerId>0</HedgeCustomerId>
    <SalesLogixAccountNo>A6UJ9A0054UN</SalesLogixAccountNo>
    <CreditStatusTypeId>2</CreditStatusTypeId>
    <CreditRequestDate>2013-08-20T15:42:34.347</CreditRequestDate>
    <CreditApplicationNo>FCX4YBBHE</CreditApplicationNo>
    <FinancialStressScore>7</FinancialStressScore>
    <DetailCreditResponse>Financial Stress Score is below 15, Credit is declined.     Please note that for requests with annual aggregate volume  5,000 MWh you may provide additional information in form of audited financial statements for the last fiscal year and most recen interim period (including balance sheet, income statement, cash flow statement, and notes) for further credit review.     Collateral in form of an LC or Surety Bond is an option for any request with an aggregate of  2,000 Mwh.</DetailCreditResponse>
    <EnteredByPersonId>1</EnteredByPersonId>
    <OwnedByPersonId>1</OwnedByPersonId>
    <EstimatedAggregateAnnualVolumeMWh />
    <FirstName>First</FirstName>
    <LastName>Customer</LastName>
    <EmailAddress>inrelease2@email.com</EmailAddress>
    <PrimaryPhoneNumber>123-123-1234</PrimaryPhoneNumber>
    <PrimaryContactPhoneTypeName>Mobile</PrimaryContactPhoneTypeName>
    <PrimaryDescription>Cell Phone</PrimaryDescription>
    <IsPrimaryPhoneSmsEnabled>0</IsPrimaryPhoneSmsEnabled>
    <OfferId>1</OfferId>
    <ContractId>1</ContractId>
    <ActualCustomerId>1</ActualCustomerId>
    <EnteredByFirstName>Ryan</EnteredByFirstName>
    <EnteredByLastName>Roark</EnteredByLastName>
    <OwnedByFirstName>Ryan</OwnedByFirstName>
    <OwnedByLastName>Roark</OwnedByLastName>
    <Sites>
      <Site>
        <SnapShotSiteId>1</SnapShotSiteId>
        <SnapShotCustomerId>1</SnapShotCustomerId>
        <CountryId>1</CountryId>
        <StateOrProvinceCode>TX</StateOrProvinceCode>
        <Description>Texas</Description>
        <IsActive>1</IsActive>
        <TaxPct>0.000000</TaxPct>
        <AddressLine1>123 Washington Ave</AddressLine1>
        <City>Houston</City>
        <PostalCode>77007</PostalCode>
        <SiteName>First Location</SiteName>
        <IsPriorityMoveIn>0</IsPriorityMoveIn>
        <HasBuildingPermit>0</HasBuildingPermit>
        <ActualSiteId>1</ActualSiteId>
        <SiteServices>
          <SiteService>
            <SnapShotSiteServiceId>1</SnapShotSiteServiceId>
            <SnapShotSiteId>1</SnapShotSiteId>
            <UtilityName>Centerpoint</UtilityName>
            <UtilityAbrevation>REN</UtilityAbrevation>
            <UtilityDuns>957877905</UtilityDuns>
            <ServiceTypeName>Power</ServiceTypeName>
            <UtilityCountryId>1</UtilityCountryId>
            <UtilityStateCode>TX</UtilityStateCode>
            <UtilityStateDesc>Texas</UtilityStateDesc>
            <IsoName>Electric Reliability Council of Texas</IsoName>
            <IsoCode>ERCOT</IsoCode>
            <BillingAddressLine1>1702 N COCKRELL HILL RD</BillingAddressLine1>
            <BillingCity>DALLAS</BillingCity>
            <BillingPostalCode>75211-1385</BillingPostalCode>
            <BillingStateOrProvinceCode>TX</BillingStateOrProvinceCode>
            <BillingStateOrProvinceDesc>Texas</BillingStateOrProvinceDesc>
            <BillingCountryId>1</BillingCountryId>
            <LoadFactorName>MED</LoadFactorName>
            <LoadFactorDesc>Medium</LoadFactorDesc>
            <LdcAcctNumber>1008901012398273498723</LdcAcctNumber>
            <Volume>2123.000000</Volume>
            <UomCode>KH</UomCode>
            <UomName>kWh</UomName>
            <VolumeTimePeriodCode>Annual</VolumeTimePeriodCode>
            <LoeInEffect>0</LoeInEffect>
            <ZoneCode>HOUSTON</ZoneCode>
            <IsActive>1</IsActive>
            <ActualSiteServiceId>1</ActualSiteServiceId>
            <EnrollmentTypeCode>SWTH</EnrollmentTypeCode>
            <EnrollmentTypeName>Switch</EnrollmentTypeName>
          </SiteService>
        </SiteServices>
      </Site>
    </Sites>
  </Customer>
  <OfferId>1</OfferId>
  <EnteredByPersonId>1</EnteredByPersonId>
  <OwnedByPersonId>2</OwnedByPersonId>
  <CustomerId>1</CustomerId>
  <Term>7</Term>
  <StartDate>2013-08-01</StartDate>
  <BrokerFee>0.00000</BrokerFee>
  <AdditionalDebMargin>0.00100</AdditionalDebMargin>
  <IsActive>0</IsActive>
  <SourceSystemProductId>54639</SourceSystemProductId>
  <CreateDate>2013-08-20T19:44:16.613</CreateDate>
  <CreateUserId>1</CreateUserId>
  <ModifyDate>2013-08-20T19:44:18.820</ModifyDate>
  <ModifyUserId>1</ModifyUserId>
  <DebMargin>0.00000</DebMargin>
  <OfferPricingStatusTypeId>5</OfferPricingStatusTypeId>
  <Price>0.0374500000</Price>
  <ExactPrice>0.0374500000</ExactPrice>
  <TotalAveragePrice>0.0374500000</TotalAveragePrice>
  <IsProtected>1</IsProtected>
  <ProtectionOverridden>0</ProtectionOverridden>
  <LanguageId>1</LanguageId>
  <IsAccepted>0</IsAccepted>
  <ConsolidateBilling>0</ConsolidateBilling>
  <IsExternallyPriced>0</IsExternallyPriced>
  <IsRecommended>0</IsRecommended>
  <PricingTypeId>1</PricingTypeId>
  <PersonId>1</PersonId>
  <FirstName>Ryan</FirstName>
  <LastName>Roark</LastName>
  <DigitalUserGuid>3C577F2C-08AA-420D-B690-EDEBB5FCF6C2</DigitalUserGuid>
  <RoleId>1</RoleId>
  <IsActive>1</IsActive>
  <PersonId>2</PersonId>
  <FirstName>Sales</FirstName>
  <LastName>Rep</LastName>
  <DigitalUserGuid>951D3421-EB23-4294-BA15-BFCFCD816346</DigitalUserGuid>
  <HedgeSalesEntityId>71913</HedgeSalesEntityId>
  <RoleId>5</RoleId>
  <PhoneNumber>123-123-1234</PhoneNumber>
  <IsActive>1</IsActive>
  <EnteredByFirstName>Ryan</EnteredByFirstName>
  <EnteredByLastName>Roark</EnteredByLastName>
  <OwnedByFirstName>Sales</OwnedByFirstName>
  <OwnedByLastName>Rep</OwnedByLastName>
  <OwnedByPhoneNumber>123-123-1234</OwnedByPhoneNumber>
  <OwnedByHedgeSalesEntityId>71913</OwnedByHedgeSalesEntityId>
</Offer>";
    }
}

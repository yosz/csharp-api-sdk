using System.Linq;
using FortnoxAPILibrary.Connectors;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FortnoxAPILibrary.Tests.ConnectorTests
{
    [TestClass]
    public class PrintTemplateTests
    {
        [TestInitialize]
        public void Init()
        {
            //Set global credentials for SDK
            //--- Open 'TestCredentials.resx' to edit the values ---\\
            ConnectionCredentials.AccessToken = TestCredentials.Access_Token;
            ConnectionCredentials.ClientSecret = TestCredentials.Client_Secret;
        }

        [TestMethod]
        public void Test_PrintTemplate_CRUD()
        {
            //Not supported
        }

        [TestMethod]
        public void Test_Find()
        {
            IPrintTemplateConnector connector = new PrintTemplateConnector();
            
            var fullCollection = connector.Find(null);
            MyAssert.HasNoError(connector);

            Assert.AreEqual(9, fullCollection.Entities.Count);
            Assert.IsNotNull(fullCollection.Entities.First().Name);

            //Limit not supported
        }

        [TestMethod]
        public void Test_Find_Filter()
        {
            IPrintTemplateConnector connector = new PrintTemplateConnector();
            var searchSettings = new PrintTemplateSearch();

            searchSettings.FilterBy = Filter.PrintTemplate.Order;
            var orderTemplates = connector.Find(searchSettings);
            MyAssert.HasNoError(connector);

            Assert.AreEqual(4, orderTemplates.Entities.Count);

            searchSettings.FilterBy = Filter.PrintTemplate.Offer;
            var offerTemplates = connector.Find(searchSettings);
            MyAssert.HasNoError(connector);

            Assert.AreEqual(1, offerTemplates.Entities.Count);

            searchSettings.FilterBy = Filter.PrintTemplate.Invoice;
            var invoiceTemplates = connector.Find(searchSettings);
            MyAssert.HasNoError(connector);

            Assert.AreEqual(9, invoiceTemplates.Entities.Count);
        }
    }
}

using NUnit.Framework;
using PetStore.Swagger.APITest.Requests;
using System.Net;

namespace PetStore.Swagger.APITest.Tests
{
    public class GetInventoryTest
    {
        [Test]
        public void CheckGetInventoryResponseCode()
        {
            var expectedStatusCode = HttpStatusCode.OK;
            GetInventoryRequest getInventoryRequest = new GetInventoryRequest();
            var actualStatusCode = getInventoryRequest.GetInventoryResponseCode();
            Assert.AreEqual(expectedStatusCode, actualStatusCode, "Status code 200 olarak dönmemiştir.Dönen code: {0}", actualStatusCode);
        }
    }
}

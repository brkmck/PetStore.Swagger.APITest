using NUnit.Framework;
using PetStore.Swagger.APITest.Entities;
using PetStore.Swagger.APITest.Requests;
using System;
using System.Net;

namespace PetStore.Swagger.APITest.Tests
{
    public class PostOrderTest
    {
        [Test]
        public void CheckPostOrderResponseCode()
        {
            var expectedStatusCode = HttpStatusCode.OK;
            PostOrderRequest postOrderRequest = new PostOrderRequest();
            OrderEntity orderEntity = new OrderEntity()
            {
                petId = 15,
                quantity = 25,
                shipDate = DateTime.Now
            };
            var actualStatusCode = postOrderRequest.PostOrderResponseCode(orderEntity);
            Assert.AreEqual(expectedStatusCode, actualStatusCode, "Status code 200 olarak dönmemiştir.Dönen code: {0}", actualStatusCode);
        }
    }
}

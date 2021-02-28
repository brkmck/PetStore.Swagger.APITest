using PetStore.Swagger.APITest.Entities;
using RestSharp;
using System.Net;

namespace PetStore.Swagger.APITest.Requests
{
    public class PostOrderRequest
    {
        const string BASE_URL = "https://petstore.swagger.io/v2/";

        public HttpStatusCode PostOrderResponseCode(OrderEntity orderEntity)
        {
            RestClient client = new RestClient(BASE_URL);
            RestRequest request = new RestRequest("store/order", Method.POST);
            request.AddJsonBody(orderEntity);
            var response = client.Execute(request);
            return response.StatusCode;
        }
    }
}

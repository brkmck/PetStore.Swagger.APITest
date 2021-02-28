using RestSharp;
using System.Net;

namespace PetStore.Swagger.APITest.Requests
{
    public class GetInventoryRequest
    {
        const string BASE_URL = "https://petstore.swagger.io/v2/";

        public HttpStatusCode GetInventoryResponseCode()
        {
            RestClient client = new RestClient(BASE_URL);
            var request = new RestRequest("store/inventory", Method.GET);
            var response = client.Execute(request);
            return response.StatusCode;
        }
    }
}

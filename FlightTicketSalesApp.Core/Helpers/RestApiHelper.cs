using Newtonsoft.Json;
using RestSharp;

namespace FlightTicketSalesApp.Core.Helpers
{
    public class RestApiHelper
    {
        public static TResponse CallRestWebService<TRequest, TResponse>(TRequest entity, string baseUri, string apiUrl)
        {
            var options = new RestClientOptions(baseUri)
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest(apiUrl, Method.Post);
            request.AddHeader("Content-Type", "application/json");
            var body = JsonConvert.SerializeObject(entity);
            request.AddStringBody(body, DataFormat.Json);
            var response = client.ExecuteAsync(request).Result;
            var content = response.Content;
            var result = JsonConvert.DeserializeObject<TResponse>(content);
            return result;
        }
    }
}

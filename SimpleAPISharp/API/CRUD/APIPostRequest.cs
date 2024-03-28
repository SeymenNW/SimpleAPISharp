using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAPISharp.API.CRUD
{
    #region API Get Requests Class (Deserialized)
    public class APIPostRequest<T>
    {
        public T Result { get; set; }
        public HttpClient HttpClient = new();
        public string? JwtToken { get; set; }


        public async Task PostRequests(string postUrl)
        {
            HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", JwtToken);

            try
            {

                // Construct the URL with the query parameter
                string apiUrl = postUrl;

                // You should include a JSON content in your POST request. Create a model for it.
                var requestData = new { url = postUrl }; // Adjust the model to match your API's requirements

                // Serialize the model to JSON
                string jsonRequestData = JsonConvert.SerializeObject(requestData);
                StringContent content = new StringContent(jsonRequestData, Encoding.UTF8, "application/json");

                // Make the POST request
                HttpResponseMessage httpResponse = await HttpClient.PostAsync(apiUrl, content);

                // Check if the request was successful
                if (httpResponse.IsSuccessStatusCode)
                {
                    // Deserialize the response JSON
                    string jsonResponse = await httpResponse.Content.ReadAsStringAsync();
                    Result = JsonConvert.DeserializeObject<T>(jsonResponse);

                }
                else
                {
                    // Handle the error here, e.g., log it or return an error view
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions here
            }
        }



    }

    #endregion
}

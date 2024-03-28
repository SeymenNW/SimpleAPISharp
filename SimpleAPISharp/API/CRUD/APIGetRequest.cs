
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SimpleAPISharp.API.CRUD
{
    #region API Get Requests Class (Deserialized)
    public class APIGetRequest<T>
    {
        public T Result { get; set; }
        public List<T> Items { get; set; }

        public HttpClient HttpClient = new();
        public string? JwtToken { get; set; }

 

        public async Task GetRequests(string urlForApi)
        {

            HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", JwtToken);


            Uri uri = new Uri(urlForApi);

            HttpResponseMessage httpResponse = await HttpClient.GetAsync(uri);

            if (httpResponse.IsSuccessStatusCode)
            {
                string content = await httpResponse.Content.ReadAsStringAsync();
                Result = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(content);
            }
            else
            {
                // Handle non-successful HTTP response here if needed.
                throw new HttpRequestException($"Request Failed: {httpResponse.StatusCode}");
            }
        }


        public async Task GetListRequests(string urlForApi)
        {

            HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", JwtToken);

            // Make an HTTP request to retrieve the JSON data


            var response = await HttpClient.GetStringAsync(urlForApi);

            // Deserialize the JSON data into a List of MyItem
            Items = System.Text.Json.JsonSerializer.Deserialize<List<T>>(response, new JsonSerializerOptions { PropertyNameCaseInsensitive = true }).ToList();
        }



    }

    #endregion


}

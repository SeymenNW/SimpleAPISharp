using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;
using System.Text;

namespace SimpleAPISharp.API.CRUD
{
  
        #region API Delete Requests Class (Deserialized)
        public class APIDeleteRequest<T>
        {
            public T Result { get; set; }
        public HttpClient HttpClient = new();
        public string JwtToken { get; set; }


        public async Task DeleteRequest(string postUrl)
            {
            HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", JwtToken);

            try
            {

                    // Construct the URL with the query parameter
                    string apiUrl = postUrl;

                    // Make the DELETE request
                    HttpResponseMessage httpResponse = await HttpClient.DeleteAsync(apiUrl);

          
                }
                catch (Exception ex)
                {
                    // Handle exceptions here
                }
            }



        }

        #endregion
    }


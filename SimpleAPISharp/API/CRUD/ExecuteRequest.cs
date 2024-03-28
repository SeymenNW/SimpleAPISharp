using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAPISharp.API.CRUD
{
    //This is old and shall not be used. V2 Will scrap this altogether soon.
    public class ExecuteRequest<TApi> where TApi : new()

    {

        public ExecuteRequest() { }

   


        public TApi ApiModel { get; set; } = new TApi();

        public List<TApi> ItemList { get; set; } = new List<TApi>();

        public string? JwtToken { get; set; }

        //API Classes so they can be used.
        public APIGetRequest<TApi> ApiGetClass = new APIGetRequest<TApi>();
        public APIDeleteRequest<TApi> ApiDeleteClass = new APIDeleteRequest<TApi>();
        public APIGetRequest<TApi> ApiGetListClass = new APIGetRequest<TApi>();
        public APIPutRequest<TApi> ApiPutClass = new APIPutRequest<TApi>();
        public APIPostRequest<TApi> ApiPostClass = new APIPostRequest<TApi>();








        public async Task Delete(string url)
        {
            ApiDeleteClass.JwtToken = JwtToken;
            await ApiDeleteClass.DeleteRequest(url);


            ////TApi kortCheck = new TApi();
            //ApiModel = apiGet.Result;
        }


        public async Task Get(string url)
        {
            ApiGetClass.JwtToken = JwtToken;
            await ApiGetClass.GetRequests(url);
            //TApi kortCheck = new TApi();
            ApiModel = ApiGetClass.Result;
        }

        public async Task GetList(string url)
        {
            ApiGetListClass.JwtToken = JwtToken;
            //APIGetRequest<TApi> ApiGetList = new APIGetRequest<TApi>();
            await ApiGetListClass.GetListRequests(url);
            //TApi kortCheck = new TApi();
            ItemList = ApiGetListClass.Items;
        }

        public async Task Put(string url)
        {
            ApiPutClass.JwtToken = JwtToken;
            //APIPutRequest<TApi> ApiPut = new APIPutRequest<TApi>();
            await ApiPutClass.PutRequests(url);
            //TApi kortCheck = new TApi();
            ApiModel = ApiPutClass.Result;
        }

        public async Task Post(string url)
        {
            ApiPostClass.JwtToken = JwtToken;
            //APIPostRequest<TApi> ApiPost = new APIPostRequest<TApi>();
            await ApiPostClass.PostRequests(url);
            //TApi kortCheck = new TApi();
            ApiModel = ApiPostClass.Result;
        }
    }


}

using Newtonsoft.Json.Linq;
using SimpleAPISharp.API.CRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAPISharp.API.V2
{
    //This completely simplifies the process making the entire call one line.
    /*
    And if you need to configure something (eg not implemented stuff like ApiKeys) 
    then you can simply add that because ExecuteRequest allows you to access the 
    method for the Api Calls which means you can modify it for your needs.

    *Not everything works I think

    */
    public static class ApiLine
    {
        public static async Task<ExecuteRequest<T>> AsyncRequest<T>(ApiMethod method,string apiUrl) where T : new()
        {

            ExecuteRequest<T> apiRequest = new();

            //This is if you want to retrieve multiple data.
            if (method == ApiMethod.GET_ALL)
            {
                ExecuteRequest<T> request = new();
                await request.GetList(apiUrl);


                apiRequest =    request;
                return request;
            }

            //This is if you want to retrieve one piece of Data
            else if (method == ApiMethod.GET)
            {
                ExecuteRequest<T> request = new();
                await request.Get(apiUrl);
                apiRequest = request;

                return request;
            }

            //This is if you want to POST data.
            else if (method == ApiMethod.POST)
            {
                ExecuteRequest<T> request = new();
                await request.Post(apiUrl);
                apiRequest = request;

                return request;
            }

            //This is if you want to EDIT data.
            else if (method == ApiMethod.PUT)
            {
                ExecuteRequest<T> request = new();
                await request.Put(apiUrl);
                apiRequest = request;

                return request;
            }

            //This is if you want to DELETE data.
            else if (method == ApiMethod.DELETE)
            {
                ExecuteRequest<T> request = new();
                await request.Delete(apiUrl);
                apiRequest = request;

                return request;
            }

            return apiRequest;

      
        }
    }
}
using System.Collections.Generic;
using System.Net;
using ApiTest.Models;
using RestSharp;

namespace ApiTest
{
    public class TodoApiClient : BaseApiClient
    {
        public TodoApiClient(string baseUrl = "https://jsonplaceholder.typicode.com/", CookieContainer cookieContainer = null) 
            : base(baseUrl, cookieContainer)
        {
        }

        public TodoResponse GetTodoItemById(int id)
        {
            var url = $"todos/{id}";

            var request = new RestRequest(url, Method.GET);

            return this.RestClient.Execute<TodoResponse>(request).Data; ;
        }

        public List<TodoResponse> GetTodoItems()
        {
            var url = "todos/";

            var request = new RestRequest(url, Method.GET);

            return this.RestClient.Execute<List<TodoResponse>>(request).Data;
        }
    }
}

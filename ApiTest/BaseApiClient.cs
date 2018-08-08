using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace ApiTest
{
    public abstract class BaseApiClient
    {
        public string BaseUrl { get; set; }
  
        public CookieContainer CookieContainer { get; set; }

        protected RestClient RestClient { get; set; } = new RestClient();

        protected BaseApiClient(string baseUrl, CookieContainer cookieContainer = null)
        {
            this.RestClient.CookieContainer = cookieContainer;
            this.RestClient.BaseUrl =  new Uri(baseUrl);
        }
    }
}

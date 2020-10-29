using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AssetToPurchaseFrontend.Model
{
    public class ClientConnection
    {
        HttpClient client;
        HttpResponseMessage response;
        public void Connect()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:52590/");
        }
        public HttpResponseMessage ExecuteGetMethod(string requestUri)
        {
            response = client.GetAsync(requestUri).Result;
            return response;
        }
        public HttpResponseMessage ExecutePostMethod(string requestUri, UserDetails userDetails)
        {
            response = client.PostAsJsonAsync(requestUri, userDetails).Result;
            return response;
        }
        public HttpResponseMessage ExecuteDeleteMethod(string requestUri)
        {
            response= client.DeleteAsync(requestUri).Result;
            return response;
        }
        public HttpResponseMessage ExecutePostMethod(string requestUri, MonitoringDevice monitoringDevice)
        {
            response = client.PostAsJsonAsync(requestUri, monitoringDevice).Result;
            return response;
        }
        public HttpResponseMessage ExecutePutMethod(string requestUri)
        {
            response = client.PutAsJsonAsync(requestUri, "").Result;
            return response;
        }
    }
}

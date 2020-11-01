using System;
using System.Net.Http;

namespace AssetToPurchaseFrontend.Model
{
    public class ClientConnection
    {
        HttpClient _client;
        HttpResponseMessage _response;
        public void Connect()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("http://localhost:52590/");
        }
        public HttpResponseMessage ExecuteGetMethod(string requestUri)
        {
            _response = _client.GetAsync(requestUri).Result;
            return _response;
        }
        public HttpResponseMessage ExecutePostMethod(string requestUri, UserDetails userDetails)
        {
            _response = _client.PostAsJsonAsync(requestUri, userDetails).Result;
            return _response;
        }
        public HttpResponseMessage ExecuteDeleteMethod(string requestUri)
        {
            _response = _client.DeleteAsync(requestUri).Result;
            return _response;
        }
        public HttpResponseMessage ExecutePostMethod(string requestUri, MonitoringDevice monitoringDevice)
        {
            _response = _client.PostAsJsonAsync(requestUri, monitoringDevice).Result;
            return _response;
        }
        public HttpResponseMessage ExecutePutMethod(string requestUri)
        {
            _response = _client.PutAsJsonAsync(requestUri, "").Result;
            return _response;
        }
        public HttpResponseMessage ExecutePostMethod(string requestUri,EmailDetails emailDetails)
        {
            _response = _client.PostAsJsonAsync(requestUri, emailDetails).Result;
            return _response;
        }
    }
}

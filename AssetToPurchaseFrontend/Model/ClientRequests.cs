using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;

namespace AssetToPurchaseFrontend.Model
{
    public class ClientRequests
    {
        ClientConnection clientConnection;
        HttpResponseMessage response;
        List<MonitoringDevice> _monitoringDeviceList = default;
        List<UserDetails> _userList = default;
        string result = default;
        public bool ExecuteGetRequest(string requestUri)
        {
            clientConnection = new ClientConnection();
            clientConnection.Connect();
            response = clientConnection.ExecuteGetMethod(requestUri);
            if (response.IsSuccessStatusCode)
            {
                result = response.Content.ReadAsStringAsync().Result;
                return true;
            }
            return false;
        }
        public bool ExecutePostRequest(string requestUri, MonitoringDevice monitoringDevice)
        {
            clientConnection = new ClientConnection();
            clientConnection.Connect();
            response = clientConnection.ExecutePostMethod(requestUri, monitoringDevice);
            if (response.IsSuccessStatusCode)
            {
                result = response.Content.ReadAsStringAsync().Result;
                return true;
            }
            return false;
        }
        public bool ExecutePostRequest(string requestUri, UserDetails userDetails)
        {
            clientConnection = new ClientConnection();
            clientConnection.Connect();
            response = clientConnection.ExecutePostMethod(requestUri, userDetails);
            if (response.IsSuccessStatusCode)
            {
                result = response.Content.ReadAsStringAsync().Result;
                return true;
            }
            return false;
        }
        public bool ExecuteDeleteRequest(string requestUri)
        {
            clientConnection = new ClientConnection();
            clientConnection.Connect();
            response = clientConnection.ExecuteDeleteMethod(requestUri);
            if (response.IsSuccessStatusCode)
            {
                result = response.Content.ReadAsStringAsync().Result;
                return true;
            }
            return false;
        }
        public bool ExecutePutRequest(string requestUri)
        {
            clientConnection = new ClientConnection();
            clientConnection.Connect();
            response = clientConnection.ExecutePutMethod(requestUri);
            if (response.IsSuccessStatusCode)
            {
                result = response.Content.ReadAsStringAsync().Result;
                return true;
            }
            return false;
        }
        public List<MonitoringDevice> ProductGetRequest(string requestUri)
        {
            if (ExecuteGetRequest(requestUri))
            {
                _monitoringDeviceList = JsonConvert.DeserializeObject<List<MonitoringDevice>>(result);
                return _monitoringDeviceList;
            }
            else
            {
                return _monitoringDeviceList;
            }
        }
        public List<UserDetails> UserGetRequest(string requestUri)
        {
            if (ExecuteGetRequest(requestUri))
            {
                _userList = JsonConvert.DeserializeObject<List<UserDetails>>(result);
                return _userList;
            }
            else
            {
                return _userList;
            }
        }
        public bool ProductPostRequest(string requestUri, MonitoringDevice monitoringDevice)
        {
            if (ExecutePostRequest(requestUri, monitoringDevice))
            {
                _monitoringDeviceList = JsonConvert.DeserializeObject<List<MonitoringDevice>>(result);
                return true;
            }
            return false;
        }
        public bool ProductDeleteRequest(string requestUri)
        {
            if (ExecuteDeleteRequest(requestUri))
            {
                _monitoringDeviceList = JsonConvert.DeserializeObject<List<MonitoringDevice>>(result);
                return true;
            }
            return false;
        }
        public List<UserDetails> UserPostRequest(string requestUri, UserDetails userDetails)
        {
            if (ExecutePostRequest(requestUri, userDetails))
            {
                _userList = JsonConvert.DeserializeObject<List<UserDetails>>(result);
                return _userList;
            }
            return _userList;
        }
        public string UserPostRequestAndStringResponse(string requestUri, UserDetails userDetails)
        {
            if (ExecutePostRequest(requestUri, userDetails))
            {
                return result;
            }
            return result;
        }
        public string UserPostRequestAndStringResponce(string requestUri)
        {
            if (ExecutePutRequest(requestUri))
            {
                return result;
            }
            return result;
        }
    }
}

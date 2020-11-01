using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;

namespace AssetToPurchaseFrontend.Model
{
    public class ClientRequests
    {
        ClientConnection _clientConnection;
        HttpResponseMessage _response;
        List<MonitoringDevice> _monitoringDeviceList ;
        List<UserDetails> _userList ;
        string _result ;
        private bool ExecuteGetRequest(string requestUri)
        {
            _clientConnection = new ClientConnection();
            _clientConnection.Connect();
            _response = _clientConnection.ExecuteGetMethod(requestUri);
            if (_response.IsSuccessStatusCode)
            {
                _result = _response.Content.ReadAsStringAsync().Result;
                return true;
            }
            return false;
        }
        private void ExecutePostRequest(string requestUri, MonitoringDevice monitoringDevice)
        {
            _clientConnection = new ClientConnection();
            _clientConnection.Connect();
            _response = _clientConnection.ExecutePostMethod(requestUri, monitoringDevice);
            if (_response.IsSuccessStatusCode)
            {
                _result = _response.Content.ReadAsStringAsync().Result;

            }

        }
        private void ExecutePostRequest(string requestUri, UserDetails userDetails)
        {
            _clientConnection = new ClientConnection();
            _clientConnection.Connect();
            _response = _clientConnection.ExecutePostMethod(requestUri, userDetails);
            if (_response.IsSuccessStatusCode)
            {
                _result = _response.Content.ReadAsStringAsync().Result;

            }

        }
        private void ExecutePostRequest(string requestUri, EmailDetails emailDetails)
        {
            _clientConnection = new ClientConnection();
            _clientConnection.Connect();
            _response = _clientConnection.ExecutePostMethod(requestUri, emailDetails);
            if (_response.IsSuccessStatusCode)
            {
                _result = _response.Content.ReadAsStringAsync().Result;

            }

        }
        private void ExecuteDeleteRequest(string requestUri)
        {
            _clientConnection = new ClientConnection();
            _clientConnection.Connect();
            _response = _clientConnection.ExecuteDeleteMethod(requestUri);
            if (_response.IsSuccessStatusCode)
            {
                _result = _response.Content.ReadAsStringAsync().Result;

            }

        }
        //private bool ExecutePutRequest(string requestUri)
        //{
        //    _clientConnection = new ClientConnection();
        //    _clientConnection.Connect();
        //    //_response = _clientConnection.ExecutePutMethod(requestUri);
        //    if (_response.IsSuccessStatusCode)
        //    {
        //        _result = _response.Content.ReadAsStringAsync().Result;
        //        return true;
        //    }
        //    return false;
        //}
        public List<MonitoringDevice> ProductGetRequest(string requestUri)
        {
            if (ExecuteGetRequest(requestUri))
            {
                _monitoringDeviceList = JsonConvert.DeserializeObject<List<MonitoringDevice>>(_result);
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
                _userList = JsonConvert.DeserializeObject<List<UserDetails>>(_result);
                return _userList;
            }
            else
            {
                return _userList;
            }
        }
        public void ProductPostRequest(string requestUri, MonitoringDevice monitoringDevice)
        {
            ExecutePostRequest(requestUri, monitoringDevice);

        }
        public void ProductDeleteRequest(string requestUri)
        {
            ExecuteDeleteRequest(requestUri);

        }
        public void UserPostRequest(string requestUri, UserDetails userDetails)
        {
            ExecutePostRequest(requestUri, userDetails);
           
        }
        //private string UserPostRequestAndStringResponse(string requestUri, UserDetails userDetails)
        //{
        //    if (ExecutePostRequest(requestUri, userDetails))
        //    {
        //        return _result;
        //    }
        //    return _result;
        //}
        //private string UserPostRequestAndStringResponce(string requestUri)
        //{
        //    if (ExecutePutRequest(requestUri))
        //    {
        //        return _result;
        //    }
        //    return _result;
        //}
        public void EmailAlert(string requestUri, EmailDetails emailDetails)
        {
            ExecutePostRequest(requestUri, emailDetails);

        }
    }
}

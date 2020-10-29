using System;
using System.Net.Http;
using Xunit;
using AssetToPurchaseFrontend.Model;
namespace Asset_To_Purchase_FrontEnd.Tests
{
    public class ClientConnectionTests
    {
        HttpResponseMessage response;
        ClientConnection clientConnection;
        [Fact]
        public void Test_ExecuteGetMethod()
        {
            clientConnection = new ClientConnection();
            clientConnection.Connect();
            string uri = "api/AlertUser/GetUserDetail/IntelliVue X3";
            response = clientConnection.ExecuteGetMethod(uri);
            Assert.True(response.IsSuccessStatusCode);
        }
        [Fact]
        public void Test_ExecutePostMethod()
        {
            MonitoringDevice _dummDevice = new MonitoringDevice()
            {
                DeviceName1 = "IntelliVue v3",
                Ecg1 = "YES",
                Spo21 = "YES",
                Respiration1 = "YES",
                Hr1 = "YES",
                PhysiologicalAlarming1 = "NO",
                BloodPressure1 = "NO",
                BatteryLife1 = "5 in",
                SupportedScreenOrientations1 = "0° / 90° / 180°",
                Size1 = "249 x 97 x 111 mm",
                MobileOrStatic1 = "STATIC",
                AntiMicrobialGlass1 = "YES",
                PatientLocation1 = "NO"
            };
            clientConnection = new ClientConnection();
            clientConnection.Connect();
            string uri = "api/productcategory/PostDevice";
            response = clientConnection.ExecutePostMethod(uri, _dummDevice);
            Assert.True(response.IsSuccessStatusCode);
        }
        [Fact]
        public void Test_ExecutePostMethod2()
        {
            UserDetails userDetails = new UserDetails()
            {
                UserName1 = "tests",
                UserContactNo1 = 123,
                ProductsBooked1 = "none_tests"
            };
            clientConnection = new ClientConnection();
            clientConnection.Connect();
            string uri = "api/AlertUser/Registration";
            response = clientConnection.ExecutePostMethod(uri, userDetails);
            Assert.True(response.IsSuccessStatusCode);
        }
        [Fact]
        public void Test_ExecuteDeleteMethod()
        {
            clientConnection = new ClientConnection();
            clientConnection.Connect();
            string uri = "api/productcategory/devicename";
            response = clientConnection.ExecuteDeleteMethod(uri);
            Assert.True(response.IsSuccessStatusCode);
        }
        [Fact]
        public void Test_ExecutePutMethod()
        {
            clientConnection = new ClientConnection();
            clientConnection.Connect();
            string uri = "api/AlertUser/NewModelAlert";
            response = clientConnection.ExecutePutMethod(uri);
            Assert.True(response.IsSuccessStatusCode);
        }
    }
}

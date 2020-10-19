using AssistPurchaseData;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using RestSharp.Serialization.Json;
using System.Collections.Generic;

namespace Api.Tests
{
    [TestClass]
    public class ProductCategoryApiTests
    {
        string baseUrl = "http://localhost:5000/api/productcategory/";
        RestClient client;
        RestRequest request;
        

        [TestMethod]
        public void Test_CardiacType()
        {
            client = new RestClient(baseUrl);
            request = new RestRequest("cardiac", Method.GET) { RequestFormat = DataFormat.Json };
            var deserialize = new JsonDeserializer();
            var response = client.Execute(request);
            List<MonitoringDevice> resultList = deserialize.Deserialize<List<MonitoringDevice>>(response);
            foreach (var device in resultList)
            {
                Assert.IsTrue(device.Ecg == "YES" && device.Hr == "YES");
            }
        }
        [TestMethod]
        public void Test_PneumoniaType()
        {
            client = new RestClient(baseUrl);
            request = new RestRequest("pneumonia", Method.GET) { RequestFormat = DataFormat.Json };

            var response = client.Execute(request);
            var deserialize = new JsonDeserializer();
            List<MonitoringDevice> resultList = deserialize.Deserialize<List<MonitoringDevice>>(response);
            foreach (var device in resultList)
            {
                Assert.IsTrue(device.Respiration == "YES" && device.Spo2 == "YES");
            }

        }
        [TestMethod]
        public void Test_Covid19Type()
        {
            client = new RestClient(baseUrl);
            request = new RestRequest("covid19", Method.GET) { RequestFormat = DataFormat.Json };
            var deserialize = new JsonDeserializer();
            var response = client.Execute(request);

            List<MonitoringDevice> resultList = deserialize.Deserialize<List<MonitoringDevice>>(response);
            foreach (var device in resultList)
            {
                Assert.IsTrue(device.Respiration == "YES" && device.BloodPressure == "YES");
            }

        }
        [TestMethod]
        public void Test_HighBpType()
        {
            client = new RestClient(baseUrl);
            request = new RestRequest("highbp", Method.GET) { RequestFormat = DataFormat.Json };

            var response = client.Execute(request);
            var deserialize = new JsonDeserializer();
            List<MonitoringDevice> resultList = deserialize.Deserialize<List<MonitoringDevice>>(response);
            foreach (var device in resultList)
            {
                Assert.IsTrue(device.BloodPressure == "YES");
            }

        }
        [TestMethod]
        public void Test_BatteryLifeType()
        {
            int batteryLife = 5;

            client = new RestClient(baseUrl);
            request = new RestRequest("batterylife/{batterylife}", Method.GET) { RequestFormat = DataFormat.Json };
            request.AddUrlSegment("batterylife", batteryLife);

            var deserialize = new JsonDeserializer();
            var response = client.Execute(request);

            List<MonitoringDevice> resultList = deserialize.Deserialize<List<MonitoringDevice>>(response);
            foreach (var device in resultList)
            {
                Assert.IsTrue(device.BatteryLife == batteryLife.ToString());
            }

        }
        [TestMethod]
        public void Test_DisplayType()
        {
            string displaysize = "12.1";

            client = new RestClient(baseUrl);
            request = new RestRequest("display/{displaysize}", Method.GET) { RequestFormat = DataFormat.Json };
            request.AddUrlSegment("displaysize", displaysize);

            var response = client.Execute(request);
            var deserialize = new JsonDeserializer();
            List<MonitoringDevice> resultList = deserialize.Deserialize<List<MonitoringDevice>>(response);

            foreach (var device in resultList)
            {
                Assert.IsTrue(device.Size == displaysize || device.SupportedScreenOrientations == "YES");
            }

        }
        [TestMethod]
        public void Test_AdvancedFeatureType()
        {
            string value = "TRUE";
            client = new RestClient(baseUrl);
            request = new RestRequest("advancedfeatures/{value}", Method.GET) { RequestFormat = DataFormat.Json };
            request.AddUrlSegment("value", value);

            var response = client.Execute(request);
            var deserialize = new JsonDeserializer();

            List<MonitoringDevice> resultList = deserialize.Deserialize<List<MonitoringDevice>>(response);
            foreach (var device in resultList)
            {
                Assert.IsTrue(device.PatientLocation == "YES" && device.AntiMicrobialGlass == "YES");
            }

        }
        [TestMethod]
        public void Test_MobileOrStaticType()
        {
            string value = "MOBILE";
            client = new RestClient(baseUrl);
            request = new RestRequest("mobileorstatic/{value}", Method.GET) { RequestFormat = DataFormat.Json };
            request.AddUrlSegment("value", value);

            var response = client.Execute(request);
            var deserialize = new JsonDeserializer();

            List<MonitoringDevice> resultList = deserialize.Deserialize<List<MonitoringDevice>>(response);
            foreach (var device in resultList)
            {
                Assert.IsTrue(device.MobileOrStatic == value);
            }

        }
        [TestMethod]
        public void Test_DeviceOfAlarmType()
        {
            string value = "TRUE";
            client = new RestClient(baseUrl);
            request = new RestRequest("alaraming/{value}", Method.GET) { RequestFormat = DataFormat.Json };
            request.AddUrlSegment("value", value);

            var response = client.Execute(request);
            var deserialize = new JsonDeserializer();

            List<MonitoringDevice> resultList = deserialize.Deserialize<List<MonitoringDevice>>(response);
            foreach (var device in resultList)
            {
                Assert.IsTrue(device.PhysiologicalAlarming == "YES");
            }

        }


    }
}

﻿using AssistPurchaseData;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using System.Collections.Generic;

namespace Api.Tests
{
    [TestClass]
    public class ProductCategoryApiTests
    {
        string baseUrl = "http://localhost:52590/api/productcategory/";
        private  static RestClient _client;
        private  static RestRequest _request;

        private static readonly RestSharp.Serialization.Json.JsonDeserializer Deserialize = new RestSharp.Serialization.Json.JsonDeserializer();
        private static IRestResponse Response;
        private List<MonitoringDevice> _resultList = new List<MonitoringDevice>();
        [TestMethod]
        public void Test_CardiacType()
        {
            _client = new RestClient(baseUrl);
            _request = new RestRequest("cardiac", Method.GET) { RequestFormat = DataFormat.Json };
            Response = _client.Execute(_request);
            _resultList = Deserialize.Deserialize<List<MonitoringDevice>>(Response);
            foreach (var device in _resultList)
            {
                Assert.IsTrue(device.Ecg == "YES" && device.Hr == "YES");
            }
        }
        [TestMethod]
        public void Test_PneumoniaType()
        {
            _client = new RestClient(baseUrl);
            _request = new RestRequest("pneumonia", Method.GET) { RequestFormat = DataFormat.Json };
            Response = _client.Execute(_request);
            _resultList = Deserialize.Deserialize<List<MonitoringDevice>>(Response);
            foreach (var device in _resultList)
            {
                Assert.IsTrue(device.Respiration == "YES" && device.Spo2 == "YES");
            }

        }
        [TestMethod]
        public void Test_Covid19Type()
        {
            _client = new RestClient(baseUrl);
            _request = new RestRequest("covid19", Method.GET) { RequestFormat = DataFormat.Json };
            Response = _client.Execute(_request);
            _resultList = Deserialize.Deserialize<List<MonitoringDevice>>(Response);
            foreach (var device in _resultList)
            {
                Assert.IsTrue(device.Respiration == "YES" && device.BloodPressure == "YES");
            }

        }
        [TestMethod]
        public void Test_HighBpType()
        {
            _client = new RestClient(baseUrl);
            _request = new RestRequest("highbp", Method.GET) { RequestFormat = DataFormat.Json };
            Response = _client.Execute(_request);
            _resultList = Deserialize.Deserialize<List<MonitoringDevice>>(Response);
            foreach (var device in _resultList)
            {
                Assert.IsTrue(device.BloodPressure == "YES");
            }

        }
        [TestMethod]
        public void Test_BatteryLifeType()
        {
            int batteryLife = 5;

            _client = new RestClient(baseUrl);
            _request = new RestRequest("batterylife/{batterylife}", Method.GET) { RequestFormat = DataFormat.Json };
            _request.AddUrlSegment("batterylife", batteryLife);

            Response = _client.Execute(_request);
            _resultList = Deserialize.Deserialize<List<MonitoringDevice>>(Response);

            foreach (var device in _resultList)
            {
                Assert.IsTrue(device.BatteryLife == batteryLife.ToString());
            }

        }
        [TestMethod]
        public void Test_DisplayType()
        {
            string displaysize = "12.1";

            _client = new RestClient(baseUrl);
            _request = new RestRequest("display/{displaysize}", Method.GET) { RequestFormat = DataFormat.Json };
            _request.AddUrlSegment("displaysize", displaysize);
            Response = _client.Execute(_request);
            _resultList = Deserialize.Deserialize<List<MonitoringDevice>>(Response);
            foreach (var device in _resultList)
            {
                Assert.IsTrue(device.Size == displaysize || device.SupportedScreenOrientations == "YES");
            }

        }
        [TestMethod]
        public void Test_AdvancedFeatureType()
        {
            string value = "TRUE";
            _client = new RestClient(baseUrl);
            _request = new RestRequest("advancedfeatures/{featurevalues}", Method.GET) { RequestFormat = DataFormat.Json };
            _request.AddUrlSegment("featurevalues", value);
            Response = _client.Execute(_request);
            _resultList = Deserialize.Deserialize<List<MonitoringDevice>>(Response);
            foreach (var device in _resultList)
            {
                Assert.IsTrue(device.PatientLocation == "YES" && device.AntiMicrobialGlass == "YES");
            }

        }
        [TestMethod]
        public void Test_MobileOrStaticType()
        {
            string value = "MOBILE";
            _client = new RestClient(baseUrl);
            _request = new RestRequest("mobileorstatic/{staticormobile}", Method.GET) { RequestFormat = DataFormat.Json };
            _request.AddUrlSegment("staticormobile", value);
            Response = _client.Execute(_request);
            _resultList = Deserialize.Deserialize<List<MonitoringDevice>>(Response);
            foreach (var device in _resultList)
            {
                Assert.IsTrue(device.MobileOrStatic == value);
            }

        }
        [TestMethod]
        public void Test_DeviceOfAlarmType()
        {
            string value = "TRUE";
            _client = new RestClient(baseUrl);
            _request = new RestRequest("alaraming/{physiologicalalaram}", Method.GET) { RequestFormat = DataFormat.Json };
            _request.AddUrlSegment("physiologicalalaram", value);
            Response = _client.Execute(_request);
            _resultList = Deserialize.Deserialize<List<MonitoringDevice>>(Response);
            foreach (var device in _resultList)
            {
                Assert.IsTrue(device.PhysiologicalAlarming == "YES");
            }

        }


    }
}

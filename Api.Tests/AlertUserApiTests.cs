using AssistPurchaseData;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using System.Collections.Generic;

namespace Api.Tests
{
    [TestClass]
    public class AlertUserApiTests
    {
        string baseUrl = "http://localhost:5000/api/alertuser/";
        private static RestClient _client;
        private static RestRequest _request;
        UserDetails user = new UserDetails() { UserName = "john", UserEmailId = "john12", ProductsBooked = "IntelliVue", UserContactNo = 23432 };
        static RestSharp.Serialization.Json.JsonDeserializer deserialize = new RestSharp.Serialization.Json.JsonDeserializer();
        static IRestResponse response = _client.Execute(_request);
       
        private readonly List<UserDetails> _userDetails = deserialize.Deserialize<List<UserDetails>>(response);
        string output = JsonDeserializer.Deserialize<string>(Execute);
        public static object Execute;

        [TestMethod]
        public void Test_UserRegistration()
        {
            _client = new RestClient(baseUrl);
            _request = new RestRequest("registration", Method.POST) { RequestFormat = DataFormat.Json };
            _request.AddJsonBody(user);
            foreach (var details in _userDetails)
            {
                Assert.IsTrue(details.UserName == "john");
            }
        }
        [TestMethod]
        public void Test_NewModelAlert()
        {
            _client = new RestClient(baseUrl);
            _request = new RestRequest("newmodelalert", Method.PUT) { RequestFormat = DataFormat.Json };
            Assert.AreEqual(output, "A new Model has arrived!!!!!");

        }
        [TestMethod]
        public void Test_OrderConfirmation()
        {
            _client = new RestClient(baseUrl);
            _request = new RestRequest("orderconfirmation", Method.POST) { RequestFormat = DataFormat.Json };
            _request.AddJsonBody(user);
            Assert.AreEqual(output, user.UserName + " has booked the following product " + user.ProductsBooked + " ");

        }
        [TestMethod]
        public void Test_CallBack()
        {
            _client = new RestClient(baseUrl);
            _request = new RestRequest("callback", Method.POST) { RequestFormat = DataFormat.Json };
            _request.AddJsonBody(user);
            Assert.AreEqual(output, "One of our Philips Personnel will reach you out soon..Thank You!!!");

        }
    }

    internal class JsonDeserializer
    {
        public static T Deserialize<T>(object execute)
        {
            throw new System.NotImplementedException();
        }
    }
}

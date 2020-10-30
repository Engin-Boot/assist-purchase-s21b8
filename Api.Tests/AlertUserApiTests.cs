using AssistPurchaseData;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using RestSharp.Serialization.Json;
using System.Collections.Generic;

namespace Api.Tests
{
    [TestClass]
    public class AlertUserApiTests
    {
        string baseUrl = "http://localhost:52590/api/alertuser/";
        private static RestClient _client;
        private static RestRequest _request;
        private readonly UserDetails _user = new UserDetails() { UserName = "john", ProductsBooked = "IntelliVue", UserContactNo = 23432 };
        private readonly JsonDeserializer _deserialize = new JsonDeserializer();
        private static IRestResponse _response;
        private readonly EmailDetails _emailDetails = new EmailDetails() { EmailId = "casestudyb217@gmail.com", Message = "API Tests Mail" };
        private List<UserDetails> _userDetails;
        private string _output;

        [TestMethod]
        public void Test_UserRegistration()
        {
            _client = new RestClient(baseUrl);
            _request = new RestRequest("registration", Method.POST) { RequestFormat = DataFormat.Json };
            _request.AddJsonBody(_user);

            _response = _client.Execute(_request);
            _userDetails = _deserialize.Deserialize<List<UserDetails>>(_response);
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
            _response = _client.Execute(_request);
            _output = _deserialize.Deserialize<string>(_response);
            Assert.AreEqual(_output, "A new Model has arrived!!!!!");

        }
        [TestMethod]
        public void Test_OrderConfirmation()
        {
            _client = new RestClient(baseUrl);
            _request = new RestRequest("orderconfirmation", Method.POST) { RequestFormat = DataFormat.Json };
            _request.AddJsonBody(_emailDetails);
            _response = _client.Execute(_request);
            //Assert.AreEqual(_output, _user.UserName + " has booked the following product " + _user.ProductsBooked + " ");
            Assert.IsTrue(_response.IsSuccessful);
        }
        [TestMethod]
        public void Test_CallBack()
        {
            _client = new RestClient(baseUrl);
            _request = new RestRequest("callback", Method.POST) { RequestFormat = DataFormat.Json };
            _request.AddJsonBody(_user);
            _response = _client.Execute(_request);
            _output = _deserialize.Deserialize<string>(_response);
            Assert.AreEqual(_output, "One of our Philips Personnel will reach you out soon..Thank You!!!");

        }
        [TestMethod]
        public void Test_GetUserDetails()
        {
            _client = new RestClient(baseUrl);
            _request = new RestRequest("GetUserDetail/IntelliVue X3", Method.GET) { RequestFormat = DataFormat.Json };
            _response = _client.Execute(_request);
            var output = _deserialize.Deserialize<string>(_response);
            Assert.IsNotNull(output);
        }
    }
}

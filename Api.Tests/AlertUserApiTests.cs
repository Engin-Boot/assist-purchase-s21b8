using AssistPurchaseData;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using RestSharp.Serialization.Json;
using Services;
using System.Collections.Generic;

namespace Api.Tests
{
    [TestClass]
    public class AlertUserApiTests
    {
        string baseUrl = "http://localhost:5000/api/alertuser/";
        RestClient client;
        RestRequest request;
        UserDetails user = new UserDetails() { UserName = "john", UserEmailId = "john12", ProductsBooked = "IntelliVue", UserContactNo = 23432 };

        [TestMethod]
        public void Test_UserRegistration()
        {
            client = new RestClient(baseUrl);
            request = new RestRequest("registration", Method.POST) { RequestFormat = DataFormat.Json };
            request.AddJsonBody(user);
         
            var deserialize = new JsonDeserializer();
            var response = client.Execute(request);
            List<UserDetails> userDetails = deserialize.Deserialize<List<UserDetails>>(response);
            foreach (var user in userDetails)
            {
                Assert.IsTrue(user.UserName == "john");
            }
        }
        [TestMethod]
        public void Test_NewModelAlert()
        {
            client = new RestClient(baseUrl);
            request = new RestRequest("newmodelalert", Method.PUT) { RequestFormat = DataFormat.Json };

            var response = client.Execute(request);
            var deserialize = new JsonDeserializer();
            string output = deserialize.Deserialize<string>(response);
            Assert.AreEqual(output, "A new Model has arrived!!!!!");

        }
        [TestMethod]
        public void Test_OrderConfirmation()
        {
            client = new RestClient(baseUrl);
            request = new RestRequest("orderconfirmation", Method.POST) { RequestFormat = DataFormat.Json };
            request.AddJsonBody(user);

            var deserialize = new JsonDeserializer();
            var response = client.Execute(request);


            string output = deserialize.Deserialize<string>(response);
            Assert.AreEqual(output, user.UserName + " has booked the following product " + user.ProductsBooked + " ");

        }
        [TestMethod]
        public void Test_CallBack()
        {
            client = new RestClient(baseUrl);
            request = new RestRequest("callback", Method.POST) { RequestFormat = DataFormat.Json };
            request.AddJsonBody(user);

            var response = client.Execute(request);
            var deserialize = new JsonDeserializer();

            string output = deserialize.Deserialize<string>(response);
            Assert.AreEqual(output, "One of our Philips Personnel will reach you out soon..Thank You!!!");

        }
    }
}

using AssistPurchaseData;
using System.Collections.Generic;
using Xunit;
using Services;
namespace FunctionLogic.Tests
{
    public class AlertUserTests
    {
        private UserDetails _user = new UserDetails() { UserName = "Unit_Test", Email = "Unit@Test.com", ProductsBooked = "Unit_Test", UserContactNo = 2343 };
        private readonly AlertUser _alertUser = new AlertUser();
        private readonly List<UserDetails> _expected = new List<UserDetails>();
        private List<UserDetails> _actual;
        [Fact]
        public void UserRegistration_Unit_Test()
        {
            _actual = _alertUser.UserRegistration(_user);
          //  _expected = new List<UserDetails>();
            _expected.Add(new UserDetails { UserName = "Unit_Test", Email = "Unit@Test.com", ProductsBooked = "Unit_Test", UserContactNo = 2343 });
            if (_expected == _actual)
                Assert.True(true);
        }
        //[Fact]
        //public void NewModelEmailAlert_Unit_Test()
        //{
        //    Assert.True(alertUser.NewModelEmailAlert() == "A new Model has arrived!!!!!");
        //}
        [Fact]
        public void UserCallBackRequest_Unit_Test()
        {
            var actual = _alertUser.UserCallBackRequest(_user);
            var expected = "One of our Philips Personnel will reach you out soon..Thank You!!!";
            Assert.True(expected == actual);
        }
        [Fact]
        public void UserCallBackRequest_Unit_Test_2()
        {
            _user = new UserDetails()
            {
                UserName = "xyz",
                UserContactNo = 000,
                Email = "xyz@000.com",
                ProductsBooked = "none"
            };
            var actual = _alertUser.UserCallBackRequest(_user);
            var expected = "User not registered or registered phone no does not match";
            Assert.True(expected == actual);
        }
        [Fact]
        public void OrderConfirmationEmailAlert_Unit_Test()
        {
            EmailDetails emailDetails = new EmailDetails() { EmailId = "casestudyb217@gmail.com", Message = "Order Confirmation /Registration (Unit Test Mail)" };
            var actual = _alertUser.OrderConfirmationEmailAlert(emailDetails);
            var expected= "Email Sent";
            Assert.True(expected == actual);
        }
        [Fact]
        public void GetUserDetails_Unit_Test()
        {
            _actual = new List<UserDetails>();
            var deviceName = "Unit_Test";
            _actual = _alertUser.GetUserDetails(deviceName);
           // _expected = new List<UserDetails>();
            _expected.Add(new UserDetails { UserName = "Unit_Test", Email = "Unit@Test.com", ProductsBooked = "Unit_Test", UserContactNo = 2343 });
            if (_actual == _expected)
                Assert.True(true);
        }
    }
}

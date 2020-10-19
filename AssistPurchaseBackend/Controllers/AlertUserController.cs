using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace AssistPurchaseBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlertUserController : ControllerBase
    {
        private readonly  AlertUser _user = new AlertUser();

        [HttpGet("Registration/{username}/{usermaildid}/{productbooked}/{userCallid}")]
        public List<UserDetails> AddUserDetailsforRegistration(string username,string usermaildid,string productbooked,int userCallid)
        {
            return _user.UserRegistration(username,usermaildid,productbooked,userCallid);
        }
        [HttpPost("NewModelAlert/{registeredemailid}")]
        public string NewModelEmailAlerttoUser(string registeredemailid)
        {

            return _user.NewModelEmailAlert(registeredemailid);
        }
        [HttpPost("OrderConfirmation/{registeredname}/{productsbooked}")]
        public string OrderConfirmationEmailAlerttoRegisteredUsers(string registeredname,string productsbooked)
        {

            return _user.OrderConfirmationEmailAlert(registeredname,productsbooked);
        }
        [HttpPost("CallBack/{registeredname}/{registeredUserphoneno}")]
        public string CallBackRequestFromRegisteredUser(string registeredname, int registeredUserphoneno)
        {

            return _user.UserCallBackRequest(registeredname,registeredUserphoneno);
        }
    }
}

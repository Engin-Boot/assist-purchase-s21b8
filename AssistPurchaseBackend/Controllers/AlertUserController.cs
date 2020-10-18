using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace AssistPurchaseBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlertUserController : ControllerBase
    {
        private AlertUser user = new AlertUser();

        [HttpGet("Registration/{username}/{usermaildid}/{productbooked}/{UserCallid}")]
        public List<UserDetails> AddUserDetailsforRegistration(string username,string usermaildid,string productbooked,int UserCallid)
        {
            return user.UserRegistration(username,usermaildid,productbooked,UserCallid);
        }
        [HttpPost("NewModelAlert")]
        public string NewModelEmailAlerttoUser()
        {

            return user.NewModelEmailAlert();
        }
        [HttpPost("OrderConfirmation/{registeredname}/{productsbooked}")]
        public string OrderConfirmationEmailAlerttoRegisteredUsers(string registeredname,string productsbooked)
        {

            return user.OrderConfirmationEmailAlert(registeredname,productsbooked);
        }
        [HttpPost("CallBack/{registeredname}/{RegisteredUserphoneno}")]
        public string CallBackRequestFromRegisteredUser(string registeredname, int RegisteredUserphoneno)
        {

            return user.UserCallBackRequest(registeredname,RegisteredUserphoneno);
        }
    }
}

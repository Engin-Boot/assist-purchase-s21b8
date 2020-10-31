using System.Collections.Generic;
using AssistPurchaseData;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace AssistPurchaseBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlertUserController : ControllerBase
    {
        private readonly AlertUser _user = new AlertUser();

        [HttpPost("Registration")]
        public List<UserDetails> AddUserDetailsforRegistration([FromBody] UserDetails userDetails)
        {
            return _user.UserRegistration(userDetails);
        }
        [HttpPut("NewModelAlert")]
        public IActionResult NewModelEmailAlerttoUser()
        {
            return Ok(_user.NewModelEmailAlert());
        }
        [HttpPost("OrderConfirmation")]
        public IActionResult OrderConfirmationEmailAlerttoRegisteredUsers(EmailDetails emailDetails)
        {
            return Ok(_user.OrderConfirmationEmailAlert(emailDetails));
            //return Ok();
        }
        [HttpPost("{CallBack}")]
        public IActionResult CallBackRequestFromRegisteredUser(UserDetails userDetails)
        {
            return Ok(_user.UserCallBackRequest(userDetails));
        }
        //[HttpGet("AdvancedFeatures/{value}")]
        [HttpGet("GetUserDetail/{deviceName}")]
        public IActionResult GetRegisterdUsersOfDevice(string deviceName)
        {
            var details = _user.GetUserDetails(deviceName);
            return Ok(details);
        }
    }
}

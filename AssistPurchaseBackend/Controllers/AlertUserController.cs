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
        private AlertUser user = new AlertUser();

        [HttpPost("Registration")]
        public List<UserDetails> AddUserDetailsforRegistration([FromBody] UserDetails userDetails)
        {
            return user.UserRegistration(userDetails);
        }
        [HttpPut("NewModelAlert")]
        public IActionResult NewModelEmailAlerttoUser()
        {
            return Ok(user.NewModelEmailAlert());
        }
        [HttpPost("OrderConfirmation")]
        public IActionResult OrderConfirmationEmailAlerttoRegisteredUsers(UserDetails userDetails)
        {
            return Ok(user.OrderConfirmationEmailAlert(userDetails));
        }
        [HttpPost("{CallBack}")]
        public IActionResult CallBackRequestFromRegisteredUser(UserDetails userDetails)
        {
            return Ok(user.UserCallBackRequest(userDetails));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.IdentityModel.Tokens;

namespace AssistPurchaseBackend.Services
{
    public class AlertUser
    {
        private string message;
        List<UserDetails> _userDetails = new List<UserDetails>();

        UserDetails user = new UserDetails();

        public List<UserDetails> UserRegistration(string username, string usermailid, string bookedproduct,
            int UserPhoneNo)
        {
            _userDetails.Add(
                new UserDetails
                {
                    UserName = username,
                    UserEmailID = usermailid,
                    ProductsBooked = bookedproduct,
                    UserContactNo = UserPhoneNo

                });
            return _userDetails;
        }

        public string NewModelEmailAlert()
        {
           
            if (_userDetails != null)
            {
                message = "A new Model has arrived!!!!!";
            }
            else
            {
                message = "No users registered to alert";
            }

            return message;
        }

        public string UserCallBackRequest(string registeredusername, int phoneno)
        {
            
            foreach (var userdetailslist in _userDetails)
            {
                if (registeredusername == userdetailslist.UserName && phoneno == userdetailslist.UserContactNo)
                {
                    message = "One of our Philips Personnel will reach you out soon..Thank You!!!";
                }
                else
                {
                    message = "User not registered or registered phone no doesnot match";
                }
            }



            return message;
        }

        public string OrderConfirmationEmailAlert(string registereduser, string confirmproductbooking)
        {

            foreach (var userdetailslist in _userDetails)
            {
               
                if (registereduser == userdetailslist.UserName &&
                    confirmproductbooking == userdetailslist.ProductsBooked)
                {
                    message = $"{registereduser} has booked the following product {confirmproductbooking} ";
                }
                else
                {
                    message = "User not registered or device name doesnot match";
                }

               
            }
            return message;
        }
    }
}

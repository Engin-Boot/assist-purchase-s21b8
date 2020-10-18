using System;
using System.Collections.Generic;
namespace Services
{
    public class AlertUser
    {
        private string _message;
         List<UserDetails> _userDetails = new List<UserDetails>();

        private UserDetails _user = new UserDetails();

        public List<UserDetails> UserRegistration(string username, string usermailid, string bookedproduct,
            int userPhoneNo)
        {
            _userDetails.Add(
                new UserDetails
                {
                    UserName = username,
                    UserEmailId = usermailid,
                    ProductsBooked = bookedproduct,
                    UserContactNo = userPhoneNo

                });
            return _userDetails;
        }

        public string NewModelEmailAlert()
        {
           
            if (_userDetails != null)
            {
                _message = "A new Model has arrived!!!!!";
            }
            else
            {
                _message = "No users registered to alert";
            }

            return _message;
        }

        public string UserCallBackRequest(string registeredusername, int phoneno)
        {
            
            foreach (var userdetailslist in _userDetails)
            {
                if (registeredusername == userdetailslist.UserName && phoneno == userdetailslist.UserContactNo)
                {
                    _message = "One of our Philips Personnel will reach you out soon..Thank You!!!";
                }
                else
                {
                    _message = "User not registered or registered phone no doesnot match";
                }
            }



            return _message;
        }

        public string OrderConfirmationEmailAlert(string registereduser, string confirmproductbooking)
        {
            Console.WriteLine(_userDetails);

            foreach (var userdetailslist in this._userDetails)
            {
               
                if (registereduser == userdetailslist.UserName &&
                    confirmproductbooking == userdetailslist.ProductsBooked)
                {
                    _message = $"{registereduser} has booked the following product {confirmproductbooking} ";
                    break;
                    
                }
                else
                {
                    _message = "User not registered or device name doesnot match";
                    break;
                }

               
            }
            return _message;
        }
    }
}

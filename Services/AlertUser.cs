using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Services
{
    public class AlertUser 
    {
        private string _message;
        public UserDetails User { get; }
        List<UserDetails> _userDetails = new List<UserDetails>();
        List<UserDetails> _deserializedMonitoringDevices = new List<UserDetails>();
        string _path = @"C:\Users\320087877\OneDrive - Philips\Documents\GitHub\assist-purchase-s21b8\UserDetails.xml";

        public AlertUser(UserDetails user)
        {
            User = user;
        }

        public AlertUser()
        {
        }

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
            WriteToXml();
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
            var user = ReadFromXml();
            foreach (var userdetailslist in user)
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

            var user = ReadFromXml();
            foreach (var userdetailslist in user)
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
        private void WriteToXml()
        {

            var serializer = new XmlSerializer(_userDetails.GetType(), new XmlRootAttribute("UserDetailsList"));

            var writer = new StreamWriter(_path);
            serializer.Serialize(writer.BaseStream, _userDetails);
            writer.Close();

        }
        private List<UserDetails> ReadFromXml()
        {
            var serializer = new XmlSerializer(_userDetails.GetType(), new XmlRootAttribute("UserDetailsList"));

            if (File.Exists(_path))
            {
                StreamReader reader = new StreamReader(_path);
                List<UserDetails> userDetails = (List<UserDetails>)serializer.Deserialize(reader);
                reader.Close();

                foreach (var details in userDetails)
                {
                    _deserializedMonitoringDevices.Add(details);
                }
            }
            else
            {
                Console.WriteLine("File not found.");
                //var doc = new XDocument(new XElement("Use-Cases"));
                //doc.Save(path);
            }
            return _deserializedMonitoringDevices;
        }

    }
}

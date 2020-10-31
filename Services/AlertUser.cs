using AssistPurchaseData;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Services
{
    public class AlertUser
    {
        private string _message;
        
        List<UserDetails> _userDetails = new List<UserDetails>();
        readonly List<UserDetails> _deserializedMonitoringDevices = new List<UserDetails>();
        string _path = @"D:\UserDetails.xml";

        public List<UserDetails> UserRegistration(UserDetails user)
        {
            _userDetails.Add(user);
            WriteToXml();
            return _userDetails;
        }

        public string NewModelEmailAlert()
        {
            _userDetails = ReadFromXml();
            _message = _userDetails.Count > 0 ? "A new Model has arrived!!!!!" : "No users registered to alert";
            return _message;
        }

        public string UserCallBackRequest(UserDetails userDetails)
        {
            var userdetailslist = ReadFromXml();
            foreach (var user in userdetailslist)
            {

                if (userDetails.UserName == user.UserName && userDetails.UserContactNo == user.UserContactNo)
                {
                    _message = "One of our Philips Personnel will reach you out soon..Thank You!!!";
                    return _message;
                }
            }
            _message = "User not registered or registered phone no does not match";
            return _message;
        }

        public string OrderConfirmationEmailAlert(EmailDetails emailDetails)
        {
            var message = emailDetails.Message;
            var emailId = emailDetails.EmailId;
            EmailService.IAlerter alerter = new EmailService.EmailAlert(emailId);
            if (alerter.Alert(message))
                return "Email Sent";
            else return "Email Not Sent";
        }
        private void WriteToXml()
        {
            List<UserDetails> users = new List<UserDetails>();
            users = ReadFromXml();
            users.AddRange(_userDetails);
            var serializer = new XmlSerializer(users.GetType(), new XmlRootAttribute("UserDetailsList"));
            var writer = new StreamWriter(_path);
            serializer.Serialize(writer.BaseStream, users);
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
        public List<UserDetails> GetUserDetails(string deviceName)
        {
            List<UserDetails> userDetails = new List<UserDetails>();
            List<UserDetails> matchingUserDetails = new List<UserDetails>();
            userDetails = ReadFromXml();
            foreach(var user in userDetails)
            {
                if (user.ProductsBooked == deviceName)
                    matchingUserDetails.Add(user);
            }
            return matchingUserDetails;
        }

    }
}

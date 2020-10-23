﻿using AssistPurchaseData;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Services
{
    public class AlertUser
    {
        private string _message;
        
        List<UserDetails> _userDetails = new List<UserDetails>();
        readonly List<UserDetails> _deserializedMonitoringDevices = new List<UserDetails>();
        string _path = @"D:\UserDetails.xml";
        //string _path = @"C:\Users\320087992\Documents\Bootcamp\case-study-II\assist-purchase-s21b8\UserDetails.xml";

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
                    break;
                }
                else
                {
                    _message = "User not registered or registered phone no does not match";
                    break;
                }
            }

            return _message;
        }

        public string OrderConfirmationEmailAlert(UserDetails userDetails)
        {

            var userdetailslist = ReadFromXml();
            foreach (var dummy in userdetailslist)
            {

                if (true)
                {
                    _message = $"{userDetails.UserName} has booked the following product {userDetails.ProductsBooked} ";
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

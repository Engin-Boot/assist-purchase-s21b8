using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class EmailService
    {
        public interface IAlerter
        {
            bool Alert(string message);
        }
        public class EmailAlert : IAlerter
        {
            string emailId;
            public EmailAlert(string emailId)
            {
                this.emailId = emailId;
            }
        
            public bool Alert(string message)
            {
                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("casestudyb217@gmail.com", "Case@217"),
                    EnableSsl = true,
                };
                smtpClient.Send("casestudyb217@gmail.com", emailId, "Philips Purchase Assist", message);

                return true;
            }
        }
    }
}

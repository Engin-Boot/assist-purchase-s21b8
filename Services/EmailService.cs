using System.Net;
using System.Net.Mail;

namespace Services
{
    public static class EmailService
    {
        public interface IAlerter
        {
            bool Alert(string message);
        }
        public class EmailAlert : IAlerter
        {
           readonly string  _emailId;
            public EmailAlert(string emailId)
            {
                this._emailId = emailId;
            }
        
            public bool Alert(string message)
            {
                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("casestudyb217@gmail.com", "Case@217"),
                    EnableSsl = true,
                };
                smtpClient.Send("casestudyb217@gmail.com", _emailId, "Philips Purchase Assist", message);

                return true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace AppNET.Infrastructure
{
    public class SendInfoMail
    {
        public void SendMail(string mailAddress,string mailMessage)
        {
            MailMessage infoMessage= new MailMessage();
            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("melihunal2560@gmail.com", "34gm4191M");
            client.Port = 587;
            client.Host = "smpt.gmail.com";
            client.EnableSsl = true;
            infoMessage.To.Add(mailAddress);
            infoMessage.From = new MailAddress("melihunal2560@gmail.com");
            infoMessage.Subject = ("Yeni Fatura Bildirimi");
            infoMessage.Body = mailMessage;
            client.Send(infoMessage);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.SendEmail;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
  
  [Route("api/[controller]/[action]")]
    public class MailController:ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> SendMail([FromBody]Email email)
       {
            var client = new System.Net.Mail.SmtpClient("smtp.example.com", 111);
            client.UseDefaultCredentials = false;
            client.EnableSsl = true;

            client.Credentials = new System.Net.NetworkCredential("yourusername", "yourpassword");

            var mailMessage = new System.Net.Mail.MailMessage();
            mailMessage.From = new System.Net.Mail.MailAddress("youremail@example.com");

            mailMessage.To.Add(email.FirstName);

            if (!string.IsNullOrEmpty(email.LastName))
            {
                mailMessage.CC.Add(email.EmailAdress);
            }

            mailMessage.Body = email.Text;

           /*  mailMessage.Subject = email.Subject; */

            mailMessage.BodyEncoding = System.Text.Encoding.UTF8;
            mailMessage.SubjectEncoding = System.Text.Encoding.UTF8;

            await client.SendMailAsync(mailMessage);

            return Ok();
        }
    }
 }

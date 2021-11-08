using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace odczytTemperatury
{
    class SendMail
    {
        public void Send_Mail(string message, string mailTo, string nameTopic)
        {
            try
            {

                SmtpClient mySmtpClient = new SmtpClient("poczta.interia.pl");

                // set smtp-client with basicAuthentication
                mySmtpClient.UseDefaultCredentials = false;
                System.Net.NetworkCredential basicAuthenticationInfo = new
                   System.Net.NetworkCredential("adres_mailowy_z_jakiego_nalezy_wyslac_wiadomosc", "haslo_do_tego_maila");
                mySmtpClient.Credentials = basicAuthenticationInfo;

                // add from,to mailaddresses
                MailAddress from = new MailAddress("adres_mailowy", "inicjaly");
                MailAddress to = new MailAddress(mailTo, "Nazwa_Name");
                MailMessage myMail = new System.Net.Mail.MailMessage(from, to);

                // add ReplyTo
                MailAddress replyTo = new MailAddress("adres_mailowy");
                myMail.ReplyToList.Add(replyTo);

                // set subject and encoding
                myMail.Subject = nameTopic;
                myMail.SubjectEncoding = System.Text.Encoding.UTF8;

                // set body-message and encoding
                //myMail.Body = "<b>Test Mail</b><br>using <b>HTML</b>.";
                myMail.Body = message;
                myMail.BodyEncoding = System.Text.Encoding.UTF8;
                // text or html
                myMail.IsBodyHtml = true;

                mySmtpClient.Send(myMail);
            }

            catch (SmtpException ex)
            {

            }
            catch (Exception ex)
            {

            }
        }
    
    }
}

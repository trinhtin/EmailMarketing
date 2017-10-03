using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EmailMarketingTool
{
    class SendEmail
    {
        public static void SendEmailMarketing(string toAddress,string fromAddress,string pass,string subject,string content ) 
        {
            using (MailMessage mail = new MailMessage())
            {
                //initialize info
                mail.From = new MailAddress(fromAddress);
                mail.To.Add(toAddress);
                mail.Subject = subject;
                mail.Body = content;
                mail.IsBodyHtml = true;


                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    //
                    smtp.Credentials = new NetworkCredential(fromAddress, pass);
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                }
            }
        }
        public static void sendHtmlEmail(string from_Email, string to_Email, string body, string from_Name, string Subject, string SMTP_IP, Int32 SMTP_Server_Port)
        {
            //create an instance of new mail message
            MailMessage mail = new MailMessage();

            //set the HTML format to true
            mail.IsBodyHtml = true;

            //create Alrternative HTML view
            AlternateView htmlView = AlternateView.CreateAlternateViewFromString(body, null, "text/html");

            //Add Image
            //LinkedResource theEmailImage = new LinkedResource("E:\\IMG_3332.jpg");
            //theEmailImage.ContentId = "myImageID";

            //Add the Image to the Alternate view
            //htmlView.LinkedResources.Add(theEmailImage);

            //Add view to the Email Message
           // mail.AlternateViews.Add(htmlView);

            //set the "from email" address and specify a friendly 'from' name
            mail.From = new MailAddress(from_Email, from_Name);

            //set the "to" email address
            mail.To.Add(to_Email);

            //set the Email subject
            mail.Subject = Subject;

            //set the SMTP info
            System.Net.NetworkCredential cred = new System.Net.NetworkCredential("minhhoanghoangvo@gmail.com", "hoangvotong");
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = cred;
            //send the email
            smtp.Send(mail);
        }
        public static void Page_Load(string contents)
        {
            string Themessage = @"<html>
                              <body>
                                <table width=""100%""> "
                                + contents +
                                @"</table>
                                </body>
                                </html>";
            sendHtmlEmail("minhhoanghoangvo@gmail.com", "cdtdmathoi@gmail.com", Themessage, "Scoutfoto", "Test HTML Email", "smtp.gmail.com", 25);
        }
    }
}

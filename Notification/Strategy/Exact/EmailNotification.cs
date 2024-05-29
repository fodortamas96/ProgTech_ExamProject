using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ExamProject.Interfaces;

namespace ExamProject.Notification.Strategy.Exact
{
    internal class EmailNotification : NotificationStrategy
    {
        public override void SendNotification(ISubject subject)
        {
            SmtpClient smtpClient = new SmtpClient("smtp.mailersend.net", 587);
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new NetworkCredential("MS_wmqduK@trial-o65qngkk8zwgwr12.mlsender.net", "NTJ2x5oqPO0mfg0z");
            MailMessage message = new MailMessage();
            message.From = new MailAddress("MS_wmqduK@trial-o65qngkk8zwgwr12.mlsender.net");
            message.To.Add(new MailAddress((subject as AddForm).EmailAddress ?? "fodor.tamas48@gmail.com"));
            message.Subject = "Note added";
            message.Body = $"Note added successfully! Title: {(subject as AddForm).Note.Title}, Content: {(subject as AddForm).Note.Context}, Importance: {(subject as AddForm).Note.Importance}";
            message.IsBodyHtml = true;
            smtpClient.Send(message);
            message.Dispose();
        }
    }
}

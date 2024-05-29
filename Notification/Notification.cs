using ExamProject.Interfaces;
using ExamProject.Notification.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject.Notification
{
    internal class Notification : NotificationBase
    {
        private NotificationStrategy notificationStrategy;

        public Notification(NotificationStrategy notificationStrategy)
        {
            this.notificationStrategy = notificationStrategy;
        }

        public override void SendNotification(ISubject subject)
        {
            notificationStrategy.SendNotification(subject);
        }
    }
}

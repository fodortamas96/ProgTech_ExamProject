using ExamProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject.Notification.Strategy
{
    internal abstract class NotificationStrategy
    {
        public abstract void SendNotification(ISubject subject);
    }
}

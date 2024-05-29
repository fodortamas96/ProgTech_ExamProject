using ExamProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject.Notification.Strategy.Exact
{
    internal class ModalNotification : NotificationStrategy
    {
        public override void SendNotification(ISubject subject)
        {
            MessageBox.Show($"Title: {(subject as AddForm).Note.Title}, Content: {(subject as AddForm).Note.Context}, Importance: {(subject as AddForm).Note.Importance}", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

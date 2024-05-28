using ExamProject.Database;
using ExamProject.Interfaces;
using ExamProject.Notes;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Net;
using System.Net.Mail;

namespace ExamProject
{
    public partial class MainForm : Form, IObserver
    {
        private NotesContext? dbContext;
        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.dbContext = new NotesContext();
            //this.dbContext.Database.EnsureDeleted();
            this.dbContext.Database.EnsureCreated();
            this.dbContext.Notes.Load();
            this.noteBindingSource.DataSource = dbContext.Notes.Local.ToBindingList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.dbContext?.Dispose();
            this.dbContext = null;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.dbContext!.SaveChanges();

            this.dataGridViewNotes.Refresh();
            this.richTextBoxNoteContext.Refresh();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(this.dbContext);
            addForm.Attach(this);

            DialogResult result = addForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Note added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(addForm.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (dataGridViewNotes.CurrentRow != null)
                {
                    var selectedNote = (Note)dataGridViewNotes.CurrentRow.DataBoundItem;
                    this.dbContext!.Remove(selectedNote);
                    this.dbContext!.SaveChanges();
                }
            }

        }

        public void Update(ISubject subject)
        {
            if ((subject as AddForm).DialogResult == DialogResult.OK)
            {
                SendEmail(subject);
            }
        }

        public void SendEmail(ISubject subject)
        {
            SmtpClient smtpClient = new SmtpClient("smtp.mailersend.net", 587);
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new NetworkCredential("MS_wmqduK@trial-o65qngkk8zwgwr12.mlsender.net", "NTJ2x5oqPO0mfg0z");
            MailMessage message = new MailMessage();
            message.From = new MailAddress("MS_wmqduK@trial-o65qngkk8zwgwr12.mlsender.net");
            message.To.Add(new MailAddress("fodor.tamas48@gmail.com"));
            message.Subject = "Note added";
            message.Body = $"Note added successfully! Title: {(subject as AddForm).Note.Title}, Content: {(subject as AddForm).Note.Context}, Importance: {(subject as AddForm).Note.Importance}";
            message.IsBodyHtml = true;
            smtpClient.Send(message);
            message.Dispose();

        }
    }
}

using ExamProject.Database;
using ExamProject.Interfaces;
using ExamProject.Notes;
using ExamProject.Notification.Strategy.Exact;
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
                Notification.Notification notification;
                if ((subject as AddForm).Email == true)
                {
                    notification = new Notification.Notification(new EmailNotification());
                    notification.SendNotification(subject);
                }
                else
                {
                    notification = new Notification.Notification(new ModalNotification());
                    notification.SendNotification(subject);
                }
            }
        }
    }
}

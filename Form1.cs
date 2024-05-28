using ExamProject.Database;
using ExamProject.Notes;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace ExamProject
{
    public partial class MainForm : Form
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
            AddForm addForm = new AddForm();
            
            DialogResult result = addForm.ShowDialog();
        }
    }
}

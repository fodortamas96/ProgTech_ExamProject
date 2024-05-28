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
            AddForm addForm = new AddForm(this.dbContext);

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
    }
}

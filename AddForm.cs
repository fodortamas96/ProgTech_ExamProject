using ExamProject.Notes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamProject
{
    public partial class AddForm : Form
    {
        DbContext dbContext;
        string errorMessage = "";
        public AddForm(DbContext dbContext)
        {
            InitializeComponent();
            this.dbContext = dbContext;
        }

        public string ErrorMessage { get => errorMessage; }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            
            Importance importance;
            if (radioButtonLow.Checked)
            {
                importance = Importance.Low;
            } else if (radioButtonNormal.Checked)
            {
                importance = Importance.Normal;
            } else
            {
                importance = Importance.High;
            }

            try
            {
                Note newNote = new Note(textBoxTitle.Text, richTextBoxContent.Text, importance, DateTime.Now, 1);
                this.dbContext.Add(newNote);
                this.dbContext.SaveChanges();
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception exception)
            {
                this.DialogResult = DialogResult.Abort;
                this.errorMessage = exception.Message;
            }
            this.Close();
        }
    }
}

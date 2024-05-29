using ExamProject.Interfaces;
using ExamProject.Notes;
using ExamProject.Users;
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
    public partial class AddForm : Form, ISubject
    {
        DbContext dbContext;
        string errorMessage = "";
        Note note;
        bool email = false;
        string emailAddress;

        private List<IObserver> observers = new List<IObserver>();

        public AddForm(DbContext dbContext)
        {
            InitializeComponent();
            this.dbContext = dbContext;
        }

        public string ErrorMessage { get => errorMessage; }
        public Note Note { get => note; }
        public bool Email { get => email; }
        public string EmailAddress { get => emailAddress; }

        public void Attach(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this.observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(this);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            Importance importance;
            if (radioButtonLow.Checked)
            {
                importance = Importance.Low;
            }
            else if (radioButtonNormal.Checked)
            {
                importance = Importance.Normal;
            }
            else
            {
                importance = Importance.High;
            }

            try
            {
                Note newNote = new Note(textBoxTitle.Text, richTextBoxContent.Text, importance, DateTime.Now, 1);
                this.dbContext.Add(newNote);
                this.dbContext.SaveChanges();
                this.DialogResult = DialogResult.OK;
                this.note = newNote;
                this.emailAddress = textBoxEmail.Text;
                this.Notify();

            }
            catch (Exception exception)
            {
                this.DialogResult = DialogResult.Abort;
                this.errorMessage = exception.Message;
            }
            this.Close();
        }

        private void checkBoxEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEmail.Checked == true)
            {
                labelEmail.Visible = true;
                textBoxEmail.Visible = true;
                email = true;
            } else
            {
                labelEmail.Visible = false;
                textBoxEmail.Visible = false;
                textBoxEmail.Text = string.Empty;
                email = false;
            }
        }
    }
}

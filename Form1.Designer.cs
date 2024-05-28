using ExamProject.Notes;

namespace ExamProject
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridViewNotes = new DataGridView();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            importanceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            CreationDate = new DataGridViewTextBoxColumn();
            noteBindingSource = new BindingSource(components);
            richTextBoxNoteContext = new RichTextBox();
            buttonSave = new Button();
            buttonAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNotes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)noteBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewNotes
            // 
            dataGridViewNotes.AutoGenerateColumns = false;
            dataGridViewNotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNotes.Columns.AddRange(new DataGridViewColumn[] { titleDataGridViewTextBoxColumn, importanceDataGridViewTextBoxColumn, CreationDate });
            dataGridViewNotes.DataSource = noteBindingSource;
            dataGridViewNotes.Location = new Point(12, 52);
            dataGridViewNotes.Name = "dataGridViewNotes";
            dataGridViewNotes.Size = new Size(343, 386);
            dataGridViewNotes.TabIndex = 0;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // importanceDataGridViewTextBoxColumn
            // 
            importanceDataGridViewTextBoxColumn.DataPropertyName = "Importance";
            importanceDataGridViewTextBoxColumn.HeaderText = "Importance";
            importanceDataGridViewTextBoxColumn.Name = "importanceDataGridViewTextBoxColumn";
            // 
            // CreationDate
            // 
            CreationDate.DataPropertyName = "CreationDate";
            CreationDate.HeaderText = "CreationDate";
            CreationDate.Name = "CreationDate";
            // 
            // noteBindingSource
            // 
            noteBindingSource.DataSource = typeof(Note);
            // 
            // richTextBoxNoteContext
            // 
            richTextBoxNoteContext.DataBindings.Add(new Binding("Text", noteBindingSource, "Context", true));
            richTextBoxNoteContext.Location = new Point(361, 52);
            richTextBoxNoteContext.Name = "richTextBoxNoteContext";
            richTextBoxNoteContext.Size = new Size(276, 96);
            richTextBoxNoteContext.TabIndex = 1;
            richTextBoxNoteContext.Text = "";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(361, 154);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(97, 34);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(12, 12);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(97, 34);
            buttonAdd.TabIndex = 3;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 450);
            Controls.Add(buttonAdd);
            Controls.Add(buttonSave);
            Controls.Add(richTextBoxNoteContext);
            Controls.Add(dataGridViewNotes);
            Name = "MainForm";
            Text = "Notes";
            ((System.ComponentModel.ISupportInitialize)dataGridViewNotes).EndInit();
            ((System.ComponentModel.ISupportInitialize)noteBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewNotes;
        private BindingSource noteBindingSource;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn importanceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn CreationDate;
        private RichTextBox richTextBoxNoteContext;
        private Button buttonSave;
        private Button buttonAdd;
    }
}

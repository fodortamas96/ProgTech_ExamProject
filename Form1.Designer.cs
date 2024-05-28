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
            noteBindingSource = new BindingSource(components);
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            importanceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            CreationDate = new DataGridViewTextBoxColumn();
            richTextBoxNoteContext = new RichTextBox();
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
            dataGridViewNotes.Location = new Point(12, 12);
            dataGridViewNotes.Name = "dataGridViewNotes";
            dataGridViewNotes.Size = new Size(343, 426);
            dataGridViewNotes.TabIndex = 0;
            dataGridViewNotes.SelectionChanged += dataGridViewNotes_SelectionChanged;
            // 
            // noteBindingSource
            // 
            noteBindingSource.DataSource = typeof(Note);
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
            // richTextBoxNoteContext
            // 
            richTextBoxNoteContext.Location = new Point(361, 12);
            richTextBoxNoteContext.Name = "richTextBoxNoteContext";
            richTextBoxNoteContext.Size = new Size(276, 96);
            richTextBoxNoteContext.TabIndex = 1;
            richTextBoxNoteContext.Text = "";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 450);
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
    }
}

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
            noteIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contextDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            importanceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ownerIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ownerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            CreationDate = new DataGridViewTextBoxColumn();
            ModificationDate = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNotes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)noteBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewNotes
            // 
            dataGridViewNotes.AutoGenerateColumns = false;
            dataGridViewNotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNotes.Columns.AddRange(new DataGridViewColumn[] { noteIdDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, contextDataGridViewTextBoxColumn, importanceDataGridViewTextBoxColumn, ownerIdDataGridViewTextBoxColumn, ownerDataGridViewTextBoxColumn, CreationDate, ModificationDate });
            dataGridViewNotes.DataSource = noteBindingSource;
            dataGridViewNotes.Location = new Point(12, 12);
            dataGridViewNotes.Name = "dataGridViewNotes";
            dataGridViewNotes.Size = new Size(842, 426);
            dataGridViewNotes.TabIndex = 0;
            // 
            // noteBindingSource
            // 
            noteBindingSource.DataSource = typeof(Note);
            // 
            // noteIdDataGridViewTextBoxColumn
            // 
            noteIdDataGridViewTextBoxColumn.DataPropertyName = "NoteId";
            noteIdDataGridViewTextBoxColumn.HeaderText = "NoteId";
            noteIdDataGridViewTextBoxColumn.Name = "noteIdDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // contextDataGridViewTextBoxColumn
            // 
            contextDataGridViewTextBoxColumn.DataPropertyName = "Context";
            contextDataGridViewTextBoxColumn.HeaderText = "Context";
            contextDataGridViewTextBoxColumn.Name = "contextDataGridViewTextBoxColumn";
            // 
            // importanceDataGridViewTextBoxColumn
            // 
            importanceDataGridViewTextBoxColumn.DataPropertyName = "Importance";
            importanceDataGridViewTextBoxColumn.HeaderText = "Importance";
            importanceDataGridViewTextBoxColumn.Name = "importanceDataGridViewTextBoxColumn";
            // 
            // ownerIdDataGridViewTextBoxColumn
            // 
            ownerIdDataGridViewTextBoxColumn.DataPropertyName = "OwnerId";
            ownerIdDataGridViewTextBoxColumn.HeaderText = "OwnerId";
            ownerIdDataGridViewTextBoxColumn.Name = "ownerIdDataGridViewTextBoxColumn";
            // 
            // ownerDataGridViewTextBoxColumn
            // 
            ownerDataGridViewTextBoxColumn.DataPropertyName = "Owner";
            ownerDataGridViewTextBoxColumn.HeaderText = "Owner";
            ownerDataGridViewTextBoxColumn.Name = "ownerDataGridViewTextBoxColumn";
            // 
            // CreationDate
            // 
            CreationDate.DataPropertyName = "CreationDate";
            CreationDate.HeaderText = "CreationDate";
            CreationDate.Name = "CreationDate";
            // 
            // ModificationDate
            // 
            ModificationDate.DataPropertyName = "ModificationDate";
            ModificationDate.HeaderText = "ModificationDate";
            ModificationDate.Name = "ModificationDate";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 450);
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
        private DataGridViewTextBoxColumn noteIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contextDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn importanceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ownerIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ownerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn CreationDate;
        private DataGridViewTextBoxColumn ModificationDate;
    }
}

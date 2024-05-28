namespace ExamProject
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTitle = new Label();
            labelContent = new Label();
            radioButtonLow = new RadioButton();
            radioButtonNormal = new RadioButton();
            radioButtonHigh = new RadioButton();
            groupBoxImportance = new GroupBox();
            textBoxTitle = new TextBox();
            richTextBoxContent = new RichTextBox();
            buttonAdd = new Button();
            groupBoxImportance.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(12, 28);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(29, 15);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Title";
            // 
            // labelContent
            // 
            labelContent.AutoSize = true;
            labelContent.Location = new Point(12, 82);
            labelContent.Name = "labelContent";
            labelContent.Size = new Size(50, 15);
            labelContent.TabIndex = 1;
            labelContent.Text = "Content";
            // 
            // radioButtonLow
            // 
            radioButtonLow.AutoSize = true;
            radioButtonLow.Location = new Point(6, 22);
            radioButtonLow.Name = "radioButtonLow";
            radioButtonLow.Size = new Size(47, 19);
            radioButtonLow.TabIndex = 2;
            radioButtonLow.Text = "Low";
            radioButtonLow.UseVisualStyleBackColor = true;
            // 
            // radioButtonNormal
            // 
            radioButtonNormal.AutoSize = true;
            radioButtonNormal.Checked = true;
            radioButtonNormal.Location = new Point(59, 22);
            radioButtonNormal.Name = "radioButtonNormal";
            radioButtonNormal.Size = new Size(65, 19);
            radioButtonNormal.TabIndex = 4;
            radioButtonNormal.TabStop = true;
            radioButtonNormal.Text = "Normal";
            radioButtonNormal.UseVisualStyleBackColor = true;
            // 
            // radioButtonHigh
            // 
            radioButtonHigh.AutoSize = true;
            radioButtonHigh.Location = new Point(130, 22);
            radioButtonHigh.Name = "radioButtonHigh";
            radioButtonHigh.Size = new Size(51, 19);
            radioButtonHigh.TabIndex = 0;
            radioButtonHigh.Text = "High";
            radioButtonHigh.UseVisualStyleBackColor = true;
            // 
            // groupBoxImportance
            // 
            groupBoxImportance.Controls.Add(radioButtonLow);
            groupBoxImportance.Controls.Add(radioButtonHigh);
            groupBoxImportance.Controls.Add(radioButtonNormal);
            groupBoxImportance.Location = new Point(51, 187);
            groupBoxImportance.Name = "groupBoxImportance";
            groupBoxImportance.Size = new Size(200, 55);
            groupBoxImportance.TabIndex = 5;
            groupBoxImportance.TabStop = false;
            groupBoxImportance.Text = "Importance";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(12, 46);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(277, 23);
            textBoxTitle.TabIndex = 6;
            // 
            // richTextBoxContent
            // 
            richTextBoxContent.Location = new Point(12, 100);
            richTextBoxContent.Name = "richTextBoxContent";
            richTextBoxContent.Size = new Size(277, 81);
            richTextBoxContent.TabIndex = 7;
            richTextBoxContent.Text = "";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(96, 265);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(97, 34);
            buttonAdd.TabIndex = 8;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 324);
            Controls.Add(buttonAdd);
            Controls.Add(richTextBoxContent);
            Controls.Add(textBoxTitle);
            Controls.Add(groupBoxImportance);
            Controls.Add(labelContent);
            Controls.Add(labelTitle);
            Name = "AddForm";
            Text = "Add Note";
            groupBoxImportance.ResumeLayout(false);
            groupBoxImportance.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label labelContent;
        private RadioButton radioButtonLow;
        private RadioButton radioButtonNormal;
        private RadioButton radioButtonHigh;
        private GroupBox groupBoxImportance;
        private TextBox textBoxTitle;
        private RichTextBox richTextBoxContent;
        private Button buttonAdd;
    }
}
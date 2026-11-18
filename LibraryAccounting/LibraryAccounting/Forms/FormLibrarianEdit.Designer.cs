namespace LibraryAccounting.Forms
{
    partial class FormLibrarianEdit
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
            label1 = new Label();
            textBoxFirstName = new TextBox();
            label2 = new Label();
            textBoxLastName = new TextBox();
            label3 = new Label();
            checkedListBoxThemes = new CheckedListBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 23);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 0;
            label1.Text = "Имя:";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(118, 23);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(208, 27);
            textBoxFirstName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 70);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 2;
            label2.Text = "Фамилия:";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(118, 70);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(208, 27);
            textBoxLastName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 128);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 4;
            label3.Text = "Доступные темы:";
            // 
            // checkedListBoxThemes
            // 
            checkedListBoxThemes.CheckOnClick = true;
            checkedListBoxThemes.FormattingEnabled = true;
            checkedListBoxThemes.Location = new Point(157, 128);
            checkedListBoxThemes.Name = "checkedListBoxThemes";
            checkedListBoxThemes.Size = new Size(169, 70);
            checkedListBoxThemes.TabIndex = 5;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(23, 231);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(198, 231);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormLibrarianEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 297);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(checkedListBoxThemes);
            Controls.Add(label3);
            Controls.Add(textBoxLastName);
            Controls.Add(label2);
            Controls.Add(textBoxFirstName);
            Controls.Add(label1);
            Name = "FormLibrarianEdit";
            Text = "Редактирование библиотекаря ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxFirstName;
        private Label label2;
        private TextBox textBoxLastName;
        private Label label3;
        private CheckedListBox checkedListBoxThemes;
        private Button buttonSave;
        private Button buttonCancel;
    }
}
namespace LibraryAccounting.Forms
{
    partial class FormLiteraryItemEdit
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
            label2 = new Label();
            label3 = new Label();
            buttonSave = new Button();
            buttonCancel = new Button();
            textBoxTitle = new TextBox();
            comboBoxTheme = new ComboBox();
            comboBoxType = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 32);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "Название:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 85);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 1;
            label2.Text = "Тематика:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 147);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 2;
            label3.Text = "Тип:";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(30, 238);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(241, 238);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 4;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(123, 32);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(265, 27);
            textBoxTitle.TabIndex = 5;
            // 
            // comboBoxTheme
            // 
            comboBoxTheme.FormattingEnabled = true;
            comboBoxTheme.Location = new Point(123, 85);
            comboBoxTheme.Name = "comboBoxTheme";
            comboBoxTheme.Size = new Size(265, 28);
            comboBoxTheme.TabIndex = 6;
            // 
            // comboBoxType
            // 
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(123, 144);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(265, 28);
            comboBoxType.TabIndex = 7;
            // 
            // FormLiteraryItemEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 323);
            Controls.Add(comboBoxType);
            Controls.Add(comboBoxTheme);
            Controls.Add(textBoxTitle);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormLiteraryItemEdit";
            Text = "Редактирование издания";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonSave;
        private Button buttonCancel;
        private TextBox textBoxTitle;
        private ComboBox comboBoxTheme;
        private ComboBox comboBoxType;
    }
}
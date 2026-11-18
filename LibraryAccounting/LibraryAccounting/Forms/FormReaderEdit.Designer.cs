namespace LibraryAccounting.Forms
{
    partial class FormReaderEdit
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
            textBoxFullName = new TextBox();
            label2 = new Label();
            textBoxTicketNumber = new TextBox();
            label3 = new Label();
            dateTimePickerValidUntil = new DateTimePicker();
            buttonSave = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 31);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 0;
            label1.Text = "ФИО:";
            // 
            // textBoxFullName
            // 
            textBoxFullName.Location = new Point(26, 54);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(356, 27);
            textBoxFullName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 96);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 2;
            label2.Text = "Номер билета:";
            // 
            // textBoxTicketNumber
            // 
            textBoxTicketNumber.Location = new Point(26, 133);
            textBoxTicketNumber.Name = "textBoxTicketNumber";
            textBoxTicketNumber.Size = new Size(356, 27);
            textBoxTicketNumber.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 173);
            label3.Name = "label3";
            label3.Size = new Size(129, 20);
            label3.TabIndex = 4;
            label3.Text = "Действителен до:";
            // 
            // dateTimePickerValidUntil
            // 
            dateTimePickerValidUntil.Location = new Point(26, 208);
            dateTimePickerValidUntil.Name = "dateTimePickerValidUntil";
            dateTimePickerValidUntil.Size = new Size(160, 27);
            dateTimePickerValidUntil.TabIndex = 5;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(386, 369);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(386, 404);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormReaderEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 456);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(dateTimePickerValidUntil);
            Controls.Add(label3);
            Controls.Add(textBoxTicketNumber);
            Controls.Add(label2);
            Controls.Add(textBoxFullName);
            Controls.Add(label1);
            Name = "FormReaderEdit";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Редактирование читателя ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxFullName;
        private Label label2;
        private TextBox textBoxTicketNumber;
        private Label label3;
        private DateTimePicker dateTimePickerValidUntil;
        private Button buttonSave;
        private Button buttonCancel;
    }
}
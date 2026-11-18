namespace LibraryAccounting.Forms
{
    partial class FormLoanCreate
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
            label4 = new Label();
            buttonSave = new Button();
            buttonCancel = new Button();
            comboBoxReader = new ComboBox();
            comboBoxLibrarian = new ComboBox();
            comboBoxItem = new ComboBox();
            dateTimePickerDueDate = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 25);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Читатель:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 87);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 1;
            label2.Text = "Библиотекарь:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 150);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 2;
            label3.Text = "Издание:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 215);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 3;
            label4.Text = "Дата возврата:";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(38, 275);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Выдать";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(267, 275);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // comboBoxReader
            // 
            comboBoxReader.FormattingEnabled = true;
            comboBoxReader.Location = new Point(172, 25);
            comboBoxReader.Name = "comboBoxReader";
            comboBoxReader.Size = new Size(220, 28);
            comboBoxReader.TabIndex = 6;
            // 
            // comboBoxLibrarian
            // 
            comboBoxLibrarian.FormattingEnabled = true;
            comboBoxLibrarian.Location = new Point(172, 87);
            comboBoxLibrarian.Name = "comboBoxLibrarian";
            comboBoxLibrarian.Size = new Size(220, 28);
            comboBoxLibrarian.TabIndex = 7;
            // 
            // comboBoxItem
            // 
            comboBoxItem.FormattingEnabled = true;
            comboBoxItem.Location = new Point(172, 150);
            comboBoxItem.Name = "comboBoxItem";
            comboBoxItem.Size = new Size(220, 28);
            comboBoxItem.TabIndex = 8;
            // 
            // dateTimePickerDueDate
            // 
            dateTimePickerDueDate.Location = new Point(172, 210);
            dateTimePickerDueDate.Name = "dateTimePickerDueDate";
            dateTimePickerDueDate.Size = new Size(165, 27);
            dateTimePickerDueDate.TabIndex = 9;
            // 
            // FormLoanCreate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 327);
            Controls.Add(dateTimePickerDueDate);
            Controls.Add(comboBoxItem);
            Controls.Add(comboBoxLibrarian);
            Controls.Add(comboBoxReader);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormLoanCreate";
            Text = "Оформление выдачи";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonSave;
        private Button buttonCancel;
        private ComboBox comboBoxReader;
        private ComboBox comboBoxLibrarian;
        private ComboBox comboBoxItem;
        private DateTimePicker dateTimePickerDueDate;
    }
}
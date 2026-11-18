namespace LibraryAccounting.Forms
{
    partial class FormSupplyCreate
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
            comboBoxLibrarian = new ComboBox();
            dateTimePickerDate = new DateTimePicker();
            dataGridViewItems = new DataGridView();
            ColumnItem = new DataGridViewComboBoxColumn();
            ColumnCount = new DataGridViewTextBoxColumn();
            buttonSave = new Button();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItems).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 22);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 0;
            label1.Text = "Библиотекарь:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 64);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 1;
            label2.Text = "Дата:";
            // 
            // comboBoxLibrarian
            // 
            comboBoxLibrarian.FormattingEnabled = true;
            comboBoxLibrarian.Location = new Point(161, 22);
            comboBoxLibrarian.Name = "comboBoxLibrarian";
            comboBoxLibrarian.Size = new Size(179, 28);
            comboBoxLibrarian.TabIndex = 2;
            // 
            // dateTimePickerDate
            // 
            dateTimePickerDate.Enabled = false;
            dateTimePickerDate.Location = new Point(161, 59);
            dateTimePickerDate.Name = "dateTimePickerDate";
            dateTimePickerDate.Size = new Size(179, 27);
            dateTimePickerDate.TabIndex = 3;
            // 
            // dataGridViewItems
            // 
            dataGridViewItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewItems.Columns.AddRange(new DataGridViewColumn[] { ColumnItem, ColumnCount });
            dataGridViewItems.Location = new Point(27, 108);
            dataGridViewItems.Name = "dataGridViewItems";
            dataGridViewItems.RowHeadersWidth = 51;
            dataGridViewItems.Size = new Size(432, 224);
            dataGridViewItems.TabIndex = 4;
            // 
            // ColumnItem
            // 
            ColumnItem.HeaderText = "Издание";
            ColumnItem.MinimumWidth = 6;
            ColumnItem.Name = "ColumnItem";
            // 
            // ColumnCount
            // 
            ColumnCount.HeaderText = "Количество";
            ColumnCount.MinimumWidth = 6;
            ColumnCount.Name = "ColumnCount";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(27, 370);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 5;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(218, 370);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 6;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormSupplyCreate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 435);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(dataGridViewItems);
            Controls.Add(dateTimePickerDate);
            Controls.Add(comboBoxLibrarian);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormSupplyCreate";
            Text = "Оформление поставки";
            ((System.ComponentModel.ISupportInitialize)dataGridViewItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBoxLibrarian;
        private DateTimePicker dateTimePickerDate;
        private DataGridView dataGridViewItems;
        private Button buttonSave;
        private Button buttonCancel;
        private DataGridViewComboBoxColumn ColumnItem;
        private DataGridViewTextBoxColumn ColumnCount;
    }
}
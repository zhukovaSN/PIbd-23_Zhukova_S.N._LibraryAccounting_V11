namespace LibraryAccounting.Forms
{
    partial class FormLiteraryItems
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
            dataGridViewData = new DataGridView();
            panel1 = new Panel();
            buttonAdd = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewData
            // 
            dataGridViewData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewData.Dock = DockStyle.Left;
            dataGridViewData.Location = new Point(0, 0);
            dataGridViewData.Name = "dataGridViewData";
            dataGridViewData.RowHeadersWidth = 51;
            dataGridViewData.Size = new Size(593, 450);
            dataGridViewData.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonDelete);
            panel1.Controls.Add(buttonUpdate);
            panel1.Controls.Add(buttonAdd);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(593, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(207, 450);
            panel1.TabIndex = 1;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(60, 61);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(60, 106);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(94, 29);
            buttonUpdate.TabIndex = 1;
            buttonUpdate.Text = "Изменить";
            buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(60, 151);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // FormLiteraryItems
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(dataGridViewData);
            Name = "FormLiteraryItems";
            Text = "Список изданий";
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewData;
        private Panel panel1;
        private Button buttonDelete;
        private Button buttonUpdate;
        private Button buttonAdd;
    }
}
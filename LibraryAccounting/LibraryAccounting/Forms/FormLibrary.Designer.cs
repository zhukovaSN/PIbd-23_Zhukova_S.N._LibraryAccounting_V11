using System.Drawing;
using System.Windows.Forms;
namespace LibraryAccounting
{
    partial class FormLibrary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLibrary));
            menuStrip1 = new MenuStrip();
            directoriesMenuItem = new ToolStripMenuItem();
            readersMenuItem = new ToolStripMenuItem();
            librariansMenuItem = new ToolStripMenuItem();
            literaryItemsMenuItem = new ToolStripMenuItem();
            operationsMenuItem = new ToolStripMenuItem();
            loansMenuItem = new ToolStripMenuItem();
            suppliesMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { directoriesMenuItem, operationsMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(627, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // directoriesMenuItem
            // 
            directoriesMenuItem.DropDownItems.AddRange(new ToolStripItem[] { readersMenuItem, librariansMenuItem, literaryItemsMenuItem });
            directoriesMenuItem.Name = "directoriesMenuItem";
            directoriesMenuItem.Size = new Size(117, 24);
            directoriesMenuItem.Text = "Справочники";
            // 
            // readersMenuItem
            // 
            readersMenuItem.Name = "readersMenuItem";
            readersMenuItem.Size = new Size(192, 26);
            readersMenuItem.Text = "Читатели";
            readersMenuItem.Click += readersMenuItem_Click;
            // 
            // librariansMenuItem
            // 
            librariansMenuItem.Name = "librariansMenuItem";
            librariansMenuItem.Size = new Size(192, 26);
            librariansMenuItem.Text = "Библиотекари";
            librariansMenuItem.Click += librariansMenuItem_Click;
            // 
            // literaryItemsMenuItem
            // 
            literaryItemsMenuItem.Name = "literaryItemsMenuItem";
            literaryItemsMenuItem.Size = new Size(192, 26);
            literaryItemsMenuItem.Text = "Издания";
            literaryItemsMenuItem.Click += literaryItemsMenuItem_Click;
            // 
            // operationsMenuItem
            // 
            operationsMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loansMenuItem, suppliesMenuItem });
            operationsMenuItem.Name = "operationsMenuItem";
            operationsMenuItem.Size = new Size(95, 24);
            operationsMenuItem.Text = "Операции";
            // 
            // loansMenuItem
            // 
            loansMenuItem.Name = "loansMenuItem";
            loansMenuItem.Size = new Size(157, 26);
            loansMenuItem.Text = "Выдачи";
            loansMenuItem.Click += loansMenuItem_Click;
            // 
            // suppliesMenuItem
            // 
            suppliesMenuItem.Name = "suppliesMenuItem";
            suppliesMenuItem.Size = new Size(157, 26);
            suppliesMenuItem.Text = "Поставки";
            suppliesMenuItem.Click += suppliesMenuItem_Click;
            // 
            // FormLibrary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(627, 477);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            MainMenuStrip = menuStrip1;
            Name = "FormLibrary";
            Text = "Библиотека";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem directoriesMenuItem;
        private ToolStripMenuItem readersMenuItem;
        private ToolStripMenuItem librariansMenuItem;
        private ToolStripMenuItem literaryItemsMenuItem;
        private ToolStripMenuItem operationsMenuItem;
        private ToolStripMenuItem loansMenuItem;
        private ToolStripMenuItem suppliesMenuItem;
    }
}

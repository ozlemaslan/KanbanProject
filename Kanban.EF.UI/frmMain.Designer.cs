namespace Kanban.EF.UI
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kANBANToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.kANBANToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // kANBANToolStripMenuItem
            // 
            this.kANBANToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBoardToolStripMenuItem,
            this.openBoardToolStripMenuItem});
            this.kANBANToolStripMenuItem.Name = "kANBANToolStripMenuItem";
            this.kANBANToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.kANBANToolStripMenuItem.Text = "KANBAN ";
            // 
            // newBoardToolStripMenuItem
            // 
            this.newBoardToolStripMenuItem.Name = "newBoardToolStripMenuItem";
            this.newBoardToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newBoardToolStripMenuItem.Text = "New Board";
            this.newBoardToolStripMenuItem.Click += new System.EventHandler(this.newBoardToolStripMenuItem_Click);
            // 
            // openBoardToolStripMenuItem
            // 
            this.openBoardToolStripMenuItem.Name = "openBoardToolStripMenuItem";
            this.openBoardToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openBoardToolStripMenuItem.Text = "Open Board";
            this.openBoardToolStripMenuItem.Click += new System.EventHandler(this.openBoardToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "KanbanBoard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kANBANToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newBoardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openBoardToolStripMenuItem;
    }
}


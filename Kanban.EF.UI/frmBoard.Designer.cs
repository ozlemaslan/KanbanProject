namespace Kanban.EF.UI
{
    partial class frmBoard
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yeniGörevToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDONE = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDOING = new System.Windows.Forms.Panel();
            this.pnlTODO = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniGörevToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(733, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // yeniGörevToolStripMenuItem
            // 
            this.yeniGörevToolStripMenuItem.Name = "yeniGörevToolStripMenuItem";
            this.yeniGörevToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.yeniGörevToolStripMenuItem.Text = "Yeni Görev";
            this.yeniGörevToolStripMenuItem.Click += new System.EventHandler(this.yeniGörevToolStripMenuItem_Click);
            // 
            // pnlDONE
            // 
            this.pnlDONE.AllowDrop = true;
            this.pnlDONE.ContextMenuStrip = this.contextMenuStrip1;
            this.pnlDONE.Location = new System.Drawing.Point(487, 83);
            this.pnlDONE.Name = "pnlDONE";
            this.pnlDONE.Size = new System.Drawing.Size(227, 339);
            this.pnlDONE.TabIndex = 29;
            this.pnlDONE.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlTODO_DragDrop);
            this.pnlDONE.DragOver += new System.Windows.Forms.DragEventHandler(this.pnlTODO_DragOver);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(87, 26);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // pnlDOING
            // 
            this.pnlDOING.AllowDrop = true;
            this.pnlDOING.ContextMenuStrip = this.contextMenuStrip1;
            this.pnlDOING.Location = new System.Drawing.Point(219, 83);
            this.pnlDOING.Name = "pnlDOING";
            this.pnlDOING.Size = new System.Drawing.Size(246, 339);
            this.pnlDOING.TabIndex = 30;
            this.pnlDOING.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlTODO_DragDrop);
            this.pnlDOING.DragOver += new System.Windows.Forms.DragEventHandler(this.pnlTODO_DragOver);
            // 
            // pnlTODO
            // 
            this.pnlTODO.AllowDrop = true;
            this.pnlTODO.ContextMenuStrip = this.contextMenuStrip1;
            this.pnlTODO.Location = new System.Drawing.Point(18, 83);
            this.pnlTODO.Name = "pnlTODO";
            this.pnlTODO.Size = new System.Drawing.Size(179, 339);
            this.pnlTODO.TabIndex = 31;
            this.pnlTODO.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlTODO_DragDrop);
            this.pnlTODO.DragOver += new System.Windows.Forms.DragEventHandler(this.pnlTODO_DragOver);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(90, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "TODO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(309, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "DOING";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(564, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "DONE";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(471, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 394);
            this.panel3.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(18, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 13);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(203, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 394);
            this.panel2.TabIndex = 26;
            // 
            // frmBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 450);
            this.Controls.Add(this.pnlDONE);
            this.Controls.Add(this.pnlDOING);
            this.Controls.Add(this.pnlTODO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmBoard";
            this.Text = "frmBoard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBoard_FormClosing);
            this.Load += new System.EventHandler(this.frmBoard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yeniGörevToolStripMenuItem;
        private System.Windows.Forms.Panel pnlDONE;
        private System.Windows.Forms.Panel pnlDOING;
        private System.Windows.Forms.Panel pnlTODO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
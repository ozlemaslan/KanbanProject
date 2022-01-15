namespace Kanban.EF.UI
{
    partial class frmBoardListele
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
            this.lstTahtalar = new System.Windows.Forms.ListBox();
            this.btnYukle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstTahtalar
            // 
            this.lstTahtalar.FormattingEnabled = true;
            this.lstTahtalar.Location = new System.Drawing.Point(11, 0);
            this.lstTahtalar.Name = "lstTahtalar";
            this.lstTahtalar.Size = new System.Drawing.Size(269, 329);
            this.lstTahtalar.TabIndex = 0;
            // 
            // btnYukle
            // 
            this.btnYukle.Location = new System.Drawing.Point(80, 335);
            this.btnYukle.Name = "btnYukle";
            this.btnYukle.Size = new System.Drawing.Size(109, 37);
            this.btnYukle.TabIndex = 1;
            this.btnYukle.Text = "Tahta Yükle";
            this.btnYukle.UseVisualStyleBackColor = true;
            this.btnYukle.Click += new System.EventHandler(this.btnYukle_Click);
            // 
            // frmBoardListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 379);
            this.Controls.Add(this.btnYukle);
            this.Controls.Add(this.lstTahtalar);
            this.Name = "frmBoardListele";
            this.Text = "frmBoardListele";
            this.Load += new System.EventHandler(this.frmBoardListele_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstTahtalar;
        private System.Windows.Forms.Button btnYukle;
    }
}
namespace Kanban.EF.UI
{
    partial class frmYeniGorev
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
            this.btnGorevEkle = new System.Windows.Forms.Button();
            this.txtGorev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGorevEkle
            // 
            this.btnGorevEkle.Location = new System.Drawing.Point(108, 65);
            this.btnGorevEkle.Name = "btnGorevEkle";
            this.btnGorevEkle.Size = new System.Drawing.Size(122, 33);
            this.btnGorevEkle.TabIndex = 8;
            this.btnGorevEkle.Text = "GÖREV EKLE";
            this.btnGorevEkle.UseVisualStyleBackColor = true;
            this.btnGorevEkle.Click += new System.EventHandler(this.btnGorevEkle_Click);
            // 
            // txtGorev
            // 
            this.txtGorev.Location = new System.Drawing.Point(108, 24);
            this.txtGorev.Name = "txtGorev";
            this.txtGorev.Size = new System.Drawing.Size(122, 20);
            this.txtGorev.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Yeni Görev Adı:";
            // 
            // frmYeniGorev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 126);
            this.Controls.Add(this.btnGorevEkle);
            this.Controls.Add(this.txtGorev);
            this.Controls.Add(this.label1);
            this.Name = "frmYeniGorev";
            this.Text = "frmYeniGorev";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGorevEkle;
        private System.Windows.Forms.TextBox txtGorev;
        private System.Windows.Forms.Label label1;
    }
}
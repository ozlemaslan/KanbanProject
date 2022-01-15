namespace Kanban.EF.UI
{
    partial class frmYeniTahta
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
            this.btnTahtaEkle = new System.Windows.Forms.Button();
            this.txtTahta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTahtaEkle
            // 
            this.btnTahtaEkle.Location = new System.Drawing.Point(99, 62);
            this.btnTahtaEkle.Name = "btnTahtaEkle";
            this.btnTahtaEkle.Size = new System.Drawing.Size(122, 33);
            this.btnTahtaEkle.TabIndex = 5;
            this.btnTahtaEkle.Text = "EKLE";
            this.btnTahtaEkle.UseVisualStyleBackColor = true;
            this.btnTahtaEkle.Click += new System.EventHandler(this.btnTahtaEkle_Click);
            // 
            // txtTahta
            // 
            this.txtTahta.Location = new System.Drawing.Point(99, 21);
            this.txtTahta.Name = "txtTahta";
            this.txtTahta.Size = new System.Drawing.Size(122, 20);
            this.txtTahta.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Yeni Tahta Adı:";
            // 
            // frmYeniTahta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 124);
            this.Controls.Add(this.btnTahtaEkle);
            this.Controls.Add(this.txtTahta);
            this.Controls.Add(this.label1);
            this.Name = "frmYeniTahta";
            this.Text = "frmYeniTahta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTahtaEkle;
        private System.Windows.Forms.TextBox txtTahta;
        private System.Windows.Forms.Label label1;
    }
}
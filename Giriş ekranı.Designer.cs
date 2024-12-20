namespace Petrol
{
    partial class frmGiris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnGiriş = new System.Windows.Forms.Button();
            this.lblGiris = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BackColor = System.Drawing.Color.Black;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(271, 228);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(216, 38);
            this.txtKullaniciAdi.TabIndex = 6;
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.Black;
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtSifre.Location = new System.Drawing.Point(271, 302);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(216, 38);
            this.txtSifre.TabIndex = 1;
            // 
            // btnGiriş
            // 
            this.btnGiriş.BackColor = System.Drawing.Color.Black;
            this.btnGiriş.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiriş.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnGiriş.Location = new System.Drawing.Point(310, 393);
            this.btnGiriş.Name = "btnGiriş";
            this.btnGiriş.Size = new System.Drawing.Size(131, 67);
            this.btnGiriş.TabIndex = 2;
            this.btnGiriş.Text = "GİRİŞ";
            this.btnGiriş.UseVisualStyleBackColor = false;
            this.btnGiriş.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // lblGiris
            // 
            this.lblGiris.AutoSize = true;
            this.lblGiris.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGiris.ForeColor = System.Drawing.Color.Chocolate;
            this.lblGiris.Location = new System.Drawing.Point(280, 95);
            this.lblGiris.Name = "lblGiris";
            this.lblGiris.Size = new System.Drawing.Size(194, 70);
            this.lblGiris.TabIndex = 3;
            this.lblGiris.Text = "GİRİŞ";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdi.ForeColor = System.Drawing.Color.Gray;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(76, 228);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(174, 39);
            this.lblKullaniciAdi.TabIndex = 4;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(76, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Şifre";
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(750, 529);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.lblGiris);
            this.Controls.Add(this.btnGiriş);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Name = "frmGiris";
            this.Text = "Giriş Sayfası";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnGiriş;
        private System.Windows.Forms.Label lblGiris;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label label1;
    }
}


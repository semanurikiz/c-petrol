namespace Petrol
{
    partial class frmYöneticiEkrani
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
            this.grpSubePersonel = new System.Windows.Forms.GroupBox();
            this.lblSubeİsmi = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.lstYetki = new System.Windows.Forms.ListBox();
            this.lstPersonel = new System.Windows.Forms.ListBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtSubeİsmi = new System.Windows.Forms.TextBox();
            this.grpPersonelEkleme = new System.Windows.Forms.GroupBox();
            this.txtAdKullanici = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblSifreİki = new System.Windows.Forms.Label();
            this.txtSube = new System.Windows.Forms.TextBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblSube = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.lblAdKullanici = new System.Windows.Forms.Label();
            this.cmbYetki = new System.Windows.Forms.ComboBox();
            this.txtSifreİki = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblYetki = new System.Windows.Forms.Label();
            this.grpPersonelSayisi = new System.Windows.Forms.GroupBox();
            this.btnYukle = new System.Windows.Forms.Button();
            this.lstPersonelSayisi = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnYükleİki = new System.Windows.Forms.Button();
            this.lstYakitMiktar = new System.Windows.Forms.ListBox();
            this.lblGünYakitMiktar = new System.Windows.Forms.Label();
            this.lblAnaDepo = new System.Windows.Forms.Label();
            this.lstAnaDepo = new System.Windows.Forms.ListBox();
            this.txtGönYakit = new System.Windows.Forms.TextBox();
            this.lblGönYakit = new System.Windows.Forms.Label();
            this.lblİsimSube = new System.Windows.Forms.Label();
            this.txtİsimSube = new System.Windows.Forms.TextBox();
            this.grpSubePersonel.SuspendLayout();
            this.grpPersonelEkleme.SuspendLayout();
            this.grpPersonelSayisi.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSubePersonel
            // 
            this.grpSubePersonel.Controls.Add(this.lblSubeİsmi);
            this.grpSubePersonel.Controls.Add(this.btnSil);
            this.grpSubePersonel.Controls.Add(this.lstYetki);
            this.grpSubePersonel.Controls.Add(this.lstPersonel);
            this.grpSubePersonel.Controls.Add(this.btnAra);
            this.grpSubePersonel.Controls.Add(this.txtSubeİsmi);
            this.grpSubePersonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpSubePersonel.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grpSubePersonel.Location = new System.Drawing.Point(12, 291);
            this.grpSubePersonel.Name = "grpSubePersonel";
            this.grpSubePersonel.Size = new System.Drawing.Size(603, 433);
            this.grpSubePersonel.TabIndex = 0;
            this.grpSubePersonel.TabStop = false;
            this.grpSubePersonel.Text = "ŞUBE PERSONELLERİ";
            // 
            // lblSubeİsmi
            // 
            this.lblSubeİsmi.AutoSize = true;
            this.lblSubeİsmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSubeİsmi.Location = new System.Drawing.Point(7, 30);
            this.lblSubeİsmi.Name = "lblSubeİsmi";
            this.lblSubeİsmi.Size = new System.Drawing.Size(102, 20);
            this.lblSubeİsmi.TabIndex = 5;
            this.lblSubeİsmi.Text = "ŞUBE İSMİ";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Black;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(481, 20);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(102, 38);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lstYetki
            // 
            this.lstYetki.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lstYetki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstYetki.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lstYetki.FormattingEnabled = true;
            this.lstYetki.ItemHeight = 25;
            this.lstYetki.Location = new System.Drawing.Point(389, 71);
            this.lstYetki.Name = "lstYetki";
            this.lstYetki.Size = new System.Drawing.Size(208, 354);
            this.lstYetki.TabIndex = 3;
            // 
            // lstPersonel
            // 
            this.lstPersonel.BackColor = System.Drawing.Color.Black;
            this.lstPersonel.ForeColor = System.Drawing.Color.White;
            this.lstPersonel.ItemHeight = 20;
            this.lstPersonel.Location = new System.Drawing.Point(6, 71);
            this.lstPersonel.Name = "lstPersonel";
            this.lstPersonel.Size = new System.Drawing.Size(368, 344);
            this.lstPersonel.TabIndex = 6;
            this.lstPersonel.SelectedIndexChanged += new System.EventHandler(this.lstPersonel_SelectedIndexChanged);
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.Black;
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.ForeColor = System.Drawing.Color.White;
            this.btnAra.Location = new System.Drawing.Point(348, 20);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(97, 36);
            this.btnAra.TabIndex = 1;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtSubeİsmi
            // 
            this.txtSubeİsmi.BackColor = System.Drawing.Color.Black;
            this.txtSubeİsmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSubeİsmi.ForeColor = System.Drawing.Color.White;
            this.txtSubeİsmi.Location = new System.Drawing.Point(126, 27);
            this.txtSubeİsmi.Name = "txtSubeİsmi";
            this.txtSubeİsmi.Size = new System.Drawing.Size(193, 27);
            this.txtSubeİsmi.TabIndex = 0;
            // 
            // grpPersonelEkleme
            // 
            this.grpPersonelEkleme.Controls.Add(this.txtAdKullanici);
            this.grpPersonelEkleme.Controls.Add(this.txtAd);
            this.grpPersonelEkleme.Controls.Add(this.lblSifreİki);
            this.grpPersonelEkleme.Controls.Add(this.txtSube);
            this.grpPersonelEkleme.Controls.Add(this.lblSoyad);
            this.grpPersonelEkleme.Controls.Add(this.lblSube);
            this.grpPersonelEkleme.Controls.Add(this.txtSoyad);
            this.grpPersonelEkleme.Controls.Add(this.lblAdKullanici);
            this.grpPersonelEkleme.Controls.Add(this.cmbYetki);
            this.grpPersonelEkleme.Controls.Add(this.txtSifreİki);
            this.grpPersonelEkleme.Controls.Add(this.lblAd);
            this.grpPersonelEkleme.Controls.Add(this.btnEkle);
            this.grpPersonelEkleme.Controls.Add(this.lblYetki);
            this.grpPersonelEkleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpPersonelEkleme.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grpPersonelEkleme.Location = new System.Drawing.Point(12, 12);
            this.grpPersonelEkleme.Name = "grpPersonelEkleme";
            this.grpPersonelEkleme.Size = new System.Drawing.Size(603, 273);
            this.grpPersonelEkleme.TabIndex = 1;
            this.grpPersonelEkleme.TabStop = false;
            this.grpPersonelEkleme.Text = "PERSONEL EKLEME";
            // 
            // txtAdKullanici
            // 
            this.txtAdKullanici.BackColor = System.Drawing.Color.Black;
            this.txtAdKullanici.ForeColor = System.Drawing.Color.White;
            this.txtAdKullanici.Location = new System.Drawing.Point(251, 224);
            this.txtAdKullanici.Name = "txtAdKullanici";
            this.txtAdKullanici.Size = new System.Drawing.Size(152, 27);
            this.txtAdKullanici.TabIndex = 11;
            // 
            // txtAd
            // 
            this.txtAd.BackColor = System.Drawing.Color.Black;
            this.txtAd.ForeColor = System.Drawing.Color.White;
            this.txtAd.Location = new System.Drawing.Point(23, 70);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(161, 27);
            this.txtAd.TabIndex = 0;
            // 
            // lblSifreİki
            // 
            this.lblSifreİki.AutoSize = true;
            this.lblSifreİki.Location = new System.Drawing.Point(247, 113);
            this.lblSifreİki.Name = "lblSifreİki";
            this.lblSifreİki.Size = new System.Drawing.Size(62, 20);
            this.lblSifreİki.TabIndex = 8;
            this.lblSifreİki.Text = "SİFRE";
            // 
            // txtSube
            // 
            this.txtSube.BackColor = System.Drawing.Color.Black;
            this.txtSube.ForeColor = System.Drawing.Color.White;
            this.txtSube.Location = new System.Drawing.Point(22, 224);
            this.txtSube.Name = "txtSube";
            this.txtSube.Size = new System.Drawing.Size(162, 27);
            this.txtSube.TabIndex = 5;
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblSoyad.Location = new System.Drawing.Point(247, 43);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(72, 20);
            this.lblSoyad.TabIndex = 3;
            this.lblSoyad.Text = "SOYAD";
            // 
            // lblSube
            // 
            this.lblSube.AutoSize = true;
            this.lblSube.Location = new System.Drawing.Point(64, 189);
            this.lblSube.Name = "lblSube";
            this.lblSube.Size = new System.Drawing.Size(59, 20);
            this.lblSube.TabIndex = 6;
            this.lblSube.Text = "ŞUBE";
            // 
            // txtSoyad
            // 
            this.txtSoyad.BackColor = System.Drawing.Color.Black;
            this.txtSoyad.ForeColor = System.Drawing.Color.White;
            this.txtSoyad.Location = new System.Drawing.Point(250, 70);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(153, 27);
            this.txtSoyad.TabIndex = 1;
            // 
            // lblAdKullanici
            // 
            this.lblAdKullanici.AutoSize = true;
            this.lblAdKullanici.Location = new System.Drawing.Point(247, 189);
            this.lblAdKullanici.Name = "lblAdKullanici";
            this.lblAdKullanici.Size = new System.Drawing.Size(141, 20);
            this.lblAdKullanici.TabIndex = 10;
            this.lblAdKullanici.Text = "KULLANICI ADI";
            // 
            // cmbYetki
            // 
            this.cmbYetki.BackColor = System.Drawing.Color.Black;
            this.cmbYetki.ForeColor = System.Drawing.Color.White;
            this.cmbYetki.FormattingEnabled = true;
            this.cmbYetki.Items.AddRange(new object[] {
            "Pompacı",
            "Şube Müdürü"});
            this.cmbYetki.Location = new System.Drawing.Point(22, 146);
            this.cmbYetki.Name = "cmbYetki";
            this.cmbYetki.Size = new System.Drawing.Size(162, 28);
            this.cmbYetki.TabIndex = 2;
            // 
            // txtSifreİki
            // 
            this.txtSifreİki.BackColor = System.Drawing.Color.Black;
            this.txtSifreİki.ForeColor = System.Drawing.Color.White;
            this.txtSifreİki.Location = new System.Drawing.Point(251, 147);
            this.txtSifreİki.Name = "txtSifreİki";
            this.txtSifreİki.PasswordChar = '*';
            this.txtSifreİki.Size = new System.Drawing.Size(152, 27);
            this.txtSifreİki.TabIndex = 9;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(74, 43);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(35, 20);
            this.lblAd.TabIndex = 2;
            this.lblAd.Text = "AD";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Black;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(461, 113);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(122, 54);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblYetki
            // 
            this.lblYetki.AutoSize = true;
            this.lblYetki.Location = new System.Drawing.Point(64, 113);
            this.lblYetki.Name = "lblYetki";
            this.lblYetki.Size = new System.Drawing.Size(60, 20);
            this.lblYetki.TabIndex = 4;
            this.lblYetki.Text = "YETKİ";
            // 
            // grpPersonelSayisi
            // 
            this.grpPersonelSayisi.Controls.Add(this.btnYukle);
            this.grpPersonelSayisi.Controls.Add(this.lstPersonelSayisi);
            this.grpPersonelSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpPersonelSayisi.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grpPersonelSayisi.Location = new System.Drawing.Point(638, 12);
            this.grpPersonelSayisi.Name = "grpPersonelSayisi";
            this.grpPersonelSayisi.Size = new System.Drawing.Size(297, 479);
            this.grpPersonelSayisi.TabIndex = 2;
            this.grpPersonelSayisi.TabStop = false;
            this.grpPersonelSayisi.Text = "ŞUBE PERSONEL SAYISI";
            // 
            // btnYukle
            // 
            this.btnYukle.BackColor = System.Drawing.Color.Black;
            this.btnYukle.ForeColor = System.Drawing.Color.White;
            this.btnYukle.Location = new System.Drawing.Point(54, 400);
            this.btnYukle.Name = "btnYukle";
            this.btnYukle.Size = new System.Drawing.Size(184, 37);
            this.btnYukle.TabIndex = 1;
            this.btnYukle.Text = "Yükle";
            this.btnYukle.UseVisualStyleBackColor = false;
            this.btnYukle.Click += new System.EventHandler(this.btnYukle_Click);
            // 
            // lstPersonelSayisi
            // 
            this.lstPersonelSayisi.BackColor = System.Drawing.Color.Black;
            this.lstPersonelSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstPersonelSayisi.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lstPersonelSayisi.FormattingEnabled = true;
            this.lstPersonelSayisi.ItemHeight = 25;
            this.lstPersonelSayisi.Location = new System.Drawing.Point(28, 46);
            this.lstPersonelSayisi.Name = "lstPersonelSayisi";
            this.lstPersonelSayisi.Size = new System.Drawing.Size(251, 329);
            this.lstPersonelSayisi.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnYükleİki);
            this.groupBox4.Controls.Add(this.lstYakitMiktar);
            this.groupBox4.Controls.Add(this.lblGünYakitMiktar);
            this.groupBox4.Controls.Add(this.lblAnaDepo);
            this.groupBox4.Controls.Add(this.lstAnaDepo);
            this.groupBox4.Controls.Add(this.txtGönYakit);
            this.groupBox4.Controls.Add(this.lblGönYakit);
            this.groupBox4.Controls.Add(this.lblİsimSube);
            this.groupBox4.Controls.Add(this.txtİsimSube);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox4.Location = new System.Drawing.Point(941, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(315, 588);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "DEPO MİKTARI";
            // 
            // btnYükleİki
            // 
            this.btnYükleİki.BackColor = System.Drawing.Color.Black;
            this.btnYükleİki.ForeColor = System.Drawing.Color.White;
            this.btnYükleİki.Location = new System.Drawing.Point(40, 484);
            this.btnYükleİki.Name = "btnYükleİki";
            this.btnYükleİki.Size = new System.Drawing.Size(211, 70);
            this.btnYükleİki.TabIndex = 2;
            this.btnYükleİki.Text = "YÜKLE";
            this.btnYükleİki.UseVisualStyleBackColor = false;
            this.btnYükleİki.Click += new System.EventHandler(this.btnYukleİki_Click);
            // 
            // lstYakitMiktar
            // 
            this.lstYakitMiktar.BackColor = System.Drawing.Color.Black;
            this.lstYakitMiktar.ForeColor = System.Drawing.Color.White;
            this.lstYakitMiktar.FormattingEnabled = true;
            this.lstYakitMiktar.ItemHeight = 25;
            this.lstYakitMiktar.Location = new System.Drawing.Point(40, 400);
            this.lstYakitMiktar.Name = "lstYakitMiktar";
            this.lstYakitMiktar.Size = new System.Drawing.Size(211, 54);
            this.lstYakitMiktar.TabIndex = 7;
            // 
            // lblGünYakitMiktar
            // 
            this.lblGünYakitMiktar.AutoSize = true;
            this.lblGünYakitMiktar.Location = new System.Drawing.Point(6, 350);
            this.lblGünYakitMiktar.Name = "lblGünYakitMiktar";
            this.lblGünYakitMiktar.Size = new System.Drawing.Size(290, 25);
            this.lblGünYakitMiktar.TabIndex = 6;
            this.lblGünYakitMiktar.Text = "Şubenin Güncel Yakıt Miktarı";
            // 
            // lblAnaDepo
            // 
            this.lblAnaDepo.AutoSize = true;
            this.lblAnaDepo.Location = new System.Drawing.Point(37, 233);
            this.lblAnaDepo.Name = "lblAnaDepo";
            this.lblAnaDepo.Size = new System.Drawing.Size(108, 25);
            this.lblAnaDepo.TabIndex = 5;
            this.lblAnaDepo.Text = "Ana Depo";
            // 
            // lstAnaDepo
            // 
            this.lstAnaDepo.BackColor = System.Drawing.Color.Black;
            this.lstAnaDepo.ForeColor = System.Drawing.Color.White;
            this.lstAnaDepo.FormattingEnabled = true;
            this.lstAnaDepo.ItemHeight = 25;
            this.lstAnaDepo.Location = new System.Drawing.Point(40, 272);
            this.lstAnaDepo.Name = "lstAnaDepo";
            this.lstAnaDepo.Size = new System.Drawing.Size(211, 54);
            this.lstAnaDepo.TabIndex = 4;
            // 
            // txtGönYakit
            // 
            this.txtGönYakit.BackColor = System.Drawing.Color.Black;
            this.txtGönYakit.ForeColor = System.Drawing.Color.White;
            this.txtGönYakit.Location = new System.Drawing.Point(40, 192);
            this.txtGönYakit.Name = "txtGönYakit";
            this.txtGönYakit.Size = new System.Drawing.Size(211, 30);
            this.txtGönYakit.TabIndex = 3;
            // 
            // lblGönYakit
            // 
            this.lblGönYakit.AutoSize = true;
            this.lblGönYakit.Location = new System.Drawing.Point(37, 147);
            this.lblGönYakit.Name = "lblGönYakit";
            this.lblGönYakit.Size = new System.Drawing.Size(193, 25);
            this.lblGönYakit.TabIndex = 2;
            this.lblGönYakit.Text = "Gönderilecek Yakıt";
            // 
            // lblİsimSube
            // 
            this.lblİsimSube.AutoSize = true;
            this.lblİsimSube.Location = new System.Drawing.Point(39, 65);
            this.lblİsimSube.Name = "lblİsimSube";
            this.lblİsimSube.Size = new System.Drawing.Size(108, 25);
            this.lblİsimSube.TabIndex = 1;
            this.lblİsimSube.Text = "Şube İsmi";
            // 
            // txtİsimSube
            // 
            this.txtİsimSube.BackColor = System.Drawing.Color.Black;
            this.txtİsimSube.ForeColor = System.Drawing.Color.White;
            this.txtİsimSube.Location = new System.Drawing.Point(40, 102);
            this.txtİsimSube.Name = "txtİsimSube";
            this.txtİsimSube.Size = new System.Drawing.Size(211, 30);
            this.txtİsimSube.TabIndex = 0;
            // 
            // frmYöneticiEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1268, 736);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.grpPersonelSayisi);
            this.Controls.Add(this.grpPersonelEkleme);
            this.Controls.Add(this.grpSubePersonel);
            this.Name = "frmYöneticiEkrani";
            this.Text = "Yönetici Ekranı";
            this.grpSubePersonel.ResumeLayout(false);
            this.grpSubePersonel.PerformLayout();
            this.grpPersonelEkleme.ResumeLayout(false);
            this.grpPersonelEkleme.PerformLayout();
            this.grpPersonelSayisi.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSubePersonel;
        private System.Windows.Forms.ListBox lstPersonel;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtSubeİsmi;
        private System.Windows.Forms.ListBox lstYetki;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.GroupBox grpPersonelEkleme;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.ComboBox cmbYetki;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblYetki;
        private System.Windows.Forms.TextBox txtSube;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblSube;
        private System.Windows.Forms.Label lblSifreİki;
        private System.Windows.Forms.TextBox txtAdKullanici;
        private System.Windows.Forms.Label lblAdKullanici;
        private System.Windows.Forms.TextBox txtSifreİki;
        private System.Windows.Forms.GroupBox grpPersonelSayisi;
        private System.Windows.Forms.Button btnYukle;
        private System.Windows.Forms.ListBox lstPersonelSayisi;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblGünYakitMiktar;
        private System.Windows.Forms.Label lblAnaDepo;
        private System.Windows.Forms.ListBox lstAnaDepo;
        private System.Windows.Forms.TextBox txtGönYakit;
        private System.Windows.Forms.Label lblGönYakit;
        private System.Windows.Forms.Label lblİsimSube;
        private System.Windows.Forms.TextBox txtİsimSube;
        private System.Windows.Forms.Button btnYükleİki;
        private System.Windows.Forms.ListBox lstYakitMiktar;
        private System.Windows.Forms.Label lblSubeİsmi;
    }
}
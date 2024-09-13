namespace MailGonder
{
    partial class Form1
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
            lblGondericiMail = new Label();
            GondericiMail = new TextBox();
            lblGondericiSifre = new Label();
            GondericiSifre = new TextBox();
            lblAliciMail = new Label();
            AliciMail = new TextBox();
            Mesaj = new RichTextBox();
            lblMesaj = new Label();
            lblKonu = new Label();
            Konu = new TextBox();
            btnGonder = new Button();
            openFileDialog1 = new OpenFileDialog();
            btnDosya = new Button();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            Unvan = new TextBox();
            lblAdSoyad = new Label();
            AdSoyad = new TextBox();
            label4 = new Label();
            lblFirmaAd = new Label();
            FirmaAd = new TextBox();
            lblMailAdres = new Label();
            MailAdres = new TextBox();
            lblCepTelefon = new Label();
            CepTelefon = new TextBox();
            lblLinkedin = new Label();
            Linkedin = new TextBox();
            lblGithub = new Label();
            Github = new TextBox();
            btnLogo = new Button();
            Dosya = new ListBox();
            lblDosya = new Label();
            SuspendLayout();
            // 
            // lblGondericiMail
            // 
            lblGondericiMail.AutoSize = true;
            lblGondericiMail.Location = new Point(12, 36);
            lblGondericiMail.Name = "lblGondericiMail";
            lblGondericiMail.Size = new Size(120, 15);
            lblGondericiMail.TabIndex = 0;
            lblGondericiMail.Text = "Gönderici Mail Adresi";
            // 
            // GondericiMail
            // 
            GondericiMail.Location = new Point(14, 54);
            GondericiMail.Name = "GondericiMail";
            GondericiMail.Size = new Size(602, 23);
            GondericiMail.TabIndex = 1;
            // 
            // lblGondericiSifre
            // 
            lblGondericiSifre.AutoSize = true;
            lblGondericiSifre.Location = new Point(12, 85);
            lblGondericiSifre.Name = "lblGondericiSifre";
            lblGondericiSifre.Size = new Size(84, 15);
            lblGondericiSifre.TabIndex = 0;
            lblGondericiSifre.Text = "Gönderici Şifre";
            // 
            // GondericiSifre
            // 
            GondericiSifre.Location = new Point(14, 103);
            GondericiSifre.Name = "GondericiSifre";
            GondericiSifre.Size = new Size(142, 23);
            GondericiSifre.TabIndex = 2;
            // 
            // lblAliciMail
            // 
            lblAliciMail.AutoSize = true;
            lblAliciMail.Location = new Point(12, 168);
            lblAliciMail.Name = "lblAliciMail";
            lblAliciMail.Size = new Size(92, 15);
            lblAliciMail.TabIndex = 0;
            lblAliciMail.Text = "Alıcı Mail Adresi";
            // 
            // AliciMail
            // 
            AliciMail.Location = new Point(14, 186);
            AliciMail.Name = "AliciMail";
            AliciMail.Size = new Size(602, 23);
            AliciMail.TabIndex = 3;
            // 
            // Mesaj
            // 
            Mesaj.Location = new Point(14, 274);
            Mesaj.Name = "Mesaj";
            Mesaj.Size = new Size(602, 72);
            Mesaj.TabIndex = 7;
            Mesaj.Text = "";
            // 
            // lblMesaj
            // 
            lblMesaj.AutoSize = true;
            lblMesaj.Location = new Point(12, 256);
            lblMesaj.Name = "lblMesaj";
            lblMesaj.Size = new Size(38, 15);
            lblMesaj.TabIndex = 0;
            lblMesaj.Text = "Mesaj";
            // 
            // lblKonu
            // 
            lblKonu.AutoSize = true;
            lblKonu.Location = new Point(12, 212);
            lblKonu.Name = "lblKonu";
            lblKonu.Size = new Size(35, 15);
            lblKonu.TabIndex = 0;
            lblKonu.Text = "Konu";
            // 
            // Konu
            // 
            Konu.Location = new Point(14, 230);
            Konu.Name = "Konu";
            Konu.Size = new Size(602, 23);
            Konu.TabIndex = 4;
            // 
            // btnGonder
            // 
            btnGonder.Location = new Point(280, 669);
            btnGonder.Name = "btnGonder";
            btnGonder.Size = new Size(75, 23);
            btnGonder.TabIndex = 16;
            btnGonder.Text = "Gönder";
            btnGonder.UseVisualStyleBackColor = true;
            btnGonder.Click += btnGonder_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnDosya
            // 
            btnDosya.Location = new Point(14, 136);
            btnDosya.Name = "btnDosya";
            btnDosya.Size = new Size(163, 23);
            btnDosya.TabIndex = 5;
            btnDosya.Text = "Dosya Seç";
            btnDosya.UseVisualStyleBackColor = true;
            btnDosya.Click += btnDosya_Click;
            // 
            // button1
            // 
            button1.Location = new Point(160, 103);
            button1.Name = "button1";
            button1.Size = new Size(17, 23);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnGizle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(214, 9);
            label1.Name = "label1";
            label1.Size = new Size(223, 21);
            label1.TabIndex = 4;
            label1.Text = "Mail Gönderme Uygulaması";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 431);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 0;
            label2.Text = "Ünvanı";
            // 
            // Unvan
            // 
            Unvan.Location = new Point(14, 450);
            Unvan.Name = "Unvan";
            Unvan.Size = new Size(602, 23);
            Unvan.TabIndex = 9;
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Location = new Point(12, 387);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(63, 15);
            lblAdSoyad.TabIndex = 0;
            lblAdSoyad.Text = "Adı Soyadı";
            // 
            // AdSoyad
            // 
            AdSoyad.Location = new Point(14, 405);
            AdSoyad.Name = "AdSoyad";
            AdSoyad.Size = new Size(352, 23);
            AdSoyad.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(266, 360);
            label4.Name = "label4";
            label4.Size = new Size(89, 17);
            label4.TabIndex = 4;
            label4.Text = "İmza Bilgileri";
            // 
            // lblFirmaAd
            // 
            lblFirmaAd.AutoSize = true;
            lblFirmaAd.Location = new Point(12, 520);
            lblFirmaAd.Name = "lblFirmaAd";
            lblFirmaAd.Size = new Size(58, 15);
            lblFirmaAd.TabIndex = 0;
            lblFirmaAd.Text = "Firma Adı";
            // 
            // FirmaAd
            // 
            FirmaAd.Location = new Point(14, 538);
            FirmaAd.Name = "FirmaAd";
            FirmaAd.Size = new Size(602, 23);
            FirmaAd.TabIndex = 10;
            // 
            // lblMailAdres
            // 
            lblMailAdres.AutoSize = true;
            lblMailAdres.Location = new Point(12, 476);
            lblMailAdres.Name = "lblMailAdres";
            lblMailAdres.Size = new Size(66, 15);
            lblMailAdres.TabIndex = 0;
            lblMailAdres.Text = "Mail Adresi";
            // 
            // MailAdres
            // 
            MailAdres.Location = new Point(14, 494);
            MailAdres.Name = "MailAdres";
            MailAdres.Size = new Size(602, 23);
            MailAdres.TabIndex = 12;
            // 
            // lblCepTelefon
            // 
            lblCepTelefon.AutoSize = true;
            lblCepTelefon.Location = new Point(369, 387);
            lblCepTelefon.Name = "lblCepTelefon";
            lblCepTelefon.Size = new Size(76, 15);
            lblCepTelefon.TabIndex = 0;
            lblCepTelefon.Text = "Cep Telefonu";
            // 
            // CepTelefon
            // 
            CepTelefon.Location = new Point(372, 405);
            CepTelefon.Name = "CepTelefon";
            CepTelefon.Size = new Size(163, 23);
            CepTelefon.TabIndex = 11;
            // 
            // lblLinkedin
            // 
            lblLinkedin.AutoSize = true;
            lblLinkedin.Location = new Point(11, 608);
            lblLinkedin.Name = "lblLinkedin";
            lblLinkedin.Size = new Size(52, 15);
            lblLinkedin.TabIndex = 0;
            lblLinkedin.Text = "Linkedin";
            // 
            // Linkedin
            // 
            Linkedin.Location = new Point(14, 626);
            Linkedin.Name = "Linkedin";
            Linkedin.Size = new Size(602, 23);
            Linkedin.TabIndex = 15;
            // 
            // lblGithub
            // 
            lblGithub.AutoSize = true;
            lblGithub.Location = new Point(9, 564);
            lblGithub.Name = "lblGithub";
            lblGithub.Size = new Size(43, 15);
            lblGithub.TabIndex = 0;
            lblGithub.Text = "Github";
            // 
            // Github
            // 
            Github.Location = new Point(14, 582);
            Github.Name = "Github";
            Github.Size = new Size(602, 23);
            Github.TabIndex = 14;
            // 
            // btnLogo
            // 
            btnLogo.Location = new Point(541, 404);
            btnLogo.Name = "btnLogo";
            btnLogo.Size = new Size(75, 23);
            btnLogo.TabIndex = 5;
            btnLogo.Text = "Logo Seç";
            btnLogo.UseVisualStyleBackColor = true;
            btnLogo.Click += btnLogo_Click;
            // 
            // Dosya
            // 
            Dosya.FormattingEnabled = true;
            Dosya.ItemHeight = 15;
            Dosya.Location = new Point(183, 98);
            Dosya.Name = "Dosya";
            Dosya.Size = new Size(433, 79);
            Dosya.TabIndex = 17;
            // 
            // lblDosya
            // 
            lblDosya.AutoSize = true;
            lblDosya.Location = new Point(181, 80);
            lblDosya.Name = "lblDosya";
            lblDosya.Size = new Size(52, 15);
            lblDosya.TabIndex = 0;
            lblDosya.Text = "Dosyalar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 709);
            Controls.Add(Dosya);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(btnLogo);
            Controls.Add(btnDosya);
            Controls.Add(button1);
            Controls.Add(btnGonder);
            Controls.Add(Mesaj);
            Controls.Add(AliciMail);
            Controls.Add(lblMesaj);
            Controls.Add(lblAliciMail);
            Controls.Add(GondericiSifre);
            Controls.Add(lblDosya);
            Controls.Add(lblGondericiSifre);
            Controls.Add(Konu);
            Controls.Add(lblKonu);
            Controls.Add(Github);
            Controls.Add(CepTelefon);
            Controls.Add(lblGithub);
            Controls.Add(lblCepTelefon);
            Controls.Add(AdSoyad);
            Controls.Add(lblAdSoyad);
            Controls.Add(FirmaAd);
            Controls.Add(Linkedin);
            Controls.Add(MailAdres);
            Controls.Add(lblLinkedin);
            Controls.Add(lblFirmaAd);
            Controls.Add(lblMailAdres);
            Controls.Add(Unvan);
            Controls.Add(label2);
            Controls.Add(GondericiMail);
            Controls.Add(lblGondericiMail);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mail Gönderme Uygulaması";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGondericiMail;
        private TextBox GondericiMail;
        private Label lblGondericiSifre;
        private TextBox GondericiSifre;
        private Label lblAliciMail;
        private TextBox AliciMail;
        private RichTextBox Mesaj;
        private Label lblMesaj;
        private Label lblKonu;
        private TextBox Konu;
        private Button btnGonder;
        private OpenFileDialog openFileDialog1;
        private Button btnDosya;
        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox Unvan;
        private Label lblAdSoyad;
        private TextBox AdSoyad;
        private Label label4;
        private Label lblFirmaAd;
        private TextBox FirmaAd;
        private Label lblMailAdres;
        private TextBox MailAdres;
        private Label lblCepTelefon;
        private TextBox CepTelefon;
        private Label lblLinkedin;
        private TextBox Linkedin;
        private Label lblGithub;
        private TextBox Github;
        private Button btnLogo;
        private ListBox Dosya;
        private Label lblDosya;
    }
}

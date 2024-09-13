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
            txtGondericiMail = new TextBox();
            lblGondericiSifre = new Label();
            txtGondericiSifre = new TextBox();
            lblAliciMail = new Label();
            txtAliciMail = new TextBox();
            txtMesaj = new RichTextBox();
            lblMesaj = new Label();
            lblKonu = new Label();
            txtKonu = new TextBox();
            btnGonder = new Button();
            openFileDialog1 = new OpenFileDialog();
            btnDosya = new Button();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            txtUnvan = new TextBox();
            lblAdSoyad = new Label();
            txtAdSoyad = new TextBox();
            label4 = new Label();
            lblFirmaAd = new Label();
            txtFirmaAd = new TextBox();
            lblMailAdres = new Label();
            txtMailAdres = new TextBox();
            lblCepTelefon = new Label();
            txtCepTelefon = new TextBox();
            lblLinkedin = new Label();
            txtLinkedin = new TextBox();
            lblGithub = new Label();
            txtGithub = new TextBox();
            btnLogo = new Button();
            lstDosya = new ListBox();
            SuspendLayout();
            // 
            // lblGondericiMail
            // 
            lblGondericiMail.AutoSize = true;
            lblGondericiMail.Location = new Point(14, 36);
            lblGondericiMail.Name = "lblGondericiMail";
            lblGondericiMail.Size = new Size(120, 15);
            lblGondericiMail.TabIndex = 0;
            lblGondericiMail.Text = "Gönderici Mail Adresi";
            // 
            // txtGondericiMail
            // 
            txtGondericiMail.Location = new Point(14, 54);
            txtGondericiMail.Name = "txtGondericiMail";
            txtGondericiMail.Size = new Size(602, 23);
            txtGondericiMail.TabIndex = 1;
            // 
            // lblGondericiSifre
            // 
            lblGondericiSifre.AutoSize = true;
            lblGondericiSifre.Location = new Point(14, 85);
            lblGondericiSifre.Name = "lblGondericiSifre";
            lblGondericiSifre.Size = new Size(84, 15);
            lblGondericiSifre.TabIndex = 0;
            lblGondericiSifre.Text = "Gönderici Şifre";
            // 
            // txtGondericiSifre
            // 
            txtGondericiSifre.Location = new Point(14, 103);
            txtGondericiSifre.Name = "txtGondericiSifre";
            txtGondericiSifre.Size = new Size(142, 23);
            txtGondericiSifre.TabIndex = 2;
            // 
            // lblAliciMail
            // 
            lblAliciMail.AutoSize = true;
            lblAliciMail.Location = new Point(14, 168);
            lblAliciMail.Name = "lblAliciMail";
            lblAliciMail.Size = new Size(92, 15);
            lblAliciMail.TabIndex = 0;
            lblAliciMail.Text = "Alıcı Mail Adresi";
            // 
            // txtAliciMail
            // 
            txtAliciMail.Location = new Point(14, 186);
            txtAliciMail.Name = "txtAliciMail";
            txtAliciMail.Size = new Size(602, 23);
            txtAliciMail.TabIndex = 3;
            // 
            // txtMesaj
            // 
            txtMesaj.Location = new Point(14, 274);
            txtMesaj.Name = "txtMesaj";
            txtMesaj.Size = new Size(602, 72);
            txtMesaj.TabIndex = 7;
            txtMesaj.Text = "";
            // 
            // lblMesaj
            // 
            lblMesaj.AutoSize = true;
            lblMesaj.Location = new Point(14, 256);
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
            // txtKonu
            // 
            txtKonu.Location = new Point(14, 230);
            txtKonu.Name = "txtKonu";
            txtKonu.Size = new Size(602, 23);
            txtKonu.TabIndex = 4;
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
            // txtUnvan
            // 
            txtUnvan.Location = new Point(11, 450);
            txtUnvan.Name = "txtUnvan";
            txtUnvan.Size = new Size(605, 23);
            txtUnvan.TabIndex = 9;
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
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(14, 405);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(352, 23);
            txtAdSoyad.TabIndex = 8;
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
            // txtFirmaAd
            // 
            txtFirmaAd.Location = new Point(14, 538);
            txtFirmaAd.Name = "txtFirmaAd";
            txtFirmaAd.Size = new Size(602, 23);
            txtFirmaAd.TabIndex = 10;
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
            // txtMailAdres
            // 
            txtMailAdres.Location = new Point(14, 494);
            txtMailAdres.Name = "txtMailAdres";
            txtMailAdres.Size = new Size(602, 23);
            txtMailAdres.TabIndex = 12;
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
            // txtCepTelefon
            // 
            txtCepTelefon.Location = new Point(372, 405);
            txtCepTelefon.Name = "txtCepTelefon";
            txtCepTelefon.Size = new Size(163, 23);
            txtCepTelefon.TabIndex = 11;
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
            // txtLinkedin
            // 
            txtLinkedin.Location = new Point(14, 626);
            txtLinkedin.Name = "txtLinkedin";
            txtLinkedin.Size = new Size(602, 23);
            txtLinkedin.TabIndex = 15;
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
            // txtGithub
            // 
            txtGithub.Location = new Point(14, 582);
            txtGithub.Name = "txtGithub";
            txtGithub.Size = new Size(602, 23);
            txtGithub.TabIndex = 14;
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
            // lstDosya
            // 
            lstDosya.FormattingEnabled = true;
            lstDosya.ItemHeight = 15;
            lstDosya.Location = new Point(183, 83);
            lstDosya.Name = "lstDosya";
            lstDosya.Size = new Size(433, 94);
            lstDosya.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 709);
            Controls.Add(lstDosya);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(btnLogo);
            Controls.Add(btnDosya);
            Controls.Add(button1);
            Controls.Add(btnGonder);
            Controls.Add(txtMesaj);
            Controls.Add(txtAliciMail);
            Controls.Add(lblMesaj);
            Controls.Add(lblAliciMail);
            Controls.Add(txtGondericiSifre);
            Controls.Add(lblGondericiSifre);
            Controls.Add(txtKonu);
            Controls.Add(lblKonu);
            Controls.Add(txtGithub);
            Controls.Add(txtCepTelefon);
            Controls.Add(lblGithub);
            Controls.Add(lblCepTelefon);
            Controls.Add(txtAdSoyad);
            Controls.Add(lblAdSoyad);
            Controls.Add(txtFirmaAd);
            Controls.Add(txtLinkedin);
            Controls.Add(txtMailAdres);
            Controls.Add(lblLinkedin);
            Controls.Add(lblFirmaAd);
            Controls.Add(lblMailAdres);
            Controls.Add(txtUnvan);
            Controls.Add(label2);
            Controls.Add(txtGondericiMail);
            Controls.Add(lblGondericiMail);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGondericiMail;
        private TextBox txtGondericiMail;
        private Label lblGondericiSifre;
        private TextBox txtGondericiSifre;
        private Label lblAliciMail;
        private TextBox txtAliciMail;
        private RichTextBox txtMesaj;
        private Label lblMesaj;
        private Label lblKonu;
        private TextBox txtKonu;
        private Button btnGonder;
        private OpenFileDialog openFileDialog1;
        private Button btnDosya;
        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox txtUnvan;
        private Label lblAdSoyad;
        private TextBox txtAdSoyad;
        private Label label4;
        private Label lblFirmaAd;
        private TextBox txtFirmaAd;
        private Label lblMailAdres;
        private TextBox txtMailAdres;
        private Label lblCepTelefon;
        private TextBox txtCepTelefon;
        private Label lblLinkedin;
        private TextBox txtLinkedin;
        private Label lblGithub;
        private TextBox txtGithub;
        private Button btnLogo;
        private ListBox lstDosya;
    }
}

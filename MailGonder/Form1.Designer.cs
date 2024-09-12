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
            txtDosya = new TextBox();
            button1 = new Button();
            label1 = new Label();
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
            // txtGondericiMail
            // 
            txtGondericiMail.Location = new Point(14, 54);
            txtGondericiMail.Name = "txtGondericiMail";
            txtGondericiMail.Size = new Size(142, 23);
            txtGondericiMail.TabIndex = 1;
            // 
            // lblGondericiSifre
            // 
            lblGondericiSifre.AutoSize = true;
            lblGondericiSifre.Location = new Point(12, 81);
            lblGondericiSifre.Name = "lblGondericiSifre";
            lblGondericiSifre.Size = new Size(84, 15);
            lblGondericiSifre.TabIndex = 0;
            lblGondericiSifre.Text = "Gönderici Şifre";
            // 
            // txtGondericiSifre
            // 
            txtGondericiSifre.Location = new Point(14, 99);
            txtGondericiSifre.Name = "txtGondericiSifre";
            txtGondericiSifre.Size = new Size(142, 23);
            txtGondericiSifre.TabIndex = 1;
            // 
            // lblAliciMail
            // 
            lblAliciMail.AutoSize = true;
            lblAliciMail.Location = new Point(12, 130);
            lblAliciMail.Name = "lblAliciMail";
            lblAliciMail.Size = new Size(92, 15);
            lblAliciMail.TabIndex = 0;
            lblAliciMail.Text = "Alıcı Mail Adresi";
            // 
            // txtAliciMail
            // 
            txtAliciMail.Location = new Point(14, 148);
            txtAliciMail.Name = "txtAliciMail";
            txtAliciMail.Size = new Size(142, 23);
            txtAliciMail.TabIndex = 1;
            // 
            // txtMesaj
            // 
            txtMesaj.Location = new Point(195, 99);
            txtMesaj.Name = "txtMesaj";
            txtMesaj.Size = new Size(338, 72);
            txtMesaj.TabIndex = 2;
            txtMesaj.Text = "";
            // 
            // lblMesaj
            // 
            lblMesaj.AutoSize = true;
            lblMesaj.Location = new Point(195, 81);
            lblMesaj.Name = "lblMesaj";
            lblMesaj.Size = new Size(38, 15);
            lblMesaj.TabIndex = 0;
            lblMesaj.Text = "Mesaj";
            // 
            // lblKonu
            // 
            lblKonu.AutoSize = true;
            lblKonu.Location = new Point(193, 36);
            lblKonu.Name = "lblKonu";
            lblKonu.Size = new Size(35, 15);
            lblKonu.TabIndex = 0;
            lblKonu.Text = "Konu";
            // 
            // txtKonu
            // 
            txtKonu.Location = new Point(195, 54);
            txtKonu.Name = "txtKonu";
            txtKonu.Size = new Size(100, 23);
            txtKonu.TabIndex = 1;
            // 
            // btnGonder
            // 
            btnGonder.Location = new Point(237, 183);
            btnGonder.Name = "btnGonder";
            btnGonder.Size = new Size(75, 23);
            btnGonder.TabIndex = 3;
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
            btnDosya.Location = new Point(328, 53);
            btnDosya.Name = "btnDosya";
            btnDosya.Size = new Size(75, 23);
            btnDosya.TabIndex = 3;
            btnDosya.Text = "Dosya Seç";
            btnDosya.UseVisualStyleBackColor = true;
            btnDosya.Click += btnDosya_Click;
            // 
            // txtDosya
            // 
            txtDosya.Location = new Point(406, 53);
            txtDosya.Name = "txtDosya";
            txtDosya.Size = new Size(127, 23);
            txtDosya.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(158, 99);
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
            label1.Location = new Point(158, 9);
            label1.Name = "label1";
            label1.Size = new Size(223, 21);
            label1.TabIndex = 4;
            label1.Text = "Mail Gönderme Uygulaması";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 219);
            Controls.Add(label1);
            Controls.Add(btnDosya);
            Controls.Add(button1);
            Controls.Add(btnGonder);
            Controls.Add(txtMesaj);
            Controls.Add(txtAliciMail);
            Controls.Add(lblMesaj);
            Controls.Add(lblAliciMail);
            Controls.Add(txtGondericiSifre);
            Controls.Add(lblGondericiSifre);
            Controls.Add(txtDosya);
            Controls.Add(txtKonu);
            Controls.Add(lblKonu);
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
        private TextBox txtDosya;
        private Button button1;
        private Label label1;
    }
}

using System.Net.Mail;
using System.Net;
using System.Net.Mime;
using System.Net.Http;

namespace MailGonder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            txtGondericiSifre.UseSystemPasswordChar = true;
        }
        public void MesajGonder()
        {
            try
            {
                string gondericiEmail = txtGondericiMail.Text;
                string gondericiSifre = txtGondericiSifre.Text;
                string aliciEmail = txtAliciMail.Text;
                string konu = txtKonu.Text;
                string mesaj = txtMesaj.Text;
                string unvan = txtUnvan.Text;
                string adsoyad = txtAdSoyad.Text;
                string firmaAdi = txtFirmaAd.Text;
                string cepTelefon = txtCepTelefon.Text;
                string mailAdres = txtMailAdres.Text;
                string github = txtGithub.Text;
                string linkedin = txtLinkedin.Text;
                string firmaLogo = txtFirmaLogo.Text;
                SmtpClient smtpClient = new SmtpClient();
                string smtpServer = "";
                int smtpPort = 0;

                if (gondericiEmail.Contains("@gmail.com"))
                {
                    smtpServer = "smtp.gmail.com";
                    smtpPort = 587;
                }
                else if (gondericiEmail.Contains("@hotmail.com") || gondericiEmail.Contains("@outlook.com"))
                {
                    smtpServer = "smtp-mail.outlook.com";
                    smtpPort = 587;
                }
                else
                {
                    MessageBox.Show("Desteklenmeyen e-posta sa�lay�c�s�.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                smtpClient.Host = smtpServer;
                smtpClient.Port = smtpPort;
                smtpClient.Credentials = new NetworkCredential(gondericiEmail, gondericiSifre);
                smtpClient.EnableSsl = true;

                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress(gondericiEmail);
                mailMessage.To.Add(aliciEmail);
                mailMessage.Subject = konu;
                mailMessage.IsBodyHtml = true;
                mailMessage.Body = $@"
            <h1 style='color: blue; font-family: Arial, sans-serif;'>Merhaba!</h1>
            <p style='font-size: 16px; color: gray;'>{mesaj}</p>
            <hr style='border: 0; border-top: 1px solid #ccc; margin: 20px 0;' />
            <div style='display: flex; align-items: center;'>
                <img src='cid:firmaLogo' style='width: 100px; height: auto; margin-right: 20px;' />
                <div>
                    <p style='font-size: 14px; color: #333; margin: 0;'>
                        <strong>{adsoyad}</strong><br />
                        {unvan}<br />
                        {firmaAdi}<br />
                        Telefon: {cepTelefon}<br />
                        <p style='font-size: 14px; color: #333; margin: 0;'>
                        <strong>�leti�im Bilgileri:</strong><br />
                        E-Posta: <a href=""mailto:{mailAdres}"" style='color: #1a73e8; text-decoration: none;'>{mailAdres}</a><br />
                        Portf�y: <a href='{github}' style='color: #1a73e8; text-decoration: none;'>GitHub Profilim</a><br />
                        Linkedin: <a href='{linkedin}' style='color: #1a73e8; text-decoration: none;'>LinkedIn Profilim</a>
                        </p>
                    </p>
                </div>
            </div>
        ";

                // Bir Dosya G�nderme
                //if (!string.IsNullOrEmpty(txtDosya.Text))
                //{
                //    Attachment inline = new Attachment(txtDosya.Text);
                //    inline.ContentId = "foto";
                //    inline.ContentDisposition.Inline = true;
                //    inline.ContentDisposition.DispositionType = DispositionTypeNames.Inline;
                //    mailMessage.Attachments.Add(inline);
                //}

                // Toplu Dosya G�nderme
                if (!string.IsNullOrEmpty(txtDosya.Text))
                {
                    string[] dosyaYollari = txtDosya.Text.Split(new[] { ", " }, StringSplitOptions.None);

                    foreach (string dosyaYolu in dosyaYollari)
                    {
                        Attachment attachment = new Attachment(dosyaYolu);
                        mailMessage.Attachments.Add(attachment);
                    }
                }
                // Firma Logosu G�nderme
                if (!string.IsNullOrEmpty(firmaLogo))
                {
                    Attachment inlineLogo = new Attachment(firmaLogo);
                    inlineLogo.ContentId = "firmaLogo";
                    inlineLogo.ContentDisposition.Inline = true;
                    inlineLogo.ContentDisposition.DispositionType = DispositionTypeNames.Inline;
                    inlineLogo.ContentType.MediaType = "image/jpeg";
                    mailMessage.Attachments.Add(inlineLogo);
                }

                smtpClient.Send(mailMessage);
                MessageBox.Show("Mail ba�ar�yla g�nderildi.", "Ba�ar�l�", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata : " + ex.Message);
            }
        }
        private void btnGonder_Click(object sender, EventArgs e)
        {
            MesajGonder();
        }

        private void btnDosya_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Title = "Bir dosya se�in";

            // Tek Dosya
            //if (openFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    string dosyaYolu = openFileDialog.FileName;
            //    txtDosya.Text = dosyaYolu;
            //}

            //�oklu Dosya
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] dosyaYollari = openFileDialog.FileNames;
                txtDosya.Text = string.Join(", ", dosyaYollari);
            }
        }

        private void btnGizle_Click(object sender, EventArgs e)
        {
            if (txtGondericiSifre.UseSystemPasswordChar == true)
            {
                txtGondericiSifre.UseSystemPasswordChar = false;
            }
            else
            {
                txtGondericiSifre.UseSystemPasswordChar = true;
            }
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            openFileDialog.Title = "Bir dosya se�in";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string dosyaYolu = openFileDialog.FileName;
                txtFirmaLogo.Text = dosyaYolu;
            }
        }
    }
}

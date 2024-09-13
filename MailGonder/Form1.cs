using System.Net.Mail;
using System.Net;
using System.Net.Mime;
using System.Net.Http;
using System.Windows.Forms;
using System.Text;

namespace MailGonder
{
    public partial class Form1 : Form
    {
        string dosyaYolu, firmaLogo;
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
            this.FormClosing += Form1_FormClosing;
            Dosya.SelectionMode = SelectionMode.MultiExtended;
        }

        private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                if (Dosya.Focused)
                {
                    for (int i = 0; i < Dosya.Items.Count; i++)
                    {
                        Dosya.SetSelected(i, true);
                    }
                }
                else if (Mesaj.Focused)
                {
                    Mesaj.SelectAll();
                }
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Delete && Dosya.SelectedItem != null)
            {
                var selectedItems = Dosya.SelectedItems.Cast<object>().ToList();
                foreach (var item in selectedItems)
                {
                    Dosya.Items.Remove(item);
                }
                e.Handled = true;
            }
            else if (e.Control && e.KeyCode == Keys.C)
            {
                if (Dosya.SelectedItems.Count > 0)
                {
                    var sb = new StringBuilder();

                    foreach (var item in Dosya.SelectedItems)
                    {
                        sb.AppendLine(item.ToString());
                    }

                    Clipboard.SetText(sb.ToString());
                    e.Handled = true;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            GondericiSifre.UseSystemPasswordChar = true;
        }
        public void MesajGonder()
        {
            try
            {
                string gondericiEmail = GondericiMail.Text;
                string gondericiSifre = GondericiSifre.Text;
                string aliciEmail = AliciMail.Text;
                string konu = Konu.Text;
                string mesaj = Mesaj.Text;
                string unvan = Unvan.Text;
                string adsoyad = AdSoyad.Text;
                string firmaAdi = FirmaAd.Text;
                string cepTelefon = CepTelefon.Text;
                string mailAdres = MailAdres.Text;
                string github = Github.Text;
                string linkedin = Linkedin.Text;

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
                    Message.MessageError("Desteklenmeyen e-posta saðlayýcýsý.", "Hata");
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
                        <strong>Ýletiþim Bilgileri:</strong><br />
                        E-Posta: <a href=""mailto:{mailAdres}"" style='color: #1a73e8; text-decoration: none;'>{mailAdres}</a><br />
                        Portföy: <a href='{github}' style='color: #1a73e8; text-decoration: none;'>GitHub Profilim</a><br />
                        Linkedin: <a href='{linkedin}' style='color: #1a73e8; text-decoration: none;'>LinkedIn Profilim</a>
                        </p>
                    </p>
                </div>
            </div>
        ";

                // Bir Dosya Gönderme
                //if (!string.IsNullOrEmpty(txtDosya.Text))
                //{
                //    Attachment inline = new Attachment(txtDosya.Text);
                //    inline.ContentId = "foto";
                //    inline.ContentDisposition.Inline = true;
                //    inline.ContentDisposition.DispositionType = DispositionTypeNames.Inline;
                //    mailMessage.Attachments.Add(inline);
                //}

                // Toplu Dosya Gönderme TextBox ile
                //if (!string.IsNullOrEmpty(txtDosya.Text))
                //{
                //    string[] dosyaYollari = txtDosya.Text.Split(new[] { ", " }, StringSplitOptions.None);

                //    foreach (string dosyaYolu in dosyaYollari)
                //    {
                //        Attachment attachment = new Attachment(dosyaYolu);
                //        mailMessage.Attachments.Add(attachment);
                //    }
                //}

                // Toplu Dosya Gönderme ListBox ile
                if (Dosya.Items.Count > 0)
                {
                    foreach (string dosyaYolu in Dosya.Items)
                    {
                        Attachment attachment = new Attachment(dosyaYolu);
                        mailMessage.Attachments.Add(attachment);
                    }
                }
                // Firma Logosu Gönderme
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
                Message.MessageInfo($"Mail baþarýyla {aliciEmail} adresine gönderildi.", "Baþarýlý");
            }
            catch (Exception ex)
            {
                Message.MessageError(ex.Message, "Hata");
            }
        }
        private void btnGonder_Click(object sender, EventArgs e)
        {
            if (this.ValidateAll())
            {
                MesajGonder();
            }
        }

        private void btnDosya_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Title = "Bir dosya seçin";

            // Tek Dosya
            //if (openFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    string dosyaYolu = openFileDialog.FileName;
            //    txtDosya.Text = dosyaYolu;
            //}

            //Çoklu Dosya
            //if (openFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    string[] dosyaYollari = openFileDialog.FileNames;
            //    txtDosya.Text = string.Join(", ", dosyaYollari);
            //}

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string dosyaYolu in openFileDialog.FileNames)
                {
                    Dosya.Items.Add(dosyaYolu);
                }
            }
        }

        private void btnGizle_Click(object sender, EventArgs e)
        {
            if (GondericiSifre.UseSystemPasswordChar == true)
            {
                GondericiSifre.UseSystemPasswordChar = false;
            }
            else
            {
                GondericiSifre.UseSystemPasswordChar = true;
            }
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            openFileDialog.Title = "Bir dosya seçin";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string dosyaYolu = openFileDialog.FileName;
                firmaLogo = dosyaYolu;
            }
        }
    }
}

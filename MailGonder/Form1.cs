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
                    MessageBox.Show("Desteklenmeyen e-posta saðlayýcýsý.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            <img src='cid:foto' style='border: 1px solid #000; width: 300px; height: auto;' />
            <hr style='border: 0; border-top: 1px solid #ccc; margin: 20px 0;' />
            <div style='display: flex; align-items: center;'>
                <img src='https://media.licdn.com/dms/image/v2/C560BAQEKJ1puP35ZKQ/company-logo_200_200/company-logo_200_200/0/1630666865388?e=2147483647&v=beta&t=rtBcbSZFAw1KNdRCCuldwZ1LSGrKF3leYG8onnXve0g' style='width: 100px; height: auto; margin-right: 20px;' />
                <div>
                    <p style='font-size: 14px; color: #333; margin: 0;'>
                        <strong>Burak Yýlmam</strong><br />
                        Bilgisayar Mühendisi<br />
                        BLS Birleþik Lastik A.Þ<br />
                        Telefon: (539) 439-8213<br />
                        <p style='font-size: 14px; color: #333; margin: 0;'>
                        <strong>Ýletiþim Bilgileri:</strong><br />
                        E-Posta: <a href=""mailto:burakyilmamm@hotmail.com"" style='color: #1a73e8; text-decoration: none;'>burakyilmamm@hotmail.com</a><br />
                        Portföy: <a href='https://github.com/burakyilmam' style='color: #1a73e8; text-decoration: none;'>GitHub Profilim</a><br />
                        Linkedin: <a href='https://tr.linkedin.com/in/burak-y%C4%B1lmam-6a21191a7' style='color: #1a73e8; text-decoration: none;'>LinkedIn Profilim</a>
                        </p>
                    </p>
                </div>
            </div>
        ";

                if (!string.IsNullOrEmpty(txtDosya.Text))
                {
                    Attachment inline = new Attachment(txtDosya.Text);
                    inline.ContentId = "foto";
                    inline.ContentDisposition.Inline = true;
                    inline.ContentDisposition.DispositionType = DispositionTypeNames.Inline;
                    mailMessage.Attachments.Add(inline);
                }

                smtpClient.Send(mailMessage);
                MessageBox.Show("Mail baþarýyla gönderildi.", "Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            openFileDialog.Title = "Bir dosya seçin";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string dosyaYolu = openFileDialog.FileName;
                txtDosya.Text = dosyaYolu;
            }
        }

        private void btnGizle_Click(object sender, EventArgs e)
        {
            if(txtGondericiSifre.UseSystemPasswordChar == true)
            {
                txtGondericiSifre.UseSystemPasswordChar = false;
            }
            else
            {
                txtGondericiSifre.UseSystemPasswordChar = true;
            }
        }
    }
}

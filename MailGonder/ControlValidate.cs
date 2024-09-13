using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailGonder
{
    public static class ControlValidate
    {
        public static bool ValidateAll(this Control parent, Control c = null)
        {
            if (c == null)
            {
                c = parent;
            }

            bool isValid = true;

            foreach (Control control in c.Controls)
            {
                if (!control.Visible || !control.Enabled)
                {
                    continue;
                }

                if (control is TextBox textBox)
                {
                    Label label = FindLabel(parent, textBox.Name);

                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        Message.MessageError(label.Text + " alanı boş bırakılamaz.","Hata");
                        isValid = false;
                        return isValid;
                    }
                    else if (IsEmailField(textBox) && !EmailKontrol(textBox.Text))
                    {
                        isValid = false;
                        return isValid;
                    }
                }
                else if (control is ComboBox comboBox)
                {
                    Label label = FindLabel(parent, comboBox.Name);

                    if (comboBox.SelectedIndex == -1)
                    {
                        Message.MessageError(label.Text + " alanı boş bırakılamaz ", "Hata");
                        control.Focus();
                        isValid = false;
                        return isValid;
                    }
                }
                else if (control is DateTimePicker dateTimePicker)
                {
                    Label label = FindLabel(parent, dateTimePicker.Name);

                    if (dateTimePicker.Value == DateTime.MinValue)
                    {
                        Message.MessageError(label.Text + " alanı boş bırakılamaz ", "Hata");
                        control.Focus();
                        isValid = false;
                        return isValid;
                    }
                }
                else if (control is ListBox listBox)
                {
                    Label label = FindLabel(parent, listBox.Name);

                    if (listBox.Items.Count == 0)
                    {
                        Message.MessageError(label.Text + " alanı boş bırakılamaz ", "Hata");
                        isValid = false;
                        return isValid;
                    }
                }
                else if (control is RichTextBox richTextBox)
                {
                    Label label = FindLabel(parent, richTextBox.Name);

                    if (string.IsNullOrWhiteSpace(richTextBox.Text))
                    {
                        Message.MessageError(label.Text + " alanı boş bırakılamaz ", "Hata");
                        control.Focus();
                        isValid = false;
                        return isValid;
                    }
                }
                else if (control.HasChildren)
                {
                    if (!ValidateAll(parent, control))
                    {
                        isValid = false;
                        return isValid;
                    }
                }
            }
            return isValid;
        }
        private static Label FindLabel(Control parent, string controlName)
        {
            string labelName = "lbl" + controlName;
            return parent.Controls.OfType<Label>().FirstOrDefault(l => l.Name == labelName);
        }
        private static bool IsEmailField(TextBox textBox)
        {
            return textBox.Name == "txtGondericiMail" || textBox.Name == "txtAliciMail" || textBox.Name == "txtMailAdres";
        }

        private static bool EmailKontrol(string email)
        {
            if (!email.EndsWith("@gmail.com") && !email.EndsWith("@hotmail.com"))
            {
                Message.MessageWarning("Sadece @gmail.com veya @hotmail.com adresleri ile mail gönderebilirsiniz.", "Geçersiz E-posta");
                return false;
            }
            return true;
        }
    }

}

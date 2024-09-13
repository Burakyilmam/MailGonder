using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailGonder
{
    public static class Message
    {
        public static DialogResult MessageGeneric(string message, string title, MessageBoxButtons type, MessageBoxIcon icon)
        {
            return MessageBox.Show(message, title, type, icon);
        }
        public static DialogResult MessageWarning(string message, string title)
        {
            return MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static DialogResult MessageError(string message, string title)
        {
            return MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static DialogResult MessageInfo(string message, string title)
        {
            return MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static DialogResult MessageQuestion(string message, string title)
        {
            return MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}

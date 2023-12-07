using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSchoolManagement.Utilities
{
    internal class Helper
    {
        public void MessageSuccess(string message)
        {
            MessageBox.Show(message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void MessageError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public DialogResult MessageConfirm(string message)
        {
            DialogResult confirm;
            confirm = MessageBox.Show(message, "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            return confirm;
        }
        public void ClearControl(params Control[] controls)
        {
            foreach(Control control in controls)
            {
                switch(control.GetType().ToString())
                {
                    case "System.Windows.Forms.TextBox":
                        ((TextBox)control).Text = "";
                        break;
                    case "System.Windows.Forms.ComboBox":
                        ((ComboBox)control).SelectedIndex = -1;
                        break;
                    case "System.Windows.Forms.DateTimePicker":
                        ((DateTimePicker)control).Value = DateTime.Now;
                        break;
                    case "System.Windows.Forms.PictureBox":
                        ((PictureBox)control).Image = null;
                        break;
                }
            }
        }

        public int AutoId(string location)
        {
            string[] files = Directory.GetFiles(location);

            if(files.Length == 0) return 1;

            List<int> ids = new List<int>();

            foreach (string file in files)
            {
                string _fileName = Path.GetFileNameWithoutExtension(file);
                ids.Add(int.Parse(_fileName));
            }
            return ids.Max() + 1;
        }
    }
}

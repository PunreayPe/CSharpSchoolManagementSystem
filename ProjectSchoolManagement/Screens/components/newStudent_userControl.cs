using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSchoolManagement.Screens.components
{
    public partial class newStudent_userControl : UserControl
    {
        public newStudent_userControl()
        {
            InitializeComponent();
        }

        private void newStudent_userControl_Load(object sender, EventArgs e)
        {
            textBox_id.Text = new Utilities.Helper().AutoId("Students\\Data").ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void btn_clear_Click(object sender, EventArgs e)
        {
            //Utilities.Helper helper = new Utilities.Helper();
            //helper.ClearControl(textBoxFirstname, textBoxLastname);
            new Utilities.Helper().ClearControl(textBoxFirstname, textBoxLastname, comboBoxGender,dateTimePicker_dob, pictureBox_pf);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_choose_Click(object sender, EventArgs e)
        {

            DialogResult result =  openFileDialog_photo.ShowDialog();
            if (result == DialogResult.OK)
            {
                pictureBox_pf.Image = Image.FromFile(openFileDialog_photo.FileName);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Utilities.Students students = new Utilities.Students();
            students.id = int.Parse(textBox_id.Text);
            students.first_name = textBoxFirstname.Text;
            students.last_name = textBoxLastname.Text;
            students.gender = comboBoxGender.Text;
            students.dob = dateTimePicker_dob.Value;
            students.photo = pictureBox_pf.Image;

            students.Save();
            btn_clear_Click(null, null);
            newStudent_userControl_Load(null, null);
        }
    }
}

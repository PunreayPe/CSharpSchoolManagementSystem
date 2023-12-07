using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjectSchoolManagement.Screens.components
{
    public partial class tableStu : UserControl
    {
        public tableStu()
        {
            InitializeComponent();
        }

        private void tableStu_Load(object sender, EventArgs e)
        {
         
            string[] files = Directory.GetFiles("Students\\Data");
            foreach (string file in files)
            {
                //ShortCut
                dataGridView1.Rows.Add(new Utilities.Students() {file = file}.Load());
                
                // full form
                //Utilities.Students students = new Utilities.Students();
                //students.file = file;
                //dataGridView1.Rows.Add(students.Load());
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            string selectedId = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string path = "Students\\Images\\" + selectedId + ".png";
            if(File.Exists(path) == false) {
                pictureBox1.Image = null;
                return;
            }
            pictureBox1.Image = Image.FromFile(path);
        }
    }
}

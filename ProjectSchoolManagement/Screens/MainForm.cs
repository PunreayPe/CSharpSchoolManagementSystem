using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSchoolManagement.Screens
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            homeTolStrip_Click(null, null);
        }

        private void homeTolStrip_Click(object sender, EventArgs e)
        {
            var home = new components.Home_userControl(){
                Dock = DockStyle.Fill
            };
            panel_display.Controls.Clear();
            panel_display.Controls.Add(home);
        }

        private void RegisterNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newstu = new components.newStudent_userControl() { 
                Dock = DockStyle.Fill
            };
            panel_display.Controls.Clear();
            panel_display.Controls.Add(newstu);
        }

        private void TableStuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newstu = new components.tableStu()
            {
                Dock = DockStyle.Fill
            };
            panel_display.Controls.Clear();
            panel_display.Controls.Add(newstu);
        }
    }
}

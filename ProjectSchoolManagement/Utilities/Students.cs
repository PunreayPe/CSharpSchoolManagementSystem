using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSchoolManagement.Utilities
{
    internal class Students
    {
        public int id;
        public string first_name, last_name, gender;
        public DateTime dob;
        public Image photo;
        public string file;

        public void Save()
        {
            StreamWriter writer = new StreamWriter("Students\\Data\\" + id + ".txt");
            writer.Write(id + ", " + first_name + ", " + last_name + ", " + gender + ", " + dob.ToShortDateString());
            writer.Close();
        // Solution 1
            //if(photo != null )
            //{
            //    photo.Save("Students\\Images\\" + id + ".png");
            //}
        //  Solution 2
            if (photo == null) return;
            photo.Save("Students\\Images\\" + id + ".png");

            MessageBox.Show("Saved Success");
        }
        public string[] Load()
        {
            string temp = "";
            StreamReader reader = new StreamReader(file);
            temp = reader.ReadLine();
            reader.Close();

            string[] student = temp.Split(',');
            string[] row = new string[4] { student[0], student[1] + " " + student[2], student[3], student[4] };
            return row;
        }
    }
}

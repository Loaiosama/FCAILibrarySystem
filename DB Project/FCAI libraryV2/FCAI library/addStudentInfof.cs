using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCAI_library
{
    public partial class addStudentInfof : Form
    {
        public addStudentInfof()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-C5QD9JH;Initial Catalog=library; Integrated Security=True ");
            con.Open();

            SqlCommand myCommand = new SqlCommand("insert into STUDENT_PH (studentID,personalPhone,homePhone) values ('" + textBox32.Text.ToString() + "','" + textBox33.Text.ToString() + "','" + textBox34.Text.ToString() + "')", con);

            myCommand.ExecuteNonQuery();
            con.Close();
        }
    }
}

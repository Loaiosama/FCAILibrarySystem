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
    public partial class addStudentf : Form
    {
        public addStudentf()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-C5QD9JH;Initial Catalog=library; Integrated Security=True ");
            con.Open();

            SqlCommand myCommand = new SqlCommand("insert into STUDENT (studentID,firstName,lastName,email) values ('" + textBox28.Text.ToString() + "','" + textBox29.Text.ToString() + "','" + textBox30.Text.ToString() + "','" + textBox31.Text.ToString() + "')", con);

            myCommand.ExecuteNonQuery();
            con.Close();
        }

        private void label29_Click(object sender, EventArgs e)
        {

        }
    }
}

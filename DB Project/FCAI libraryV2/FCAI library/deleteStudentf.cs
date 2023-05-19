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
    public partial class deleteStudentf : Form
    {
        public deleteStudentf()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-C5QD9JH;Initial Catalog=library; Integrated Security=True ");
            con.Open();

            SqlCommand myCommand = new SqlCommand("delete from STUDENT where studentID='" + textBox22.Text.ToString() + "'", con);

            myCommand.ExecuteNonQuery();
            con.Close();
        }
    }
}

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
    public partial class updateAdminf : Form
    {
        public updateAdminf()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-C5QD9JH;Initial Catalog=library; Integrated Security=True ");
            con.Open();

            SqlCommand myCommand = new SqlCommand("update ADMIN set firstName='" + textBox7.Text.ToString() + "' where adminID='" + textBox5.Text.ToString() + "'", con);
            SqlCommand myCommand1 = new SqlCommand("update ADMIN set lastName='" + textBox8.Text.ToString() + "' where adminID='" + textBox5.Text.ToString() + "'", con);
            SqlCommand myCommand2 = new SqlCommand("update ADMIN set email='" + textBox6.Text.ToString() + "' where adminID='" + textBox5.Text.ToString() + "'", con);


            myCommand.ExecuteNonQuery();
            myCommand1.ExecuteNonQuery();
            myCommand2.ExecuteNonQuery();
            con.Close();
        }
    }
}

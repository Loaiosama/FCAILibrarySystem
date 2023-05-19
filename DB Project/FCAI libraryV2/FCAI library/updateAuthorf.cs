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
    public partial class updateAuthorf : Form
    {
        public updateAuthorf()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-C5QD9JH;Initial Catalog=library; Integrated Security=True ");
            con.Open();

            SqlCommand myCommand = new SqlCommand("update AUTHOR set authorName ='" + textBox25.Text.ToString() + "' where authorID='" + textBox24.Text.ToString() + "'", con);
           
            


            myCommand.ExecuteNonQuery();
            
            
            con.Close();
        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

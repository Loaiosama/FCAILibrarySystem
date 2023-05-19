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
    public partial class addPublisherf : Form
    {
        public addPublisherf()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-C5QD9JH;Initial Catalog=library; Integrated Security=True ");
            con.Open();

            SqlCommand myCommand = new SqlCommand("insert into PUBLISHER (street,city,phoneNum,publisherID) values ('" + textBox18.Text.ToString() + "','" + textBox19.Text.ToString() + "','" + textBox20.Text.ToString() + "','" + textBox21.Text.ToString() + "')", con);

            myCommand.ExecuteNonQuery();
            con.Close();
        }
    }
}

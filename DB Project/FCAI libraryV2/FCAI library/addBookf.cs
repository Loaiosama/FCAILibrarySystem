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
    public partial class addBookf : Form
    {
        public addBookf()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-C5QD9JH;Initial Catalog=library; Integrated Security=True ");
            con.Open();

            SqlCommand myCommand = new SqlCommand("insert into BOOKS (bookID,title,authorID,available,category,publicationDate,adminID,publisherID) values ('" + textBox9.Text.ToString() + "','" + textBox10.Text.ToString() + "','" + textBox11.Text.ToString() + "','" + textBox12.Text.ToString() + "','" + textBox13.Text.ToString() + "','" + textBox14.Text.ToString() + "','" + textBox15.Text.ToString() + "','" + textBox16.Text.ToString() + "')", con);

            myCommand.ExecuteNonQuery();
            con.Close();
        }
    }
}

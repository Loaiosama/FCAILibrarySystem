
using FCAI_library.bin;
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
    public partial class browseBooksf : Form
    {
        public browseBooksf()
        {
            InitializeComponent();
        }

        DataTable dtb = new DataTable();
        void viewdata()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-C5QD9JH;Initial Catalog=library; Integrated Security=True ");
            con.Open();

            SqlCommand myCommand = new SqlCommand("select title, available, category, publicationDate from BOOKS", con);
            SqlDataAdapter adp = new SqlDataAdapter(myCommand);

            adp.Fill(dtb);
            con.Close();
            con.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtb.Clear();
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-C5QD9JH;Initial Catalog=library; Integrated Security=True ");
            con.Open();
            CrystalReport1 crp = new CrystalReport1();
            viewdata();
            crp.Database.Tables["BOOKS"].SetDataSource(dtb);
            crystalReportViewer1.ReportSource = crp;
            con.Close();
        }
    }
}

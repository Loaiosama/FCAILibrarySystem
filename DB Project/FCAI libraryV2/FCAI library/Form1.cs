using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCAI_library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 adminFrm = new Form2();
            adminFrm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 studentFrm = new Form3();
            studentFrm.Show();
        }
    }
}

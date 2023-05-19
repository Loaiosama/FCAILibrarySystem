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
    public partial class Form2 : Form
    {
        int flag = -1;
        public Form2()
        {
            InitializeComponent();
        }

        public void loadForm(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();


        }

        private void addAdmin_Click(object sender, EventArgs e)
        {
            loadForm(new addAdminf());
        }

        private void updateAdmin_Click(object sender, EventArgs e)
        {
            loadForm(new updateAdminf());
        }

        private void addAuthor_Click(object sender, EventArgs e)
        {
            loadForm(new addAuthorf());
        }

        private void updateAuthor_Click(object sender, EventArgs e)
        {
            loadForm(new updateAuthorf());
        }

        private void addBook_Click(object sender, EventArgs e)
        {
            loadForm(new addBookf());
        }

        private void addPublisher_Click(object sender, EventArgs e)
        {
            loadForm(new addPublisherf());
        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            loadForm(new addStudentf());
        }

        private void stInfo_Click(object sender, EventArgs e)
        {
            loadForm(new addStudentInfof());
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void deleteStudentbutt_Click(object sender, EventArgs e)
        {
            loadForm(new deleteStudentf());
        }

        private void deleteBookbutt_Click(object sender, EventArgs e)
        {
            loadForm(new deleteBook());
        }

        

        private void browseBooksbutt_Click_1(object sender, EventArgs e)
        {
            loadForm(new browseBooksf());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            loadForm(new joinSearchf());
        }
    }
}

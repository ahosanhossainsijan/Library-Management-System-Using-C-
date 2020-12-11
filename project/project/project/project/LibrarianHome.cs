using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class LibrarianHome : Form
    {
        UserClass user;
        public LibrarianHome( UserClass user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void LibrarianHome_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookForm bf = new BookForm(user);
            bf.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BookDetailsFrom bdf = new BookDetailsFrom(user);
            bdf.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IssueBookForm ibf = new IssueBookForm( user);
            ibf.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BorrowHistoryForm bhf = new BorrowHistoryForm(user);
            bhf.Show();
                this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 sf = new Form3(user);
            sf.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 one = new Form1();
            one.Show();
            this.Hide();
        }

    }
}

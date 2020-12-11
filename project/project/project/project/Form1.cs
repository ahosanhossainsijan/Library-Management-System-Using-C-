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
    public partial class Form1 : Form
    {
        UserClass user = new UserClass();
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = DataAccess.LoadData("select * from UserInfo where UserName='" + txtUN.Text +
                                               "' and Password='" + txtPassword.Text + "'");
            
            if (dt.Rows.Count != 1)
            {
                MessageBox.Show("Invalid Username or Password");
                return;
            }
            int id = Int32.Parse(dt.Rows[0]["Id"].ToString());
            string name = dt.Rows[0]["Name"].ToString();
            string UserName = dt.Rows[0]["UserName"].ToString();
            string password = dt.Rows[0]["Password"].ToString();
            int type = Int32.Parse(dt.Rows[0]["Type"].ToString());
            user.setId(id);
            user.setName(name);
            user.setUserName(UserName);
            user.setPassword(password);
            user.setType(type);

            
            if (type == 3)
            {
                UserHome u = new UserHome(user);
                u.Show();
                this.Hide();
            }
            else if (type == 2)
            {
                UserHome u = new UserHome(user);
                u.Show();
                this.Hide();
            }
            else if (type == 1)
            {
                LibrarianHome l = new LibrarianHome(user);
                l.Show();
                this.Hide();
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}

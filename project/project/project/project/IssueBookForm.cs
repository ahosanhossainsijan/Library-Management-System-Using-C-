using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace project
{
    public partial class IssueBookForm : Form
    {
        UserClass user;
        public IssueBookForm(UserClass user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void IssueBookForm_Load(object sender, EventArgs e)
        {

            DataTable dt = DataAccess.LoadData("select BookDetails.Id,Book.Name as'BookName',BookDetails.Status,BookDetails.DaskNo from BookDetails,Book where BookDetails.BookId=Book.Id ");
            dt.Columns.Add("StatusName");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int statusID = Int32.Parse(dt.Rows[i]["Status"].ToString());
                dt.Rows[i]["StatusName"] = ((Enumcollection.BookStatus)statusID).ToString();
            }

            dgvIssueBook.DataSource = dt;
            dgvIssueBook.ClearSelection();
            dgvIssueBook.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!IsValid()) {

                return;
            }
            string check = txtUName.Text;
            int row0 = DataAccess.Check_UserId(check);
           
            if (row0 != 1)
            {

                MessageBox.Show("UserID not match");
                txtUName.Focus();
                return;
            }
            string query = "";
            DataTable dt1 = DataAccess.LoadData("select * from UserInfo where UserName like '" + txtUName.Text + "'");
            int id = Int32.Parse(dt1.Rows[0]["Id"].ToString());
            int type = Int32.Parse(dt1.Rows[0]["Type"].ToString());

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1TPJ3P1;Initial Catalog=ProjectLB;Integrated Security=True");
            con.Open();
           
            String Query2 = "Select Count(BookDetailsId) from BorrowHistory";
            SqlCommand n = new SqlCommand(Query2, con);
            int i = Convert.ToInt32(n.ExecuteScalar());
            i++;
            
            String q = "Select Count(UserName) from Check_id where UserName= '" + txtUName.Text + "' ";
            SqlCommand c = new SqlCommand(q, con);

            int count1 = Convert.ToInt32(c.ExecuteScalar());
           
            if (count1 >= 3)
            {
                MessageBox.Show("Already Borrowed max Books");
                return;
            }
           
            String s = "insert into check_id(UserName) values ('" + txtUName.Text + "')";
            SqlCommand one = new SqlCommand(s, con);
            int k = one.ExecuteNonQuery();

            if (type == 2)
            {
                DateTime dt = DateTime.Parse(dtpIssueDate.Text);
                DateTime dt2 = dt.AddMonths(1);
                dtpERDate.Text = dt2.ToString();
            }
            else if (type == 3)
            {
                DateTime dt = DateTime.Parse(dtpIssueDate.Text);
                DateTime dt2 = dt.AddDays(7);
                dtpERDate.Text = dt2.ToString();
            }

            query = "insert into BorrowHistory (UserId,BookDetailsId,BorrowDate,ExpectedReturnDate) Values(" + id + "," + txtId.Text + ",'" + dtpIssueDate.Text + "','" + dtpERDate.Text + "')";
         string qq="   insert into UserBorrowHistory (UserName,BookName,BorrowDate,ExpectedReturnDate) Values('" + txtUName.Text+ "','" + txtBName.Text + "','" + dtpIssueDate.Text + "','" + dtpERDate.Text + "')";


            int row = DataAccess.ExecuteQuery(query);
            int row2= DataAccess.ExecuteQuery(qq);
            if ((row > 0)&&(row2>0))
            {
                MessageBox.Show("Book Issued");

            }
            txtBName.Text = txtId.Text = txtUName.Text = "";
            dtpERDate.Text = dtpIssueDate.Text = "";
        }
        private bool IsValid()
        {
            if ((String.IsNullOrEmpty(txtBName.Text)) || (String.IsNullOrEmpty(txtUName.Text))) 
            {

                MessageBox.Show("Fill The TextBox Properly");
                return false;
            }

            return true;

        }

        private void dgvIssueBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dgvIssueBook_CellDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            txtId.Text = dgvIssueBook.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtBName.Text = dgvIssueBook.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LibrarianHome lh = new LibrarianHome(user);
            lh.Show();
            this.Hide();

        }

        private void dgvIssueBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

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
    public partial class BorrowHistoryForm : Form
    {
        UserClass user;
        public BorrowHistoryForm(UserClass user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void BorrowHistoryForm_Load(object sender, EventArgs e)
        {
            if (user.getType() == 1)
            {
                DataTable dt = DataAccess.LoadData("select BorrowHistory.Id,UserInfo.UserName,Book.Name as'BookName',BorrowHistory.BorrowDate,BorrowHistory.ExpectedReturnDate,BorrowHistory.ReturnDate,BorrowHistory.LateFine,BorrowHistory.LostFine from BorrowHistory,BookDetails,UserInfo,Book where BorrowHistory.UserId=UserInfo.Id and BorrowHistory.BookDetailsId=BookDetails.Id and BookDetails.BookId = Book.Id");

                dgvBorrowHistory.DataSource = dt;
                dgvBorrowHistory.ClearSelection();
                dgvBorrowHistory.Refresh();
            }
            else 
            {
               

                DataTable dt = DataAccess.LoadData("select * from UserBorrowHistory where UserName ='"+user.getUserName()+"' ");

                dgvBorrowHistory.DataSource = dt;
                dgvBorrowHistory.ClearSelection();
                dgvBorrowHistory.Refresh();
                btnUpdate.Visible = false;
                btnLoad.Visible = false;
                txtBookName.Visible = false;
                txtId.Visible = false;
                txtLateFine.Visible = false;
                txtLostFine.Visible = false;
                txtUserName.Visible = false;
                lblBDate.Visible = false;
                lblBName.Visible = false;
               
                lblERDate.Visible = false;
                lblId.Visible = false;
                lblLateFine.Visible = false;
                lblLostFine.Visible = false;
                lblRDate.Visible = false;
                lblUName.Visible = false;
                dtpBDate.Visible = false;
                dtpERDate.Visible = false;
                dtpRDate.Visible = false;
                txtSearch.Visible = false;
                lblUBH.Visible = false;
                lblUN.Visible = false;
                btnSearch.Visible = false;

                
            }
        }

        private void dgvBorrowHistory_CellDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(user.getType()==1)
            {

             txtId.Text = dgvBorrowHistory.Rows[e.RowIndex].Cells[0].Value.ToString();
             txtUserName.Text= dgvBorrowHistory.Rows[e.RowIndex].Cells[1].Value.ToString();
             txtBookName.Text = dgvBorrowHistory.Rows[e.RowIndex].Cells[2].Value.ToString();
             txtLateFine.Text = dgvBorrowHistory.Rows[e.RowIndex].Cells[6].Value.ToString();
             txtLostFine.Text = dgvBorrowHistory.Rows[e.RowIndex].Cells[7].Value.ToString();
             dtpBDate.Text = dgvBorrowHistory.Rows[e.RowIndex].Cells[3].Value.ToString();
             dtpERDate.Text = dgvBorrowHistory.Rows[e.RowIndex].Cells[4].Value.ToString();
             dtpRDate.Text = dgvBorrowHistory.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!IsValid()) {

                return;
            }
            
            string check = txtUserName.Text;
            int row0 = DataAccess.Check_UserId(check);
           
            if (row0 != 1)
            {

                MessageBox.Show("UserID not match");
                txtUserName.Focus();
                return;
            }
            string query = "";
            string query2 = "";
            DateTime erd=dtpERDate.Value.Date;
            DateTime rd = dtpRDate.Value.Date;
            TimeSpan ts = rd-erd;
            int day =ts.Days;

            int fine=0;
            if (day <= 0) {

                try
                {

                    DataTable dt1 = DataAccess.LoadData("select * from Check_id where UserName like '" + txtUserName.Text + "'");
                    int id = Int32.Parse(dt1.Rows[0]["id"].ToString());
                    

                    int r = DataAccess.ExecuteQuery("Delete from Check_id where id='" + id + "'");



                   

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            
            }
            if (day > 0)
            {
                fine = 50 * day;

            }
            txtLateFine.Text = fine.ToString();
            DataTable dt3 = DataAccess.LoadData("select * from UserBorrowHistory Where UserName='" + txtUserName.Text + "' and BookName='" + txtBookName.Text + "'");
            int id1 = Int32.Parse(dt3.Rows[0]["Id"].ToString());
            
            if (txtId.Text == "")
            {
                MessageBox.Show("Select a row first");
            }
            else
            {
                 query = "update BorrowHistory set ReturnDate='"+dtpRDate.Text+"',LateFine='"+txtLateFine.Text+"',LostFine='"+txtLostFine.Text +"' where Id=" + txtId.Text + "";
                 query2="update UserBorrowHistory set ReturnDate='"+dtpRDate.Text+"',LateFine='"+txtLateFine.Text+"',LostFine='"+txtLostFine.Text +"' where Id=" + id1 + "";
            }

            int row = DataAccess.ExecuteQuery(query);
            int row2 = DataAccess.ExecuteQuery(query2);
            if ((row > 0)&&(row2>0))
            {
                MessageBox.Show("Updated");

            }
            btnLoad.PerformClick();
            
        }
        private bool IsValid()
        {
            if ((String.IsNullOrEmpty(txtUserName.Text)) || (String.IsNullOrEmpty(txtBookName.Text)))
            {

                MessageBox.Show("Fill The TextBox Properly");
                return false;
            }

            return true;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (user.getType() == 1)
            {
                LibrarianHome lh = new LibrarianHome(user);
                lh.Show();
                this.Hide();

            }
            else 
            {
                UserHome uh = new UserHome(user);
                uh.Show();
                this.Hide();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (user.getType() == 1)
            {
                DataTable dt = DataAccess.LoadData("select BorrowHistory.Id,UserInfo.UserName,Book.Name as'BookName',BorrowHistory.BorrowDate,BorrowHistory.ExpectedReturnDate,BorrowHistory.ReturnDate,BorrowHistory.LateFine,BorrowHistory.LostFine from BorrowHistory,BookDetails,UserInfo,Book where BorrowHistory.UserId=UserInfo.Id and BorrowHistory.BookDetailsId=BookDetails.Id and BookDetails.BookId = Book.Id");

                dgvBorrowHistory.DataSource = dt;
                dgvBorrowHistory.ClearSelection();
                dgvBorrowHistory.Refresh();
            }
            else
            {
                DataTable dt = DataAccess.LoadData("select BorrowHistory.Id,UserInfo.UserName,Book.Name as'BookName',BorrowHistory.BorrowDate,BorrowHistory.ExpectedReturnDate,BorrowHistory.ReturnDate,BorrowHistory.LateFine,BorrowHistory.LostFine from BorrowHistory,BookDetails,UserInfo,Book where UserInfo.Id=" + user.getId() + "and BorrowHistory.BookDetailsId=BookDetails.Id and BookDetails.BookId = Book.Id");

                dgvBorrowHistory.DataSource = dt;
                dgvBorrowHistory.ClearSelection();
                dgvBorrowHistory.Refresh();
                btnUpdate.Visible = false;

            }
            txtId.Text = txtBookName.Text = txtLateFine.Text = txtLostFine.Text = txtSearch.Text = txtUserName.Text = "";
            dtpBDate.Text = dtpERDate.Text = dtpRDate.Text = "";
        }

        private void dgvBorrowHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblBorrowHistory_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String query = "Select * from UserBorrowHistory where UserName like '" + txtSearch.Text + "'";
            DataTable dt = DataAccess.LoadData(query);
            dgvBorrowHistory.DataSource = dt;
            dgvBorrowHistory.ClearSelection();
            dgvBorrowHistory.Refresh();
            txtSearch.Text = "";
        }
    }
}

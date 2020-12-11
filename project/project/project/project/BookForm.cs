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
    public partial class BookForm : Form
    {
        UserClass user;
        public BookForm( UserClass user)
        {

            this.user = user;
            InitializeComponent();
          
        }
        private void BookForm_Load(object sender, EventArgs e)
        {
            DataTable dt = DataAccess.LoadData("select * from Book");
            dgvBook.DataSource = dt;
            dgvBook.Refresh();

            DataTable dt1 = DataAccess.LoadData("select * from Category");
            cBoxCategory.DataSource = dt1;
            cBoxCategory.DisplayMember = "Name";
            cBoxCategory.ValueMember = "Id";
        }
        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            DataTable dt = DataAccess.LoadData("select * from Book");
            dgvBook.DataSource = dt;
            dgvBook.Refresh();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = DataAccess.LoadData("select * from Book where Name like '%" + txtSearch.Text + "%'");
            dgvBook.DataSource = dt;
           
            dgvBook.Refresh();
            txtSearch.Text = "";
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (!IsValid()) {
                return;
            }
            
            string query = "";
        
           
          
            string bname=txtBName.Text;
            if (txtId.Text == "")
            {
                query = "insert into Book (Name,AuthorName,Isbn,Quaintity,PurchaseDate,CategoryId,Price) Values('" + txtBName.Text + "','" + txtAName.Text + "','" + txtIsbn.Text + "'," + txtQuantity.Text + ",'" + dtpDate.Text + "'," + cBoxCategory.SelectedValue + "," + txtPrice.Text + ")";
           
            }

            int row = DataAccess.ExecuteQuery(query);
            
           if (row > 0)
            {
                MessageBox.Show("Inserted");
                btnLoad.PerformClick();
            }
           Random r = new Random();
             DataTable dt2 = DataAccess.LoadData("select * from Book where Name like '" + bname + "'");
           BookClass bc = new BookClass();
            bc.setId(Int32.Parse(dt2.Rows[0]["Id"].ToString()));
            bc.setName(dt2.Rows[0]["Name"].ToString());
            bc.setQuantity(Int32.Parse(dt2.Rows[0]["Quaintity"].ToString()));
            bc.setAuthorName(dt2.Rows[0]["AuthorName"].ToString());
            int loop = bc.getQuantity();
            int rd=r.Next(1, 20);
            if (loop <= 5) {
                for (int i = 0; i < loop; i++)
                {
                    int row1 = DataAccess.ExecuteQuery("insert into BookDetails (BookId,[Status],DaskNo) Values (" + bc.getId() + "," + (int)Enumcollection.BookStatus.Not_For_Borrow + "," + rd + ")");
                  
                }
                return;
            }
            for (int i = 0; i < 5;i++ )
            {
                int row1 = DataAccess.ExecuteQuery("insert into BookDetails (BookId,[Status],DaskNo) Values ("+bc.getId()+","+(int)Enumcollection.BookStatus.Not_For_Borrow+","+rd+")");
              
            }
            for (int i = 5; i < loop; i++)
            {
                int row1 = DataAccess.ExecuteQuery("insert into BookDetails (BookId,[Status],DaskNo) Values (" + bc.getId() + "," + (int)Enumcollection.BookStatus.Borrow_Able + "," + r.Next(1, 20) + ")");
              
            }
            btnNew.PerformClick();

        }
        private bool IsValid() {
            if ((String.IsNullOrEmpty(txtAName.Text))||(String.IsNullOrEmpty(txtPrice.Text))||(String.IsNullOrEmpty(txtBName.Text))||(String.IsNullOrEmpty(txtIsbn.Text))) {

                MessageBox.Show("Fill The TextBox Properly");
                return false;
            }

            return true;
            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtBName.Text = txtAName.Text = txtIsbn.Text = txtQuantity.Text  = txtPrice.Text = "";

            dtpDate.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LibrarianHome lh = new LibrarianHome(user);
            lh.Show();
            this.Hide();
        }

        private void LoginLabel_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}

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
    public partial class BookDetailsFrom : Form
    {
        UserClass user;
        public BookDetailsFrom(UserClass user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void BookDetailsFrom_Load(object sender, EventArgs e)
        {
            if (user.getType() == 1)
            {
                DataTable dt = DataAccess.LoadData("select BookDetails.Id,Book.Name as'BookName',BookDetails.Status,BookDetails.DaskNo from BookDetails,Book where BookDetails.BookId=Book.Id ");
                dt.Columns.Add("StatusName");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int statusID = Int32.Parse(dt.Rows[i]["Status"].ToString());
                    dt.Rows[i]["StatusName"] = ((Enumcollection.BookStatus)statusID).ToString();
                }
                dgvBookDetails.DataSource = dt;
                dgvBookDetails.ClearSelection();
                dgvBookDetails.Refresh();

                cBoxStatus.DataSource = Enumcollection.BookStatusList();
                cBoxStatus.DisplayMember = "Name";
                cBoxStatus.ValueMember = "ID";
            }
            else
            {
                btnUpdate.Visible = false;
                txtBookName.Visible = false;
                txtDaskNo.Visible = false ;
                UpdateLabel.Visible = false;
                cBoxStatus.Visible = false;
                txtDaskNo.Visible = false;
                btnLoad.Visible = false;
                lblBName.Visible = false;
                lblDeskNo.Visible = false;
                lblId.Visible = false;
                lblStatus.Visible = false;
                txtId.Visible = false;
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = "";

            if (txtAuthor.Text == "" && txtBook.Text != "")
            {
                try
                {
                    DataTable dt1 = DataAccess.LoadData("select * from Book where Name like  '" + txtBook.Text + "'");
                    int id = Int32.Parse(dt1.Rows[0]["Id"].ToString());
                    
                    
                    DataTable dt = DataAccess.LoadData("select BookDetails.Id,Book.Name as'BookName',BookDetails.Status,BookDetails.DaskNo from BookDetails,Book where BookDetails.BookId=" + id + " and Book.Name  like '"+txtBook.Text+"'");
                    dt.Columns.Add("StatusName");
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        int statusID = Int32.Parse(dt.Rows[i]["Status"].ToString());
                        dt.Rows[i]["StatusName"] = ((Enumcollection.BookStatus)statusID).ToString();
                    }
                    dgvBookDetails.DataSource = dt;
                    dgvBookDetails.ClearSelection();
                    dgvBookDetails.Refresh();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Wrong Book Name");
                }

            }
                
            else if (txtBook.Text == "" && txtAuthor.Text != "")
            {


                try
                { 
                    DataTable dt = DataAccess.LoadData("select BookDetails.Id,Book.Name ,BookDetails.Status,BookDetails.DaskNo from BookDetails,Book where BookDetails.BookId=Book.Id and Book.AuthorName like '%"+txtAuthor.Text+"%'");
                    dt.Columns.Add("StatusName");
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        int statusID = Int32.Parse(dt.Rows[i]["Status"].ToString());
                        dt.Rows[i]["StatusName"] = ((Enumcollection.BookStatus)statusID).ToString();
                    }
                    dgvBookDetails.DataSource = dt;
                    dgvBookDetails.ClearSelection();
                    dgvBookDetails.Refresh();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Wrong Author Name");
                }

            }
            else if (txtBook.Text != "" && txtAuthor.Text != "")
            {
                MessageBox.Show("Select Book Name or Author Name");
            }
            txtAuthor.Text = "";
            txtBook.Text = "";
        }



        private void button1_Click(object sender, EventArgs e)
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

        private void txtBook_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvBookDetails_CellDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (user.getType() == 1)
            {
                if (e.RowIndex == -1)
                {
                    return;
                }

                else
                {
                    txtId.Text = dgvBookDetails.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtBookName.Text = dgvBookDetails.Rows[e.RowIndex].Cells[1].Value.ToString();
                    cBoxStatus.SelectedValue = dgvBookDetails.Rows[e.RowIndex].Cells[4].Value.ToString();
                    txtDaskNo.Text = dgvBookDetails.Rows[e.RowIndex].Cells[3].Value.ToString();
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtBookName.Text == "")
            {
                MessageBox.Show("Book Name Not Entered");
                return;
            }
            string query = "";
            
            DataTable dt2 = DataAccess.LoadData("select * from Book where Name like '" + txtBookName.Text + "'");
            int id = Int32.Parse(dt2.Rows[0]["Id"].ToString());
           
            if (txtId.Text == "")
            {
                MessageBox.Show("Select a row first");
            }
            else
            {
                
                query = "update BookDetails set BookId=" + id + ",Status=" + cBoxStatus.SelectedValue.ToString() + " where Id=" + txtId.Text + "";
                }

            int row = DataAccess.ExecuteQuery(query);
            if (row > 0)
            {
                MessageBox.Show("Updated");

            }
            btnLoad.PerformClick();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (user.getType() == 1)
            {
                DataTable dt = DataAccess.LoadData("select BookDetails.Id,Book.Name as'BookName',BookDetails.Status,BookDetails.DaskNo from BookDetails,Book where BookDetails.BookId=Book.Id ");
                dt.Columns.Add("StatusName");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int statusID = Int32.Parse(dt.Rows[i]["Status"].ToString());
                    dt.Rows[i]["StatusName"] = ((Enumcollection.BookStatus)statusID).ToString();
                }
                dgvBookDetails.DataSource = dt;
                dgvBookDetails.ClearSelection();
                dgvBookDetails.Refresh();

                cBoxStatus.DataSource = Enumcollection.BookStatusList();
                cBoxStatus.DisplayMember = "Name";
                cBoxStatus.ValueMember = "ID";
            }
            else
            {
                btnUpdate.Visible = false;
                txtBookName.Visible = false;
                txtDaskNo.Visible = false;
                UpdateLabel.Visible = false;
                cBoxStatus.Visible = false;
                txtDaskNo.Visible = false;
                btnLoad.Visible = false;
                lblBName.Visible = false;
                lblDeskNo.Visible = false;
                lblId.Visible = false;
                lblStatus.Visible = false;
                txtId.Visible = false;
            }
            txtId.Text = txtDaskNo.Text = txtBookName.Text = "";
            cBoxStatus.Text = "";

        }

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UpdateLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

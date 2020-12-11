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
    public partial class Form3 : Form
    {
        UserClass user;
        public Form3(UserClass user)
        {
            
            this.user = user;
            InitializeComponent();
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!IsValid())
            { 
                return; 
            
            }
            string check = textUId.Text;
            int row0 = DataAccess.Check_UserId(check);
           
            if (row0 != 1)
            {

                MessageBox.Show("UserID not match");
                textUId.Focus();
                return;
            }

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-1TPJ3P1;Initial Catalog=ProjectLB;Integrated Security=True");

                con.Open();

               

                String q = "Select * from ShowFine";
                DataTable dt = DataAccess.LoadData(q);

                String query2 = "Select Count(UserId) from ShowFine";

                SqlCommand a = new SqlCommand(query2, con);

                int i = Convert.ToInt32(a.ExecuteScalar());
                i++;
               

            string query = "Insert into ShowFine(Id,UserId,Date,LateFine,LostFine) values ('" + i + "', '" + textUId.Text + "','" + dtpFineDate.Text + "','" + textLateFine.Text + "','" + textLostFine.Text + "')";
          
                try
                {

                    DataTable dt1 = DataAccess.LoadData("select * from Check_id where UserName like '" + textUId.Text + "'");
                    int id = Int32.Parse(dt1.Rows[0]["id"].ToString());
                   

                    int r = DataAccess.ExecuteQuery("Delete from Check_id where id='"+id+"'");

                  
                 
                    
                   
                }
                catch (Exception ex) {
                    MessageBox.Show("There Is No Fine");
                    return;
                
                }
                SqlCommand command = new SqlCommand(query, con);


                int row = command.ExecuteNonQuery();


                if (row > 0)
                {
                    MessageBox.Show("Paid");
                }
                dataFineView.DataSource = dt;
                dataFineView.Refresh();
                btnLoad.PerformClick();
        }
        
        private bool IsValid() {
            if (String.IsNullOrEmpty(textUId.Text))
            {
                textUId.Focus();
                MessageBox.Show("Fill the Boxes properly");
                return false;
            }
             if ((String.IsNullOrEmpty(textLostFine.Text)) &&(String.IsNullOrEmpty(textLateFine.Text))){
               
                MessageBox.Show("Fill the Boxes properly");
                return false;
            }

            
            
            
            return true;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            txtId.ReadOnly = true;
            String q = "Select * from ShowFine";
            DataTable dt = DataAccess.LoadData(q);
            dataFineView.DataSource = dt;
            dataFineView.Refresh();
        }

        private void dataFineView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LibrarianHome one = new LibrarianHome(user);
            one.Show();
            this.Hide();

        }

        private void textUId_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = DataAccess.LoadData("Select * from ShowFine where UserId like '" + txtSearch.Text + "'");
            dataFineView.DataSource = dt;
            dataFineView.ClearSelection();
            dataFineView.Refresh();
            txtSearch.Text = "";
            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            txtId.ReadOnly = true;
            String q = "Select * from ShowFine";
            DataTable dt = DataAccess.LoadData(q);
            dataFineView.DataSource = dt;
            dataFineView.Refresh();
            txtId.Text = "";
            textLateFine.Text = "";
            textLostFine.Text = "";
            textUId.Text = "";
            dtpFineDate.Text = "";
            
        }
    }
}

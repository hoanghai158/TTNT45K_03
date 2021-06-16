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
using hethongbanvexemfim.DTO;

namespace hethongbanvexemfim
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            
            loadfilmlist();
            
          
            
        }

       
      void loadfilmlist()
        {
            string query = " Select * from VE";
            DataProvider provider = new DataProvider();
            dtgvFilm.DataSource = provider.ExcuteQuery(query);
        }
    

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CV_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tpCategory_Click(object sender, EventArgs e)
        {

        }

        private void btnShowAccount_Click(object sender, EventArgs e)
        {

        }

        private void btnshowFilm_Click(object sender, EventArgs e)
        {

        }

        private void bntShowCategory_Click(object sender, EventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tpCustomer_Click(object sender, EventArgs e)
            
        {
            
        }

        private void btnShowCustomer_Click(object sender, EventArgs e)
            
        {
            string connectionSTR = @"Data Source=LAPTOP-0VKU2PBT\SQLEXPRESS;Initial Catalog=HTQL_BANVEXEMFILM;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionSTR);
            string query = " Select * from KHACH_HANG";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            dtgvCustomer.DataSource = data;
        }

        private void btnShowCashier_Click(object sender, EventArgs e)
        {
            string connectionSTR = @"Data Source=LAPTOP-0VKU2PBT\SQLEXPRESS;Initial Catalog=HTQL_BANVEXEMFILM;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionSTR);
            string query = " Select * from NHAN_VIEN";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            dtgvCashier.DataSource = data;
        }

        private void tpCasiher_Click(object sender, EventArgs e)
        {
           
        }

        private void dtgvCashier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}

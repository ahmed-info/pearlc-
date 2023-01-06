using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rare_pearl.pages
{
    public partial class searchPage : DevExpress.XtraEditors.XtraUserControl
    {
        public searchPage()
        {
            InitializeComponent();
        }

        public void btnSearch_Click(object sender, EventArgs e)
        {
           
        }

        private void searchPage_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=pearl_db;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT  WorkerName,NoPassport  FROM Table_files", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            dataGridView1.DataSource = dt;

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Rare_pearl
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            LoadHomePage();

        }

        private void tileBar1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            LoadHomePage();

        }
        private void LoadHomePage()
        {
            pages.HomePage page = new pages.HomePage();
            LoadPage(page);
        }
        // lOad page Method
        private void LoadPage(DevExpress.XtraEditors.XtraUserControl Page)
        {
            try
            {
                panel_container.Controls.Clear();
                Page.Dock = DockStyle.Fill;
                panel_container.Controls.Add(Page);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_primary_Click(object sender, EventArgs e)
        {
            pages.primaryPage page = new pages.primaryPage();
            LoadPage(page);
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            GetDataRecord();
        }

        public void GetDataRecord()
        {
            SqlConnection con = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=pearl_db;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Table_files",con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            
        }

        private void btnSearchPage_Click(object sender, EventArgs e)
        {
            pages.searchPage page = new pages.searchPage();
            LoadPage(page);
        }

        private void panel_container_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

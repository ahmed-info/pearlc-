using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rare_pearl.pages
{
    //public class ComboboxItem
    //{
    //    public string Text { get; set; }
    //    public object Value { get; set; }

    //    public override string ToString()
    //    {
    //        return Text;
    //    }
    //}
    public partial class primaryPage : DevExpress.XtraEditors.XtraUserControl
    {
        public primaryPage()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }
        public int getId;
        private void LoadToGridView()
        {
            SqlConnection con = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=pearl_db;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Table_files", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            dataGridView1.DataSource = dt;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker9_ValueChanged(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=pearl_db;Integrated Security=True");
        string ticketOrInsurance = "";
        private void btn_save_Click(object sender, EventArgs e)
        {
            //DataTable dt = new DataTable();
            if (rdo_return_ticket.Checked)
            {
                ticketOrInsurance = "تذكرة عودة";
            }
            if(rdo_insurance.Checked)
            {
                ticketOrInsurance = "تأمينات";
            }
            if (isValid())
            {
                try
                {

                if(con.State== ConnectionState.Closed)
                    con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Table_files VALUES (@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13,@14,@15,@16,@17,@18,@19,@20,@21,@22,@23,@24,@25,@26,@27,@28,@29,@30,@31,@32,@33,@34,@35,@36,@37,@38,@39,@40,@41,@42,@43,@44,@45,@46)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@1", txt_no_request.Text.Trim());
                cmd.Parameters.AddWithValue("@2", dt_request.Value);
                cmd.Parameters.AddWithValue("@3",int.Parse(txt_no_total.Text.Trim()));
                cmd.Parameters.AddWithValue("@4", int.Parse(txt_arab.Text.Trim()));
                cmd.Parameters.AddWithValue("@5", int.Parse(txt_foreign.Text.Trim()));
                cmd.Parameters.AddWithValue("@6", txt_worker.Text.Trim());
                cmd.Parameters.AddWithValue("@7", txt_no_passport.Text);
                cmd.Parameters.AddWithValue("@8", txt_national.Text.Trim());
                cmd.Parameters.AddWithValue("@9", cbx_gender.Text.Trim());
                cmd.Parameters.AddWithValue("@10", txt_job.Text);
                cmd.Parameters.AddWithValue("@11", txt_agent.Text);
                cmd.Parameters.AddWithValue("@12", decimal.Parse(txt_total_amount.Text.Trim()));
                cmd.Parameters.AddWithValue("@13", decimal.Parse(txt_reach.Text.Trim()));
                cmd.Parameters.AddWithValue("@14", decimal.Parse(txt_remain.Text.Trim()));
                cmd.Parameters.AddWithValue("@15", txt_Work_permit_no.Text.Trim());
                cmd.Parameters.AddWithValue("@16", dt_Work_permit_date.Value);
                cmd.Parameters.AddWithValue("@17", txt_attr_no.Text.Trim());
                cmd.Parameters.AddWithValue("@18", dt_attr.Value);
                cmd.Parameters.AddWithValue("@19", ticketOrInsurance);               
                cmd.Parameters.AddWithValue("@20", txt_attr_suffix.Text.Trim());                
                cmd.Parameters.AddWithValue("@21", dt_attr_suffix.Value);
                cmd.Parameters.AddWithValue("@22", dt_enter_iraq.Value);
                cmd.Parameters.AddWithValue("@23", txt_test_result.Text.Trim());               
                cmd.Parameters.AddWithValue("@24", dt_test.Value);
                cmd.Parameters.AddWithValue("@25", dt_interview.Value);               
                cmd.Parameters.AddWithValue("@26", dt_accept.Value);
                cmd.Parameters.AddWithValue("@27", decimal.Parse(txt_fine.Text.Trim()));                
                cmd.Parameters.AddWithValue("@28", txt_type_fine.Text.Trim());               
                cmd.Parameters.AddWithValue("@29", txt_job_permit_no.Text.Trim());
                cmd.Parameters.AddWithValue("@30", dt_job_permit_date.Value);
                cmd.Parameters.AddWithValue("@31",dt_exp_permit_date.Value);
                cmd.Parameters.AddWithValue("@32", txt_residency_no.Text.Trim());
                cmd.Parameters.AddWithValue("@33", dt_issue_date.Value);
                cmd.Parameters.AddWithValue("@34", dt_exp_national.Value);
                cmd.Parameters.AddWithValue("@35", txt_guarantor1.Text.Trim());
                cmd.Parameters.AddWithValue("@36", txt_guarantor_mobile1.Text.Trim());
                cmd.Parameters.AddWithValue("@37", txt_guarantor_address1.Text.Trim());
                cmd.Parameters.AddWithValue("@38", txt_guarantor2.Text.Trim());
                cmd.Parameters.AddWithValue("@39", txt_guarantor_mobile2.Text.Trim());
                cmd.Parameters.AddWithValue("@40", txt_guarantor_address2.Text.Trim());
                cmd.Parameters.AddWithValue("@41", txt_guarantor3.Text.Trim());
                cmd.Parameters.AddWithValue("@42", txt_guarantor_mobile3.Text.Trim());
                cmd.Parameters.AddWithValue("@43", txt_guarantor_address3.Text.Trim());
                cmd.Parameters.AddWithValue("@44", txt_worker_mobile.Text.Trim());
                cmd.Parameters.AddWithValue("@45", dt_woker_recipt.Value);
                cmd.Parameters.AddWithValue("@46", txt_description.Text);
                
                cmd.ExecuteNonQuery();
                MessageBox.Show("تمت الاضافة بنجاح", "حفظ",MessageBoxButtons.OK,MessageBoxIcon.Information);
                ResetClear();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }


            
        }

        private bool isValid()
        {
            if (txt_no_request.Text =="")
            {
                MessageBox.Show("رقم الطلب مطلوب","خطأ",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txt_no_request.Focus();
                return false;
            }
            return true;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            ResetClear();
        }

        private void ResetClear()
        {
            getId = 0;
            txt_no_request.Clear();
            dt_request.DataBindings.Clear();
            txt_no_total.Clear();
            txt_arab.Clear();
            txt_foreign.Clear();
            txt_worker.Clear();
            txt_no_passport.Clear();
            txt_national.Clear();
            cbx_gender.DataBindings.Clear();
            txt_job.Clear();
            txt_agent.Clear();
            txt_total_amount.Clear();
            cbx_gender.Items.Clear();
            txt_reach.Clear();
            txt_remain.Clear();
            txt_Work_permit_no.Clear();
            dt_Work_permit_date.DataBindings.Clear();
            txt_attr_no.Clear();
            dt_attr.DataBindings.Clear();
            rdo_return_ticket.Checked = false;
            rdo_insurance.Checked = false;
            txt_attr_suffix.Clear();
            dt_attr_suffix.DataBindings.Clear();
            dt_enter_iraq.DataBindings.Clear();
            txt_test_result.Clear();
            dt_test.DataBindings.Clear();
            dt_interview.DataBindings.Clear();
            dt_accept.DataBindings.Clear();
            txt_fine.Clear();
            txt_type_fine.Clear();
            txt_job_permit_no.Clear();
            dt_job_permit_date.DataBindings.Clear();
            dt_exp_permit_date.DataBindings.Clear();
            txt_residency_no.Clear();
            dt_issue_date.DataBindings.Clear();
            dt_exp_national.DataBindings.Clear();
            txt_guarantor1.Clear();
            txt_guarantor_mobile1.Clear();
            txt_guarantor_address1.Clear();
            txt_guarantor2.Clear();
            txt_guarantor_mobile2.Clear();
            txt_guarantor_address2.Clear();
            txt_guarantor3.Clear();
            txt_guarantor_mobile3.Clear();
            txt_guarantor_address3.Clear();
            txt_worker_mobile.Clear();
            dt_woker_recipt.DataBindings.Clear();
            txt_description.Clear();
            txt_no_request.Focus();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                getId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                txt_no_request.Text = dataGridView1.SelectedRows[0].Cells["NoRequest"].Value.ToString();

                DateTime DateRequest = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["DateRequest"].Value.ToString());
                dt_request.Value = DateRequest;


                txt_no_total.Text = dataGridView1.SelectedRows[0].Cells["NoTotal"].Value.ToString();
                txt_arab.Text = dataGridView1.SelectedRows[0].Cells["NoArab"].Value.ToString();
                txt_foreign.Text = dataGridView1.SelectedRows[0].Cells["NoForeign"].Value.ToString();
                txt_worker.Text = dataGridView1.SelectedRows[0].Cells["WorkerName"].Value.ToString();
                txt_no_passport.Text = dataGridView1.SelectedRows[0].Cells["NoPassport"].Value.ToString();
                txt_national.Text = dataGridView1.SelectedRows[0].Cells["NationalType"].Value.ToString();

                cbx_gender.Text = dataGridView1.SelectedRows[0].Cells["Gender"].Value.ToString();
                cbx_gender.Items.Add(cbx_gender.Text);
                //cbx_gender.Text = 1;

                txt_job.Text = dataGridView1.SelectedRows[0].Cells["Job"].Value.ToString();
                txt_agent.Text = dataGridView1.SelectedRows[0].Cells["AgentName"].Value.ToString();
                txt_total_amount.Text = dataGridView1.SelectedRows[0].Cells["TotalAmount"].Value.ToString();
                txt_reach.Text = dataGridView1.SelectedRows[0].Cells["ReachAmount"].Value.ToString();
                txt_remain.Text = dataGridView1.SelectedRows[0].Cells["RemainAmount"].Value.ToString();
                txt_Work_permit_no.Text = dataGridView1.SelectedRows[0].Cells["NoWorkPermit"].Value.ToString();


                DateTime DateWorkPermit = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["DateWorkPermit"].Value.ToString());
                dt_Work_permit_date.Value = DateWorkPermit;

                txt_attr_no.Text = dataGridView1.SelectedRows[0].Cells["NoAttr"].Value.ToString();
                DateTime DateAttr = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["DateAttr"].Value.ToString());
                dt_attr.Value = DateAttr;

                string checkTicket = dataGridView1.SelectedRows[0].Cells["TicketOrInsurance"].Value.ToString();
                if (checkTicket == "تذكرة عودة")
                {
                    rdo_return_ticket.Checked = true;
                }
                else
                {
                    rdo_insurance.Checked = true;
                }

                txt_attr_suffix.Text = dataGridView1.SelectedRows[0].Cells["NoAttrSuffix"].Value.ToString();
                DateTime DateAttrSuffix = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["DateAttrSuffix"].Value.ToString());
                dt_attr_suffix.Value = DateAttrSuffix;

                DateTime DateEnterIraq = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["DateEnterIraq"].Value.ToString());
                dt_enter_iraq.Value = DateEnterIraq;

                txt_test_result.Text = dataGridView1.SelectedRows[0].Cells["TestReslt"].Value.ToString();
                DateTime DateTest = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["DateTest"].Value.ToString());
                dt_test.Value = DateTest;
                DateTime DateInterview = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["DateInterview"].Value.ToString());
                dt_interview.Value = DateInterview;
                DateTime DateAccept = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["DateAccept"].Value.ToString());
                dt_accept.Value = DateAccept;
                txt_fine.Text = dataGridView1.SelectedRows[0].Cells["FineAmount"].Value.ToString();
                txt_type_fine.Text = dataGridView1.SelectedRows[0].Cells["FineType"].Value.ToString();
                txt_job_permit_no.Text = dataGridView1.SelectedRows[0].Cells["NoJobPermit"].Value.ToString();
                DateTime DateJobPermit = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["DateJobPermit"].Value.ToString());

                dt_job_permit_date.Value = DateJobPermit;
                DateTime DateExpPermit = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["DateExpPermit"].Value.ToString());
                dt_exp_permit_date.Value = DateExpPermit;
                txt_residency_no.Text = dataGridView1.SelectedRows[0].Cells["NoResidency"].Value.ToString();
                DateTime DateIssue = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["DateIssue"].Value.ToString());

                dt_issue_date.Value = DateIssue;
                DateTime DateExpNational = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["DateExpNational"].Value.ToString());
                dt_exp_national.Value = DateExpNational;

                txt_guarantor1.Text = dataGridView1.SelectedRows[0].Cells["GuarantorName1"].Value.ToString();
                txt_guarantor_mobile1.Text = dataGridView1.SelectedRows[0].Cells["GuarantorMobile1"].Value.ToString();
                txt_guarantor_address1.Text = dataGridView1.SelectedRows[0].Cells["GuarantorAddress1"].Value.ToString();
                txt_guarantor2.Text = dataGridView1.SelectedRows[0].Cells["GuarantorName2"].Value.ToString();
                txt_guarantor_mobile2.Text = dataGridView1.SelectedRows[0].Cells["GuarantorMobile2"].Value.ToString();
                txt_guarantor_address2.Text = dataGridView1.SelectedRows[0].Cells["GuarantorAddress2"].Value.ToString();
                txt_guarantor3.Text = dataGridView1.SelectedRows[0].Cells["GuarantorName3"].Value.ToString();
                txt_guarantor_mobile3.Text = dataGridView1.SelectedRows[0].Cells["GuarantorMobile3"].Value.ToString();
                txt_guarantor_address3.Text = dataGridView1.SelectedRows[0].Cells["GuarantorAddress"].Value.ToString();

                txt_worker_mobile.Text = dataGridView1.SelectedRows[0].Cells["NoWorkerMobile"].Value.ToString();
                DateTime DateWorkerRecipt = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["DateWorkerRecipt"].Value.ToString());

                dt_woker_recipt.Value = DateWorkerRecipt;
                txt_description.Text = dataGridView1.SelectedRows[0].Cells["Description"].Value.ToString();
                txt_no_request.Focus();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            LoadToGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (getId > 0)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Table_files SET NoRequest = @1,DateRequest = @2,NoTotal = @3" +
                        ",NoArab = @4,NoForeign = @5,WorkerName = @6,NoPassport = @7,NationalType = @8,Gender = @9,Job = @10" +
                        ",AgentName = @11,TotalAmount = @12,ReachAmount = @13,RemainAmount = @14,NoWorkPermit = @15,DateWorkPermit = @16" +
                        ",NoAttr = @17,DateAttr = @18,TicketOrInsurance = @19,NoAttrSuffix = @20,DateAttrSuffix = @21,DateEnterIraq = @22" +
                        ",TestReslt = @23,DateTest = @24,DateInterview = @25,DateAccept = @26,FineAmount = @27,FineType = @28,NoJobPermit =@29" +
                        ",DateJobPermit = @30,DateExpPermit = @31,NoResidency = @32,DateIssue = @33,DateExpNational = @34,GuarantorName1 = @35" +
                        ",GuarantorMobile1 = @36,GuarantorAddress1 = @37,GuarantorName2 = @38,GuarantorMobile2 = @39,GuarantorAddress2 = @40" +
                        ",GuarantorName3 = @41,GuarantorMobile3 = @42,GuarantorAddress = @43,NoWorkerMobile = @44,DateWorkerRecipt = @45" +
                        ",Description = @46 WHERE ID = @ID", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@1", txt_no_request.Text);
                    cmd.Parameters.AddWithValue("@2", dt_request.Value);
                    cmd.Parameters.AddWithValue("@3", int.Parse(txt_no_total.Text));
                    cmd.Parameters.AddWithValue("@4", int.Parse(txt_arab.Text));
                    cmd.Parameters.AddWithValue("@5", int.Parse(txt_foreign.Text));
                    cmd.Parameters.AddWithValue("@6", txt_worker.Text);
                    cmd.Parameters.AddWithValue("@7", txt_no_passport.Text);
                    cmd.Parameters.AddWithValue("@8", txt_national.Text);
                    cmd.Parameters.AddWithValue("@9", cbx_gender.Text);
                    cmd.Parameters.AddWithValue("@10", txt_job.Text);
                    cmd.Parameters.AddWithValue("@11", txt_agent.Text);
                    cmd.Parameters.AddWithValue("@12", decimal.Parse(txt_total_amount.Text));
                    cmd.Parameters.AddWithValue("@13", decimal.Parse(txt_reach.Text));
                    cmd.Parameters.AddWithValue("@14", decimal.Parse(txt_remain.Text));
                    cmd.Parameters.AddWithValue("@15", txt_Work_permit_no.Text);
                    cmd.Parameters.AddWithValue("@16", dt_Work_permit_date.Value);
                    cmd.Parameters.AddWithValue("@17", txt_attr_no.Text);
                    cmd.Parameters.AddWithValue("@18", dt_attr.Value);
                    cmd.Parameters.AddWithValue("@19", ticketOrInsurance);
                    cmd.Parameters.AddWithValue("@20", txt_attr_suffix.Text);
                    cmd.Parameters.AddWithValue("@21", dt_attr_suffix.Value);
                    cmd.Parameters.AddWithValue("@22", dt_enter_iraq.Value);
                    cmd.Parameters.AddWithValue("@23", txt_test_result.Text);
                    cmd.Parameters.AddWithValue("@24", dt_test.Value);
                    cmd.Parameters.AddWithValue("@25", dt_interview.Value);
                    cmd.Parameters.AddWithValue("@26", dt_accept.Value);
                    cmd.Parameters.AddWithValue("@27", decimal.Parse(txt_fine.Text));
                    cmd.Parameters.AddWithValue("@28", txt_type_fine.Text);
                    cmd.Parameters.AddWithValue("@29", txt_job_permit_no.Text);
                    cmd.Parameters.AddWithValue("@30", dt_job_permit_date.Value);
                    cmd.Parameters.AddWithValue("@31", dt_exp_permit_date.Value);
                    cmd.Parameters.AddWithValue("@32", txt_residency_no.Text);
                    cmd.Parameters.AddWithValue("@33", dt_issue_date.Value);
                    cmd.Parameters.AddWithValue("@34", dt_exp_national.Value);
                    cmd.Parameters.AddWithValue("@35", txt_guarantor1.Text);
                    cmd.Parameters.AddWithValue("@36", txt_guarantor_mobile1.Text);
                    cmd.Parameters.AddWithValue("@37", txt_guarantor_address1.Text);
                    cmd.Parameters.AddWithValue("@38", txt_guarantor2.Text);
                    cmd.Parameters.AddWithValue("@39", txt_guarantor_mobile2.Text);
                    cmd.Parameters.AddWithValue("@40", txt_guarantor_address2.Text);
                    cmd.Parameters.AddWithValue("@41", txt_guarantor3.Text);
                    cmd.Parameters.AddWithValue("@42", txt_guarantor_mobile3.Text);
                    cmd.Parameters.AddWithValue("@43", txt_guarantor_address3.Text);
                    cmd.Parameters.AddWithValue("@44", txt_worker_mobile.Text);
                    cmd.Parameters.AddWithValue("@45", dt_woker_recipt.Value);
                    cmd.Parameters.AddWithValue("@46", txt_description.Text);
                    cmd.Parameters.AddWithValue("@ID", this.getId);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("تمت التعديل بنجاح", "تحديث", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetClear();
                }
                else
                {
                    MessageBox.Show("اختر من شاشة العرض", "اختر", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل انت متأكد من الحذف؟ ", "حذف اضبارة", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (getId > 0)
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("Delete From Table_files WHERE ID = @ID", con);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@ID", this.getId);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("تمت الحذف بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetClear();
                    }
                    else
                    {
                        MessageBox.Show("اختر من شاشة العرض", "اختر", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error Message");
            }
        }
    }
}

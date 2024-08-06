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
using Guna.UI2.WinForms;

namespace system.adminForms
{
    public partial class formScheduleRecords : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;

        private Form activeForm;
        public formScheduleRecords()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelSchedule.Controls.Add(childForm);
            this.panelSchedule.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

       

        private void btnRlrlc_Click(object sender, EventArgs e)
        {
            GetApprovedScheduleRecord();
        }

        private void panelSchedule_Paint(object sender, PaintEventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=inventory;Integrated Security=True");
            cn.Open();
            GetAllScheduleRecord();
        }
        private void GetAllScheduleRecord()
        {
            cmd = new SqlCommand("Select * From schedule", cn);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewSchedule2.DataSource = dt;
        }
        private void GetApprovedScheduleRecord()
        {
            cmd = new SqlCommand("Select * From schedule where reports ='approved'", cn);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewSchedule2.DataSource = dt;
        }
        private void GetDeniedScheduleRecord()
        {
            cmd = new SqlCommand("Select * From schedule where reports ='denied'", cn);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewSchedule2.DataSource = dt;
        }
        private void GetPendingScheduleRecord()
        {
            cmd = new SqlCommand("Select * From schedule where reports ='pending'", cn);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewSchedule2.DataSource = dt;
        }

        private void btnDenied_Click(object sender, EventArgs e)
        {
            GetDeniedScheduleRecord();
        }

        private void btnPending_Click(object sender, EventArgs e)
        {
            GetPendingScheduleRecord();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("Select * From schedule where roomNumber = " + guna2TextBox3.Text, cn);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewSchedule2.DataSource = dt;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            UpdateInfo();
            GetAllScheduleRecord();
        }
        protected void UpdateInfo()
        {
            string QUERY = "Update schedule Set reports = @reports, adminComments = @adminComments, renovationStatus = @renovationStatus where roomNumber = @roomNumber";
            SqlCommand CMD = new SqlCommand(QUERY, cn);
            CMD.Parameters.AddWithValue("@roomNumber", guna2TextBox3.Text);
            CMD.Parameters.AddWithValue("@reports", guna2ComboBox2.SelectedItem);
            CMD.Parameters.AddWithValue("@adminComments", textBox1.Text);
            CMD.Parameters.AddWithValue("@renovationStatus", guna2ComboBox1.SelectedItem);
            CMD.ExecuteNonQuery();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DeleteInfo();
            GetAllScheduleRecord();
        }
        protected void DeleteInfo()
        {
            string QUERY = "Delete from schedule where roomNumber = @roomNumber";
            SqlCommand CMD = new SqlCommand(QUERY, cn);
            CMD.Parameters.AddWithValue("@roomNumber", guna2TextBox3.Text);
            CMD.ExecuteNonQuery();
        }
    }
}

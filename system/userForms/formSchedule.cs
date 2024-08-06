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

namespace system.userForms
{
    public partial class formSchedule : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;

        private Form activeForm;
        public formSchedule()
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (guna2TextBox3.Text != "" && guna2TextBox1.Text != "")
            {
                SaveInfo();
                GetAllScheduleRecord();

            }
            else
            {
                MessageBox.Show("Room Number and User Id should not be empty.");
                guna2TextBox1.Focus();
            }
        }
        protected void SaveInfo()
        {
            string QUERY = "INSERT INTO schedule" +
            "(userId, facilityType, roomNumber, spaceType, desciriptionOfReport)" +
            "VALUES (@userId, @facilityType, @roomNumber, @spacetype, @desciriptionOfReport)";


            SqlCommand CMD = new SqlCommand(QUERY, cn);
            CMD.Parameters.AddWithValue("@userId", guna2TextBox1.Text);
            CMD.Parameters.AddWithValue("@facilityType", guna2ComboBox1.SelectedItem);
            CMD.Parameters.AddWithValue("@roomNumber", guna2TextBox3.Text);
            CMD.Parameters.AddWithValue("@spaceType", guna2ComboBox2.SelectedItem);
            CMD.Parameters.AddWithValue("@desciriptionOfReport", textBox1.Text);
            CMD.ExecuteNonQuery();
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

        private void btnPending_Click(object sender, EventArgs e)
        {
            GetPendingScheduleRecord();
        }

        private void btnDenied_Click(object sender, EventArgs e)
        {
            GetDeniedScheduleRecord();
        }

        private void btnApproved_Click(object sender, EventArgs e)
        {
            GetApprovedScheduleRecord();
        }
    }
}

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


namespace system.userForms.BuildingandFacilitiesForms
{
    public partial class formMainBuilding : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        string facilityType = "main building";

        private Form activeForm;
        public formMainBuilding()
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
            this.panelMainBuildingTable.Controls.Add(childForm);
            this.panelMainBuildingTable.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text != "")
            {
                SaveInfo();
                GetAllFacilityRecord();

            }
            else
            {
                MessageBox.Show("Room Number should not be empty.");
                guna2TextBox1.Focus();
            }
        }

        private void panelMainBuildingTable_Paint(object sender, PaintEventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=inventory;Integrated Security=True");
            cn.Open();
            GetAllFacilityRecord();
        }
        private void GetAllFacilityRecord()
        {
            cmd = new SqlCommand("Select * From facility where facilityType='rlrc'", cn);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewFacility2.DataSource = dt;
        }
        protected void SaveInfo()
        {
            string QUERY = "INSERT INTO facility" +
            "(roomNumber, facilityType, spaceType, status, description, remarks)" +
            "VALUES (@roomNumber, @facilityType, @spaceType, @status, @description, @remarks)";


            SqlCommand CMD = new SqlCommand(QUERY, cn);
            CMD.Parameters.AddWithValue("@roomNumber", guna2TextBox1.Text);
            CMD.Parameters.AddWithValue("@facilityType", facilityType);
            CMD.Parameters.AddWithValue("@spaceType", guna2ComboBox1.SelectedItem);
            CMD.Parameters.AddWithValue("@status", guna2ComboBox2.SelectedItem);
            CMD.Parameters.AddWithValue("@description", guna2TextBox2.Text);
            CMD.Parameters.AddWithValue("@remarks", textBox1.Text);
            CMD.ExecuteNonQuery();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("Select * From facility where roomNumber=" + guna2TextBox1.Text, cn);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewFacility2.DataSource = dt;


        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            UpdateInfo();
            GetAllFacilityRecord(); 
        }
        protected void UpdateInfo()
        {
            string QUERY = "Update facility Set spaceType = @spaceType, status = @status, description = @description, remarks = @remarks where roomNumber = @roomNumber";
            SqlCommand CMD = new SqlCommand(QUERY, cn);
            CMD.Parameters.AddWithValue("@roomNumber", guna2TextBox1.Text);
            CMD.Parameters.AddWithValue("@spaceType", guna2ComboBox1.SelectedItem);
            CMD.Parameters.AddWithValue("@status", guna2ComboBox2.SelectedItem);
            CMD.Parameters.AddWithValue("@description", guna2TextBox2.Text);
            CMD.Parameters.AddWithValue("@remarks", textBox1.Text);
            CMD.ExecuteNonQuery();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DeleteInfo();
            GetAllFacilityRecord();
        }
        protected void DeleteInfo()
        {
            string QUERY = "Delete from facility where roomNumber = @roomNumber";
            SqlCommand CMD = new SqlCommand(QUERY, cn);
            CMD.Parameters.AddWithValue("@roomNumber", guna2TextBox1.Text);
            CMD.ExecuteNonQuery();
        }
    }
}

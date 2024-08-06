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

namespace system.adminForms
{
    public partial class formFacilitiesRecords : Form
    {

        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;

        private Form activeForm;
        public formFacilitiesRecords()
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
            this.panelFacilitiesRecordsDashboard.Controls.Add(childForm);
            this.panelFacilitiesRecordsDashboard.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnRlrlc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new adminForms.FacilitiesRecordsForms.formRlrlcRecords(), sender);
        }

        private void btnStudentCenter_Click(object sender, EventArgs e)
        {
            OpenChildForm(new adminForms.FacilitiesRecordsForms.formStudentCenterRecords(), sender);
        }

        private void btnMainBuilding_Click(object sender, EventArgs e)
        {
            OpenChildForm(new adminForms.FacilitiesRecordsForms.formMainBuildingRecords(), sender);
        }

        private void btnOthers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new adminForms.FacilitiesRecordsForms.formOthersFacilitiesRecords(), sender);
        }

        private void panelFacilitiesRecordsDashboard_Paint(object sender, PaintEventArgs e)
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
    }
}

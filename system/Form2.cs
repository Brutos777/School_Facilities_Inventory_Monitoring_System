using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace system
{
    public partial class Form2 : Form
    {
        private Form activeForm;
        bool sidebarExpand;
        public Form2()
        {
            InitializeComponent();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                //if sidebar expand, minimize
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void pictureBoxMenu_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelAdminDashboard.Controls.Add(childForm);
            this.panelAdminDashboard.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle1.Text = childForm.Text;
        }

        private void btnFacilitiesRecords_Click(object sender, EventArgs e)
        {
            OpenChildForm(new adminForms.formFacilitiesRecords(), sender);
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            OpenChildForm(new adminForms.formScheduleRecords(), sender);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new adminForms.formUsersRecords(), sender);
        }

        private void OpenChildForm1(Form childForm, object btnSender)
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
            OpenChildForm1(new adminForms.FacilitiesRecordsForms.formRlrlcRecords(), sender);
        }

        private void btnStudentCenter_Click(object sender, EventArgs e)
        {
            OpenChildForm1(new adminForms.FacilitiesRecordsForms.formStudentCenterRecords(), sender);
        }

        private void btnMainBuilding_Click(object sender, EventArgs e)
        {
            OpenChildForm1(new adminForms.FacilitiesRecordsForms.formMainBuildingRecords(), sender);
        }

        private void btnOthers_Click(object sender, EventArgs e)
        {
            OpenChildForm1(new adminForms.FacilitiesRecordsForms.formOthersFacilitiesRecords(), sender);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to logout?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Form1 frm1 = new Form1();
                frm1.Show();
            }
        }
    }
}

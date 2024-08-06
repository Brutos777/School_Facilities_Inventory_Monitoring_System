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
    public partial class Form3 : Form
    {
        private Form activeForm;
        bool sidebarExpand;
        public Form3()
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
            this.panelUserDashboard.Controls.Add(childForm);
            this.panelUserDashboard.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle1.Text = childForm.Text;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new userForms.formHome(), sender);
        }

        private void btnBuilding_Click(object sender, EventArgs e)
        {
            OpenChildForm(new userForms.formBuildingandFacilities(), sender);
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            OpenChildForm(new userForms.formSchedule(), sender);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to logout?", "Question",  MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Form1 frm1 = new Form1();
                frm1.Show();
            }
        }
    }
}

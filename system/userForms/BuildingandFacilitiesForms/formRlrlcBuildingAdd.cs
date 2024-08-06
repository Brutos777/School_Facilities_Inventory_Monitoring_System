using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace system.userForms.BuildingandFacilitiesForms
{
    public partial class formRlrlcBuildingAdd : Form
    {
        private Form activeForm;
        public formRlrlcBuildingAdd()
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
            this.panelRlrlcAdd.Controls.Add(childForm);
            this.panelRlrlcAdd.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new userForms.BuildingandFacilitiesForms.formRlrlcBuilding(), sender);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace system.adminForms.FacilitiesRecordsForms
{
    public partial class formMainBuildingRecordsAdd : Form
    {
        private Form activeForm;
        public formMainBuildingRecordsAdd()
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
            this.panelMainBuildingAdd.Controls.Add(childForm);
            this.panelMainBuildingAdd.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            OpenChildForm(new adminForms.FacilitiesRecordsForms.formMainBuildingRecords(), sender);
        }
    }
}

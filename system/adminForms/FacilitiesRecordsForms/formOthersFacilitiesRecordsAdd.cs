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
    public partial class formOthersFacilitiesRecordsAdd : Form
    {
        private Form activeForm;
        public formOthersFacilitiesRecordsAdd()
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
            this.panelOthersAdd.Controls.Add(childForm);
            this.panelOthersAdd.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            OpenChildForm(new adminForms.FacilitiesRecordsForms.formOthersFacilitiesRecords(), sender);
        }
    }
}

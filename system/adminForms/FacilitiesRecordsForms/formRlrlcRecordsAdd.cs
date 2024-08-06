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
    public partial class formRlrlcRecordsAdd : Form
    {
        private Form activeForm;
        public formRlrlcRecordsAdd()
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
            this.panelRlrlcRecordsAdd.Controls.Add(childForm);
            this.panelRlrlcRecordsAdd.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnCnl_Click(object sender, EventArgs e)
        {
            OpenChildForm(new adminForms.FacilitiesRecordsForms.formRlrlcRecords(), sender);
        }
    }
}

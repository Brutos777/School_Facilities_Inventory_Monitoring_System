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
    public partial class formStudentCenterRecordsAdd : Form
    {
        private Form activeForm;
        public formStudentCenterRecordsAdd()
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
            this.panelStudentCenterRecordsAdd.Controls.Add(childForm);
            this.panelStudentCenterRecordsAdd.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnCnl_Click(object sender, EventArgs e)
        {
            OpenChildForm(new adminForms.FacilitiesRecordsForms.formStudentCenterRecords(), sender);
        }
    }
}

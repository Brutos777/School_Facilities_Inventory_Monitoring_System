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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
            {
                this.Hide();
                Form2 frm2 = new Form2();
                frm2.Show();
            } else
            {
                this.Hide();
                Form3 frm3 = new Form3();
                frm3.Show();
            }
            
        }

        private void linkLabelRegisterPanel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelRegister.BringToFront();
        }

        private void linkLabelLoginPanel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelLogin.BringToFront();
            
        }
    }
}

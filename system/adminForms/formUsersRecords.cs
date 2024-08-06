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
using Guna.UI2.WinForms;

namespace system.adminForms
{
    public partial class formUsersRecords : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        public formUsersRecords()
        {
            InitializeComponent();
        }

        private void panelSchedule_Paint(object sender, PaintEventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=inventory;Integrated Security=True");
            cn.Open();
            GetAllUserRecord();
        }
        private void GetAllUserRecord()
        {
            cmd = new SqlCommand("Select * From users", cn);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewUser2.DataSource = dt;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("Select * From users where userId=" + guna2TextBox3.Text, cn);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewUser2.DataSource = dt;
        }
    }
}

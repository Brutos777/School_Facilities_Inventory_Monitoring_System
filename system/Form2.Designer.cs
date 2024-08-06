namespace system
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxMenu = new System.Windows.Forms.PictureBox();
            this.btnFacilitiesRecords = new Guna.UI2.WinForms.Guna2Button();
            this.btnSchedule = new Guna.UI2.WinForms.Guna2Button();
            this.btnUsers = new Guna.UI2.WinForms.Guna2Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.panelAdminDashboard = new System.Windows.Forms.Panel();
            this.panelFacilitiesRecords = new System.Windows.Forms.Panel();
            this.panelFacilitiesRecordsDashboard = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnOthers = new Guna.UI2.WinForms.Guna2Button();
            this.btnMainBuilding = new Guna.UI2.WinForms.Guna2Button();
            this.btnStudentCenter = new Guna.UI2.WinForms.Guna2Button();
            this.btnRlrlc = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelAdminDashboard.SuspendLayout();
            this.panelFacilitiesRecords.SuspendLayout();
            this.panelFacilitiesRecordsDashboard.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.btnFacilitiesRecords);
            this.sidebar.Controls.Add(this.btnSchedule);
            this.sidebar.Controls.Add(this.btnUsers);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.btnLogout);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(170, 691);
            this.sidebar.MinimumSize = new System.Drawing.Size(61, 691);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(61, 691);
            this.sidebar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBoxMenu);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 68);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(58, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menu";
            // 
            // pictureBoxMenu
            // 
            this.pictureBoxMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMenu.Image = global::system.Properties.Resources.icons8_menu_96;
            this.pictureBoxMenu.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxMenu.Name = "pictureBoxMenu";
            this.pictureBoxMenu.Size = new System.Drawing.Size(49, 51);
            this.pictureBoxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMenu.TabIndex = 0;
            this.pictureBoxMenu.TabStop = false;
            this.pictureBoxMenu.Click += new System.EventHandler(this.pictureBoxMenu_Click);
            // 
            // btnFacilitiesRecords
            // 
            this.btnFacilitiesRecords.Animated = true;
            this.btnFacilitiesRecords.BackColor = System.Drawing.Color.Transparent;
            this.btnFacilitiesRecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFacilitiesRecords.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFacilitiesRecords.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFacilitiesRecords.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFacilitiesRecords.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFacilitiesRecords.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.btnFacilitiesRecords.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFacilitiesRecords.ForeColor = System.Drawing.Color.White;
            this.btnFacilitiesRecords.Image = global::system.Properties.Resources.icons8_school_building_90__1_;
            this.btnFacilitiesRecords.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFacilitiesRecords.ImageSize = new System.Drawing.Size(40, 40);
            this.btnFacilitiesRecords.Location = new System.Drawing.Point(3, 77);
            this.btnFacilitiesRecords.Name = "btnFacilitiesRecords";
            this.btnFacilitiesRecords.Size = new System.Drawing.Size(167, 62);
            this.btnFacilitiesRecords.TabIndex = 2;
            this.btnFacilitiesRecords.Text = "Facilities Records";
            this.btnFacilitiesRecords.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnFacilitiesRecords.Click += new System.EventHandler(this.btnFacilitiesRecords_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSchedule.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSchedule.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSchedule.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSchedule.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSchedule.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.btnSchedule.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSchedule.ForeColor = System.Drawing.Color.White;
            this.btnSchedule.Image = global::system.Properties.Resources.icons8_test_results_100_1;
            this.btnSchedule.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSchedule.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSchedule.Location = new System.Drawing.Point(3, 145);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(167, 62);
            this.btnSchedule.TabIndex = 3;
            this.btnSchedule.Text = "  Schedule";
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUsers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Image = global::system.Properties.Resources.icons8_home_page_90;
            this.btnUsers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUsers.ImageSize = new System.Drawing.Size(40, 40);
            this.btnUsers.Location = new System.Drawing.Point(3, 213);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(167, 62);
            this.btnUsers.TabIndex = 1;
            this.btnUsers.Text = "Users";
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(3, 281);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(62, 298);
            this.panel4.TabIndex = 5;
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::system.Properties.Resources.icons8_logout_rounded_left_90_1;
            this.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.ImageSize = new System.Drawing.Size(40, 40);
            this.btnLogout.Location = new System.Drawing.Point(3, 585);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(167, 62);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 1;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.guna2CirclePictureBox1);
            this.panel2.Controls.Add(this.lblTitle1);
            this.panel2.Location = new System.Drawing.Point(67, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1078, 63);
            this.panel2.TabIndex = 1;
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle1.ForeColor = System.Drawing.Color.White;
            this.lblTitle1.Location = new System.Drawing.Point(489, 14);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(105, 30);
            this.lblTitle1.TabIndex = 0;
            this.lblTitle1.Text = "RECORDS";
            // 
            // panelAdminDashboard
            // 
            this.panelAdminDashboard.BackColor = System.Drawing.SystemColors.Control;
            this.panelAdminDashboard.Controls.Add(this.panelFacilitiesRecords);
            this.panelAdminDashboard.Location = new System.Drawing.Point(67, 69);
            this.panelAdminDashboard.Name = "panelAdminDashboard";
            this.panelAdminDashboard.Size = new System.Drawing.Size(1078, 583);
            this.panelAdminDashboard.TabIndex = 2;
            // 
            // panelFacilitiesRecords
            // 
            this.panelFacilitiesRecords.Controls.Add(this.panelFacilitiesRecordsDashboard);
            this.panelFacilitiesRecords.Controls.Add(this.panel3);
            this.panelFacilitiesRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFacilitiesRecords.Location = new System.Drawing.Point(0, 0);
            this.panelFacilitiesRecords.Name = "panelFacilitiesRecords";
            this.panelFacilitiesRecords.Size = new System.Drawing.Size(1078, 583);
            this.panelFacilitiesRecords.TabIndex = 4;
            // 
            // panelFacilitiesRecordsDashboard
            // 
            this.panelFacilitiesRecordsDashboard.Controls.Add(this.label2);
            this.panelFacilitiesRecordsDashboard.Location = new System.Drawing.Point(3, 69);
            this.panelFacilitiesRecordsDashboard.Name = "panelFacilitiesRecordsDashboard";
            this.panelFacilitiesRecordsDashboard.Size = new System.Drawing.Size(1072, 514);
            this.panelFacilitiesRecordsDashboard.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(358, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select a Facility Above";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.btnOthers);
            this.panel3.Controls.Add(this.btnMainBuilding);
            this.panel3.Controls.Add(this.btnStudentCenter);
            this.panel3.Controls.Add(this.btnRlrlc);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1072, 74);
            this.panel3.TabIndex = 0;
            // 
            // btnOthers
            // 
            this.btnOthers.Animated = true;
            this.btnOthers.BorderRadius = 20;
            this.btnOthers.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnOthers.CheckedState.FillColor = System.Drawing.Color.Gray;
            this.btnOthers.CheckedState.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOthers.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnOthers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOthers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOthers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOthers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOthers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOthers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.btnOthers.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnOthers.ForeColor = System.Drawing.Color.White;
            this.btnOthers.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnOthers.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOthers.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnOthers.Location = new System.Drawing.Point(540, 9);
            this.btnOthers.Name = "btnOthers";
            this.btnOthers.Size = new System.Drawing.Size(160, 51);
            this.btnOthers.TabIndex = 5;
            this.btnOthers.Text = "Other Facilities";
            this.btnOthers.Click += new System.EventHandler(this.btnOthers_Click);
            // 
            // btnMainBuilding
            // 
            this.btnMainBuilding.Animated = true;
            this.btnMainBuilding.BorderRadius = 20;
            this.btnMainBuilding.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnMainBuilding.CheckedState.FillColor = System.Drawing.Color.Gray;
            this.btnMainBuilding.CheckedState.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainBuilding.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnMainBuilding.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainBuilding.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMainBuilding.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMainBuilding.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMainBuilding.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMainBuilding.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.btnMainBuilding.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnMainBuilding.ForeColor = System.Drawing.Color.White;
            this.btnMainBuilding.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnMainBuilding.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainBuilding.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnMainBuilding.Location = new System.Drawing.Point(364, 9);
            this.btnMainBuilding.Name = "btnMainBuilding";
            this.btnMainBuilding.Size = new System.Drawing.Size(160, 51);
            this.btnMainBuilding.TabIndex = 3;
            this.btnMainBuilding.Text = "Main Building";
            this.btnMainBuilding.Click += new System.EventHandler(this.btnMainBuilding_Click);
            // 
            // btnStudentCenter
            // 
            this.btnStudentCenter.Animated = true;
            this.btnStudentCenter.BorderRadius = 20;
            this.btnStudentCenter.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnStudentCenter.CheckedState.FillColor = System.Drawing.Color.Gray;
            this.btnStudentCenter.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnStudentCenter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudentCenter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStudentCenter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStudentCenter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStudentCenter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStudentCenter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.btnStudentCenter.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnStudentCenter.ForeColor = System.Drawing.Color.White;
            this.btnStudentCenter.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnStudentCenter.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentCenter.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnStudentCenter.Location = new System.Drawing.Point(186, 9);
            this.btnStudentCenter.Name = "btnStudentCenter";
            this.btnStudentCenter.Size = new System.Drawing.Size(160, 51);
            this.btnStudentCenter.TabIndex = 2;
            this.btnStudentCenter.Text = "Student Center";
            this.btnStudentCenter.Click += new System.EventHandler(this.btnStudentCenter_Click);
            // 
            // btnRlrlc
            // 
            this.btnRlrlc.Animated = true;
            this.btnRlrlc.BorderRadius = 20;
            this.btnRlrlc.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnRlrlc.CheckedState.FillColor = System.Drawing.Color.Gray;
            this.btnRlrlc.CheckedState.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRlrlc.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnRlrlc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRlrlc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRlrlc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRlrlc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRlrlc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRlrlc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.btnRlrlc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnRlrlc.ForeColor = System.Drawing.Color.White;
            this.btnRlrlc.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnRlrlc.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRlrlc.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnRlrlc.Location = new System.Drawing.Point(9, 9);
            this.btnRlrlc.Name = "btnRlrlc";
            this.btnRlrlc.Size = new System.Drawing.Size(160, 51);
            this.btnRlrlc.TabIndex = 1;
            this.btnRlrlc.Text = "RLRLC Building";
            this.btnRlrlc.Click += new System.EventHandler(this.btnRlrlc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(52, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Admin";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(0, 6);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(46, 45);
            this.guna2CirclePictureBox1.TabIndex = 4;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1143, 652);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelAdminDashboard);
            this.Name = "Form2";
            this.Text = "Admin";
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelAdminDashboard.ResumeLayout(false);
            this.panelFacilitiesRecords.ResumeLayout(false);
            this.panelFacilitiesRecordsDashboard.ResumeLayout(false);
            this.panelFacilitiesRecordsDashboard.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxMenu;
        private System.Windows.Forms.Timer sidebarTimer;
        private Guna.UI2.WinForms.Guna2Button btnUsers;
        private Guna.UI2.WinForms.Guna2Button btnFacilitiesRecords;
        private Guna.UI2.WinForms.Guna2Button btnSchedule;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelAdminDashboard;
        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.Panel panelFacilitiesRecords;
        private System.Windows.Forms.Panel panelFacilitiesRecordsDashboard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button btnOthers;
        private Guna.UI2.WinForms.Guna2Button btnMainBuilding;
        private Guna.UI2.WinForms.Guna2Button btnStudentCenter;
        private Guna.UI2.WinForms.Guna2Button btnRlrlc;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
    }
}
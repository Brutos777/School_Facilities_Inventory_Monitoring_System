﻿namespace system.userForms
{
    partial class formBuildingandFacilities
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
            this.panelBuildingDashboard = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBuildingandFacilities = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOthers = new Guna.UI2.WinForms.Guna2Button();
            this.btnMainBuilding = new Guna.UI2.WinForms.Guna2Button();
            this.btnStudentCenter = new Guna.UI2.WinForms.Guna2Button();
            this.btnRlrlc = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridViewFacility2 = new System.Windows.Forms.DataGridView();
            this.panelBuildingDashboard.SuspendLayout();
            this.panelBuildingandFacilities.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFacility2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBuildingDashboard
            // 
            this.panelBuildingDashboard.Controls.Add(this.dataGridViewFacility2);
            this.panelBuildingDashboard.Controls.Add(this.label1);
            this.panelBuildingDashboard.Location = new System.Drawing.Point(4, 85);
            this.panelBuildingDashboard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelBuildingDashboard.Name = "panelBuildingDashboard";
            this.panelBuildingDashboard.Size = new System.Drawing.Size(1429, 629);
            this.panelBuildingDashboard.TabIndex = 1;
            this.panelBuildingDashboard.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBuildingDashboard_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(477, 214);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a Facility Above";
            // 
            // panelBuildingandFacilities
            // 
            this.panelBuildingandFacilities.Controls.Add(this.panelBuildingDashboard);
            this.panelBuildingandFacilities.Controls.Add(this.panel1);
            this.panelBuildingandFacilities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBuildingandFacilities.Location = new System.Drawing.Point(0, 0);
            this.panelBuildingandFacilities.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelBuildingandFacilities.Name = "panelBuildingandFacilities";
            this.panelBuildingandFacilities.Size = new System.Drawing.Size(1437, 718);
            this.panelBuildingandFacilities.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnOthers);
            this.panel1.Controls.Add(this.btnMainBuilding);
            this.panel1.Controls.Add(this.btnStudentCenter);
            this.panel1.Controls.Add(this.btnRlrlc);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1429, 91);
            this.panel1.TabIndex = 0;
            // 
            // btnOthers
            // 
            this.btnOthers.Animated = true;
            this.btnOthers.BorderRadius = 20;
            this.btnOthers.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnOthers.CheckedState.FillColor = System.Drawing.Color.MediumOrchid;
            this.btnOthers.CheckedState.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOthers.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnOthers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOthers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOthers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOthers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOthers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOthers.FillColor = System.Drawing.Color.Orchid;
            this.btnOthers.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnOthers.ForeColor = System.Drawing.Color.Black;
            this.btnOthers.HoverState.FillColor = System.Drawing.Color.MediumOrchid;
            this.btnOthers.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOthers.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnOthers.Location = new System.Drawing.Point(720, 11);
            this.btnOthers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOthers.Name = "btnOthers";
            this.btnOthers.Size = new System.Drawing.Size(213, 63);
            this.btnOthers.TabIndex = 5;
            this.btnOthers.Text = "Other Facilities";
            this.btnOthers.Click += new System.EventHandler(this.btnOthers_Click);
            // 
            // btnMainBuilding
            // 
            this.btnMainBuilding.Animated = true;
            this.btnMainBuilding.BorderRadius = 20;
            this.btnMainBuilding.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnMainBuilding.CheckedState.FillColor = System.Drawing.Color.Purple;
            this.btnMainBuilding.CheckedState.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainBuilding.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnMainBuilding.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainBuilding.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMainBuilding.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMainBuilding.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMainBuilding.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMainBuilding.FillColor = System.Drawing.Color.Orchid;
            this.btnMainBuilding.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnMainBuilding.ForeColor = System.Drawing.Color.Black;
            this.btnMainBuilding.HoverState.FillColor = System.Drawing.Color.Purple;
            this.btnMainBuilding.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainBuilding.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnMainBuilding.Location = new System.Drawing.Point(485, 11);
            this.btnMainBuilding.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMainBuilding.Name = "btnMainBuilding";
            this.btnMainBuilding.Size = new System.Drawing.Size(213, 63);
            this.btnMainBuilding.TabIndex = 3;
            this.btnMainBuilding.Text = "Main Building";
            this.btnMainBuilding.Click += new System.EventHandler(this.btnMainBuilding_Click);
            // 
            // btnStudentCenter
            // 
            this.btnStudentCenter.Animated = true;
            this.btnStudentCenter.BorderRadius = 20;
            this.btnStudentCenter.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnStudentCenter.CheckedState.FillColor = System.Drawing.Color.Plum;
            this.btnStudentCenter.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnStudentCenter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudentCenter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStudentCenter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStudentCenter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStudentCenter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStudentCenter.FillColor = System.Drawing.Color.Orchid;
            this.btnStudentCenter.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnStudentCenter.ForeColor = System.Drawing.Color.Black;
            this.btnStudentCenter.HoverState.FillColor = System.Drawing.Color.Plum;
            this.btnStudentCenter.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentCenter.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnStudentCenter.Location = new System.Drawing.Point(248, 11);
            this.btnStudentCenter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStudentCenter.Name = "btnStudentCenter";
            this.btnStudentCenter.Size = new System.Drawing.Size(213, 63);
            this.btnStudentCenter.TabIndex = 2;
            this.btnStudentCenter.Text = "Student Center";
            this.btnStudentCenter.Click += new System.EventHandler(this.btnStudentCenter_Click);
            // 
            // btnRlrlc
            // 
            this.btnRlrlc.Animated = true;
            this.btnRlrlc.BorderRadius = 20;
            this.btnRlrlc.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnRlrlc.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(140)))), ((int)(((byte)(218)))));
            this.btnRlrlc.CheckedState.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRlrlc.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnRlrlc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRlrlc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRlrlc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRlrlc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRlrlc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRlrlc.FillColor = System.Drawing.Color.Orchid;
            this.btnRlrlc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnRlrlc.ForeColor = System.Drawing.Color.Black;
            this.btnRlrlc.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(140)))), ((int)(((byte)(218)))));
            this.btnRlrlc.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRlrlc.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnRlrlc.Location = new System.Drawing.Point(12, 11);
            this.btnRlrlc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRlrlc.Name = "btnRlrlc";
            this.btnRlrlc.Size = new System.Drawing.Size(213, 63);
            this.btnRlrlc.TabIndex = 1;
            this.btnRlrlc.Text = "RLRLC Building";
            this.btnRlrlc.Click += new System.EventHandler(this.btnRlrlc_Click_1);
            // 
            // dataGridViewFacility2
            // 
            this.dataGridViewFacility2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFacility2.Location = new System.Drawing.Point(269, 56);
            this.dataGridViewFacility2.Name = "dataGridViewFacility2";
            this.dataGridViewFacility2.RowHeadersWidth = 51;
            this.dataGridViewFacility2.RowTemplate.Height = 24;
            this.dataGridViewFacility2.Size = new System.Drawing.Size(890, 516);
            this.dataGridViewFacility2.TabIndex = 21;
            // 
            // formBuildingandFacilities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 718);
            this.Controls.Add(this.panelBuildingandFacilities);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formBuildingandFacilities";
            this.Text = "FACILITIES";
            this.panelBuildingDashboard.ResumeLayout(false);
            this.panelBuildingDashboard.PerformLayout();
            this.panelBuildingandFacilities.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFacility2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBuildingDashboard;
        private System.Windows.Forms.Panel panelBuildingandFacilities;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnRlrlc;
        private Guna.UI2.WinForms.Guna2Button btnStudentCenter;
        private Guna.UI2.WinForms.Guna2Button btnMainBuilding;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnOthers;
        private System.Windows.Forms.DataGridView dataGridViewFacility2;
    }
}
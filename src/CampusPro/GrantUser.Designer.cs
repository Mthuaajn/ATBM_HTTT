﻿namespace UsersManagement
{
    partial class GrantUser
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
            this.grantBtn = new System.Windows.Forms.Button();
            this.selectPrivilegeComboBox = new System.Windows.Forms.ComboBox();
            this.selectPrivilegeLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.grantRoleForUserLabel = new System.Windows.Forms.Label();
            this.exitBtn1 = new System.Windows.Forms.Button();
            this.selectTabLabel = new System.Windows.Forms.Label();
            this.selectTableComboBox = new System.Windows.Forms.ComboBox();
            this.attributesDGV = new System.Windows.Forms.DataGridView();
            this.Column = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.withGrantOptionCheckBox = new System.Windows.Forms.CheckBox();
            this.grantToColCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.attributesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // grantBtn
            // 
            this.grantBtn.BackColor = System.Drawing.Color.White;
            this.grantBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grantBtn.ForeColor = System.Drawing.Color.Black;
            this.grantBtn.Location = new System.Drawing.Point(492, 542);
            this.grantBtn.Name = "grantBtn";
            this.grantBtn.Size = new System.Drawing.Size(117, 48);
            this.grantBtn.TabIndex = 22;
            this.grantBtn.Text = "Grant";
            this.grantBtn.UseVisualStyleBackColor = false;
            this.grantBtn.Click += new System.EventHandler(this.grantBtn_Click);
            // 
            // selectPrivilegeComboBox
            // 
            this.selectPrivilegeComboBox.FormattingEnabled = true;
            this.selectPrivilegeComboBox.Items.AddRange(new object[] {
            "SELECT",
            "UPDATE",
            "INSERT",
            "DELETE"});
            this.selectPrivilegeComboBox.Location = new System.Drawing.Point(357, 220);
            this.selectPrivilegeComboBox.Name = "selectPrivilegeComboBox";
            this.selectPrivilegeComboBox.Size = new System.Drawing.Size(239, 24);
            this.selectPrivilegeComboBox.TabIndex = 21;
            this.selectPrivilegeComboBox.TextChanged += new System.EventHandler(this.selectPrivilegeComboBox_TextChanged);
            // 
            // selectPrivilegeLabel
            // 
            this.selectPrivilegeLabel.AutoSize = true;
            this.selectPrivilegeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectPrivilegeLabel.Location = new System.Drawing.Point(131, 213);
            this.selectPrivilegeLabel.Name = "selectPrivilegeLabel";
            this.selectPrivilegeLabel.Size = new System.Drawing.Size(196, 29);
            this.selectPrivilegeLabel.TabIndex = 20;
            this.selectPrivilegeLabel.Text = "Select privilege";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(357, 151);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.ReadOnly = true;
            this.usernameTextBox.Size = new System.Drawing.Size(239, 22);
            this.usernameTextBox.TabIndex = 19;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(131, 144);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(132, 29);
            this.userNameLabel.TabIndex = 18;
            this.userNameLabel.Text = "Username";
            // 
            // grantRoleForUserLabel
            // 
            this.grantRoleForUserLabel.AutoSize = true;
            this.grantRoleForUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grantRoleForUserLabel.ForeColor = System.Drawing.Color.Green;
            this.grantRoleForUserLabel.Location = new System.Drawing.Point(12, 9);
            this.grantRoleForUserLabel.Name = "grantRoleForUserLabel";
            this.grantRoleForUserLabel.Size = new System.Drawing.Size(281, 29);
            this.grantRoleForUserLabel.TabIndex = 17;
            this.grantRoleForUserLabel.Text = "Grant privilege for user";
            // 
            // exitBtn1
            // 
            this.exitBtn1.BackColor = System.Drawing.Color.Red;
            this.exitBtn1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitBtn1.Location = new System.Drawing.Point(1031, 9);
            this.exitBtn1.Name = "exitBtn1";
            this.exitBtn1.Size = new System.Drawing.Size(37, 35);
            this.exitBtn1.TabIndex = 16;
            this.exitBtn1.Text = "X";
            this.exitBtn1.UseVisualStyleBackColor = false;
            this.exitBtn1.Click += new System.EventHandler(this.exitBtn1_Click);
            // 
            // selectTabLabel
            // 
            this.selectTabLabel.AutoSize = true;
            this.selectTabLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTabLabel.Location = new System.Drawing.Point(131, 301);
            this.selectTabLabel.Name = "selectTabLabel";
            this.selectTabLabel.Size = new System.Drawing.Size(213, 29);
            this.selectTabLabel.TabIndex = 23;
            this.selectTabLabel.Text = "Select table/view";
            // 
            // selectTableComboBox
            // 
            this.selectTableComboBox.FormattingEnabled = true;
            this.selectTableComboBox.Location = new System.Drawing.Point(357, 306);
            this.selectTableComboBox.Name = "selectTableComboBox";
            this.selectTableComboBox.Size = new System.Drawing.Size(239, 24);
            this.selectTableComboBox.TabIndex = 24;
            this.selectTableComboBox.TextChanged += new System.EventHandler(this.selectTableComboBox_TextChanged);
            // 
            // attributesDGV
            // 
            this.attributesDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.attributesDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.attributesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attributesDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column});
            this.attributesDGV.Location = new System.Drawing.Point(739, 144);
            this.attributesDGV.Name = "attributesDGV";
            this.attributesDGV.RowHeadersWidth = 51;
            this.attributesDGV.RowTemplate.Height = 24;
            this.attributesDGV.Size = new System.Drawing.Size(254, 261);
            this.attributesDGV.TabIndex = 25;
            // 
            // Column
            // 
            this.Column.FillWeight = 5F;
            this.Column.HeaderText = "Check";
            this.Column.MinimumWidth = 6;
            this.Column.Name = "Column";
            // 
            // withGrantOptionCheckBox
            // 
            this.withGrantOptionCheckBox.AutoSize = true;
            this.withGrantOptionCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withGrantOptionCheckBox.Location = new System.Drawing.Point(357, 376);
            this.withGrantOptionCheckBox.Name = "withGrantOptionCheckBox";
            this.withGrantOptionCheckBox.Size = new System.Drawing.Size(242, 29);
            this.withGrantOptionCheckBox.TabIndex = 27;
            this.withGrantOptionCheckBox.Text = "WITH GRANT OPTION";
            this.withGrantOptionCheckBox.UseVisualStyleBackColor = true;
            // 
            // grantToColCheckBox
            // 
            this.grantToColCheckBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.grantToColCheckBox.AutoSize = true;
            this.grantToColCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grantToColCheckBox.Location = new System.Drawing.Point(739, 92);
            this.grantToColCheckBox.Name = "grantToColCheckBox";
            this.grantToColCheckBox.Size = new System.Drawing.Size(273, 24);
            this.grantToColCheckBox.TabIndex = 28;
            this.grantToColCheckBox.Text = "GRANT TO COLUMS LEVEL";
            this.grantToColCheckBox.UseVisualStyleBackColor = true;
            this.grantToColCheckBox.CheckedChanged += new System.EventHandler(this.grantToColCheckBox_CheckedChanged);
            // 
            // GrantUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.grantToColCheckBox);
            this.Controls.Add(this.withGrantOptionCheckBox);
            this.Controls.Add(this.attributesDGV);
            this.Controls.Add(this.selectTableComboBox);
            this.Controls.Add(this.selectTabLabel);
            this.Controls.Add(this.grantBtn);
            this.Controls.Add(this.selectPrivilegeComboBox);
            this.Controls.Add(this.selectPrivilegeLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.grantRoleForUserLabel);
            this.Controls.Add(this.exitBtn1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GrantUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GrantUser";
            this.Load += new System.EventHandler(this.GrantUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.attributesDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button grantBtn;
        private System.Windows.Forms.ComboBox selectPrivilegeComboBox;
        private System.Windows.Forms.Label selectPrivilegeLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label grantRoleForUserLabel;
        private System.Windows.Forms.Button exitBtn1;
        private System.Windows.Forms.Label selectTabLabel;
        private System.Windows.Forms.ComboBox selectTableComboBox;
        private System.Windows.Forms.DataGridView attributesDGV;
        private System.Windows.Forms.CheckBox withGrantOptionCheckBox;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column;
        private System.Windows.Forms.CheckBox grantToColCheckBox;
    }
}
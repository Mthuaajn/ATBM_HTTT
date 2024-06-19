namespace UsersManagement
{
    partial class GrantRole
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
            this.attributesLabel = new System.Windows.Forms.Label();
            this.attributesDGV = new System.Windows.Forms.DataGridView();
            this.selectTableComboBox = new System.Windows.Forms.ComboBox();
            this.selectTabLabel = new System.Windows.Forms.Label();
            this.grantBtn = new System.Windows.Forms.Button();
            this.selectPrivilegeComboBox = new System.Windows.Forms.ComboBox();
            this.selectPrivilegeLabel = new System.Windows.Forms.Label();
            this.roleTextBox = new System.Windows.Forms.TextBox();
            this.roleLabel = new System.Windows.Forms.Label();
            this.grantRoleForRoleLabel = new System.Windows.Forms.Label();
            this.exitBtn1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.attributesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // attributesLabel
            // 
            this.attributesLabel.AutoSize = true;
            this.attributesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attributesLabel.Location = new System.Drawing.Point(707, 103);
            this.attributesLabel.Name = "attributesLabel";
            this.attributesLabel.Size = new System.Drawing.Size(115, 29);
            this.attributesLabel.TabIndex = 38;
            this.attributesLabel.Text = "Columns";
            // 
            // attributesDGV
            // 
            this.attributesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attributesDGV.Location = new System.Drawing.Point(712, 148);
            this.attributesDGV.Name = "attributesDGV";
            this.attributesDGV.RowHeadersWidth = 51;
            this.attributesDGV.RowTemplate.Height = 24;
            this.attributesDGV.Size = new System.Drawing.Size(254, 186);
            this.attributesDGV.TabIndex = 37;
            // 
            // selectTableComboBox
            // 
            this.selectTableComboBox.FormattingEnabled = true;
            this.selectTableComboBox.Location = new System.Drawing.Point(330, 310);
            this.selectTableComboBox.Name = "selectTableComboBox";
            this.selectTableComboBox.Size = new System.Drawing.Size(239, 24);
            this.selectTableComboBox.TabIndex = 36;
            // 
            // selectTabLabel
            // 
            this.selectTabLabel.AutoSize = true;
            this.selectTabLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTabLabel.Location = new System.Drawing.Point(104, 305);
            this.selectTabLabel.Name = "selectTabLabel";
            this.selectTabLabel.Size = new System.Drawing.Size(213, 29);
            this.selectTabLabel.TabIndex = 35;
            this.selectTabLabel.Text = "Select table/view";
            // 
            // grantBtn
            // 
            this.grantBtn.BackColor = System.Drawing.Color.White;
            this.grantBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grantBtn.ForeColor = System.Drawing.Color.Black;
            this.grantBtn.Location = new System.Drawing.Point(468, 510);
            this.grantBtn.Name = "grantBtn";
            this.grantBtn.Size = new System.Drawing.Size(117, 48);
            this.grantBtn.TabIndex = 34;
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
            this.selectPrivilegeComboBox.Location = new System.Drawing.Point(330, 224);
            this.selectPrivilegeComboBox.Name = "selectPrivilegeComboBox";
            this.selectPrivilegeComboBox.Size = new System.Drawing.Size(239, 24);
            this.selectPrivilegeComboBox.TabIndex = 33;
            this.selectPrivilegeComboBox.TextChanged += new System.EventHandler(this.selectPrivilegeComboBox_TextChanged);
            // 
            // selectPrivilegeLabel
            // 
            this.selectPrivilegeLabel.AutoSize = true;
            this.selectPrivilegeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectPrivilegeLabel.Location = new System.Drawing.Point(104, 217);
            this.selectPrivilegeLabel.Name = "selectPrivilegeLabel";
            this.selectPrivilegeLabel.Size = new System.Drawing.Size(196, 29);
            this.selectPrivilegeLabel.TabIndex = 32;
            this.selectPrivilegeLabel.Text = "Select privilege";
            // 
            // roleTextBox
            // 
            this.roleTextBox.Location = new System.Drawing.Point(330, 155);
            this.roleTextBox.Name = "roleTextBox";
            this.roleTextBox.ReadOnly = true;
            this.roleTextBox.Size = new System.Drawing.Size(239, 22);
            this.roleTextBox.TabIndex = 31;
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleLabel.Location = new System.Drawing.Point(104, 148);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(68, 29);
            this.roleLabel.TabIndex = 30;
            this.roleLabel.Text = "Role";
            // 
            // grantRoleForRoleLabel
            // 
            this.grantRoleForRoleLabel.AutoSize = true;
            this.grantRoleForRoleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grantRoleForRoleLabel.ForeColor = System.Drawing.Color.Green;
            this.grantRoleForRoleLabel.Location = new System.Drawing.Point(12, 9);
            this.grantRoleForRoleLabel.Name = "grantRoleForRoleLabel";
            this.grantRoleForRoleLabel.Size = new System.Drawing.Size(276, 29);
            this.grantRoleForRoleLabel.TabIndex = 29;
            this.grantRoleForRoleLabel.Text = "Grant privilege for role";
            // 
            // exitBtn1
            // 
            this.exitBtn1.BackColor = System.Drawing.Color.Red;
            this.exitBtn1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitBtn1.Location = new System.Drawing.Point(1031, 12);
            this.exitBtn1.Name = "exitBtn1";
            this.exitBtn1.Size = new System.Drawing.Size(37, 35);
            this.exitBtn1.TabIndex = 28;
            this.exitBtn1.Text = "X";
            this.exitBtn1.UseVisualStyleBackColor = false;
            this.exitBtn1.Click += new System.EventHandler(this.exitBtn1_Click);
            // 
            // GrantRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.attributesLabel);
            this.Controls.Add(this.attributesDGV);
            this.Controls.Add(this.selectTableComboBox);
            this.Controls.Add(this.selectTabLabel);
            this.Controls.Add(this.grantBtn);
            this.Controls.Add(this.selectPrivilegeComboBox);
            this.Controls.Add(this.selectPrivilegeLabel);
            this.Controls.Add(this.roleTextBox);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.grantRoleForRoleLabel);
            this.Controls.Add(this.exitBtn1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GrantRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GrantRole";
            this.Load += new System.EventHandler(this.GrantRole_Load);
            ((System.ComponentModel.ISupportInitialize)(this.attributesDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label attributesLabel;
        private System.Windows.Forms.DataGridView attributesDGV;
        private System.Windows.Forms.ComboBox selectTableComboBox;
        private System.Windows.Forms.Label selectTabLabel;
        private System.Windows.Forms.Button grantBtn;
        private System.Windows.Forms.ComboBox selectPrivilegeComboBox;
        private System.Windows.Forms.Label selectPrivilegeLabel;
        private System.Windows.Forms.TextBox roleTextBox;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Label grantRoleForRoleLabel;
        private System.Windows.Forms.Button exitBtn1;
    }
}
namespace UsersManagement
{
    partial class LoginUi
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
            this.title_label = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.input_username = new System.Windows.Forms.TextBox();
            this.input_password = new System.Windows.Forms.TextBox();
            this.check_role = new System.Windows.Forms.CheckedListBox();
            this.label_role = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Arial Narrow", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.Location = new System.Drawing.Point(299, 72);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(180, 52);
            this.title_label.TabIndex = 0;
            this.title_label.Text = "Welcome";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.Location = new System.Drawing.Point(232, 245);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(96, 25);
            this.label_password.TabIndex = 1;
            this.label_password.Text = "password";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.Location = new System.Drawing.Point(231, 189);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(99, 25);
            this.label_username.TabIndex = 2;
            this.label_username.Text = "username";
            // 
            // input_username
            // 
            this.input_username.Location = new System.Drawing.Point(379, 190);
            this.input_username.Name = "input_username";
            this.input_username.Size = new System.Drawing.Size(204, 26);
            this.input_username.TabIndex = 3;
            this.input_username.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // input_password
            // 
            this.input_password.Location = new System.Drawing.Point(379, 241);
            this.input_password.Name = "input_password";
            this.input_password.Size = new System.Drawing.Size(204, 26);
            this.input_password.TabIndex = 4;
            // 
            // check_role
            // 
            this.check_role.FormattingEnabled = true;
            this.check_role.Items.AddRange(new object[] {
            "SYSDBA",
            "USER"});
            this.check_role.Location = new System.Drawing.Point(379, 288);
            this.check_role.Name = "check_role";
            this.check_role.Size = new System.Drawing.Size(204, 27);
            this.check_role.TabIndex = 5;
            this.check_role.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged_1);
            // 
            // label_role
            // 
            this.label_role.AutoSize = true;
            this.label_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_role.Location = new System.Drawing.Point(236, 294);
            this.label_role.Name = "label_role";
            this.label_role.Size = new System.Drawing.Size(51, 25);
            this.label_role.TabIndex = 6;
            this.label_role.Text = "Role";
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_login.ForeColor = System.Drawing.Color.Cornsilk;
            this.button_login.Location = new System.Drawing.Point(326, 357);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(100, 37);
            this.button_login.TabIndex = 7;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Red;
            this.exitBtn.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitBtn.Location = new System.Drawing.Point(719, 31);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(42, 44);
            this.exitBtn.TabIndex = 20;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // LoginUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.label_role);
            this.Controls.Add(this.check_role);
            this.Controls.Add(this.input_password);
            this.Controls.Add(this.input_username);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.title_label);
            this.Name = "LoginUi";
            this.Text = "LoginUi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.TextBox input_username;
        private System.Windows.Forms.TextBox input_password;
        private System.Windows.Forms.CheckedListBox check_role;
        private System.Windows.Forms.Label label_role;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button exitBtn;
    }
}
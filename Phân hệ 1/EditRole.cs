using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UsersManagement
{
    public partial class EditRole : Form
    {
        public string RoleName { get; set; }
        public EditRole()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void editRoleBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to change password to this?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                string roleName = RoleName;
                string pwdChange = passwordTextBox.Text;
                MessageBox.Show(roleName + " " + pwdChange );
                try
                {
                    using (OracleConnection oracleConnection = Connection.GetOracleConnection())
                    {
                        oracleConnection.Open();
                        string query = "";
                        if (pwdChange == "")
                        {
                            query = $"ALTER ROLE {roleName} NOT IDENTIFIED ";
                        }
                        else
                        {
                            query = $"ALTER ROLE {roleName} IDENTIFIED BY {pwdChange} ";
                        }
                        using (OracleCommand command = new OracleCommand(query, oracleConnection))
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("Role password changed successfully.");
                        }
                        oracleConnection.Close();
                    }
                    // Change the list
                    UsersAndRoles obj = new UsersAndRoles();
                    obj.UsersAndRoles_Load(sender, e);
                    obj.Clear();
                    // Exit adding window
                    this.Hide();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error manipluting role: " + ex.Message);
                }

            }
        }
    }
}

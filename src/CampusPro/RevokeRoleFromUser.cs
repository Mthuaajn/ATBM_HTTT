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
using BUS;
using DAO;

namespace UsersManagement
{
    public partial class RevokeRoleFromUser : Form
    {

        public string UsernameSelected { get; set; }
        public RevokeRoleFromUser()
        {
            InitializeComponent();
            GetRole();
        }

        private void GetRole()
        {
            Modify modify = new Modify();
            string query = "SELECT DRP.GRANTED_ROLE " +
                            "FROM DBA_USERS U LEFT JOIN DBA_ROLE_PRIVS DRP ON U.USERNAME = DRP.GRANTEE " +
                            "WHERE U.USERNAME = '" + UsernameSelected + "' AND DRP.GRANTED_ROLE IS NOT NULL";
            DataTable dataTable = new DataTable();
            dataTable = modify.LoadTable(query);
            selectRoleComboBox.ValueMember = "GRANTED_ROLE";
            selectRoleComboBox.DataSource = dataTable;
        }

        private void RevokeRoleFromUser_Load(object sender, EventArgs e)
        {
            usernameTextBox.Text = UsernameSelected;
            GetRole();
        }

        private void exitBtn1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void revokeBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameSelected;
            string role = selectRoleComboBox.SelectedValue.ToString();

            if (MessageBox.Show("Are you sure you want to revoke this role from the above user?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

                try
                {
                    using (OracleConnection oracleConnection = Connection.GetOracleConnection())
                    {
                        oracleConnection.Open();
                        string query = $"REVOKE {role} FROM {username}";

                        using (OracleCommand command = new OracleCommand(query, oracleConnection))
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("Role revoked successfully.");
                        }
                        oracleConnection.Close();
                    }
                    // Exit adding window
                    this.Hide();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error revoking role: " + ex.Message);
                }

            }
        }
    }
}

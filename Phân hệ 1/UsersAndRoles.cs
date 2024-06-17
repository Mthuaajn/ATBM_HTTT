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
    public partial class UsersAndRoles : Form
    {
        
        public UsersAndRoles()
        {
            InitializeComponent();
        }
        public void Clear()
        {
            userNameTextBox.Text = "";
            roleNameTextBox.Text = "";

        }
        Modify modify = new Modify();

        // Display data
        public void UsersAndRoles_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1._USER_' table. You can move, or remove it, as needed.
            //this.uSER_TableAdapter.Fill(this.dataSet1._USER_);
           
            try
            {
                usersDGV.DataSource = modify.Table("SELECT USERNAME AS Username, CREATED AS TIME_CREATED FROM all_users ");
                rolesDGV.DataSource = modify.Table("SELECT ROLE, PASSWORD_REQUIRED FROM DBA_ROLES");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }


        }

        // Search user name
        private void usersDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (usersDGV.SelectedRows.Count > 0)
            {
                userNameTextBox.Text = usersDGV.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {
            string userName = userNameTextBox.Text.Trim();
            if (userName == "")
            {
                UsersAndRoles_Load(sender, e);

            }
            else
            {
                string query = "SELECT USERNAME, CREATED AS TIME_CREATED FROM all_users WHERE USERNAME LIKE '%" + userName + "%'";
                usersDGV.DataSource = modify.Table(query);
            }
        }

        // Search role name
        private void rolesDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rolesDGV.SelectedRows.Count > 0)
            {
                roleNameTextBox.Text = rolesDGV.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void roleNameTextBox_TextChanged(object sender, EventArgs e)
        {
            string roleName = roleNameTextBox.Text.Trim();
            if (roleName == "")
            {
                UsersAndRoles_Load(sender, e);

            }
            else
            {
                string query = "SELECT ROLE, PASSWORD_REQUIRED FROM DBA_ROLES WHERE ROLE LIKE '%" + roleName + "%'";
                rolesDGV.DataSource = modify.Table(query);
            }
        }
        //Add user
        private void addUserBtn_Click(object sender, EventArgs e)
        {
            // Call AddUser form
            AddUser obj = new AddUser();
            obj.Show();
        }

        //Delete user
        private void deleteUserBtn_Click(object sender, EventArgs e)
        {
            if (usersDGV.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this user?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    string username = usersDGV.SelectedRows[0].Cells[0].Value.ToString();
                    try
                    {
                        using (OracleConnection oracleConnection = Connection.GetOracleConnection())
                        {
                            oracleConnection.Open();

                            string query = $"DROP USER {username}";
                            using (OracleCommand command = new OracleCommand(query, oracleConnection))
                            {
                                command.ExecuteNonQuery();
                                MessageBox.Show("User deleted successfully.");
                            }
                            oracleConnection.Close();
                        }
                        UsersAndRoles_Load(sender, e);
                        Clear();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting user: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please choose the user you want to delete !");
            }

        }

        // Edit user
        private void editUserBtn_Click(object sender, EventArgs e)
        {
            if (usersDGV.SelectedRows.Count > 0)
            {
                string username = usersDGV.SelectedRows[0].Cells[0].Value.ToString(); 
                EditUser targetForm = new EditUser();
                targetForm.Username = username;
                targetForm.Show();
            }
            else
            {
                MessageBox.Show("Please choose the user you want to edit !");
            }
        }

        // Add role
        private void addRoleBtn_Click(object sender, EventArgs e)
        {
            // Call AddUser form
            AddRole obj = new AddRole();
            obj.Show();
        }

        // Delete role
        private void deleteRoleBtn_Click(object sender, EventArgs e)
        {
            if (rolesDGV.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this role?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    string roleName = rolesDGV.SelectedRows[0].Cells[0].Value.ToString();
                    try
                    {
                        using (OracleConnection oracleConnection = Connection.GetOracleConnection())
                        {
                            oracleConnection.Open();

                            string query = $"DROP ROLE {roleName}";
                            using (OracleCommand command = new OracleCommand(query, oracleConnection))
                            {
                                command.ExecuteNonQuery();
                                MessageBox.Show("Role deleted successfully.");
                            }
                            oracleConnection.Close();
                        }
                        UsersAndRoles_Load(sender, e);
                        Clear();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting role: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please choose the role you want to delete !");
            }
        }

        // Edit role
        private void editRoleBtn_Click(object sender, EventArgs e)
        {
            if (usersDGV.SelectedRows.Count > 0)
            {
                string roleName = rolesDGV.SelectedRows[0].Cells[0].Value.ToString();
                EditRole targetForm = new EditRole();
                targetForm.RoleName = roleName;
                targetForm.Show();
            }
            else
            {
                MessageBox.Show("Please choose the role you want to edit !");
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

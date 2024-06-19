using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using PrivilegesBUS = BUS.PrivilegesBUS;

namespace UsersManagement
{
    
    public partial class Privileges : Form
    {
        PrivilegesBUS privileges = new PrivilegesBUS();
        private string UserName;
        private string RoleName;
        Modify modify = new Modify();
        public Privileges()
        {
            InitializeComponent();
        }

        private void Privileges_Load(object sender, EventArgs e)
        {
            toTabCheckBox1.Checked = true;
            totableCheckBox2.Checked = true; 
            UsersPrivsLoadByTab(sender, e);
            RolesPrivsLoadByTab(sender, e);
        }
        private void UsersPrivsLoadByTab(object sender, EventArgs e)
        {
            try
            {
                usersPrivsDGV.DataSource = privileges.LoadAllusersInTabLevel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading users privileges to tables: " + ex.Message);
            }
        }
        private void UserPrivsLoadByCol(object sender, EventArgs e)
        {
            try
            {
                usersPrivsDGV.DataSource = privileges.LoadAllusersInColLevel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading users privileges to columns: " + ex.Message);
            }
        }
        private void RolesPrivsLoadByTab(object sender, EventArgs e)
        {
            try
            {
                rolesPrivsDGV.DataSource = privileges.LoadAllRolesInTabLevel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading roles privileges to tables: " + ex.Message);
            }
        }
        private void RolesPRivsLoadByCol(object sender, EventArgs e)
        {
            try
            {
                rolesPrivsDGV.DataSource = privileges.LoadAllRolesInColLevel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading roles privileges to columns: " + ex.Message);
            }
        }

        private void toTabCheckBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (toTabCheckBox1.Checked == true)
            {
                toColCheckBox1.Checked = false;
                UsersPrivsLoadByTab(sender, e);
            }
            else
            {
                toColCheckBox1.Checked = true;
                UserPrivsLoadByCol (sender, e);
            }
            
        }

        private void toColCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (toColCheckBox1.Checked == true)
            {
                toTabCheckBox1.Checked = false;
                UserPrivsLoadByCol(sender, e);
            }
            else
            { 
                toTabCheckBox1.Checked = true;
                UsersPrivsLoadByTab(sender, e);
            }
        }

        private void totableCheckBox2_CheckStateChanged(object sender, EventArgs e)
        {
            if (totableCheckBox2.Checked == true)
            {
                toColCheckBox2.Checked = false;
                RolesPrivsLoadByTab(sender, e);
            }
            else
            {
                toColCheckBox2.Checked = true;
                RolesPRivsLoadByCol(sender, e);

            }
        }

        private void toColCheckBox2_CheckStateChanged(object sender, EventArgs e)
        {
            if (toColCheckBox2.Checked == true)
            {
                totableCheckBox2.Checked = false;
                RolesPRivsLoadByCol(sender, e);
            }
            else
            {
                totableCheckBox2.Checked = true;
                RolesPrivsLoadByTab(sender, e);
            }
        }

        // Search by users
        private void usersPrivsDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (usersPrivsDGV.SelectedRows.Count > 0)
            {
                userNameTextBox.Text = usersPrivsDGV.SelectedRows[0].Cells[0].Value.ToString();
                UserName = usersPrivsDGV.SelectedRows[0].Cells[0].Value.ToString();
            }
        }
        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {
            string userName = userNameTextBox.Text.Trim();
            if (userName == "" && toTabCheckBox1.Checked == true)
            {
                UsersPrivsLoadByTab(sender, e);

            }
            else if (userName == "" && toTabCheckBox1.Checked == false)
            {
                UserPrivsLoadByCol(sender, e);
            }
            else if (toTabCheckBox1.Checked == true)
            {
                usersPrivsDGV.DataSource = privileges.FilterUsersInTabLevel(userName);
            }
            else
            {
                usersPrivsDGV.DataSource = privileges.FilterUsersInColLevel(userName);
            }
        }

        // Search by roles
        private void rolesPrivsDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rolesPrivsDGV.SelectedRows.Count > 0)
            {
                roleNameTextBox.Text = rolesPrivsDGV.SelectedRows[0].Cells[0].Value.ToString();
                RoleName = rolesPrivsDGV.SelectedRows[0].Cells[0].Value.ToString();
            }
        }
        private void roleNameTextBox_TextChanged(object sender, EventArgs e)
        {
            string roleName = roleNameTextBox.Text.Trim();
            if (roleName == "" && totableCheckBox2.Checked == true)
            {
                RolesPrivsLoadByTab(sender, e);

            }
            else if (roleName == "" && totableCheckBox2.Checked == false)
            {
                RolesPRivsLoadByCol(sender, e);
            }
            else if (totableCheckBox2.Checked == true)
            {
                rolesPrivsDGV.DataSource = privileges.FilterRolesInTabLevel(roleName);
            }
            else
            {
                rolesPrivsDGV.DataSource = privileges.FilterRolesInColLevel(roleName);
            }
        }

        // Uppercase the search
        private void userNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void roleNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }
        //
        // GRATING AND REVOKING
        //
        // Users===========
        // Granting in another form
        private void grantBtn1_Click(object sender, EventArgs e)
        {
            if (usersPrivsDGV.SelectedRows.Count > 0)
            {
                GrantUser target = new GrantUser();
                target.UsernameSelected = UserName;
                target.Show();
            }
            else
            {
                MessageBox.Show("Please choose the user you want to grant !");
            }
        }
        // Revoking in this form
        private void revokeBtn1_Click(object sender, EventArgs e)
        {
            string username = usersPrivsDGV.SelectedRows[0].Cells[0].Value.ToString();
            string privilege = usersPrivsDGV.SelectedRows[0].Cells[3].Value.ToString();
            string table = usersPrivsDGV.SelectedRows[0].Cells[1].Value.ToString();
            //string column = "";

            if (MessageBox.Show("Are you sure you want to revoke this privilege from the this user?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

                try
                {
                    using (OracleConnection oracleConnection = Connection.GetOracleConnection())
                    {
                        oracleConnection.Open();
                        string query = $"REVOKE {privilege} ON {table} FROM {username}";

                        using (OracleCommand command = new OracleCommand(query, oracleConnection))
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("Role revoked successfully.");
                        }
                        oracleConnection.Close();
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error revoking role: " + ex.Message);
                }

            }
        }


        // ROLE=================================
        // Granting in another form
        private void grantBtn2_Click(object sender, EventArgs e)
        {
            if (rolesPrivsDGV.SelectedRows.Count > 0)
            {
                GrantRole target = new GrantRole();
                target.RoleSelected = RoleName;
             
                target.Show();
            }
            else
            {
                MessageBox.Show("Please choose the role you want to grant !");
            }
        }

        private void revokeBtn2_Click(object sender, EventArgs e)
        {
            string role = rolesPrivsDGV.SelectedRows[0].Cells[0].Value.ToString();
            string privilege = rolesPrivsDGV.SelectedRows[0].Cells[3].Value.ToString();
            string table = rolesPrivsDGV.SelectedRows[0].Cells[1].Value.ToString();
            //string column = "";

            if (MessageBox.Show("Are you sure you want to revoke this privilege from the this user?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

                try
                {
                    using (OracleConnection oracleConnection = Connection.GetOracleConnection())
                    {
                        oracleConnection.Open();
                        string query = $"REVOKE {privilege} ON {table} FROM {role}";

                        using (OracleCommand command = new OracleCommand(query, oracleConnection))
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("Role revoked successfully.");
                        }
                        oracleConnection.Close();
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error revoking role: " + ex.Message);
                }

            }
        }



        // Revoking in this form

        // Flow
        private void exitBtn1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void systemUsersBtn_Click(object sender, EventArgs e)
        {
            SystemUsers obj = new SystemUsers();
            obj.Show();
            this.Hide();
        }

        private void usersAndRolesBtn_Click(object sender, EventArgs e)
        {
            UsersAndRoles obj = new UsersAndRoles();
            obj.Show();
            this.Hide();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            Privileges_Load(sender, e);
        }

        //private void logoutBtn_Click(object sender, EventArgs e)
        //{
        //    Login obj = new Login();
        //    obj.Show();
        //    this.Hide();
        //}


    }
}

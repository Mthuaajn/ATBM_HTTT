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

namespace UsersManagement
{
    public partial class AddRole : Form
    {
        public AddRole()
        {
            InitializeComponent();
        }

        private void createUserBtn_Click(object sender, EventArgs e)
        {
            if (roleTextBox.Text == "")
            {
                MessageBox.Show("Please complete all information");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to add this role?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    string roleName =  "C##" + roleTextBox.Text; 
                    string pwd = passwordTextBox.Text;
                    //string password = passwordTextBox.Text;
                    try
                    {
                        using (OracleConnection oracleConnection = Connection.GetOracleConnection())
                        {
                            oracleConnection.Open();
                            string query = "";
                            if (pwd == "")
                            {
                                query = $"CREATE ROLE {roleName} NOT IDENTIFIED";
                            }
                            else
                            {
                                query = $"CREATE ROLE {roleName} IDENTIFIED by {pwd}";
                            }
                            using (OracleCommand command = new OracleCommand(query, oracleConnection))
                            {
                                command.ExecuteNonQuery();
                                MessageBox.Show("Role added successfully.");
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
                        MessageBox.Show("Error adding role: " + ex.Message);
                    }

                }


            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

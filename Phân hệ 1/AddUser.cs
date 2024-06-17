using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UsersManagement
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void createUserBtn_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == "" )
            {
                MessageBox.Show("Please complete all information");
            }
            else
            {
                    if (MessageBox.Show("Are you sure you want to add this user?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        string username = "C##" + userNameTextBox.Text; // Use for Multitenant environment
                        string password = passwordTextBox.Text;
                        try
                        {
                            using (OracleConnection oracleConnection = Connection.GetOracleConnection())
                            {
                                oracleConnection.Open();    

                                string query = $"CREATE USER {username} IDENTIFIED BY {password}";
                                using (OracleCommand command = new OracleCommand(query, oracleConnection))
                                {
                                    command.ExecuteNonQuery();
                                    MessageBox.Show("User added successfully.");
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
                            MessageBox.Show("Error adding user: " + ex.Message);
                        }

                    }
                
               
            }
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void userNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void addANewUserLabel_Click(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
    }


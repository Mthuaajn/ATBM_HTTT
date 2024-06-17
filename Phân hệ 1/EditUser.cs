using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UsersManagement
{
    public partial class EditUser : Form
    {
        public string Username { get; set; }
        public EditUser()
        {
            InitializeComponent();
        }
        

        private void createUserBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to change password to this?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                string username = Username;
                string pwdChange = passwordTextBox.Text;
                //MessageBox.Show(username + " " + pwdChange );
                try
                {
                    using (OracleConnection oracleConnection = Connection.GetOracleConnection())
                    {
                        oracleConnection.Open();

                        string query = $"ALTER USER {username} IDENTIFIED BY {pwdChange} ";
                        using (OracleCommand command = new OracleCommand(query, oracleConnection))
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("User password changed successfully.");
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
                    MessageBox.Show("Error changing password: " + ex.Message);
                }

            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

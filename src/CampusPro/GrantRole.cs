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
using DAO;

namespace UsersManagement
{
    public partial class GrantRole : Form
    {
        public string RoleSelected { get; set; }
        private string Privilege;
        //public bool IsCol { get; set; }
        public GrantRole()
        {
            InitializeComponent();
            GetTable();
        }

        private void exitBtn1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void GrantRole_Load(object sender, EventArgs e)
        {
            roleTextBox.Text = RoleSelected;
        }

        private void GetTable()
        {
            Modify modify = new Modify();
            string query = "SELECT object_name " +
                            "FROM user_objects " +
                            "WHERE object_type = 'TABLE' AND created >= TO_DATE('2024-04-01', 'YYYY-MM-DD')";
            DataTable dataTable = new DataTable();
            dataTable = modify.LoadTable(query);
            selectTableComboBox.ValueMember = "Object_name";
            selectTableComboBox.DataSource = dataTable;
        }

        private void selectPrivilegeComboBox_TextChanged(object sender, EventArgs e)
        {
            Privilege = selectPrivilegeComboBox.Text;
        }

        private void grantBtn_Click(object sender, EventArgs e)
        {
            string role = RoleSelected;
            string privilege = Privilege;
            string table = selectTableComboBox.SelectedValue.ToString();
       
            if (MessageBox.Show("Are you sure you want to grant this privilege to the above role?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

                try
                {
                    using (OracleConnection oracleConnection = Connection.GetOracleConnection())
                    {
                        oracleConnection.Open();
                      
                         string   query = $"GRANT {privilege} ON {table} TO {role}";
                        
                        using (OracleCommand command = new OracleCommand(query, oracleConnection))
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("Privilege granted successfully.");
                        }
                        oracleConnection.Close();
                    }
                    // Exit adding window
                    this.Hide();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error granting to role: " + ex.Message);
                }

            }
        }
    }
    
}

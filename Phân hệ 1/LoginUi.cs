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
    public partial class LoginUi : Form
    {
        public static OracleConnection con;
        public static String userUser;
        public static String passUser;
        public static String roleUser;
        public LoginUi()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if(input_username.Text.Length == 0)
            {
                MessageBox.Show("Không được để trống username");
                return;
            }
            if(input_password.Text.Length == 0)
            {
                MessageBox.Show("Không được để trống password");
                return;
            }
            if(check_role.CheckedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn role để đăng nhập hệ thống");
            }
            // check username, password, role
            try
            {
                string connectionString = "";
                if(check_role.CheckedItems.Contains("SYSDBA"))
                {
                    MessageBox.Show("SYSDBA");
                    connectionString = $"DATA SOURCE=localhost:1521/XE;DBA PRIVILEGE=SYSDBA;USER ID={input_username.Text};PASSWORD={input_password.Text}";
                }
                else
                {
                    connectionString = $"DATA SOURCE=localhost:1521/XE;USER ID={input_username.Text};PASSWORD={input_password.Text}";
                }
                con = new OracleConnection();
                con.ConnectionString = connectionString;
                con.Open();
                userUser = input_username.Text;
                passUser = input_password.Text;
                if (check_role.CheckedItems.Contains("SYSDBA"))
                {
                    OracleCommand command = new OracleCommand("alter session set \"_ORACLE_SCRIPT\"=true", con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Connect với Oracle thành công");
                    UsersAndRoles dba = new UsersAndRoles();
                    dba.Show();
                }
                this.Hide();
            }
            catch(OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}

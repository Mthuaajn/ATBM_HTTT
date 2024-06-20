using System;
using System.Drawing;
using System.Windows.Forms;

namespace UsersManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Connected successfully!");
            SystemUsers obj = new SystemUsers();
            obj.Show();
            this.Hide();
        }

        private void exitBtn1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginBtn_MouseEnter(object sender, EventArgs e)
        {
            loginBtn.BackColor = Color.LightGreen;
        }

        private void loginBtn_MouseLeave(object sender, EventArgs e)
        {
            loginBtn.BackColor = Color.Blue;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

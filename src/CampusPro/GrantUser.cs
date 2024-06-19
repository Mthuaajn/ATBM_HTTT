﻿using Oracle.ManagedDataAccess.Client;
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
using PrivilegesBUS = BUS.PrivilegesBUS;
using System.Collections;

namespace UsersManagement
{
    public partial class GrantUser : Form
    {
        PrivilegesBUS privileges = new PrivilegesBUS();
        public string UsernameSelected { get; set; }
        private string Privilege = "";
        private string table;
        public GrantUser()
        {
            InitializeComponent();
            GetTable();
        }

        private void exitBtn1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void GrantUser_Load(object sender, EventArgs e)
        {
            usernameTextBox.Text = UsernameSelected;
            selectColLabel.Hide();
            selectColumnCB.Hide();
        }
        private void GetTable()
        {
            selectTableComboBox.ValueMember = "Object_name";
            selectTableComboBox.DataSource = privileges.LoadTables();
        }
        private void GetColumn()
        {
            selectColumnCB.ValueMember = "COLUMN_NAME";
            selectColumnCB.DataSource = privileges.LoadColumnsOfTable(table);
        }
     

        private void grantToColCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (grantToColCheckBox.Checked == true)
            {
                if (selectPrivilegeComboBox.Text == "SELECT" || selectPrivilegeComboBox.Text == "UPDATE")
                {
                    selectColLabel.Show();
                    selectColumnCB.Show();
                }
                else
                {
                    MessageBox.Show("Only allow grant to column for SELECT OR UPDATE !");
                }
            }
            else
            {
                selectColLabel.Hide() ;
                selectColumnCB.Hide();
            }
        }

        private void selectTableComboBox_TextChanged(object sender, EventArgs e)
        {
            table = selectTableComboBox.Text;
            GetColumn();
        }

  

        private void grantBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameSelected;
            string privilege = Privilege;
            string table = selectTableComboBox.SelectedValue.ToString();
            bool withGrantOption = false;
            if (withGrantOptionCheckBox.Checked == true)
            {
                withGrantOption = true;
            }
            if (grantToColCheckBox.Checked == false)
            {

                if (MessageBox.Show("Are you sure you want to grant this privilege to the above user?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    try
                    {
                        if (withGrantOption == true)
                        {
                            privileges.GrantUserWithGrantOption(privilege, table, username);
                        }
                        else
                        {
                            privileges.GrantUser(privilege, table, username);
                        }
                        MessageBox.Show("Privilege granted successfully.");
                        // Exit adding window
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error granting to user: " + ex.Message);
                    }
                }
                
            }
            // Phan quyen den muc cot
            else
            {

            }
        }
    }
}

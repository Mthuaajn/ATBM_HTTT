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
    public partial class GrantUser : Form
    {
        public string UsernameSelected { get; set; }
        private string Privilege;
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
            attributesDGV.Hide();
        }
        private void GetTable()
        {
            Modify modify = new Modify();
            string query = "SELECT object_name "+
                            "FROM user_objects "+
                            "WHERE object_type = 'TABLE' AND created >= TO_DATE('2024-04-01', 'YYYY-MM-DD')";
            DataTable dataTable = new DataTable();
            dataTable = modify.LoadTable(query);
            selectTableComboBox.ValueMember = "Object_name";
            selectTableComboBox.DataSource = dataTable;
        }
        private void LoadColDGV()
        {
            Modify modify = new Modify();
            string query = "SELECT COLUMN_NAME " +
                           "FROM ALL_TAB_COLUMNS " +
                           $"WHERE TABLE_NAME = '{table}'";

            // Get the column names from the database
            DataTable columnNames = modify.LoadTable(query);

            // Clear existing columns in DataGridView
            //attributesDGV.Columns.Clear();

            // Add a single checkbox column to DataGridView
            //DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            //checkBoxColumn.HeaderText = "Column";
            //checkBoxColumn.Width = 5;
            //checkBoxColumn.Name = "Check";
            //attributesDGV.Columns.Add(checkBoxColumn);

            // Add column names as rows and set the names
            foreach (DataRow row in columnNames.Rows)
            {
                // Get column name from DataRow
                string columnName = row["COLUMN_NAME"].ToString();

                // Add a new row to the DataGridView
                DataGridViewRow newRow = new DataGridViewRow();

                // Create a new checkbox cell
                DataGridViewCheckBoxCell checkBoxCell = new DataGridViewCheckBoxCell();
                checkBoxCell.Value = false; // Set initial value to unchecked
             

                // Add the checkbox cell to the new row
                newRow.Cells.Add(checkBoxCell);

                // Add the column name as the name of the row
                newRow.HeaderCell.Value = columnName;
                // Adjust size of headercell
                //newRow.HeaderCell.Style.Padding = new Padding(50, 0, 50, 0);

                // Add the row to the DataGridView
                attributesDGV.Rows.Add(newRow);
            }
        }

        private List<string> GetCheckedColumns(DataGridView dgv)
        {
            List<string> checkedColumns = new List<string>();

            // Duyệt qua các hàng trong DataGridView
            foreach (DataGridViewRow row in dgv.Rows)
            {
                // Kiểm tra xem hàng có được chọn không
                if (row.Cells[0].Value != null && (bool)row.Cells[0].Value)
                {
                    // Lấy tên cột từ HeaderCell của hàng
                    string columnName = row.HeaderCell.Value.ToString();

                    // Thêm tên cột vào mảng
                    checkedColumns.Add(columnName);
                }
            }

            return checkedColumns;
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
                        using (OracleConnection oracleConnection = Connection.GetOracleConnection())
                        {
                            oracleConnection.Open();
                            string query = "";
                            //MessageBox.Show(withGrantOption.ToString());
                            if (withGrantOption == true)
                            {
                                query = $"GRANT {privilege} ON {table} TO {username} WITH GRANT OPTION";
                            }
                            else
                            {
                                query = $"GRANT {privilege} ON {table} TO {username}";
                            }
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
                        MessageBox.Show("Error granting to user: " + ex.Message);
                    }

                }
                else
                {
                    MessageBox.Show("Ban phan quyen den muc cot");
                    // Code chuc nang cuoi
                    LoadColDGV();
                    List<string> col = new List<string>(){"NAME" };//GetCheckedColumns(attributesDGV);
                    if(col.Count() == 0)
                    {
                        MessageBox.Show("Please check at least one column to grant!");
                    }
                    else
                    {
                        try
                        {
                            using (OracleConnection oracleConnection = Connection.GetOracleConnection())
                            {
                                oracleConnection.Open();
                                string query = $"GRANT {privilege} (";
                                //MessageBox.Show(withGrantOption.ToString());
                                for(int i = 0; i < col.Count(); i++)
                                {
                                    query += col[i];
                                    if (i != col.Count() - 1)
                                    {
                                        query += ",";
                                    }
                                }
                                query += ")";
                                if (withGrantOption == true)
                                {
                                    query += $" ON {table} TO {username} WITH GRANT OPTION";
                                }
                                else
                                {
                                    query += $" ON {table} TO {username}";
                                }
                                using (OracleCommand command = new OracleCommand(query, oracleConnection))
                                {
                                    command.ExecuteNonQuery();
                                    MessageBox.Show("Privilege granted to column level successfully.");
                                }
                                oracleConnection.Close();
                            }
                            // Exit adding window
                            this.Hide();


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error granting to user to column level: " + ex.Message);
                        }
                    }
                }
            }

        }

        private void grantToColCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(grantToColCheckBox.Checked == true)
            {
                if (selectPrivilegeComboBox.Text == "SELECT" || selectPrivilegeComboBox.Text == "UPDATE")
                {
                    attributesDGV.Show();
                }
                else
                {
                    MessageBox.Show("Only allow grant to column for SELECT OR UPDATE !");
                }
            }
            else
            {
                attributesDGV.Hide();
            }
        }

        private void selectTableComboBox_TextChanged(object sender, EventArgs e)
        {
            table = selectTableComboBox.Text;
            LoadColDGV();   
        }

        private void selectPrivilegeComboBox_TextChanged(object sender, EventArgs e)
        {
            Privilege = selectPrivilegeComboBox.Text;
        }
    }
}

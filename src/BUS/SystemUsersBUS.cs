using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemUsersDAO = DAO.SystemUsersDAO;

namespace BUS
{
    public class SystemUsersBUS
    {
        private SystemUsersDAO systemUsers;
        public SystemUsersBUS()
        {
            systemUsers = new SystemUsersDAO();
        }
        public DataTable GetAllSystemUsers()
        {
            try
            { 
                return systemUsers.GetAllSystemUsers(); // Gọi phương thức từ DAO để lấy danh sách người dùng
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return null;
            }
        }
        public DataTable FilterSystemUsers(string userName)
        {
            if (userName == "")
            {
                return systemUsers.GetAllSystemUsers(); // Gọi phương thức từ DAO để lấy danh sách người dùng
            }
            else
            {
                try
                {
                    return systemUsers.FilterSystemUsers(userName); // Gọi phương thức từ DAO để lấy danh sách người dùng
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                    return null;
                }
            }
        }
    }
    
}

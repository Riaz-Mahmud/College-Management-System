using Final_Project.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Repository
{
    public class LoginRepository
    {
        DataAccess dataAccess;
        public LoginRepository()
        {
            dataAccess = new DataAccess();
        }

        public int ValidationTeacher(User user)
        {
            dataAccess = new DataAccess();
            string sql = "SELECT * FROM Teacher_info WHERE username='" + user.Username + "' AND password='" + user.Password + "' AND status='active'";
            SqlDataReader reader = dataAccess.GetData(sql);
            reader.Read();
            try
            {
                int userType = (int)reader["userType"];
                if (userType == 2)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception)
            {
                return 0;
            }  
            
        }

        public int ValidationAdmin(User user)
        {
            dataAccess = new DataAccess();
            string sql = "SELECT * FROM admin_info WHERE username='" + user.Username + "' AND password='" + user.Password + "' AND status='active'";
            SqlDataReader reader = dataAccess.GetData(sql);
            reader.Read();
            try 
            {
                int userType = (int)reader["userType"];
                if (userType == 1)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch(Exception)
            {
                return 0;
            }            
        }

        public int ValidationStudent(User user)
        {
            dataAccess = new DataAccess();
            string sql = "SELECT * FROM Students_Info WHERE username='" + user.Username + "' AND password='" + user.Password + "' AND status='active'";
            SqlDataReader reader = dataAccess.GetData(sql);
            reader.Read();
            try
            {
                int userType = (int)reader["userType"];
                if (userType == 3)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }catch(Exception)
            {
                return 0;
            }
            
        }
    }
}

using Final_Project.Entities;
using Final_Project.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Repository
{
    public class AdminTeacherRepository : AdminTeacherIRepository<Teacher>
    {
        DataAccess dataAccess;

        public AdminTeacherRepository()
        {
            this.dataAccess = new DataAccess();
        }


        public List<Teacher> GetAllTeachers()
        {
            dataAccess = new DataAccess();
            string sql = "SELECT * FROM Teacher_info";
            SqlDataReader reader = dataAccess.GetData(sql);
            List<Teacher> teacherList = new List<Teacher>();

            while (reader.Read())
            {
                Teacher teacher = new Teacher();
                teacher.Id = Convert.ToInt32(reader["id"]);
                teacher.Username = reader["username"].ToString();
                teacher.Name = reader["name"].ToString();
                teacher.Birthdate = reader["birthdate"].ToString();
                teacher.Address = reader["address"].ToString();
                teacher.Phone = reader["number"].ToString();
                teacher.Status = reader["status"].ToString();
                teacherList.Add(teacher);
            }
            dataAccess.Dispose();
            return teacherList;
        }

        public int Insert(Teacher entity)
        {
            dataAccess = new DataAccess();
            string sql = "INSERT INTO Teacher_info(userType,username,password,name,birthdate,address,number,status) VALUES('" + entity.Type + "','" + entity.Username + "','" + entity.Password + "','" + entity.Name + "','" + entity.Birthdate + "','" + entity.Address + "','" + entity.Phone + "','" + entity.Status + "')";
            int result = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return result;
        }

        
        public int Update(Teacher teacher)
        {
            dataAccess = new DataAccess();
            string sql = "UPDATE Teacher_info SET name='" + teacher.Name + "',birthdate='" + teacher.Birthdate + "',address='" + teacher.Address + "',number='" + teacher.Phone + "',status='" + teacher.Status + "' WHERE username='" + teacher.Username + "'";
            int result = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return result;
        }

        public int Delete(int id)
        {
            dataAccess = new DataAccess();
            string sql = "DELETE FROM Teacher_info WHERE Id=" + id;
            int result = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return result;
        }
    }
}

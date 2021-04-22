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
    public class AdminCourseRepository : ACourseIRepository<Course>
    {
        DataAccess dataAccess;
        public AdminCourseRepository()
        {
            this.dataAccess = new DataAccess();
        }

        public List<Course> GetAllCourse()
        {
            dataAccess = new DataAccess();
            string sql = "SELECT * FROM Course_Info";
            SqlDataReader reader = dataAccess.GetData(sql);
            List<Course> courseList = new List<Course>();

            while (reader.Read())
            {
                Course course = new Course();
                course.Id = Convert.ToInt32(reader["cid"]);
                course.CourseName = reader["courseName"].ToString();
                course.Class = reader["class"].ToString();
                course.Status = reader["status"].ToString();
                courseList.Add(course);
            }
            dataAccess.Dispose();
            return courseList;
        }

        public int Insert(Course entity)
        {
            dataAccess = new DataAccess();
            string sql = "INSERT INTO Course_Info(courseName,class,status) VALUES('" + entity.CourseName + "','" + entity.Class + "','" + entity.Status + "')";
            int result = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return result;
        }

        public int Update(Course course)
        {
            dataAccess = new DataAccess();
            string sql = "UPDATE Course_Info SET courseName='" + course.CourseName + "',class='" + course.Class + "',status='" + course.Status + "'  WHERE cid='" + course.Id + "'";
            int result = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return result;
        }

        public int chekcAlreadyAvailable(Course course)
        {
            dataAccess = new DataAccess();
            string sql = "SELECT count(courseName) as 'total' FROM Course_Info where courseName='" + course.CourseName + "' and class= '" + course.Class + "' and status = 'active' ";
            SqlDataReader reader = dataAccess.GetData(sql);
            reader.Read();

            int result = Convert.ToInt32(reader["total"]);

            dataAccess.Dispose();
            return result;
            
        }
    }
}

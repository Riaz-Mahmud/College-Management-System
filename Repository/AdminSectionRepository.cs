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
    public class AdminSectionRepository : ASectionIRepository<Section>
    {
        DataAccess dataAccess;
        public AdminSectionRepository()
        {
            this.dataAccess = new DataAccess();
        }

        public List<Section> GetAllSection()
        {
            dataAccess = new DataAccess();
            string sql = "SELECT * FROM Section_Info order by SectionName";
            SqlDataReader reader = dataAccess.GetData(sql);
            List<Section> sectionList = new List<Section>();

            while (reader.Read())
            {
                Section section = new Section();
                section.Id = Convert.ToInt32(reader["Sid"]);
                section.SectionName = reader["SectionName"].ToString();
                section.Class = reader["SectionClass"].ToString();
                section.SectionLimit = reader["SectionLimit"].ToString();
                section.Status = reader["status"].ToString();
                sectionList.Add(section);
            }
            dataAccess.Dispose();
            return sectionList;
        }

        public List<Section> GetAllSectionTeacher()
        {
            dataAccess = new DataAccess();
            string sql = "SELECT * FROM sectionTeacher_Info order by SectionName";
            SqlDataReader reader = dataAccess.GetData(sql);
            List<Section> sectionList = new List<Section>();

            while (reader.Read())
            {
                Section section = new Section();
                section.Id = Convert.ToInt32(reader["id"]);
                section.CourseName = reader["courseName"].ToString();
                section.TeacherName = reader["teacherName"].ToString();
                section.SectionName = reader["sectionName"].ToString();
                section.Class = reader["courseClass"].ToString();
                section.Status = reader["status"].ToString();
                sectionList.Add(section);
            }
            dataAccess.Dispose();
            return sectionList;
        }

        public int Insert(Section entity)
        {
            dataAccess = new DataAccess();
            string sql = "INSERT INTO Section_Info(SectionClass,SectionName,SectionLimit,status) VALUES('" + entity.Class + "','" + entity.SectionName + "','" + entity.SectionLimit + "','" + entity.Status + "')";
            int result = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return result;
        }

        public int Update(Section entity)
        {
            dataAccess = new DataAccess();
            string sql = "UPDATE Section_Info SET SectionName='" + entity.SectionName + "',SectionClass='" + entity.Class + "',SectionLimit='" + entity.SectionLimit + "', status='" + entity.Status + "'  WHERE Sid='" + entity.Id + "'";
            int result = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return result;
        }

        public int UpdateSectionTeacaher(Section entity)
        {
            dataAccess = new DataAccess();
            string sql = "UPDATE sectionTeacher_Info SET courseName='" + entity.CourseName + "',teacherName='" + entity.TeacherName + "',sectionName='" + entity.SectionName + "',courseClass='" + entity.Class + "', status='" + entity.Status + "'  WHERE id='" + entity.Id + "'";
            int result = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return result;
        }

        public int InsertTeacher(Section entity)
        {
            dataAccess = new DataAccess();
            string sql = "INSERT INTO sectionTeacher_Info(sectionName,courseName,teacherName,courseClass,status) VALUES('" + entity.SectionName + "','" + entity.CourseName + "','" + entity.TeacherName + "','" + entity.Class + "','" + entity.Status + "')";
            int result = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return result;
        }

        public List<string> GetAllCourseNames(string year)
        {
            dataAccess = new DataAccess();
            string sql = "SELECT courseName FROM Course_Info where class='"+ year+"' and status = 'active'";
            SqlDataReader reader = dataAccess.GetData(sql);
            List<string> courseList = new List<string>();
            while (reader.Read())
            {
                courseList.Add(reader["courseName"].ToString());
            }
            dataAccess.Dispose();
            return courseList;

        }

        public List<string> GetAllTeacherNames()
        {
            dataAccess = new DataAccess();
            string sql = "SELECT username FROM Teacher_info where status = 'active'";
            SqlDataReader reader = dataAccess.GetData(sql);
            List<string> teacherList = new List<string>();
            while (reader.Read())
            {
                teacherList.Add(reader["username"].ToString());
            }
            dataAccess.Dispose();
            return teacherList;

        }

        public List<string> GetAllSectionName(string year)
        {
            dataAccess = new DataAccess();
            string sql = "SELECT SectionName FROM Section_Info where SectionClass='"+ year +"' and status = 'active'";
            SqlDataReader reader = dataAccess.GetData(sql);
            List<string> teacherList = new List<string>();
            while (reader.Read())
            {
                teacherList.Add(reader["SectionName"].ToString());
            }
            dataAccess.Dispose();
            return teacherList;

        }

        public List<string> GetAllSectionByYear(string year)
        {
            dataAccess = new DataAccess();
            string sql = "SELECT SectionName FROM Section_Info WHERE SectionClass='" + year + "'";
            SqlDataReader reader = dataAccess.GetData(sql);
            List<string> sectionList = new List<string>();
            while (reader.Read())
            {
                sectionList.Add(reader["SectionName"].ToString());
            }
            dataAccess.Dispose();
            return sectionList;

        }

        public int checkLimit(string year, string sectionName)
        {
            dataAccess = new DataAccess();
            string sql1 = "Select * from Section_Info where SectionClass = '" + year + "' and SectionName = '" + sectionName + "'";
            //string sql = "SELECT * FROM Section_Info WHERE SectionClass='" + year + "' AND SectionName='" + sectionName + "'";
            SqlDataReader reader = dataAccess.GetData(sql1);
            reader.Read();
            
                int limit = Convert.ToInt32(reader["SectionLimit"]);
                return limit;
            
        }

        public int checkSectionLimit(string year, string sectionName)
        {
            int limit = checkLimit(year,sectionName);

            dataAccess = new DataAccess();
            string sql = "SELECT count(username) as 'total' FROM Students_Info where collegeyear='"+ year+"' and section= '"+sectionName+"' and status = 'active' ";
            SqlDataReader reader = dataAccess.GetData(sql);
            reader.Read();

            int result = Convert.ToInt32(reader["total"]);

            dataAccess.Dispose();
            if (limit == result)
            {
                return 0;
            }
            else if (limit > result)
            {
                return 1;
            }
            else
            {
                return 0;
            } 
        }


        public List<string> GetAllSectionByTeacher(string username ,string year)
        {
            dataAccess = new DataAccess();
            string sql = "SELECT sectionName FROM sectionTeacher_Info WHERE teacherName='" + username + "' and courseClass='"+ year +"' and status = 'active'";
            SqlDataReader reader = dataAccess.GetData(sql);
            List<string> sectionList = new List<string>();
            while (reader.Read())
            {
                sectionList.Add(reader["sectionName"].ToString());
            }
            dataAccess.Dispose();
            return sectionList;

        }
        
        public List<string> GetAllCourseByTeacher(string username, string year, string section)
        {
            dataAccess = new DataAccess();
            string sql = "SELECT courseName FROM sectionTeacher_Info WHERE teacherName='" + username + "' and courseClass='" + year + "' and sectionName='"+ section+"' and status = 'active'";
            SqlDataReader reader = dataAccess.GetData(sql);
            List<string> sectionList = new List<string>();
            while (reader.Read())
            {
                sectionList.Add(reader["courseName"].ToString());
            }
            dataAccess.Dispose();
            return sectionList;

        }

        public int checkSectionAvailable(Section section)
        {
            dataAccess = new DataAccess();
            string sql = "SELECT count(SectionName) as 'total' FROM Section_Info where SectionName='" + section.SectionName + "' and SectionClass= '" + section.Class + "' and status = 'active' ";
            SqlDataReader reader = dataAccess.GetData(sql);
            reader.Read();

            int result = Convert.ToInt32(reader["total"]);

            dataAccess.Dispose();
            return result;
        }

        public List<courseForTeacher> GetAllCourseListForTeacher(string username)
        {
            dataAccess = new DataAccess();
            string sql = "SELECT * FROM sectionTeacher_Info where teacherName = '" + username + "'";
            SqlDataReader reader = dataAccess.GetData(sql);
            List<courseForTeacher> courseList = new List<courseForTeacher>();

            while (reader.Read())
            {
                courseForTeacher course = new courseForTeacher();
                course.Id = Convert.ToInt32(reader["id"]);
                course.sectionName = reader["sectionName"].ToString();
                course.CourseName = reader["courseName"].ToString();
                course.teacherName = reader["teacherName"].ToString();
                course.Class = reader["courseClass"].ToString();
                course.Status = reader["status"].ToString();
                courseList.Add(course);
            }
            dataAccess.Dispose();
            return courseList;

        }
    }
}

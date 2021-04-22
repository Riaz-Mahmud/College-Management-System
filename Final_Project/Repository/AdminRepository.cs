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
    public class AdminRepository : IRepository<Students>
    {
        DataAccess dataAccess;
        public AdminRepository()
        {
            this.dataAccess = new DataAccess();
        }

        public int Insert(Students entity)
        {
            dataAccess = new DataAccess();
            string sql = "INSERT INTO Students_Info(userType,username,password,name,birthdate,sex,address,fathername,mothername,familyphone,collegeyear,section ,status) VALUES('" + entity.Type + "','" + entity.Username + "','" + entity.Password + "','" + entity.Name + "','" + entity.Birthdate + "','" + entity.Sex + "','" + entity.Address + "','" + entity.FatherName + "','" + entity.MotherName + "','" + entity.FamilyPhone + "','" + entity.CollegeYear + "','" + entity.Section + "','" + entity.Status + "')";
            int result = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return result;
        }

        public List<Students> GetAllStudents()
        {
            dataAccess = new DataAccess();
            string sql = "SELECT * FROM Students_Info";
            SqlDataReader reader = dataAccess.GetData(sql);
            List<Students> studentList = new List<Students>();
            
            while (reader.Read())
            {
                Students students = new Students();
                students.Id = Convert.ToInt32(reader["id"]);
                students.Username = reader["username"].ToString();
                students.Name = reader["name"].ToString();
                students.Birthdate = reader["birthdate"].ToString();
                students.Sex = reader["sex"].ToString();
                students.Address = reader["address"].ToString();
                students.FatherName = reader["fathername"].ToString();
                students.MotherName = reader["mothername"].ToString();
                students.FamilyPhone = reader["familyphone"].ToString();
                students.Section = reader["section"].ToString();
                students.CollegeYear = reader["collegeyear"].ToString();
                students.Status = reader["status"].ToString();
                studentList.Add(students);
            }
            dataAccess.Dispose();
            return studentList;
        }

        public int Update(Students student)
        {
            dataAccess = new DataAccess();
            string sql = "UPDATE Students_Info SET name='" + student.Name + "',birthdate='" + student.Birthdate + "',sex='" + student.Sex + "',address='" + student.Address + "',fathername='" + student.FatherName + "',mothername='" + student.MotherName + "',familyphone='" + student.FamilyPhone + "',collegeyear='" + student.CollegeYear + "',status='" + student.Status + "'  WHERE username='" + student.Username + "'";
            int result = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return result;
        }

        public int Delete(int id)
        {
            dataAccess = new DataAccess();
            string sql = "DELETE FROM Students_Info WHERE Id=" + id;
            int result = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return result;
        }

        public Students GetUserInfo(string username)
        {
            Students student = new Students();
            try
            {
                dataAccess = new DataAccess();
                string sql = "SELECT * FROM Students_Info WHERE username ='" + username + "'";
                SqlDataReader reader = dataAccess.GetData(sql);
                reader.Read();
                
                student.Id = Convert.ToInt32(reader["id"]);
                student.Username = reader["username"].ToString();
                student.Name = reader["name"].ToString();
                student.CollegeYear = reader["collegeyear"].ToString();
                dataAccess.Dispose();
                return student;
            }
            catch(Exception )
            {
                student.Username = "";
                return student;
            }
            
        }

        public string GetTotalStudentCount()
        {
            dataAccess = new DataAccess();
            string sql = "SELECT count(username) as 'total' FROM Students_Info";
            SqlDataReader reader = dataAccess.GetData(sql);
            reader.Read();

            string result = reader["total"].ToString();

            dataAccess.Dispose();
            return result;
        }

        public string GetTotalActiveStudentCount()
        {
            dataAccess = new DataAccess();
            string sql = "SELECT count(status) as 'total' FROM Students_Info where status = 'active'";
            SqlDataReader reader = dataAccess.GetData(sql);
            reader.Read();
            string result = reader["total"].ToString();
            dataAccess.Dispose();
            return result;
        }

        public string GetTotalTeacherCount()
        {
            dataAccess = new DataAccess();
            string sql = "SELECT count(username) as 'total' FROM Teacher_info";
            SqlDataReader reader = dataAccess.GetData(sql);
            reader.Read();

            string result = reader["total"].ToString();

            dataAccess.Dispose();
            return result;
        }

        public string GetTotalActiveTeacherCount()
        {
            dataAccess = new DataAccess();
            string sql = "SELECT count(status) as 'total' FROM Teacher_info where status = 'active'";
            SqlDataReader reader = dataAccess.GetData(sql);
            reader.Read();
            string result = reader["total"].ToString();
            dataAccess.Dispose();
            return result;
        }

        public string GetTotalCourseCount()
        {
            dataAccess = new DataAccess();
            string sql = "SELECT count(courseName) as 'total' FROM Course_Info";
            SqlDataReader reader = dataAccess.GetData(sql);
            reader.Read();

            string result = reader["total"].ToString();

            dataAccess.Dispose();
            return result;
        }

        public string GetTotalActiveCourseCount()
        {
            dataAccess = new DataAccess();
            string sql = "SELECT count(status) as 'total' FROM Course_Info where status = 'active'";
            SqlDataReader reader = dataAccess.GetData(sql);
            reader.Read();
            string result = reader["total"].ToString();
            dataAccess.Dispose();
            return result;
        }

        public int checkUserNameTaken(string username)
        {
            dataAccess = new DataAccess();
            string sql = "SELECT * FROM Students_Info WHERE username='" + username + "' ";
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
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int checkTeacherUsernameAlreadyAvailable(string username)
        {
            dataAccess = new DataAccess();
            string sql = "SELECT * FROM Teacher_info WHERE username='" + username + "' ";
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

        public string ViewGradeLockStatus()
        {
            dataAccess = new DataAccess();
            string sql = "SELECT * FROM Grade_Lock";
            SqlDataReader reader = dataAccess.GetData(sql);
            reader.Read();
            string status = reader["lock"].ToString();
            return status;
        }

        public int UpdateGradeLockStatus(string status)
        {
            dataAccess = new DataAccess();
            string sql = "UPDATE Grade_Lock SET lock='" + status + "' ";
            int result = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return result;
        }

        public List<AcademicYear> LoadAcademicYear()
        {
            dataAccess = new DataAccess();
            string sql = "SELECT * FROM AcademicYearSetting";
            SqlDataReader reader = dataAccess.GetData(sql);
            List<AcademicYear> academicYear = new List<AcademicYear>();

            while (reader.Read())
            {
                AcademicYear acaYear = new AcademicYear();
                acaYear.Id = Convert.ToInt32(reader["id"]);
                acaYear.Year = reader["academicYear"].ToString();
                acaYear.Status = reader["status"].ToString();
                academicYear.Add(acaYear);
            }
            dataAccess.Dispose();
            return academicYear;
        }

        public int DeleteAcademicYear(int id)
        {
            dataAccess = new DataAccess();
            string sql = "DELETE FROM AcademicYearSetting WHERE id='" + id + "'";
            int result = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return result;
        }

        public int AddNewAcademicYear(string year)
        {
            dataAccess = new DataAccess();
            string sql = "INSERT INTO AcademicYearSetting(academicYear,status) VALUES('"+ year + "','active')";
            int result = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return result;
        }

        //From Student DashBoard

        public Students GetCurrentUserInfo(User user)
        {
            Students student = new Students();
            try
            {
                dataAccess = new DataAccess();
                string sql = "SELECT * FROM Students_Info WHERE username ='" + user.Username+ "'";
                SqlDataReader reader = dataAccess.GetData(sql);
                reader.Read();

                student.Id = Convert.ToInt32(reader["id"]);
                student.Username = reader["username"].ToString();
                student.Name = reader["name"].ToString();
                student.CollegeYear = reader["collegeyear"].ToString();
                student.FatherName = reader["fathername"].ToString();
                student.Birthdate = reader["birthdate"].ToString();
                student.MotherName = reader["mothername"].ToString();
                student.FamilyPhone = reader["familyphone"].ToString();
                student.Section = reader["section"].ToString();
                student.Address = reader["address"].ToString();
                dataAccess.Dispose();
                return student;
            }
            catch (Exception)
            {
                student.Username = "";
                return student;
            }

        }

        public List<Notification> GetAllNotice(string username)
        {
            var data = GetCurrentUserInfo(new User() { Username = username });
            dataAccess = new DataAccess();
            string sql = "SELECT * FROM Notification where forClass ='" + data.CollegeYear + "' and section ='" + data.Section + "' and status= 'active'";
            SqlDataReader reader = dataAccess.GetData(sql);
            List<Notification> noticeList = new List<Notification>();

            while (reader.Read())
            {
                Notification notification = new Notification();
                notification.Id = Convert.ToInt32(reader["id"]);
                notification.From = reader["fromTeacher"].ToString();
                notification.Message = reader["message"].ToString();
                notification.Class = reader["forClass"].ToString();
                notification.Section = reader["section"].ToString();
                notification.Status = reader["status"].ToString();
                
                noticeList.Add(notification);
            }
            dataAccess.Dispose();
            return noticeList;
        }

        //
        public List<Marks> GetAllMarksDataByStudent(string USERNAME)
        {
            var data = GetCurrentUserInfo(new User() { Username = USERNAME });
            dataAccess = new DataAccess();
            string sql = "SELECT * FROM Students_Marks where courseClass ='" + data.CollegeYear + "' and section ='" + data.Section + "' and studentUName ='" + USERNAME + "' and year ='2020' and status= 'active'";
            SqlDataReader reader = dataAccess.GetData(sql);
            List<Marks> markList = new List<Marks>();

            while (reader.Read())
            {
                Marks marksStudent = new Marks();
                marksStudent.Id = Convert.ToInt32(reader["id"]);
                marksStudent.Class = reader["courseClass"].ToString();
                marksStudent.Section = reader["section"].ToString();
                marksStudent.Subject = reader["subjectName"].ToString();
                marksStudent.MidMarks = Convert.ToSingle(reader["midMarks"]);
                marksStudent.FinalMarks = Convert.ToSingle(reader["finalMarks"]);
                marksStudent.Student = reader["studentUName"].ToString();
                marksStudent.Year = reader["year"].ToString();
                marksStudent.Status = reader["status"].ToString();

                markList.Add(marksStudent);
            }
            dataAccess.Dispose();
            return markList;
        }
        
        //teacher 
        public Teacher LoadTeacherDetails(User user)
        {
            Teacher teacher = new Teacher();
            try
            {
                dataAccess = new DataAccess();
                string sql = "SELECT * FROM Teacher_info WHERE username ='" + user.Username + "'";
                SqlDataReader reader = dataAccess.GetData(sql);
                reader.Read();

                teacher.Id = Convert.ToInt32(reader["id"]);
                teacher.Username = reader["username"].ToString();
                teacher.Name = reader["name"].ToString();
                teacher.Birthdate = reader["birthdate"].ToString();
                teacher.Phone = reader["number"].ToString();
                teacher.Address = reader["address"].ToString();
                dataAccess.Dispose();
                return teacher;
            }
            catch (Exception)
            {
                teacher.Username = "";
                return teacher;
            }

        }

        public int AddNewNotice(Notification notify)
        {
            dataAccess = new DataAccess();
            string sql = "INSERT INTO Notification(fromTeacher,forClass,section,message,status) VALUES('" + notify.From + "','" + notify.Class + "','" + notify.Section + "','" + notify.Message + "','" + notify.Status + "')";
            int result = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return result;
        }

        public List<Notification> GetAllNoticeByTeacher(string username)
        {
            dataAccess = new DataAccess();
            string sql = "SELECT * FROM Notification where fromTeacher ='" + username + "' and status= 'active'";
            SqlDataReader reader = dataAccess.GetData(sql);
            List<Notification> noticeList = new List<Notification>();

            while (reader.Read())
            {
                Notification notification = new Notification();
                notification.Id = Convert.ToInt32(reader["id"]);
                notification.From = reader["fromTeacher"].ToString();
                notification.Message = reader["message"].ToString();
                notification.Class = reader["forClass"].ToString();
                notification.Section = reader["section"].ToString();
                notification.Status = reader["status"].ToString();

                noticeList.Add(notification);
            }
            dataAccess.Dispose();
            return noticeList;
        }

        public List<SectionStudent> GetAllSectionStudentByTeacher(string year, string section)
        {
            dataAccess = new DataAccess();
            string sql = "SELECT * FROM Students_Info where collegeyear ='" + year + "' and section ='" + section + "' and status= 'active'";
            SqlDataReader reader = dataAccess.GetData(sql);
            List<SectionStudent> studentList = new List<SectionStudent>();

            while (reader.Read())
            {
                SectionStudent sectionStudent = new SectionStudent();
                sectionStudent.Id = Convert.ToInt32(reader["id"]);
                sectionStudent.Name = reader["name"].ToString();
                sectionStudent.Gender = reader["sex"].ToString();
                sectionStudent.CollegeYear = reader["collegeyear"].ToString();
                sectionStudent.Username = reader["username"].ToString();
                sectionStudent.Section = reader["section"].ToString();
                sectionStudent.Status = reader["status"].ToString();

                studentList.Add(sectionStudent);
            }
            dataAccess.Dispose();
            return studentList;
        }
        
        public List<Marks> GetAllSectionStudentResultByTeacher(Marks marks)
        {
            dataAccess = new DataAccess();
            string sql = "SELECT * FROM Students_Marks where courseClass ='" + marks.Class + "' and section ='" + marks.Section + "' and subjectName ='" + marks.Subject + "' and year ='" + marks.Year + "' and status= 'active'";
            SqlDataReader reader = dataAccess.GetData(sql);
            List<Marks> markList = new List<Marks>();

            while (reader.Read())
            {
                Marks marksStudent = new Marks();
                marksStudent.Id = Convert.ToInt32(reader["id"]);
                marksStudent.Class = reader["courseClass"].ToString();
                marksStudent.Section = reader["section"].ToString();
                marksStudent.Subject = reader["subjectName"].ToString();
                marksStudent.MidMarks = Convert.ToSingle(reader["midMarks"]);
                marksStudent.FinalMarks = Convert.ToSingle(reader["finalMarks"]);
                marksStudent.Student = reader["studentUName"].ToString();
                marksStudent.Year = reader["year"].ToString();
                marksStudent.Status = reader["status"].ToString();

                markList.Add(marksStudent);
            }
            dataAccess.Dispose();
            return markList;
        }

        public int UploadStudentMidMark(Marks marks)
        {
            dataAccess = new DataAccess();
            string sql = "INSERT INTO Students_Marks(courseClass,section,subjectName,midMarks,studentUName,year,status) VALUES('" + marks.Class + "','" + marks.Section + "','" + marks.Subject + "','" + marks.MidMarks + "','" + marks.Student + "','" + marks.Year + "','" + marks.Status + "')";
            int result = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return result;
        }
        
        public int UploadStudentFinalMark(Marks marks)
        {
            dataAccess = new DataAccess();
            string sql = "UPDATE Students_Marks SET finalMarks='" + marks.FinalMarks + "' WHERE studentUName='" + marks.Student + "' and courseClass='" + marks.Class + "' and section='" + marks.Section + "' and subjectName='" + marks.Subject + "' and year='" + marks.Year + "'";
            int result = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return result;
        }

        public List<string> GetCurrentAcademicYear()
        {
            dataAccess = new DataAccess();
            string sql = "SELECT academicYear FROM AcademicYearSetting WHERE status = 'active'";
            SqlDataReader reader = dataAccess.GetData(sql);
            List<string> acaYear = new List<string>();
            while (reader.Read())
            {
                acaYear.Add(reader["academicYear"].ToString());
            }
            dataAccess.Dispose();
            return acaYear;

        }

        public int checkAlreadySubmitMidMark(Marks marks)
        {

            dataAccess = new DataAccess();
            string sql = "SELECT count(studentUName) as 'total' FROM Students_Marks where courseClass='" + marks.Class + "' and section= '" + marks.Section + "' and subjectName = '" + marks.Subject + "' and studentUName = '" + marks.Student + "' and year = '" + marks.Year + "' ";
            SqlDataReader reader = dataAccess.GetData(sql);
            reader.Read();

            int result = Convert.ToInt32(reader["total"]);

            dataAccess.Dispose();
            return result;
        }

        public int EditStudentMidMark(Marks marks)
        {
            dataAccess = new DataAccess();
            string sql = "UPDATE Students_Marks SET midMarks='" + marks.MidMarks + "' WHERE studentUName='" + marks.Student + "' and courseClass='" + marks.Class + "' and section='" + marks.Section + "' and subjectName='" + marks.Subject + "' and year='" + marks.Year + "'";
            int result = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return result;
        }

        public int DeleteNoticeByTeacher(int id)
        {
            dataAccess = new DataAccess();
            string sql = "DELETE FROM Notification WHERE id='" + id + "'";
            int result = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return result;
        }

        

    }
}

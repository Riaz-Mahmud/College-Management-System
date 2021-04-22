using Final_Project.Entities;
using Final_Project.Interfaces;
using Final_Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Services
{
    public class AdminService
    {
        IRepository<Students> repo;
        AdminTeacherIRepository<Teacher> teacherRepo;
        ACourseIRepository<Course> courseRepo;
        ASectionIRepository<Section> sectionRepo;
        TransactionIRepository<Transaction> transRepo;

        AdminSectionRepository secRepo;
        AdminRepository adminRepo;
        
       
       
        public AdminService()
        {
            this.repo = new AdminRepository();
            this.teacherRepo = new AdminTeacherRepository();
            this.courseRepo = new AdminCourseRepository();
            this.sectionRepo = new AdminSectionRepository();
            this.transRepo = new TransactionRepository();
            this.secRepo = new AdminSectionRepository();
            this.adminRepo = new AdminRepository();
   
        }

        public List<Students> GetAllStudents()
        {
            return repo.GetAllStudents();
        }

        public int AddStudents(string username, string password, string name, string birthdate, string sex, string address, string fatherName, string motherName, string familyPhone, string collegeYear, string section ,string status, string type)
        {
            int result = repo.Insert(new Students() { Username = username, Password = password, Name = name, Birthdate = birthdate, Sex = sex, Address = address, FatherName = fatherName, MotherName = motherName, FamilyPhone = familyPhone, CollegeYear = collegeYear, Section= section, Status = status, Type= type });
            return result;
        }

        public int EditStudent(string username, string name, string birthday, string sex, string address, string fathername, string mothername, string familyPhone, string year, string status)
        {
            int result = repo.Update(new Students() { Username= username, Name = name, Birthdate= birthday, Sex = sex, Address= address, FatherName = fathername, MotherName = mothername, FamilyPhone = familyPhone, CollegeYear = year, Status = status });
            return result;
        }

        public int RemoveStudent(int id)
        {
            int result = repo.Delete(id);
            return result;
        }

        public Students GetUserbyUsername(string username)
        {
            var data = repo.GetUserInfo(username);
            return data;
        }
        
        public List<Teacher> GetAllTeacher()
        {
            return teacherRepo.GetAllTeachers();
        }

        public int AddTeacher(string type, string username, string password, string name, string birthdate, string address, string number, string status)
        {
            int result = teacherRepo.Insert(new Teacher() { Type= type, Username = username, Password = password, Name= name, Birthdate= birthdate, Address= address, Phone= number, Status= status });
            return result;
        }

        public int EditTeacher(string username, string name, string birthday, string address, string phone, string status)
        {
            int result = teacherRepo.Update(new Teacher() { Username = username, Name = name, Birthdate = birthday, Address = address, Phone = phone, Status = status });
            return result;
        }

        public int RemoveTeacher(int id)
        {
            int result = teacherRepo.Delete(id);
            return result;
        }

        public List<Course> GetAllCourse()
        {
            return courseRepo.GetAllCourse();
        }

        public int AddCourse(string courseName, string Class, string status)
        {
            int result = courseRepo.Insert(new Course() { CourseName = courseName, Class = Class, Status = status});
            return result;
        }

        public int EditCourse(int id, string courseName, string Class, string status)
        {
            int result = courseRepo.Update(new Course() { Id = id, CourseName = courseName, Class = Class, Status = status });
            return result;
        }

        public List<Section> GetAllSection()
        {
            return sectionRepo.GetAllSection();
        }

        public List<Section> GetAllSectionTeacher()
        {
            return sectionRepo.GetAllSectionTeacher();
        }

        public List<Transaction> GetAllTransaction()
        {
            return transRepo.GetAllTransaction();
        }

        public List<Transaction> GetUserTransaction(string username)
        {
            return transRepo.GetUserTransaction(username);
        }

        public List<string> GetAllCourseNames(string year)
        {
            return secRepo.GetAllCourseNames(year);
        }

        public List<string> GetAllTeacherNames()
        {
            return secRepo.GetAllTeacherNames();
        }

        public List<string> GetAllSectionName(string year)
        {
            return secRepo.GetAllSectionName(year);
        }

        public List<string> GetAllSectionByYear(string year)
        {
            return secRepo.GetAllSectionByYear(year);
        }

        public int AddSection(string Class, string sectionName, string maxStudent ,string status)
        {
            int result = secRepo.Insert(new Section() { Class = Class, SectionName = sectionName, SectionLimit= maxStudent ,Status = status });
            return result;
        }

        public int AddTacherToSection(string sectionName, string courseName, string teacherName,string Class, string status)
        {
            int result = secRepo.InsertTeacher(new Section() { SectionName= sectionName, CourseName= courseName,TeacherName= teacherName, Class= Class, Status = status });
            return result;
        }

        public int EditSection(int id, string sectionClass, string sectionName, string limit, string status)
        {
            int result = sectionRepo.Update(new Section() { Id = id, SectionName = sectionName, Class = sectionClass, SectionLimit = limit, Status = status });
            return result;
        }

        public int EditSectionTeacher(int id, string courseName, string teacherName, string sectionClass, string sectionName, string status)
        {
            int result = secRepo.UpdateSectionTeacaher(new Section() { Id = id, CourseName = courseName, TeacherName = teacherName, SectionName = sectionName, Class = sectionClass, Status = status });
            return result;
        }

        public int LogOut()
        {
            try
            {
                User user = new User() { Username="",UserType=0 };
                return 1;
            }catch(Exception){
                return 0;
            }
        }

        public string GetTotalStudentCount()
        {
            string result = adminRepo.GetTotalStudentCount();
            return result;
        }

        public string GetTotalActiveStudentCount()
        {
            string result = adminRepo.GetTotalActiveStudentCount();
            return result;
        }

        public string GetTotalTeacherCount()
        {
            string result = adminRepo.GetTotalTeacherCount();
            return result;
        }

        public string GetTotalActiveTeacherCount()
        {
            string result = adminRepo.GetTotalActiveTeacherCount();
            return result;
        }

        public string GetTotalCourseCount()
        {
            string result = adminRepo.GetTotalCourseCount();
            return result;
        }

        public string GetTotalActiveCourseCount()
        {
            string result = adminRepo.GetTotalActiveCourseCount();
            return result;
        }

        public int DeleteTrnx(int trnx)
        {
            int result = transRepo.DeleteTrnx(trnx);
            return result;
        }

        public int checkSectionLimit(string year, string sectionName)
        {
            return secRepo.checkSectionLimit(year, sectionName);
            
        }

        public int checkUserNameTaken(string username)
        {
            return adminRepo.checkUserNameTaken(username);
        }

        public int checkTeacherUsernameAlreadyAvailable(string username)
        {
            return adminRepo.checkTeacherUsernameAlreadyAvailable(username);
        }


        public string UserTutionPaidOrNot(string uname, string type, string monthName, string year)
        {
            string username = transRepo.CheckTutionIsPayAlready(uname, type, monthName, year);
            return username;
        }

        public string UserExamFeePainOrNOt(string uname, string type, string year)
        {
            string username = transRepo.CheckExamFeeIsPayAlready(uname, type,year);
            return username;
        }

        public int AddNewTrnx(string username, string name, string date, string student_class, float amount, string type, string month, string year)
        {
            int result = transRepo.Insert(new Transaction() { Username = username, FullName = name, Payment_Date = date, Class = student_class, Amount = amount, Type = type, Month = month, Year= year });
            return result;
        }

        public int chekcAlreadyAvailable(string courseName, string year)
        {
            return courseRepo.chekcAlreadyAvailable(new Course() { CourseName = courseName, Class = year });
        }

        public int checkSectionAvailable(string year, string sectionName)
        {
            return secRepo.checkSectionAvailable(new Section() { SectionName = sectionName, Class = year });
        }

        public string ViewGradeLockStatus()
        {
            return adminRepo.ViewGradeLockStatus();
        }

        public int UpdateGradeLockStatus(string status)
        {
            return adminRepo.UpdateGradeLockStatus(status);
        }

        public List<AcademicYear> LoadAcademicYear()
        {
            return adminRepo.LoadAcademicYear();
        }

        public int DeleteAcademicYear(int id)
        {
            return adminRepo.DeleteAcademicYear(id);
        }

        public int AddNewAcademicYear(string year)
        {
            return adminRepo.AddNewAcademicYear( year);
        }

        //StudentService

        public Students GetCurrentUserbyUsername(string username)
        {
            var data = adminRepo.GetCurrentUserInfo(new User() { Username = username});
            return data;
        }

        public List<Notification> GetAllNotice(String username)
        {
            return adminRepo.GetAllNotice(username);
        }

        
        public List<Marks> GetAllMarksDataByStudent(string USERNAME)
        {
            return adminRepo.GetAllMarksDataByStudent(USERNAME );
        }

        //Teache Service

        public Teacher LoadTeacherDetails(string username)
        {
            var data = adminRepo.LoadTeacherDetails(new User() { Username = username });
            return data;
        }

        public List<string> GetAllSectionByTeacher(string username, string year)
        {
            return secRepo.GetAllSectionByTeacher(username,year);
        }
        
        public List<string> GetAllCourseByTeacher(string username, string year, string section)
        {
            return secRepo.GetAllCourseByTeacher(username, year, section);
        }

        public int AddNewNotice(string forClass, string section, string text, string from)
        {
            return adminRepo.AddNewNotice(new Notification() { From=from, Class= forClass, Section= section, Message= text, Status= "active" });
        }
        
        public List<Notification> GetAllNoticeByTeacher(String username)
        {
            return adminRepo.GetAllNoticeByTeacher(username);
        }
        
        public List<SectionStudent> GetAllSectionStudentByTeacher( string year, string section)
        {
            return adminRepo.GetAllSectionStudentByTeacher(year, section);
        }

        public List<Marks> GetAllSectionStudentResultByTeacher(string year, string section, string course, string acaYear)
        {
            return adminRepo.GetAllSectionStudentResultByTeacher(new Marks() { Class= year, Section= section, Subject= course, Year = acaYear });
        }

        public List<courseForTeacher> GetAllCourseByTeacher(string username)
        {
            return secRepo.GetAllCourseListForTeacher(username);
        }

        public int UploadStudentMidMark(string YEAR, string SECTION, string SUBJECT, float mark, string USERNAME, string acaYear, string status)
        {
            return adminRepo.UploadStudentMidMark(new Marks() { Class = YEAR, Section = SECTION, Subject = SUBJECT, MidMarks = mark, Student = USERNAME, Year = acaYear, Status = status });
        }

        public int UploadStudentFinalMark(string YEAR, string SECTION,string SUBJECT, float mark,string USERNAME, string acaYear)
        {
            return adminRepo.UploadStudentFinalMark(new Marks() { Class = YEAR, Section = SECTION, Subject = SUBJECT, FinalMarks = mark, Student = USERNAME, Year = acaYear });
        }

        public List<string> GetCurrentAcademicYear()
        {
            return adminRepo.GetCurrentAcademicYear();
        }

        public int checkAlreadySubmitMidMark(string YEAR,string SECTION,string SUBJECT,string USERNAME,string acaYear, string status)
        {
            return adminRepo.checkAlreadySubmitMidMark(new Marks() { Class = YEAR, Section = SECTION, Subject = SUBJECT, Student = USERNAME, Year = acaYear, Status = status });
        }
        
        public int EditStudentMidMark(string YEAR, string SECTION, string SUBJECT, float mark, string USERNAME, string acaYear)
        {
            return adminRepo.EditStudentMidMark(new Marks() { Class = YEAR, Section = SECTION, Subject = SUBJECT, MidMarks = mark, Student = USERNAME, Year = acaYear });
        }

        public int DeleteNoticeByTeacher(int id)
        {
            return adminRepo.DeleteNoticeByTeacher(id);
        }
    }
}

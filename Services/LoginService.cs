using Final_Project.Entities;
using Final_Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Services
{
    public class LoginService
    {
        LoginRepository loginRepo;
        public LoginService()
        {
            loginRepo = new LoginRepository();
        }

        public int LoginValidationTeacher(string username, string password)
        {
            return loginRepo.ValidationTeacher(new User() { Username = username, Password = password });
        }

        public int LoginValidationAdmin(string username, string password)
        {
            return loginRepo.ValidationAdmin(new User() { Username = username, Password = password });
        }

        public int LoginValidationStudent(string username, string password)
        {
            return loginRepo.ValidationStudent(new User() { Username= username, Password = password });
        }

    }
}

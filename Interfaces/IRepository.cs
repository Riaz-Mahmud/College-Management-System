using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        List<TEntity> GetAllStudents();
        TEntity GetUserInfo(string username);
        int Insert(TEntity entity);
        int Update(TEntity entity);
        int Delete(int id);
        

    }
}

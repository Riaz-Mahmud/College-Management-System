using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Interfaces
{
    public interface ASectionIRepository<TEntity> where TEntity : class
    {
        List<TEntity> GetAllSection();
        List<TEntity> GetAllSectionTeacher();
        int Insert(TEntity entity);
        int Update(TEntity entity);
        int InsertTeacher(TEntity entity);
    }
}

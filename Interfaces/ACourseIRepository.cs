using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Interfaces
{
    public interface ACourseIRepository<TEntity> where TEntity : class
    {
        List<TEntity> GetAllCourse();
        int Insert(TEntity entity);
        int Update(TEntity entity);
        int chekcAlreadyAvailable(TEntity entity);

        int chekcAlreadyAvailable(Entities.Course course);
    }
}

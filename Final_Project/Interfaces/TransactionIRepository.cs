using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Interfaces
{
    public interface TransactionIRepository<TEntity> where TEntity : class
    {
        List<TEntity> GetAllTransaction();
        List<TEntity> GetUserTransaction(string username);
        string CheckTutionIsPayAlready(string username, string type, string monthName, string year);
        string CheckExamFeeIsPayAlready(string username, string type, string year);
        int Insert(TEntity entity);
        int DeleteTrnx(int trnx);
    }
}

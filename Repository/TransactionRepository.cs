using Final_Project.Entities;
using Final_Project.Interfaces;
using Final_Project.Services;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Repository
{
    public class TransactionRepository : TransactionIRepository<Transaction>
    {
        DataAccess dataAccess;
        public TransactionRepository()
        {
            this.dataAccess = new DataAccess();
        }

        public List<Transaction> GetAllTransaction()
        {
            dataAccess = new DataAccess();
            string sql = "SELECT * FROM Tnx_Info ORDER BY id DESC";
            SqlDataReader reader = dataAccess.GetData(sql);
            List<Transaction> transactionList = new List<Transaction>();

            while (reader.Read())
            {
                Transaction transaction = new Transaction();
                transaction.TnxId = Convert.ToInt32(reader["id"]);
                transaction.Username = reader["username"].ToString();
                transaction.FullName = reader["name"].ToString();
                transaction.Payment_Date = reader["pdate"].ToString();
                transaction.Class = reader["class"].ToString();
                transaction.Amount = Convert.ToSingle(reader["amount"]);
                transaction.Type = reader["type"].ToString();
                transaction.Month = reader["month"].ToString();
                transaction.Year = reader["year"].ToString();
                transactionList.Add(transaction);
            }
            dataAccess.Dispose();
            return transactionList;
        }

        public List<Transaction> GetUserTransaction(string username)
        {
            //string username = "riaz";
            dataAccess = new DataAccess();
            string sql = "SELECT * FROM Tnx_Info WHERE username='" + username + "' ORDER BY id DESC";
            SqlDataReader reader = dataAccess.GetData(sql);
            List<Transaction> transactionList1 = new List<Transaction>();

            while (reader.Read())
            {
                Transaction transaction1 = new Transaction();
                transaction1.TnxId = Convert.ToInt32(reader["id"]);
                transaction1.Username = reader["username"].ToString();
                transaction1.FullName = reader["name"].ToString();
                transaction1.Payment_Date = reader["pdate"].ToString();
                transaction1.Class = reader["class"].ToString();
                transaction1.Amount = Convert.ToSingle(reader["amount"]);
                transaction1.Type = reader["type"].ToString();
                transaction1.Month = reader["month"].ToString();
                transaction1.Year = reader["year"].ToString();
                transactionList1.Add(transaction1);
            }
            dataAccess.Dispose();
            return transactionList1;
        }

        public string CheckTutionIsPayAlready(string username, string type, string monthName, string year)
        {
            Transaction transaction = new Transaction();
            try
            {
                dataAccess = new DataAccess();
                string sql = "SELECT * FROM Tnx_Info WHERE username ='" + username + "' and month ='" + monthName + "' and type ='" + type + "' and year ='" + year + "'";
                SqlDataReader reader = dataAccess.GetData(sql);
                reader.Read();
                
                transaction.TnxId = Convert.ToInt32(reader["id"]);
                transaction.Username = reader["username"].ToString();
                return transaction.Username;
            }
            catch(Exception)
            {
                transaction.Username = "";
                return transaction.Username;
            }
        }

        public string CheckExamFeeIsPayAlready(string username, string type, string year)
        {
            Transaction transaction = new Transaction();
            try
            {
                dataAccess = new DataAccess();
                string sql = "SELECT * FROM Tnx_Info WHERE username ='" + username + "' and type ='" + type + "' and year ='" + year + "'";
                SqlDataReader reader = dataAccess.GetData(sql);
                reader.Read();

                transaction.TnxId = Convert.ToInt32(reader["id"]);
                transaction.Username = reader["username"].ToString();
                return transaction.Username;
            }
            catch (Exception)
            {
                transaction.Username = "";
                return transaction.Username;
            }
        }

        public int Insert(Transaction entity)
        {
            dataAccess = new DataAccess();
            string sql = "INSERT INTO Tnx_Info(username,name,pdate,class,amount,type,month, year) VALUES('" + entity.Username + "','" + entity.FullName + "','" + entity.Payment_Date + "','" + entity.Class + "','" + entity.Amount + "','" + entity.Type + "','" + entity.Month + "','" + entity.Year + "')";
            int result = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return result;
        }

        public int DeleteTrnx(int trnx)
        {
            dataAccess = new DataAccess();
            string sql = "DELETE FROM Tnx_Info WHERE id='" + trnx + "'";
            int result = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return result;
        }

    }
}

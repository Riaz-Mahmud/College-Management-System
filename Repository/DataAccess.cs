using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Repository
{
    class DataAccess : IDisposable
    {
        private SqlConnection connection;
        private SqlCommand command;

        public DataAccess()
        {
            //this.connection = new SqlConnection(@"data source=RIAZ-PC;initial catalog=college_ms;integrated security=true;");
            this.connection = new SqlConnection(ConfigurationManager.ConnectionStrings["college_ms"].ConnectionString);
            this.connection.Open();
        }

        public SqlDataReader GetData(string sql)
        {
            this.command = new SqlCommand(sql, this.connection);
            return this.command.ExecuteReader();
        }

        public SqlDataAdapter GetDataL(string sql)
        {
            return new SqlDataAdapter(sql, this.connection);
        }

        public int ExecuteQuery(string sql)
        {
            this.command = new SqlCommand(sql, this.connection);
            return this.command.ExecuteNonQuery();
        }

        public void Dispose()
        {
            this.connection.Close();
        }
    }
}

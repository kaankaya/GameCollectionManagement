using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCollectionManagement.Repositories
{
    public abstract class BaseRepository<T> : IRepository<T> where T : class
    {
        protected string _connectionString = "Server=PRIZRAK\\SQLEXPRESS;Database=GameCollectionManagement;Trusted_Connection=True";
        public abstract List<T> GetAll();
        public abstract T GetById(int id);
        public abstract void Add(T entity);
        public abstract void Update(T entity);
        public abstract void Delete(T entity);
        public abstract void Delete(int id);

       protected DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameters is not null)
                {
                    command.Parameters.AddRange(parameters);
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        //insert,update,delet
        protected int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            using(SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                if(parameters is not null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                return cmd.ExecuteNonQuery();
            }
        }
    }
}

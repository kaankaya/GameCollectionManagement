using GameCollectionManagement.Models;
using GameCollectionManagement.Models.Mappers;
using GameCollectionManagement.Utilities.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GameCollectionManagement.Repositories
{
    public class UserRepository : BaseRepository<User>
    {
        public override List<User> GetAll()
        {
            string query = "SELECT * FROM Users";
            DataTable dt = ExecuteQuery(query);
            List<User> users = new List<User>();

            foreach (DataRow row in dt.Rows)
            {
                users.Add(DataMappers.MapToUser(row));
            }

            return users;

        }//end GetAll()

        public override User GetById(int id)
        {
            string query = "SELECT * FROM Users where Id=@Id";
            //SqlParameter[] sqlParameters = new SqlParameter[] { 
            //    new SqlParameter("@Id", id)
            //};
            var parameters = new SqlParameterBuilder()
                            .AddParameter("@Id", id)
                            .Build();

            DataTable dataTable = ExecuteQuery(query, parameters);

            if(dataTable.Rows.Count == 0)
            {
                return null;
            }

            DataRow row = dataTable.Rows[0];
            return DataMappers.MapToUser(row);
        }//End GetById

        public override void Add(User entity)
        {
            string query = "insert into Users(Username,Email,Password,Role) Values (@Username,@Email,@Password,@Role)";

            //SqlParameter[] parameters = new SqlParameter[]
            //{
            //    new SqlParameter("@Username",entity.Username),
            //    new SqlParameter("@Email",entity.Email),
            //    new SqlParameter("@Password",entity.Password),
            //    new SqlParameter("@Role",entity.Role)
            //};

            var parameters = new SqlParameterBuilder()
                                .AddParameter("@Username", entity.Username)
                                .AddParameter("@Email", entity.Email)
                                .AddParameter("@Password", entity.Password)
                                .AddParameter("@Role", entity.Role)
                                .Build();

            ExecuteNonQuery(query, parameters);
        }

        public override void Update(User entity)
        {
            string query = "UPDATE Users set Username=@Username,Email=@Email,Password=@Password,Role=@Role where Id=@Id";
            //SqlParameter[] parameters = new SqlParameter[]
            //{
            //    new SqlParameter("@Id",entity.Id),
            //    new SqlParameter("@Username",entity.Username),
            //    new SqlParameter("@Email",entity.Email),
            //    new SqlParameter("@Password",entity.Password),
            //    new SqlParameter("@Role",entity.Role)
            //};
            var parameters = new SqlParameterBuilder()
                                .AddParameter("@Id",entity.Id)
                                .AddParameter("@Username", entity.Username)
                                .AddParameter("@Email", entity.Email)
                                .AddParameter("@Password", entity.Password)
                                .AddParameter("@Role", entity.Role)
                                .Build();
            ExecuteNonQuery (query, parameters);
        }//End Update()


        public override void Delete(int id)
        {
            string query = "DELETE FROM Users Where Id=@Id";
            //SqlParameter[] parameters = new SqlParameter[]
            //{
            //    new SqlParameter("@Id",id)
            //};
            var parameters = new SqlParameterBuilder()
                            .AddParameter("@Id", id)
                            .Build();
            ExecuteNonQuery (query, parameters);
        }//End Delete(int id) 

        public override void Delete(User entity)
        {
            string query = "DELETE FROM Users Where Id=@Id";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Id",entity.Id)
            };
            ExecuteNonQuery(query, parameters);
        }//End Delete(entity)

        public (bool,int?) Login(string username,string password)
        {
            string query = "SELECT Id FROM Users WHERE Username=@Username and Password=@Password";
            //SqlParameter[] parameters = new SqlParameter[]
            //{
            //    new SqlParameter ("@Username",username),
            //    new SqlParameter("@Password",password)
            //};
            var parameters = new SqlParameterBuilder()
                            .AddParameter("@Username", username)
                            .AddParameter("@Password", password)
                            .Build();

            var dataTable =  ExecuteQuery(query, parameters);

            if (dataTable.Rows.Count == 0)
                return (false, null);

            int id = (int)dataTable.Rows[0]["Id"];
            return (true, id);
            

            
          

        }
    }
}

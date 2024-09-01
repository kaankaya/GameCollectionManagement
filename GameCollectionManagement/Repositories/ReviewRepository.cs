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

namespace GameCollectionManagement.Repositories
{
    public class ReviewRepository : BaseRepository<Review>
    {
        public override List<Review> GetAll()
        {
            string query = "SELECT * FROM Reviews";
            DataTable dataTable = ExecuteQuery(query);
            List<Review> reviews = new List<Review>();
            foreach (DataRow row in dataTable.Rows)
            {
                reviews.Add(DataMappers.MapToReview(row));
            }

            return reviews;
        }//End GetAll()

        public List<Review> GetAllByRole(string role, int userId)
        {
            if(role == "admin")
            {
                return GetAll();
            }
            string query = "SELECT * FROM Reviews WHERE UserId=@UserId";
            var parameters = new SqlParameterBuilder()
                                .AddParameter("@UserId",userId)
                                .Build();
            DataTable dataTable = ExecuteQuery(query,parameters);
            List<Review> reviews = new List<Review>();
            foreach (DataRow row in dataTable.Rows)
            {
                reviews.Add(DataMappers.MapToReview(row));
            }

            return reviews;
        }//End GetAllByRole

        public override Review GetById(int id)
        {
            string query = "SELECT * FROM Reviews WHERE Id=@Id";
            //SqlParameter[] parameters = new SqlParameter[]
            //{
            //    new SqlParameter("@Id", id)
            //};
            var parameters = new SqlParameterBuilder()
                            .AddParameter("@Id",id)
                            .Build(); 

            DataTable dataTable = ExecuteQuery(query, parameters);
            if (dataTable.Rows.Count > 0) return null;
            DataRow row = dataTable.Rows[0];

            return DataMappers.MapToReview(row);
        }//End GetById

        public override void Add(Review entity)
        {
            string query = "INSERT INTO Reviews (UserId,GameId,Rating,ReviewText) values(@UserId,@GameId,@Rating,@ReviewText)";
            //SqlParameter[] parameters = new SqlParameter[]
            //{
            //    new SqlParameter("@UserId",entity.UserId),
            //    new SqlParameter("@GameId",entity.GameId),
            //    new SqlParameter("@Rating",entity.Rating),
            //    new SqlParameter("@ReviewText",entity.ReviewText)
            //};

            var parameters = new SqlParameterBuilder()
                                .AddParameter("@UserId", entity.UserId)
                                .AddParameter("@GameId",entity.GameId)
                                .AddParameter("@Rating", entity.Rating)
                                .AddParameter("@ReviewText", entity.ReviewText)
                                .Build();
            ExecuteNonQuery(query, parameters);
        }//End Add

        public override void Update(Review entity)
        {
            string query = "UPDATE Reviews Set UserId=@UserId,GameId=@GameId,Rating=@Rating,ReviewText=@ReviewText WHERE Id=@Id";
            // SqlParameter[] parameters = new SqlParameter[]
            //{
            //     new SqlParameter("@Id",entity.Id),
            //     new SqlParameter("@UserId",entity.UserId),
            //     new SqlParameter("@GameId",entity.GameId),
            //     new SqlParameter("@Rating",entity.Rating),
            //     new SqlParameter("@ReviewText",entity.ReviewText)
            //};
            var parameters = new SqlParameterBuilder()
                                 .AddParameter("@Id",entity.Id)
                                 .AddParameter("@UserId", entity.UserId)
                                 .AddParameter("@GameId", entity.GameId)
                                 .AddParameter("@Rating", entity.Rating)
                                 .AddParameter("@ReviewText", entity.ReviewText)
                                 .Build();
            ExecuteNonQuery(query, parameters);
        }//End Update

        public override void Delete(int id)
        {
            string query = "DELETE FROM Reviews WHERE Id=@Id";
            //  SqlParameter[] parameters = new SqlParameter[]
            //{
            //      new SqlParameter("@Id", id),
            //};
            var parameters = new SqlParameterBuilder()
                              .AddParameter("@Id", id)
                              .Build();
            ExecuteNonQuery(query, parameters);
        }//End Delete(int id)

        public override void Delete(Review entity)
        {
            Delete(entity.Id);
        }//End Delete(entity)


        public List<Review> GetAllWithDetails()
        {
            string query = "SELECT r.*,u.Username,u.Email,u.Password,u.Role,g.Name,g.Genre,g.Platform,g.ReleaseDate,g.CoverImage FROM Reviews r INNER JOIN Users u ON r.UserId=u.Id INNER JOIN Games g ON r.GameId=g.Id";
            //gerekli bilgiyi çekicek datatable query içine tanımladık
            DataTable dataTable = ExecuteQuery(query);
            List<Review> reviews = new List<Review>();

            foreach (DataRow row in dataTable.Rows)
            {
                reviews.Add(DataMappers.MapToReviewWithDetails(row));

            }

            return reviews;

        }//End GetAllWithDetails

        public Review GetByIdWithDetails(int id)
        {
            string query = "SELECT r.*,u.Username,u.Email,u.Password,u.Role,g.Name,g.Genre,g.Platform,g.ReleaseDate,g.CoverImage FROM Reviews r INNER JOIN Users u ON r.UserId=u.Id INNER JOIN Games g ON r.GameId=g.Id WHERE r.Id=@Id";

            //SqlParameter[] parameters = new SqlParameter[]
            //{
            //    new SqlParameter ("@Id",id)
            //};
            var parameters = new SqlParameterBuilder()
                            .AddParameter("@Id", id)
                            .Build();
            DataTable dataTable = ExecuteQuery(query,parameters);
            if (dataTable.Rows.Count == 0) return null;
            DataRow row = dataTable.Rows[0];
            return DataMappers.MapToReviewWithDetails(row);
        }
    }
}
